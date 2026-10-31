USE db_citas_medicas;
GO

/*=========================================================
    LISTAR ESTADOS DE LAS CITAS
=========================================================*/

CREATE OR ALTER PROCEDURE sp_estado_cita_listar
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        id_estado,
        nombre,
        descripcion
    FROM tb_estado_cita
    ORDER BY id_estado;
END;
GO


/*=========================================================
    LISTAR TODAS LAS CITAS
=========================================================*/

CREATE OR ALTER PROCEDURE sp_cita_listar
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        c.id_cita,
        c.id_paciente,
        c.id_medico,
        c.id_estado,
        c.fecha_cita,
        c.hora_inicio,
        c.hora_fin,
        p.cedula AS cedula_paciente,
        p.nombres + ' ' + p.apellidos AS paciente,
        m.nombres + ' ' + m.apellidos AS medico,
        e.nombre AS especialidad,
        c.motivo,
        c.observaciones,
        ec.nombre AS estado,
        c.id_cita_origen
    FROM tb_cita AS c
    INNER JOIN tb_paciente AS p
        ON c.id_paciente = p.id_paciente
    INNER JOIN tb_medico AS m
        ON c.id_medico = m.id_medico
    INNER JOIN tb_especialidad AS e
        ON m.id_especialidad = e.id_especialidad
    INNER JOIN tb_estado_cita AS ec
        ON c.id_estado = ec.id_estado
    ORDER BY
        c.fecha_cita DESC,
        c.hora_inicio DESC;
END;
GO


/*=========================================================
    BUSCAR CITAS
=========================================================*/

CREATE OR ALTER PROCEDURE sp_cita_buscar
    @texto NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        c.id_cita,
        c.id_paciente,
        c.id_medico,
        c.id_estado,
        c.fecha_cita,
        c.hora_inicio,
        c.hora_fin,
        p.cedula AS cedula_paciente,
        p.nombres + ' ' + p.apellidos AS paciente,
        m.nombres + ' ' + m.apellidos AS medico,
        e.nombre AS especialidad,
        c.motivo,
        c.observaciones,
        ec.nombre AS estado,
        c.id_cita_origen
    FROM tb_cita AS c
    INNER JOIN tb_paciente AS p
        ON c.id_paciente = p.id_paciente
    INNER JOIN tb_medico AS m
        ON c.id_medico = m.id_medico
    INNER JOIN tb_especialidad AS e
        ON m.id_especialidad = e.id_especialidad
    INNER JOIN tb_estado_cita AS ec
        ON c.id_estado = ec.id_estado
    WHERE p.cedula LIKE '%' + @texto + '%'
       OR p.nombres LIKE '%' + @texto + '%'
       OR p.apellidos LIKE '%' + @texto + '%'
       OR p.nombres + ' ' + p.apellidos
            LIKE '%' + @texto + '%'
       OR m.nombres LIKE '%' + @texto + '%'
       OR m.apellidos LIKE '%' + @texto + '%'
       OR m.nombres + ' ' + m.apellidos
            LIKE '%' + @texto + '%'
       OR e.nombre LIKE '%' + @texto + '%'
       OR c.motivo LIKE '%' + @texto + '%'
       OR ec.nombre LIKE '%' + @texto + '%'
    ORDER BY
        c.fecha_cita DESC,
        c.hora_inicio DESC;
END;
GO


/*=========================================================
    VALIDAR DISPONIBILIDAD

    Devuelve:
    disponible = 1 cuando el horario está disponible.
    disponible = 0 cuando existe algún inconveniente.
=========================================================*/

CREATE OR ALTER PROCEDURE sp_cita_validar_disponibilidad
    @id_paciente INT,
    @id_medico INT,
    @fecha_cita DATE,
    @hora_inicio TIME,
    @hora_fin TIME,
    @id_cita_excluir INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @dia_semana TINYINT;

    SET @dia_semana =
        CONVERT
        (
            TINYINT,
            (DATEDIFF(DAY, '19000101', @fecha_cita) % 7) + 1
        );

    IF NOT EXISTS
    (
        SELECT 1
        FROM tb_paciente
        WHERE id_paciente = @id_paciente
          AND estado = 1
    )
    BEGIN
        SELECT
            CAST(0 AS BIT) AS disponible,
            'El paciente no existe o está inactivo.' AS mensaje;
        RETURN;
    END;

    IF NOT EXISTS
    (
        SELECT 1
        FROM tb_medico
        WHERE id_medico = @id_medico
          AND estado = 1
    )
    BEGIN
        SELECT
            CAST(0 AS BIT) AS disponible,
            'El médico no existe o está inactivo.' AS mensaje;
        RETURN;
    END;

    IF @fecha_cita < CAST(GETDATE() AS DATE)
    BEGIN
        SELECT
            CAST(0 AS BIT) AS disponible,
            'La fecha de la cita no puede ser anterior a la fecha actual.'
                AS mensaje;
        RETURN;
    END;

    IF @fecha_cita = CAST(GETDATE() AS DATE)
       AND @hora_inicio <= CAST(GETDATE() AS TIME)
    BEGIN
        SELECT
            CAST(0 AS BIT) AS disponible,
            'La hora de la cita no puede ser anterior a la hora actual.'
                AS mensaje;
        RETURN;
    END;

    IF @hora_inicio >= @hora_fin
    BEGIN
        SELECT
            CAST(0 AS BIT) AS disponible,
            'La hora de inicio debe ser menor que la hora final.'
                AS mensaje;
        RETURN;
    END;

    IF NOT EXISTS
    (
        SELECT 1
        FROM tb_horario_medico
        WHERE id_medico = @id_medico
          AND dia_semana = @dia_semana
          AND estado = 1
          AND @hora_inicio >= hora_inicio
          AND @hora_fin <= hora_fin
    )
    BEGIN
        SELECT
            CAST(0 AS BIT) AS disponible,
            'El médico no atiende en el día o en el horario seleccionado.'
                AS mensaje;
        RETURN;
    END;

    IF EXISTS
    (
        SELECT 1
        FROM tb_cita
        WHERE id_medico = @id_medico
          AND fecha_cita = @fecha_cita
          AND id_estado = 1
          AND
          (
              @id_cita_excluir IS NULL
              OR id_cita <> @id_cita_excluir
          )
          AND @hora_inicio < hora_fin
          AND @hora_fin > hora_inicio
    )
    BEGIN
        SELECT
            CAST(0 AS BIT) AS disponible,
            'El médico ya tiene una cita en ese horario.'
                AS mensaje;
        RETURN;
    END;

    IF EXISTS
    (
        SELECT 1
        FROM tb_cita
        WHERE id_paciente = @id_paciente
          AND fecha_cita = @fecha_cita
          AND id_estado = 1
          AND
          (
              @id_cita_excluir IS NULL
              OR id_cita <> @id_cita_excluir
          )
          AND @hora_inicio < hora_fin
          AND @hora_fin > hora_inicio
    )
    BEGIN
        SELECT
            CAST(0 AS BIT) AS disponible,
            'El paciente ya tiene una cita en ese horario.'
                AS mensaje;
        RETURN;
    END;

    SELECT
        CAST(1 AS BIT) AS disponible,
        'El horario está disponible.' AS mensaje;
END;
GO


/*=========================================================
    REGISTRAR CITA
=========================================================*/

CREATE OR ALTER PROCEDURE sp_cita_registrar
    @id_paciente INT,
    @id_medico INT,
    @fecha_cita DATE,
    @hora_inicio TIME,
    @hora_fin TIME,
    @motivo NVARCHAR(250),
    @observaciones NVARCHAR(500)
AS
BEGIN
    SET NOCOUNT ON;

    SET @motivo = LTRIM(RTRIM(@motivo));
    SET @observaciones = LTRIM(RTRIM(@observaciones));

    IF @motivo IS NULL OR @motivo = ''
    BEGIN
        RAISERROR(
            'El motivo de la cita es obligatorio.',
            16,
            1
        );
        RETURN;
    END;

    DECLARE @resultado TABLE
    (
        disponible BIT,
        mensaje NVARCHAR(250)
    );

    INSERT INTO @resultado
    EXEC sp_cita_validar_disponibilidad
        @id_paciente = @id_paciente,
        @id_medico = @id_medico,
        @fecha_cita = @fecha_cita,
        @hora_inicio = @hora_inicio,
        @hora_fin = @hora_fin,
        @id_cita_excluir = NULL;

    DECLARE @disponible BIT;
    DECLARE @mensaje NVARCHAR(250);

    SELECT
        @disponible = disponible,
        @mensaje = mensaje
    FROM @resultado;

    IF @disponible = 0
    BEGIN
        RAISERROR(@mensaje, 16, 1);
        RETURN;
    END;

    INSERT INTO tb_cita
    (
        id_paciente,
        id_medico,
        id_estado,
        fecha_cita,
        hora_inicio,
        hora_fin,
        motivo,
        observaciones
    )
    VALUES
    (
        @id_paciente,
        @id_medico,
        1,
        @fecha_cita,
        @hora_inicio,
        @hora_fin,
        @motivo,
        NULLIF(@observaciones, '')
    );

    SELECT
        SCOPE_IDENTITY() AS id_cita_registrada;
END;
GO


/*=========================================================
    MODIFICAR CITA
=========================================================*/

CREATE OR ALTER PROCEDURE sp_cita_modificar
    @id_cita INT,
    @id_paciente INT,
    @id_medico INT,
    @fecha_cita DATE,
    @hora_inicio TIME,
    @hora_fin TIME,
    @motivo NVARCHAR(250),
    @observaciones NVARCHAR(500)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1
        FROM tb_cita
        WHERE id_cita = @id_cita
    )
    BEGIN
        RAISERROR(
            'La cita seleccionada no existe.',
            16,
            1
        );
        RETURN;
    END;

    IF NOT EXISTS
    (
        SELECT 1
        FROM tb_cita
        WHERE id_cita = @id_cita
          AND id_estado = 1
    )
    BEGIN
        RAISERROR(
            'Solamente se pueden modificar citas programadas.',
            16,
            1
        );
        RETURN;
    END;

    SET @motivo = LTRIM(RTRIM(@motivo));
    SET @observaciones = LTRIM(RTRIM(@observaciones));

    IF @motivo IS NULL OR @motivo = ''
    BEGIN
        RAISERROR(
            'El motivo de la cita es obligatorio.',
            16,
            1
        );
        RETURN;
    END;

    DECLARE @resultado TABLE
    (
        disponible BIT,
        mensaje NVARCHAR(250)
    );

    INSERT INTO @resultado
    EXEC sp_cita_validar_disponibilidad
        @id_paciente = @id_paciente,
        @id_medico = @id_medico,
        @fecha_cita = @fecha_cita,
        @hora_inicio = @hora_inicio,
        @hora_fin = @hora_fin,
        @id_cita_excluir = @id_cita;

    DECLARE @disponible BIT;
    DECLARE @mensaje NVARCHAR(250);

    SELECT
        @disponible = disponible,
        @mensaje = mensaje
    FROM @resultado;

    IF @disponible = 0
    BEGIN
        RAISERROR(@mensaje, 16, 1);
        RETURN;
    END;

    UPDATE tb_cita
    SET
        id_paciente = @id_paciente,
        id_medico = @id_medico,
        fecha_cita = @fecha_cita,
        hora_inicio = @hora_inicio,
        hora_fin = @hora_fin,
        motivo = @motivo,
        observaciones = NULLIF(@observaciones, ''),
        fecha_actualizacion = GETDATE()
    WHERE id_cita = @id_cita;
END;
GO


/*=========================================================
    CANCELAR CITA
=========================================================*/

CREATE OR ALTER PROCEDURE sp_cita_cancelar
    @id_cita INT,
    @observaciones NVARCHAR(500)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1
        FROM tb_cita
        WHERE id_cita = @id_cita
    )
    BEGIN
        RAISERROR(
            'La cita seleccionada no existe.',
            16,
            1
        );
        RETURN;
    END;

    IF NOT EXISTS
    (
        SELECT 1
        FROM tb_cita
        WHERE id_cita = @id_cita
          AND id_estado = 1
    )
    BEGIN
        RAISERROR(
            'Solamente se pueden cancelar citas programadas.',
            16,
            1
        );
        RETURN;
    END;

    UPDATE tb_cita
    SET
        id_estado = 3,
        observaciones =
            COALESCE
            (
                NULLIF(LTRIM(RTRIM(@observaciones)), ''),
                observaciones
            ),
        fecha_actualizacion = GETDATE()
    WHERE id_cita = @id_cita;
END;
GO


/*=========================================================
    MARCAR CITA COMO ATENDIDA
=========================================================*/

CREATE OR ALTER PROCEDURE sp_cita_marcar_atendida
    @id_cita INT,
    @observaciones NVARCHAR(500)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1
        FROM tb_cita
        WHERE id_cita = @id_cita
          AND id_estado = 1
    )
    BEGIN
        RAISERROR(
            'Solamente una cita programada puede marcarse como atendida.',
            16,
            1
        );
        RETURN;
    END;

    IF EXISTS
    (
        SELECT 1
        FROM tb_cita
        WHERE id_cita = @id_cita
          AND fecha_cita > CAST(GETDATE() AS DATE)
    )
    BEGIN
        RAISERROR(
            'No puede marcar como atendida una cita futura.',
            16,
            1
        );
        RETURN;
    END;

    UPDATE tb_cita
    SET
        id_estado = 2,
        observaciones =
            COALESCE
            (
                NULLIF(LTRIM(RTRIM(@observaciones)), ''),
                observaciones
            ),
        fecha_actualizacion = GETDATE()
    WHERE id_cita = @id_cita;
END;
GO


/*=========================================================
    MARCAR CITA COMO NO ASISTIDA
=========================================================*/

CREATE OR ALTER PROCEDURE sp_cita_marcar_no_asistida
    @id_cita INT,
    @observaciones NVARCHAR(500)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1
        FROM tb_cita
        WHERE id_cita = @id_cita
          AND id_estado = 1
    )
    BEGIN
        RAISERROR(
            'Solamente una cita programada puede marcarse como no asistida.',
            16,
            1
        );
        RETURN;
    END;

    IF EXISTS
    (
        SELECT 1
        FROM tb_cita
        WHERE id_cita = @id_cita
          AND
          (
              fecha_cita > CAST(GETDATE() AS DATE)
              OR
              (
                  fecha_cita = CAST(GETDATE() AS DATE)
                  AND hora_inicio > CAST(GETDATE() AS TIME)
              )
          )
    )
    BEGIN
        RAISERROR(
            'No puede marcar como no asistida una cita que todavía no ocurre.',
            16,
            1
        );
        RETURN;
    END;

    UPDATE tb_cita
    SET
        id_estado = 5,
        observaciones =
            COALESCE
            (
                NULLIF(LTRIM(RTRIM(@observaciones)), ''),
                observaciones
            ),
        fecha_actualizacion = GETDATE()
    WHERE id_cita = @id_cita;
END;
GO


/*=========================================================
    REPROGRAMAR CITA
=========================================================*/

CREATE OR ALTER PROCEDURE sp_cita_reprogramar
    @id_cita INT,
    @nueva_fecha DATE,
    @nueva_hora_inicio TIME,
    @nueva_hora_fin TIME,
    @observaciones NVARCHAR(500)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @id_paciente INT;
    DECLARE @id_medico INT;
    DECLARE @motivo NVARCHAR(250);
    DECLARE @observaciones_actuales NVARCHAR(500);

    SELECT
        @id_paciente = id_paciente,
        @id_medico = id_medico,
        @motivo = motivo,
        @observaciones_actuales = observaciones
    FROM tb_cita
    WHERE id_cita = @id_cita
      AND id_estado = 1;

    IF @id_paciente IS NULL
    BEGIN
        RAISERROR(
            'La cita no existe o ya no se encuentra programada.',
            16,
            1
        );
        RETURN;
    END;

    DECLARE @resultado TABLE
    (
        disponible BIT,
        mensaje NVARCHAR(250)
    );

    INSERT INTO @resultado
    EXEC sp_cita_validar_disponibilidad
        @id_paciente = @id_paciente,
        @id_medico = @id_medico,
        @fecha_cita = @nueva_fecha,
        @hora_inicio = @nueva_hora_inicio,
        @hora_fin = @nueva_hora_fin,
        @id_cita_excluir = @id_cita;

    DECLARE @disponible BIT;
    DECLARE @mensaje NVARCHAR(250);

    SELECT
        @disponible = disponible,
        @mensaje = mensaje
    FROM @resultado;

    IF @disponible = 0
    BEGIN
        RAISERROR(@mensaje, 16, 1);
        RETURN;
    END;

    BEGIN TRY
        BEGIN TRANSACTION;

        UPDATE tb_cita
        SET
            id_estado = 4,
            fecha_actualizacion = GETDATE()
        WHERE id_cita = @id_cita;

        INSERT INTO tb_cita
        (
            id_paciente,
            id_medico,
            id_estado,
            fecha_cita,
            hora_inicio,
            hora_fin,
            motivo,
            observaciones,
            id_cita_origen
        )
        VALUES
        (
            @id_paciente,
            @id_medico,
            1,
            @nueva_fecha,
            @nueva_hora_inicio,
            @nueva_hora_fin,
            @motivo,
            COALESCE
            (
                NULLIF(LTRIM(RTRIM(@observaciones)), ''),
                @observaciones_actuales
            ),
            @id_cita
        );

        DECLARE @id_cita_nueva INT;

        SET @id_cita_nueva =
            CONVERT(INT, SCOPE_IDENTITY());

        COMMIT TRANSACTION;

        SELECT
            @id_cita_nueva AS id_cita_nueva;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        DECLARE @mensaje_error NVARCHAR(4000);

        SET @mensaje_error = ERROR_MESSAGE();

        RAISERROR(@mensaje_error, 16, 1);
    END CATCH;
END;
GO


/*=========================================================
    LISTAR CITAS POR MÉDICO
=========================================================*/

CREATE OR ALTER PROCEDURE sp_cita_listar_por_medico
    @id_medico INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        c.id_cita,
        c.fecha_cita,
        c.hora_inicio,
        c.hora_fin,
        p.cedula,
        p.nombres + ' ' + p.apellidos AS paciente,
        c.motivo,
        ec.nombre AS estado
    FROM tb_cita AS c
    INNER JOIN tb_paciente AS p
        ON c.id_paciente = p.id_paciente
    INNER JOIN tb_estado_cita AS ec
        ON c.id_estado = ec.id_estado
    WHERE c.id_medico = @id_medico
    ORDER BY
        c.fecha_cita DESC,
        c.hora_inicio DESC;
END;
GO


/*=========================================================
    HISTORIAL DE CITAS POR PACIENTE
=========================================================*/

CREATE OR ALTER PROCEDURE sp_cita_historial_paciente
    @id_paciente INT,
    @fecha_desde DATE = NULL,
    @fecha_hasta DATE = NULL,
    @id_estado INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        c.id_cita,
        c.fecha_cita,
        c.hora_inicio,
        c.hora_fin,
        m.nombres + ' ' + m.apellidos AS medico,
        e.nombre AS especialidad,
        c.motivo,
        c.observaciones,
        ec.nombre AS estado
    FROM tb_cita AS c
    INNER JOIN tb_medico AS m
        ON c.id_medico = m.id_medico
    INNER JOIN tb_especialidad AS e
        ON m.id_especialidad = e.id_especialidad
    INNER JOIN tb_estado_cita AS ec
        ON c.id_estado = ec.id_estado
    WHERE c.id_paciente = @id_paciente
      AND
      (
          @fecha_desde IS NULL
          OR c.fecha_cita >= @fecha_desde
      )
      AND
      (
          @fecha_hasta IS NULL
          OR c.fecha_cita <= @fecha_hasta
      )
      AND
      (
          @id_estado IS NULL
          OR c.id_estado = @id_estado
      )
    ORDER BY
        c.fecha_cita DESC,
        c.hora_inicio DESC;
END;
GO


/*=========================================================
    REPORTE GENERAL DE CITAS
=========================================================*/

CREATE OR ALTER PROCEDURE sp_reporte_citas
    @fecha_desde DATE,
    @fecha_hasta DATE,
    @id_medico INT = NULL,
    @id_paciente INT = NULL,
    @id_estado INT = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @fecha_desde > @fecha_hasta
    BEGIN
        RAISERROR(
            'La fecha inicial no puede ser mayor que la fecha final.',
            16,
            1
        );
        RETURN;
    END;

    SELECT
        c.id_cita,
        c.fecha_cita,
        c.hora_inicio,
        c.hora_fin,
        p.cedula,
        p.nombres + ' ' + p.apellidos AS paciente,
        m.nombres + ' ' + m.apellidos AS medico,
        e.nombre AS especialidad,
        c.motivo,
        ec.nombre AS estado
    FROM tb_cita AS c
    INNER JOIN tb_paciente AS p
        ON c.id_paciente = p.id_paciente
    INNER JOIN tb_medico AS m
        ON c.id_medico = m.id_medico
    INNER JOIN tb_especialidad AS e
        ON m.id_especialidad = e.id_especialidad
    INNER JOIN tb_estado_cita AS ec
        ON c.id_estado = ec.id_estado
    WHERE c.fecha_cita BETWEEN @fecha_desde AND @fecha_hasta
      AND
      (
          @id_medico IS NULL
          OR c.id_medico = @id_medico
      )
      AND
      (
          @id_paciente IS NULL
          OR c.id_paciente = @id_paciente
      )
      AND
      (
          @id_estado IS NULL
          OR c.id_estado = @id_estado
      )
    ORDER BY
        c.fecha_cita,
        c.hora_inicio;
END;
GO


/*=========================================================
    COMPROBAR PROCEDIMIENTOS CREADOS
=========================================================*/

SELECT
    name AS Procedimiento
FROM sys.procedures
WHERE name LIKE 'sp_cita%'
   OR name LIKE 'sp_estado_cita%'
   OR name LIKE 'sp_reporte%'
ORDER BY name;
GO