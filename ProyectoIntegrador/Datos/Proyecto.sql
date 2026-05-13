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

CREATE PROCEDURE LeerAlumnos()
BEGIN
    SELECT identificador, nombre, apellido, esSocio, vencimiento FROM Alumno;
END$

CREATE PROCEDURE CrearAlumno(in p_nombre VARCHAR(100), in p_apellido VARCHAR(100), in p_esSocio BOOLEAN, in p_vencimiento DATE)
BEGIN
    INSERT INTO Alumno (nombre, apellido, esSocio, vencimiento) VALUES (p_nombre, p_apellido, p_esSocio, p_vencimiento);
    SELECT LAST_INSERT_ID() AS identificador;
END$

CREATE PROCEDURE EditarAlumno(in p_identificador INT, in p_nombre VARCHAR(100), in p_apellido VARCHAR(100), in p_esSocio BOOLEAN, in p_vencimiento DATE)
BEGIN
    UPDATE Alumno SET nombre = p_nombre, apellido = p_apellido, esSocio = p_esSocio, vencimiento = p_vencimiento WHERE identificador = p_identificador;
    SELECT ROW_COUNT() AS filas_afectadas;
END$

CREATE PROCEDURE BorrarAlumno(in p_identificador INT)
BEGIN
    DELETE FROM Alumno WHERE identificador = p_identificador;
    SELECT ROW_COUNT() AS filas_afectadas;
END$

DELIMITER ;
