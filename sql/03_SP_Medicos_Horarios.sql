USE db_citas_medicas;
GO

/*=========================================================
    PROCEDIMIENTOS ALMACENADOS DE MÉDICOS
=========================================================*/


/*=========================================================
    LISTAR TODOS LOS MÉDICOS
=========================================================*/

CREATE OR ALTER PROCEDURE sp_medico_listar
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        m.id_medico,
        m.id_especialidad,
        m.cedula,
        m.numero_colegiatura,
        m.nombres,
        m.apellidos,
        m.nombres + ' ' + m.apellidos AS medico,
        e.nombre AS especialidad,
        m.telefono,
        m.correo,
        m.estado,
        CASE
            WHEN m.estado = 1 THEN 'Activo'
            ELSE 'Inactivo'
        END AS nombre_estado
    FROM tb_medico AS m
    INNER JOIN tb_especialidad AS e
        ON m.id_especialidad = e.id_especialidad
    ORDER BY m.apellidos, m.nombres;
END;
GO


/*=========================================================
    LISTAR MÉDICOS ACTIVOS
    Se utilizará en los ComboBox
=========================================================*/

CREATE OR ALTER PROCEDURE sp_medico_listar_activos
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        m.id_medico,
        m.id_especialidad,
        m.cedula,
        m.nombres,
        m.apellidos,
        m.nombres + ' ' + m.apellidos AS medico,
        e.nombre AS especialidad,
        m.nombres + ' ' + m.apellidos
            + ' - ' + e.nombre AS medico_especialidad
    FROM tb_medico AS m
    INNER JOIN tb_especialidad AS e
        ON m.id_especialidad = e.id_especialidad
    WHERE m.estado = 1
      AND e.estado = 1
    ORDER BY m.apellidos, m.nombres;
END;
GO


/*=========================================================
    LISTAR MÉDICOS POR ESPECIALIDAD
=========================================================*/

CREATE OR ALTER PROCEDURE sp_medico_listar_por_especialidad
    @id_especialidad INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        m.id_medico,
        m.cedula,
        m.nombres,
        m.apellidos,
        m.nombres + ' ' + m.apellidos AS medico,
        m.numero_colegiatura,
        m.telefono,
        m.correo
    FROM tb_medico AS m
    WHERE m.id_especialidad = @id_especialidad
      AND m.estado = 1
    ORDER BY m.apellidos, m.nombres;
END;
GO


/*=========================================================
    BUSCAR MÉDICOS
=========================================================*/

CREATE OR ALTER PROCEDURE sp_medico_buscar
    @texto NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        m.id_medico,
        m.id_especialidad,
        m.cedula,
        m.numero_colegiatura,
        m.nombres,
        m.apellidos,
        m.nombres + ' ' + m.apellidos AS medico,
        e.nombre AS especialidad,
        m.telefono,
        m.correo,
        m.estado,
        CASE
            WHEN m.estado = 1 THEN 'Activo'
            ELSE 'Inactivo'
        END AS nombre_estado
    FROM tb_medico AS m
    INNER JOIN tb_especialidad AS e
        ON m.id_especialidad = e.id_especialidad
    WHERE m.cedula LIKE '%' + @texto + '%'
       OR m.numero_colegiatura LIKE '%' + @texto + '%'
       OR m.nombres LIKE '%' + @texto + '%'
       OR m.apellidos LIKE '%' + @texto + '%'
       OR m.nombres + ' ' + m.apellidos LIKE '%' + @texto + '%'
       OR e.nombre LIKE '%' + @texto + '%'
    ORDER BY m.apellidos, m.nombres;
END;
GO


/*=========================================================
    REGISTRAR MÉDICO
=========================================================*/

CREATE OR ALTER PROCEDURE sp_medico_registrar
    @id_especialidad INT,
    @cedula VARCHAR(10),
    @numero_colegiatura VARCHAR(30),
    @nombres NVARCHAR(100),
    @apellidos NVARCHAR(100),
    @telefono VARCHAR(15),
    @correo VARCHAR(150),
    @estado BIT
AS
BEGIN
    SET NOCOUNT ON;

    SET @cedula = LTRIM(RTRIM(@cedula));
    SET @numero_colegiatura =
        LTRIM(RTRIM(@numero_colegiatura));
    SET @nombres = LTRIM(RTRIM(@nombres));
    SET @apellidos = LTRIM(RTRIM(@apellidos));
    SET @telefono = LTRIM(RTRIM(@telefono));
    SET @correo = LTRIM(RTRIM(@correo));

    IF NOT EXISTS
    (
        SELECT 1
        FROM tb_especialidad
        WHERE id_especialidad = @id_especialidad
          AND estado = 1
    )
    BEGIN
        RAISERROR(
            'La especialidad seleccionada no existe o está inactiva.',
            16,
            1
        );
        RETURN;
    END;

    IF LEN(@cedula) <> 10
       OR @cedula LIKE '%[^0-9]%'
    BEGIN
        RAISERROR(
            'La cédula debe contener exactamente 10 números.',
            16,
            1
        );
        RETURN;
    END;

    IF @numero_colegiatura IS NULL
       OR @numero_colegiatura = ''
    BEGIN
        RAISERROR(
            'El número de colegiatura es obligatorio.',
            16,
            1
        );
        RETURN;
    END;

    IF @nombres IS NULL OR @nombres = ''
    BEGIN
        RAISERROR(
            'Los nombres del médico son obligatorios.',
            16,
            1
        );
        RETURN;
    END;

    IF @apellidos IS NULL OR @apellidos = ''
    BEGIN
        RAISERROR(
            'Los apellidos del médico son obligatorios.',
            16,
            1
        );
        RETURN;
    END;

    IF EXISTS
    (
        SELECT 1
        FROM tb_medico
        WHERE cedula = @cedula
    )
    BEGIN
        RAISERROR(
            'Ya existe un médico con esa cédula.',
            16,
            1
        );
        RETURN;
    END;

    IF EXISTS
    (
        SELECT 1
        FROM tb_medico
        WHERE numero_colegiatura = @numero_colegiatura
    )
    BEGIN
        RAISERROR(
            'Ya existe un médico con ese número de colegiatura.',
            16,
            1
        );
        RETURN;
    END;

    INSERT INTO tb_medico
    (
        id_especialidad,
        cedula,
        numero_colegiatura,
        nombres,
        apellidos,
        telefono,
        correo,
        estado
    )
    VALUES
    (
        @id_especialidad,
        @cedula,
        @numero_colegiatura,
        @nombres,
        @apellidos,
        NULLIF(@telefono, ''),
        NULLIF(@correo, ''),
        @estado
    );
END;
GO


/*=========================================================
    MODIFICAR MÉDICO
=========================================================*/

CREATE OR ALTER PROCEDURE sp_medico_modificar
    @id_medico INT,
    @id_especialidad INT,
    @cedula VARCHAR(10),
    @numero_colegiatura VARCHAR(30),
    @nombres NVARCHAR(100),
    @apellidos NVARCHAR(100),
    @telefono VARCHAR(15),
    @correo VARCHAR(150),
    @estado BIT
AS
BEGIN
    SET NOCOUNT ON;

    SET @cedula = LTRIM(RTRIM(@cedula));
    SET @numero_colegiatura =
        LTRIM(RTRIM(@numero_colegiatura));
    SET @nombres = LTRIM(RTRIM(@nombres));
    SET @apellidos = LTRIM(RTRIM(@apellidos));
    SET @telefono = LTRIM(RTRIM(@telefono));
    SET @correo = LTRIM(RTRIM(@correo));

    IF NOT EXISTS
    (
        SELECT 1
        FROM tb_medico
        WHERE id_medico = @id_medico
    )
    BEGIN
        RAISERROR(
            'El médico seleccionado no existe.',
            16,
            1
        );
        RETURN;
    END;

    IF NOT EXISTS
    (
        SELECT 1
        FROM tb_especialidad
        WHERE id_especialidad = @id_especialidad
    )
    BEGIN
        RAISERROR(
            'La especialidad seleccionada no existe.',
            16,
            1
        );
        RETURN;
    END;

    IF LEN(@cedula) <> 10
       OR @cedula LIKE '%[^0-9]%'
    BEGIN
        RAISERROR(
            'La cédula debe contener exactamente 10 números.',
            16,
            1
        );
        RETURN;
    END;

    IF @numero_colegiatura IS NULL
       OR @numero_colegiatura = ''
    BEGIN
        RAISERROR(
            'El número de colegiatura es obligatorio.',
            16,
            1
        );
        RETURN;
    END;

    IF @nombres IS NULL OR @nombres = ''
    BEGIN
        RAISERROR(
            'Los nombres del médico son obligatorios.',
            16,
            1
        );
        RETURN;
    END;

    IF @apellidos IS NULL OR @apellidos = ''
    BEGIN
        RAISERROR(
            'Los apellidos del médico son obligatorios.',
            16,
            1
        );
        RETURN;
    END;

    IF EXISTS
    (
        SELECT 1
        FROM tb_medico
        WHERE cedula = @cedula
          AND id_medico <> @id_medico
    )
    BEGIN
        RAISERROR(
            'Ya existe otro médico con esa cédula.',
            16,
            1
        );
        RETURN;
    END;

    IF EXISTS
    (
        SELECT 1
        FROM tb_medico
        WHERE numero_colegiatura = @numero_colegiatura
          AND id_medico <> @id_medico
    )
    BEGIN
        RAISERROR(
            'Ya existe otro médico con esa colegiatura.',
            16,
            1
        );
        RETURN;
    END;

    UPDATE tb_medico
    SET
        id_especialidad = @id_especialidad,
        cedula = @cedula,
        numero_colegiatura = @numero_colegiatura,
        nombres = @nombres,
        apellidos = @apellidos,
        telefono = NULLIF(@telefono, ''),
        correo = NULLIF(@correo, ''),
        estado = @estado,
        fecha_actualizacion = GETDATE()
    WHERE id_medico = @id_medico;
END;
GO


/*=========================================================
    DAR DE BAJA LÓGICA A UN MÉDICO
=========================================================*/

CREATE OR ALTER PROCEDURE sp_medico_dar_baja
    @id_medico INT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1
        FROM tb_medico
        WHERE id_medico = @id_medico
    )
    BEGIN
        RAISERROR(
            'El médico seleccionado no existe.',
            16,
            1
        );
        RETURN;
    END;

    UPDATE tb_medico
    SET
        estado = 0,
        fecha_actualizacion = GETDATE()
    WHERE id_medico = @id_medico;

    UPDATE tb_horario_medico
    SET estado = 0
    WHERE id_medico = @id_medico;
END;
GO


/*=========================================================
    PROCEDIMIENTOS ALMACENADOS DE HORARIOS
=========================================================*/


/*=========================================================
    LISTAR HORARIOS DE UN MÉDICO
=========================================================*/

CREATE OR ALTER PROCEDURE sp_horario_listar_por_medico
    @id_medico INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        h.id_horario,
        h.id_medico,
        h.dia_semana,
        CASE h.dia_semana
            WHEN 1 THEN 'Lunes'
            WHEN 2 THEN 'Martes'
            WHEN 3 THEN 'Miércoles'
            WHEN 4 THEN 'Jueves'
            WHEN 5 THEN 'Viernes'
            WHEN 6 THEN 'Sábado'
            WHEN 7 THEN 'Domingo'
        END AS nombre_dia,
        h.hora_inicio,
        h.hora_fin,
        h.estado,
        CASE
            WHEN h.estado = 1 THEN 'Activo'
            ELSE 'Inactivo'
        END AS nombre_estado
    FROM tb_horario_medico AS h
    WHERE h.id_medico = @id_medico
    ORDER BY
        h.dia_semana,
        h.hora_inicio;
END;
GO


/*=========================================================
    REGISTRAR HORARIO
=========================================================*/

CREATE OR ALTER PROCEDURE sp_horario_registrar
    @id_medico INT,
    @dia_semana TINYINT,
    @hora_inicio TIME,
    @hora_fin TIME,
    @estado BIT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1
        FROM tb_medico
        WHERE id_medico = @id_medico
          AND estado = 1
    )
    BEGIN
        RAISERROR(
            'El médico seleccionado no existe o está inactivo.',
            16,
            1
        );
        RETURN;
    END;

    IF @dia_semana < 1 OR @dia_semana > 7
    BEGIN
        RAISERROR(
            'El día de la semana no es válido.',
            16,
            1
        );
        RETURN;
    END;

    IF @hora_inicio >= @hora_fin
    BEGIN
        RAISERROR(
            'La hora de inicio debe ser menor que la hora final.',
            16,
            1
        );
        RETURN;
    END;

    IF EXISTS
    (
        SELECT 1
        FROM tb_horario_medico
        WHERE id_medico = @id_medico
          AND dia_semana = @dia_semana
          AND estado = 1
          AND @hora_inicio < hora_fin
          AND @hora_fin > hora_inicio
    )
    BEGIN
        RAISERROR(
            'El horario se cruza con otro horario activo del médico.',
            16,
            1
        );
        RETURN;
    END;

    INSERT INTO tb_horario_medico
    (
        id_medico,
        dia_semana,
        hora_inicio,
        hora_fin,
        estado
    )
    VALUES
    (
        @id_medico,
        @dia_semana,
        @hora_inicio,
        @hora_fin,
        @estado
    );
END;
GO


/*=========================================================
    MODIFICAR HORARIO
=========================================================*/

CREATE OR ALTER PROCEDURE sp_horario_modificar
    @id_horario INT,
    @id_medico INT,
    @dia_semana TINYINT,
    @hora_inicio TIME,
    @hora_fin TIME,
    @estado BIT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1
        FROM tb_horario_medico
        WHERE id_horario = @id_horario
    )
    BEGIN
        RAISERROR(
            'El horario seleccionado no existe.',
            16,
            1
        );
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
        RAISERROR(
            'El médico seleccionado no existe o está inactivo.',
            16,
            1
        );
        RETURN;
    END;

    IF @dia_semana < 1 OR @dia_semana > 7
    BEGIN
        RAISERROR(
            'El día de la semana no es válido.',
            16,
            1
        );
        RETURN;
    END;

    IF @hora_inicio >= @hora_fin
    BEGIN
        RAISERROR(
            'La hora de inicio debe ser menor que la hora final.',
            16,
            1
        );
        RETURN;
    END;

    IF EXISTS
    (
        SELECT 1
        FROM tb_horario_medico
        WHERE id_medico = @id_medico
          AND dia_semana = @dia_semana
          AND id_horario <> @id_horario
          AND estado = 1
          AND @hora_inicio < hora_fin
          AND @hora_fin > hora_inicio
    )
    BEGIN
        RAISERROR(
            'El horario se cruza con otro horario activo del médico.',
            16,
            1
        );
        RETURN;
    END;

    UPDATE tb_horario_medico
    SET
        id_medico = @id_medico,
        dia_semana = @dia_semana,
        hora_inicio = @hora_inicio,
        hora_fin = @hora_fin,
        estado = @estado
    WHERE id_horario = @id_horario;
END;
GO


/*=========================================================
    DAR DE BAJA LÓGICA A UN HORARIO
=========================================================*/

CREATE OR ALTER PROCEDURE sp_horario_dar_baja
    @id_horario INT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1
        FROM tb_horario_medico
        WHERE id_horario = @id_horario
    )
    BEGIN
        RAISERROR(
            'El horario seleccionado no existe.',
            16,
            1
        );
        RETURN;
    END;

    UPDATE tb_horario_medico
    SET estado = 0
    WHERE id_horario = @id_horario;
END;
GO


/*=========================================================
    COMPROBAR PROCEDIMIENTOS CREADOS
=========================================================*/

SELECT
    name AS Procedimiento
FROM sys.procedures
WHERE name LIKE 'sp_medico%'
   OR name LIKE 'sp_horario%'
ORDER BY name;
GO