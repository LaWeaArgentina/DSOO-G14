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
    nombre VARCHAR(50) NOT NULL,
    correo VARCHAR(50) NOT NULL UNIQUE,
    clave VARCHAR(50) NOT NULL
);

INSERT INTO Usuario (nombre, correo, clave) VALUES
('Usuario1', 'usuario1@test.com', 'password123'),
('Usuario2', 'usuario2@test.com', 'password456');

CREATE INDEX idx_pago_alumno ON Pago(identificador_alumno);
CREATE INDEX idx_alumno_socio ON Alumno(esSocio);

DELIMITER $
CREATE PROCEDURE Ingresar(in correo varchar(50),in clave varchar(50))
BEGIN
	SELECT nombre FROM Usuario u WHERE u.correo = correo AND u.clave = clave;
END$

DELIMITER ;
