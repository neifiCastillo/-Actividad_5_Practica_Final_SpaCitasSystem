CREATE DATABASE SpaCitasDB;
GO

USE SpaCitasDB;
GO

CREATE TABLE Usuarios (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(25) NOT NULL,
    Activo BIT NOT NULL DEFAULT 1
);

CREATE TABLE Pacientes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(150) NOT NULL,
    Telefono NVARCHAR(20),
    Email NVARCHAR(150)
);

CREATE TABLE Servicios (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(150) NOT NULL,
    DuracionMinutos INT NOT NULL,
    Precio DECIMAL(10,2) NOT NULL
);

CREATE TABLE Terapeutas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(150) NOT NULL,
    Especialidad NVARCHAR(150)
);

CREATE TABLE Citas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    PacienteId INT NOT NULL,
    ServicioId INT NOT NULL,
    TerapeutaId INT NOT NULL,
    Fecha DATE NOT NULL,
    Hora TIME NOT NULL,

    CONSTRAINT FK_Cita_Paciente
    FOREIGN KEY (PacienteId)
    REFERENCES Pacientes(Id),

    CONSTRAINT FK_Cita_Servicio
    FOREIGN KEY (ServicioId)
    REFERENCES Servicios(Id),

    CONSTRAINT FK_Cita_Terapeuta
    FOREIGN KEY (TerapeutaId)
    REFERENCES Terapeutas(Id)
);