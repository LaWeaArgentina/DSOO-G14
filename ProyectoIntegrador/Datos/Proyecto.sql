-- Crea la base de datos Proyecto y sus tablas.
-- Crea usuarios de prueba.

DROP DATABASE IF EXISTS Proyecto;
CREATE DATABASE Proyecto;
USE Proyecto;

CREATE TABLE Alumno (
    identificador INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    esSocio BOOLEAN NOT NULL DEFAULT FALSE,
    vencimiento DATE
);

CREATE TABLE Pago (
    id_pago INT PRIMARY KEY AUTO_INCREMENT,
    periodoInicio DATE NOT NULL,
    periodoFin DATE NOT NULL,
    identificador_alumno INT NOT NULL,
    FOREIGN KEY (identificador_alumno) REFERENCES Alumno(identificador) ON DELETE CASCADE
);

CREATE TABLE Usuario (
    identificador INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(100) NOT NULL,
    correo VARCHAR(100) NOT NULL UNIQUE,
    contrasena VARCHAR(255) NOT NULL
);

INSERT INTO Usuario (nombre, correo, contrasena) VALUES
('Usuario1', 'usuario1@test.com', 'password123'),
('Usuario2', 'usuario2@test.com', 'password456');

CREATE INDEX idx_pago_alumno ON Pago(identificador_alumno);
CREATE INDEX idx_alumno_socio ON Alumno(esSocio);