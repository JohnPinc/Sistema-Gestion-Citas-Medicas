USE db_citas_medicas;
GO
/*=========================================================
    PROCEDIMIENTOS ALMACENADOS DE ESPECIALIDADES
=========================================================*/


/*=========================================================
    LISTAR TODAS LAS ESPECIALIDADES
=========================================================*/

CREATE OR ALTER PROCEDURE sp_especialidad_listar
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        id_especialidad,
        nombre,
        descripcion,
        estado,
        CASE
            WHEN estado = 1 THEN 'Activo'
            ELSE 'Inactivo'
        END AS nombre_estado
    FROM tb_especialidad
    ORDER BY nombre;
END;
GO


/*=========================================================
    LISTAR ESPECIALIDADES ACTIVAS
    Se utilizará en el ComboBox de médicos
=========================================================*/

CREATE OR ALTER PROCEDURE sp_especialidad_listar_activas
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        id_especialidad,
        nombre
    FROM tb_especialidad
    WHERE estado = 1
    ORDER BY nombre;
END;
GO


/*=========================================================
    BUSCAR ESPECIALIDADES
=========================================================*/

CREATE OR ALTER PROCEDURE sp_especialidad_buscar
    @texto NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        id_especialidad,
        nombre,
        descripcion,
        estado,
        CASE
            WHEN estado = 1 THEN 'Activo'
            ELSE 'Inactivo'
        END AS nombre_estado
    FROM tb_especialidad
    WHERE nombre LIKE '%' + @texto + '%'
       OR ISNULL(descripcion, '') LIKE '%' + @texto + '%'
    ORDER BY nombre;
END;
GO


/*=========================================================
    REGISTRAR ESPECIALIDAD
=========================================================*/

CREATE OR ALTER PROCEDURE sp_especialidad_registrar
    @nombre NVARCHAR(100),
    @descripcion NVARCHAR(250),
    @estado BIT
AS
BEGIN
    SET NOCOUNT ON;

    SET @nombre = LTRIM(RTRIM(@nombre));
    SET @descripcion = LTRIM(RTRIM(@descripcion));

    IF @nombre IS NULL OR @nombre = ''
    BEGIN
        THROW 50001,
        'El nombre de la especialidad es obligatorio.',
        1;
    END;

    IF EXISTS
    (
        SELECT 1
        FROM tb_especialidad
        WHERE nombre = @nombre
    )
    BEGIN
        THROW 50002,
        'Ya existe una especialidad con ese nombre.',
        1;
    END;

    INSERT INTO tb_especialidad
    (
        nombre,
        descripcion,
        estado
    )
    VALUES
    (
        @nombre,
        NULLIF(@descripcion, ''),
        @estado
    );
END;
GO


/*=========================================================
    MODIFICAR ESPECIALIDAD
=========================================================*/

CREATE OR ALTER PROCEDURE sp_especialidad_modificar
    @id_especialidad INT,
    @nombre NVARCHAR(100),
    @descripcion NVARCHAR(250),
    @estado BIT
AS
BEGIN
    SET NOCOUNT ON;

    SET @nombre = LTRIM(RTRIM(@nombre));
    SET @descripcion = LTRIM(RTRIM(@descripcion));

    IF NOT EXISTS
    (
        SELECT 1
        FROM tb_especialidad
        WHERE id_especialidad = @id_especialidad
    )
    BEGIN
        THROW 50003,
        'La especialidad seleccionada no existe.',
        1;
    END;

    IF @nombre IS NULL OR @nombre = ''
    BEGIN
        THROW 50004,
        'El nombre de la especialidad es obligatorio.',
        1;
    END;

    IF EXISTS
    (
        SELECT 1
        FROM tb_especialidad
        WHERE nombre = @nombre
          AND id_especialidad <> @id_especialidad
    )
    BEGIN
        THROW 50005,
        'Ya existe otra especialidad con ese nombre.',
        1;
    END;

    UPDATE tb_especialidad
    SET
        nombre = @nombre,
        descripcion = NULLIF(@descripcion, ''),
        estado = @estado
    WHERE id_especialidad = @id_especialidad;
END;
GO


/*=========================================================
    DAR DE BAJA LÓGICA A UNA ESPECIALIDAD
=========================================================*/

CREATE OR ALTER PROCEDURE sp_especialidad_dar_baja
    @id_especialidad INT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1
        FROM tb_especialidad
        WHERE id_especialidad = @id_especialidad
    )
    BEGIN
        THROW 50006,
        'La especialidad seleccionada no existe.',
        1;
    END;

    UPDATE tb_especialidad
    SET estado = 0
    WHERE id_especialidad = @id_especialidad;
END;
GO


/*=========================================================
    PROCEDIMIENTOS ALMACENADOS DE PACIENTES
=========================================================*/


/*=========================================================
    LISTAR TODOS LOS PACIENTES
=========================================================*/

CREATE OR ALTER PROCEDURE sp_paciente_listar
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        id_paciente,
        cedula,
        nombres,
        apellidos,
        fecha_nacimiento,
        genero,
        telefono,
        correo,
        direccion,
        estado,
        CASE
            WHEN estado = 1 THEN 'Activo'
            ELSE 'Inactivo'
        END AS nombre_estado
    FROM tb_paciente
    ORDER BY apellidos, nombres;
END;
GO


/*=========================================================
    LISTAR PACIENTES ACTIVOS
    Se utilizará en el ComboBox de citas
=========================================================*/

CREATE OR ALTER PROCEDURE sp_paciente_listar_activos
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        id_paciente,
        cedula,
        nombres,
        apellidos,
        nombres + ' ' + apellidos AS paciente
    FROM tb_paciente
    WHERE estado = 1
    ORDER BY apellidos, nombres;
END;
GO


/*=========================================================
    BUSCAR PACIENTES
=========================================================*/

CREATE OR ALTER PROCEDURE sp_paciente_buscar
    @texto NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        id_paciente,
        cedula,
        nombres,
        apellidos,
        fecha_nacimiento,
        genero,
        telefono,
        correo,
        direccion,
        estado,
        CASE
            WHEN estado = 1 THEN 'Activo'
            ELSE 'Inactivo'
        END AS nombre_estado
    FROM tb_paciente
    WHERE cedula LIKE '%' + @texto + '%'
       OR nombres LIKE '%' + @texto + '%'
       OR apellidos LIKE '%' + @texto + '%'
       OR nombres + ' ' + apellidos LIKE '%' + @texto + '%'
    ORDER BY apellidos, nombres;
END;
GO


/*=========================================================
    REGISTRAR PACIENTE
=========================================================*/

CREATE OR ALTER PROCEDURE sp_paciente_registrar
    @cedula VARCHAR(10),
    @nombres NVARCHAR(100),
    @apellidos NVARCHAR(100),
    @fecha_nacimiento DATE,
    @genero NVARCHAR(20),
    @telefono VARCHAR(15),
    @correo VARCHAR(150),
    @direccion NVARCHAR(250),
    @estado BIT
AS
BEGIN
    SET NOCOUNT ON;

    SET @cedula = LTRIM(RTRIM(@cedula));
    SET @nombres = LTRIM(RTRIM(@nombres));
    SET @apellidos = LTRIM(RTRIM(@apellidos));
    SET @genero = LTRIM(RTRIM(@genero));
    SET @telefono = LTRIM(RTRIM(@telefono));
    SET @correo = LTRIM(RTRIM(@correo));
    SET @direccion = LTRIM(RTRIM(@direccion));

    IF LEN(@cedula) <> 10
       OR @cedula LIKE '%[^0-9]%'
    BEGIN
        THROW 50010,
        'La cédula debe contener exactamente 10 números.',
        1;
    END;

    IF @nombres IS NULL OR @nombres = ''
    BEGIN
        THROW 50011,
        'Los nombres del paciente son obligatorios.',
        1;
    END;

    IF @apellidos IS NULL OR @apellidos = ''
    BEGIN
        THROW 50012,
        'Los apellidos del paciente son obligatorios.',
        1;
    END;

    IF @genero IS NULL OR @genero = ''
    BEGIN
        THROW 50013,
        'Debe seleccionar el género del paciente.',
        1;
    END;

    IF @fecha_nacimiento > CAST(GETDATE() AS DATE)
    BEGIN
        THROW 50014,
        'La fecha de nacimiento no puede ser futura.',
        1;
    END;

    IF EXISTS
    (
        SELECT 1
        FROM tb_paciente
        WHERE cedula = @cedula
    )
    BEGIN
        THROW 50015,
        'Ya existe un paciente con esa cédula.',
        1;
    END;

    INSERT INTO tb_paciente
    (
        cedula,
        nombres,
        apellidos,
        fecha_nacimiento,
        genero,
        telefono,
        correo,
        direccion,
        estado
    )
    VALUES
    (
        @cedula,
        @nombres,
        @apellidos,
        @fecha_nacimiento,
        @genero,
        NULLIF(@telefono, ''),
        NULLIF(@correo, ''),
        NULLIF(@direccion, ''),
        @estado
    );
END;
GO


/*=========================================================
    MODIFICAR PACIENTE
=========================================================*/

CREATE OR ALTER PROCEDURE sp_paciente_modificar
    @id_paciente INT,
    @cedula VARCHAR(10),
    @nombres NVARCHAR(100),
    @apellidos NVARCHAR(100),
    @fecha_nacimiento DATE,
    @genero NVARCHAR(20),
    @telefono VARCHAR(15),
    @correo VARCHAR(150),
    @direccion NVARCHAR(250),
    @estado BIT
AS
BEGIN
    SET NOCOUNT ON;

    SET @cedula = LTRIM(RTRIM(@cedula));
    SET @nombres = LTRIM(RTRIM(@nombres));
    SET @apellidos = LTRIM(RTRIM(@apellidos));
    SET @genero = LTRIM(RTRIM(@genero));
    SET @telefono = LTRIM(RTRIM(@telefono));
    SET @correo = LTRIM(RTRIM(@correo));
    SET @direccion = LTRIM(RTRIM(@direccion));

    IF NOT EXISTS
    (
        SELECT 1
        FROM tb_paciente
        WHERE id_paciente = @id_paciente
    )
    BEGIN
        THROW 50016,
        'El paciente seleccionado no existe.',
        1;
    END;

    IF LEN(@cedula) <> 10
       OR @cedula LIKE '%[^0-9]%'
    BEGIN
        THROW 50017,
        'La cédula debe contener exactamente 10 números.',
        1;
    END;

    IF @nombres IS NULL OR @nombres = ''
    BEGIN
        THROW 50018,
        'Los nombres del paciente son obligatorios.',
        1;
    END;

    IF @apellidos IS NULL OR @apellidos = ''
    BEGIN
        THROW 50019,
        'Los apellidos del paciente son obligatorios.',
        1;
    END;

    IF @genero IS NULL OR @genero = ''
    BEGIN
        THROW 50020,
        'Debe seleccionar el género del paciente.',
        1;
    END;

    IF @fecha_nacimiento > CAST(GETDATE() AS DATE)
    BEGIN
        THROW 50021,
        'La fecha de nacimiento no puede ser futura.',
        1;
    END;

    IF EXISTS
    (
        SELECT 1
        FROM tb_paciente
        WHERE cedula = @cedula
          AND id_paciente <> @id_paciente
    )
    BEGIN
        THROW 50022,
        'Ya existe otro paciente con esa cédula.',
        1;
    END;

    UPDATE tb_paciente
    SET
        cedula = @cedula,
        nombres = @nombres,
        apellidos = @apellidos,
        fecha_nacimiento = @fecha_nacimiento,
        genero = @genero,
        telefono = NULLIF(@telefono, ''),
        correo = NULLIF(@correo, ''),
        direccion = NULLIF(@direccion, ''),
        estado = @estado,
        fecha_actualizacion = GETDATE()
    WHERE id_paciente = @id_paciente;
END;
GO


/*=========================================================
    DAR DE BAJA LÓGICA A UN PACIENTE
=========================================================*/

CREATE OR ALTER PROCEDURE sp_paciente_dar_baja
    @id_paciente INT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS
    (
        SELECT 1
        FROM tb_paciente
        WHERE id_paciente = @id_paciente
    )
    BEGIN
        THROW 50023,
        'El paciente seleccionado no existe.',
        1;
    END;

    UPDATE tb_paciente
    SET
        estado = 0,
        fecha_actualizacion = GETDATE()
    WHERE id_paciente = @id_paciente;
END;
GO


/*=========================================================
    COMPROBAR PROCEDIMIENTOS CREADOS
=========================================================*/

SELECT
    name AS Procedimiento
FROM sys.procedures
WHERE name LIKE 'sp_especialidad%'
   OR name LIKE 'sp_paciente%'
ORDER BY name;
GO