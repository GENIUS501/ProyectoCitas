create database DosCuerdas
go

use DosCuerdas
go

create table Roles(
	Id_Rol int IDENTITY(1,1) primary key,
	NombreRol varchar(20),
	Descripcion varchar(100),
);

CREATE TABLE Personas(
	ID_PERSONA INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Cedula varchar(20) NOT NULL,
	Nombre varchar(20) NOT NULL,
	PrimerApellido varchar(20) NOT NULL, 
	SegundoApellido varchar(20) NOT NULL,
	Genero varchar(20) NOT NULL,
	FechaNacimiento datetime NOT NULL,
	Correo varchar(20) NULL,
	Telefono varchar(20) NULL,
	TelefonoAdisional varchar(20) NULL
);

CREATE TABLE Permisos(
    ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL, 
	Modulo VARCHAR(20) NOT NULL,
    Accion VARCHAR(27) NULL,
    Id_Rol INT NOT NULL,
	CONSTRAINT Fk_PERMISOS_ROLES FOREIGN KEY(Id_Rol) REFERENCES Roles(Id_Rol)
);

create table Clientes(
	Id_Cliente  int IDENTITY(1,1) primary key,
	ID_PERSONA INT,
	CONSTRAINT Fk_Clientes_PERSONAS FOREIGN KEY(ID_PERSONA) REFERENCES Personas(ID_PERSONA)
)

create table Estudiantes(
	Id_Estudiante int IDENTITY(1,1) primary key,
	Sucursal varchar(20),
	TipoClase varchar(20),
	Horario datetime,
	ID_PERSONA INT,
	CONSTRAINT Fk_Estudiantes_PERSONAS FOREIGN KEY(ID_PERSONA) REFERENCES Personas(ID_PERSONA)
)

 /* alter procedure Para modificar el procedimiento  */

create table Profesores(
	Id_Profesor  int IDENTITY(1,1) primary key,
	Profesion varchar(20),
	instrumento varchar(20),
	ID_PERSONA INT,
	CONSTRAINT Fk_PROFESORES_PERSONAS FOREIGN KEY(ID_PERSONA) REFERENCES Personas(ID_PERSONA)
)

create table Usuarios(
	Id_Usuario int IDENTITY(1,1) primary key,
	Id_Rol int,
	ID_PERSONA INT,
	Usuario varchar(20),
	Contrasena varchar(max),
	Estado int,
	CONSTRAINT Fk_USUARIOS_ROLES FOREIGN KEY(Id_Rol) REFERENCES Roles(Id_Rol),
	CONSTRAINT Fk_USUARIOS_PERSONAS FOREIGN KEY(ID_PERSONA) REFERENCES Personas(ID_PERSONA)
)

CREATE TABLE Bitacora_Sesiones(
    codigo_ingreso_salida int IDENTITY(1,1) primary key, 
    fecha_hora_ingreso DATETIME NOT NULL,
    fecha_hora_salida DATETIME NULL,
    Id_Usuario INT,
	CONSTRAINT Fk_SESIONES_USUARIOS FOREIGN KEY(Id_Usuario) REFERENCES Usuarios(Id_Usuario)
);

CREATE TABLE Bitacora_Movimientos(
   codigo_movimiento_usuario int IDENTITY(1,1) primary key, 
   fecha_hora_movimiento DATETIME NOT NULL,
   tipo_movimiento varchar(50),
   modulo VARCHAR(20),
   Id_Usuario INT,
   CONSTRAINT Fk_MOVIMIENTOS_USUARIOS FOREIGN KEY(Id_Usuario) REFERENCES Usuarios(Id_Usuario)
);

CREATE TABLE Cita(
	IDCITA int IDENTITY(1,1) primary key NOT NULL, 
	HORA_CITA VARCHAR(6) NOT NULL,
	DURACION FLOAT NOT NULL,
	ESTADO VARCHAR(9) NOT NULL,
	FECHACITA DATETIME NOT NULL,
	Observaciones Text NULL,
	Id_Usuario INT NOT NULL,
	Id_Profesor INT NOT NULL,
	Id_Estudiante INT NOT NULL,
	CONSTRAINT Fk_CITA_USUARIOS FOREIGN KEY(Id_Usuario) REFERENCES Usuarios(Id_Usuario),
	CONSTRAINT Fk_CITA_PROFESORES FOREIGN KEY(Id_Profesor) REFERENCES Profesores(Id_Profesor),
	CONSTRAINT Fk_CITA_ESTUDIANTES FOREIGN KEY(Id_Estudiante) REFERENCES Estudiantes(Id_Estudiante)
);

INSERT INTO ROLES(NombreRol,Descripcion)VALUES('Administrador','Administrador')

INSERT INTO Permisos (Modulo, Accion, Id_Rol) VALUES
('Roles', 'Roles', 1),
('Roles', 'Agregar', 1),
('Roles', 'Modificar', 1),
('Roles', 'Eliminar', 1),
('Roles', 'Consultar', 1),
('Usuarios', 'Usuarios', 1),
('Usuarios', 'Agregar', 1),
('Usuarios', 'Modificar', 1),
('Usuarios', 'Eliminar', 1),
('Usuarios', 'Consultar', 1),
('Clientes', 'Clientes', 1),
('Clientes', 'Agregar', 1),
('Clientes', 'Modificar', 1),
('Clientes', 'Eliminar', 1),
('Clientes', 'Consultar', 1),
('Estudiantes', 'Estudiantes', 1),
('Estudiantes', 'Agregar', 1),
('Estudiantes', 'Modificar', 1),
('Estudiantes', 'Eliminar', 1),
('Estudiantes', 'Consultar', 1),
('Profesores', 'Profesores', 1),
('Profesores', 'Agregar', 1),
('Profesores', 'Modificar', 1),
('Profesores', 'Eliminar', 1),
('Profesores', 'Consultar', 1),
('ReporteEstudiantes', 'ReporteEstudiantes', 1),
('ReporteAgenda', 'ReporteAgenda', 1),
('ReporteProfesores', 'ReporteProfesores', 1),
('BitacoraSesiones', 'BitacoraSesiones', 1),
('BitacoraMovimientos', 'BitacoraMovimientos', 1),
('Agendar', 'Agendar', 1),
('Cancelar', 'Cancelar', 1)

INSERT INTO PERSONAS (Cedula, Nombre, PrimerApellido, SegundoApellido, Genero, FechaNacimiento, Correo, Telefono, TelefonoAdisional)
VALUES ('115830356', 'Javier', 'Arguedas', 'Diaz', 'NA', '2023-04-13', '1@1.com', '12345678', '12345678');

INSERT INTO Usuarios (Id_Rol, ID_PERSONA, Usuario, Contrasena, Estado)
VALUES (1, 1, 'Administrador1', 'HVEvEz0I1wRgOshEmHhas82xZwI=', 1)