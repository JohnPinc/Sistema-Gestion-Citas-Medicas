CREATE DATABASE db_citas_medicas;
GO

USE db_citas_medicas;
GO



/*=========================================================
  TABLA ESPECIALIDAD
=========================================================*/

CREATE TABLE tb_especialidad
(
    id_especialidad INT IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL,
    descripcion NVARCHAR(250) NULL,
    estado BIT NOT NULL DEFAULT 1,
    fecha_registro DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT UQ_especialidad_nombre
        UNIQUE (nombre)
);
GO


/*=========================================================
  TABLA PACIENTE
=========================================================*/

CREATE TABLE tb_paciente
(
    id_paciente INT IDENTITY(1,1) PRIMARY KEY,
    cedula VARCHAR(10) NOT NULL,
    nombres NVARCHAR(100) NOT NULL,
    apellidos NVARCHAR(100) NOT NULL,
    fecha_nacimiento DATE NOT NULL,
    genero NVARCHAR(20) NOT NULL,
    telefono VARCHAR(15) NULL,
    correo VARCHAR(150) NULL,
    direccion NVARCHAR(250) NULL,
    estado BIT NOT NULL DEFAULT 1,
    fecha_registro DATETIME NOT NULL DEFAULT GETDATE(),
    fecha_actualizacion DATETIME NULL,

    CONSTRAINT UQ_paciente_cedula
        UNIQUE (cedula),

    CONSTRAINT CK_paciente_cedula
        CHECK
        (
            LEN(cedula) = 10
            AND cedula NOT LIKE '%[^0-9]%'
        )
);
GO


/*=========================================================
  TABLA MÉDICO
=========================================================*/

CREATE TABLE tb_medico
(
    id_medico INT IDENTITY(1,1) PRIMARY KEY,
    id_especialidad INT NOT NULL,
    cedula VARCHAR(10) NOT NULL,
    numero_colegiatura VARCHAR(30) NOT NULL,
    nombres NVARCHAR(100) NOT NULL,
    apellidos NVARCHAR(100) NOT NULL,
    telefono VARCHAR(15) NULL,
    correo VARCHAR(150) NULL,
    estado BIT NOT NULL DEFAULT 1,
    fecha_registro DATETIME NOT NULL DEFAULT GETDATE(),
    fecha_actualizacion DATETIME NULL,

    CONSTRAINT FK_medico_especialidad
        FOREIGN KEY (id_especialidad)
        REFERENCES tb_especialidad(id_especialidad),

    CONSTRAINT UQ_medico_cedula
        UNIQUE (cedula),

    CONSTRAINT UQ_medico_colegiatura
        UNIQUE (numero_colegiatura),

    CONSTRAINT CK_medico_cedula
        CHECK
        (
            LEN(cedula) = 10
            AND cedula NOT LIKE '%[^0-9]%'
        )
);
GO


/*=========================================================
  TABLA HORARIO DEL MÉDICO

  Día de la semana:
  1 = Lunes
  2 = Martes
  3 = Miércoles
  4 = Jueves
  5 = Viernes
  6 = Sábado
  7 = Domingo
=========================================================*/

CREATE TABLE tb_horario_medico
(
    id_horario INT IDENTITY(1,1) PRIMARY KEY,
    id_medico INT NOT NULL,
    dia_semana TINYINT NOT NULL,
    hora_inicio TIME NOT NULL,
    hora_fin TIME NOT NULL,
    estado BIT NOT NULL DEFAULT 1,
    fecha_registro DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_horario_medico
        FOREIGN KEY (id_medico)
        REFERENCES tb_medico(id_medico),

    CONSTRAINT CK_horario_dia
        CHECK (dia_semana BETWEEN 1 AND 7),

    CONSTRAINT CK_horario_horas
        CHECK (hora_inicio < hora_fin),

    CONSTRAINT UQ_horario_medico
        UNIQUE
        (
            id_medico,
            dia_semana,
            hora_inicio,
            hora_fin
        )
);
GO


/*=========================================================
  TABLA ESTADO DE CITA
=========================================================*/

CREATE TABLE tb_estado_cita
(
    id_estado INT PRIMARY KEY,
    nombre NVARCHAR(30) NOT NULL,
    descripcion NVARCHAR(150) NULL,

    CONSTRAINT UQ_estado_cita_nombre
        UNIQUE (nombre)
);
GO


/*=========================================================
  REGISTRAR ESTADOS DE LAS CITAS
=========================================================*/

INSERT INTO tb_estado_cita
(
    id_estado,
    nombre,
    descripcion
)
VALUES
(
    1,
    'Programada',
    'La cita se encuentra pendiente de atención'
),
(
    2,
    'Atendida',
    'El paciente fue atendido por el médico'
),
(
    3,
    'Cancelada',
    'La cita fue cancelada'
),
(
    4,
    'Reprogramada',
    'La cita fue cambiada de fecha u horario'
),
(
    5,
    'No Asistida',
    'El paciente no asistió a la cita'
);
GO


/*=========================================================
  TABLA CITA MÉDICA
=========================================================*/

CREATE TABLE tb_cita
(
    id_cita INT IDENTITY(1,1) PRIMARY KEY,
    id_paciente INT NOT NULL,
    id_medico INT NOT NULL,
    id_estado INT NOT NULL DEFAULT 1,

    fecha_cita DATE NOT NULL,
    hora_inicio TIME NOT NULL,
    hora_fin TIME NOT NULL,

    motivo NVARCHAR(250) NOT NULL,
    observaciones NVARCHAR(500) NULL,

    id_cita_origen INT NULL,

    fecha_registro DATETIME NOT NULL DEFAULT GETDATE(),
    fecha_actualizacion DATETIME NULL,

    CONSTRAINT FK_cita_paciente
        FOREIGN KEY (id_paciente)
        REFERENCES tb_paciente(id_paciente),

    CONSTRAINT FK_cita_medico
        FOREIGN KEY (id_medico)
        REFERENCES tb_medico(id_medico),

    CONSTRAINT FK_cita_estado
        FOREIGN KEY (id_estado)
        REFERENCES tb_estado_cita(id_estado),

    CONSTRAINT FK_cita_origen
        FOREIGN KEY (id_cita_origen)
        REFERENCES tb_cita(id_cita),

    CONSTRAINT CK_cita_horas
        CHECK (hora_inicio < hora_fin)
);
GO


/*=========================================================
  ÍNDICES PARA MEJORAR LAS CONSULTAS
=========================================================*/

CREATE INDEX IX_medico_especialidad
ON tb_medico(id_especialidad);
GO

CREATE INDEX IX_horario_medico
ON tb_horario_medico(id_medico, dia_semana);
GO

CREATE INDEX IX_cita_medico_fecha
ON tb_cita(id_medico, fecha_cita);
GO

CREATE INDEX IX_cita_paciente_fecha
ON tb_cita(id_paciente, fecha_cita);
GO

CREATE INDEX IX_cita_estado_fecha
ON tb_cita(id_estado, fecha_cita);
GO


/*=========================================================
  COMPROBAR LAS TABLAS CREADAS
=========================================================*/

SELECT
    name AS Tabla
FROM sys.tables
ORDER BY name;
GO


/*=========================================================
  COMPROBAR LOS ESTADOS DE CITA
=========================================================*/

SELECT *
FROM tb_estado_cita;
GO