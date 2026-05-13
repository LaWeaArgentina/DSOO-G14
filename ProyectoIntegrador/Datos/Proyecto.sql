DROP DATABASE IF EXISTS Proyecto;
CREATE DATABASE Proyecto;
USE Proyecto;

CREATE TABLE Alumno (
    identificador INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    esSocio BOOLEAN NOT NULL DEFAULT FALSE
);

CREATE TABLE Pago (
    id_pago INT PRIMARY KEY AUTO_INCREMENT,
    periodoInicio DATE NOT NULL,
    periodoFin DATE NOT NULL,
    identificadorAlumno INT NOT NULL,
    FOREIGN KEY (identificadorAlumno) REFERENCES Alumno(identificador)
);

CREATE TABLE Usuario (
    identificador INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(50) NOT NULL,
    correo VARCHAR(50) NOT NULL UNIQUE,
    clave VARCHAR(50) NOT NULL
);

CREATE INDEX idx_pago_alumno ON Pago(identificadorAlumno);
CREATE INDEX idx_alumno_socio ON Alumno(esSocio);

INSERT INTO Alumno (nombre, apellido, esSocio) VALUES
('Alumno', 'Uno', false),
('Alumno', 'Dos', true),
('Alumno', 'Tres', false),
('Alumno', 'Cuatro', true);

INSERT INTO Pago (periodoInicio, periodoFin, identificadorAlumno) VALUES
('2026-05-01','2026-05-01',1),
('2026-05-01','2026-05-31',2),
('2026-05-03','2026-05-03',3),
('2026-05-01','2026-05-31',4);

INSERT INTO Usuario (nombre, correo, clave) VALUES
('UsuarioX','x','x'),
('Usuario1', 'usuario1@test.com', 'password123'),
('Usuario2', 'usuario2@test.com', 'password456');

DELIMITER $

CREATE PROCEDURE Ingresar(in correo varchar(50),in clave varchar(50))
BEGIN
	SELECT nombre FROM Usuario u WHERE u.correo = correo AND u.clave = clave;
END$

CREATE PROCEDURE LeerAlumnos()
BEGIN
    SELECT a.identificador, a.nombre, a.apellido, a.esSocio,
           (SELECT MAX(p.periodoFin) FROM Pago p WHERE p.identificadorAlumno = a.identificador) AS vencimiento
    FROM Alumno a;
END$

CREATE PROCEDURE CrearAlumno(in p_nombre VARCHAR(100), in p_apellido VARCHAR(100), in p_esSocio BOOLEAN)
BEGIN
    INSERT INTO Alumno (nombre, apellido, esSocio) VALUES (p_nombre, p_apellido, p_esSocio);
    SELECT LAST_INSERT_ID() AS identificador;
END$

DELIMITER ;
