CREATE DATABASE Logeo
USE Logeo


--TABLAS DE ADMINISTRADOR--

CREATE TABLE tipos_usuarios(
Id_tipo INT NOT NULL PRIMARY KEY,
Nombre VARCHAR (50) NOT NULL
);


create table Usuarios_L(
Id_usuarios INT NOT NULL IDENTITY PRIMARY KEY,
Nombre VARCHAR (25) NOT NULL,
Apellido VARCHAR(25) NOT NULL,
Usuario VARCHAR (25) NOT NULL,
Contraseņa VARCHAR (50)NOT NULL,
Id_tipo INT NOT NULL REFERENCES tipos_usuarios
);


INSERT INTO tipos_usuarios VALUES(1,'USUARIO')
INSERT INTO tipos_usuarios VALUES(2,'ADMIN')
INSERT INTO tipos_usuarios VALUES(3,'SECRETARIA')

INSERT INTO Usuarios_L VALUES ('Douglas','Hurtado','Douglas_h','2006',1)
INSERT INTO Usuarios_L VALUES ('Andres','Catalan','Andres_Cat','2007',2)
INSERT INTO Usuarios_L VALUES ('Diego','Boror','Diego_Br','2008',3)

DROP TABLE usuarios
DROP TABLE tipos_usuarios
SELECT * FROM tipos_usuarios
SELECT * FROM Usuarios_L


--TABLAS SECUNDARIAS--
CREATE TABLE NUEVOS_EMPLEADOS(
Id_empleado INT NOT NULL PRIMARY KEY,
Nombre VARCHAR (25),
Apelllido VARCHAR (25),
Tipo_empleo VARCHAR(35),
Codigo INT NOT NULL
);
Select * from NUEVOS_EMPLEADOS
DROP TABLE NUEVOS_EMPLEADOS

drop table CUENTAS_ACTIVADAS
CREATE TABLE CUENTAS_ACTIVADAS(
Id_usuarios INT NOT NULL PRIMARY KEY,
Nombre_usuario VARCHAR (25),
Contraseņa VARCHAR (50)NOT NULL,
Id_tipo INT
);


DROP TABLE CUENTAS_ACTIVADAS
select * from CUENTAS_ACTIVADAS

CREATE TABLE ID_EN_USO(
Id INT NOT NULL PRIMARY KEY);


Select * from ID_EN_USO
Drop table ID_EN_USO
INSERT INTO ID_EN_USO VALUES (1)
INSERT INTO ID_EN_USO VALUES (2)
INSERT INTO ID_EN_USO VALUES (3)