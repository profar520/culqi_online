create database bd_culqi
use bd_culqi

/************************TABLAS CON PK*******************************************************/

--Tabla Tipo Usuario
CREATE TABLE Tipo_Usuario (
ID_Tipo int identity (1,1) primary key not null,
valor varchar (20),
)

--Tabla Tipo documento
CREATE TABLE Tipo_Documento(
ID_Tipo_Documento int identity (1,1) primary key not null,
valor varchar (20) not null
)

--Tabla Banco
CREATE TABLE Banco (
ID_Banco int identity (1,1) primary key not null,
Nombre_Banco varchar (20) not null,
)

--Tabla canal 
CREATE TABLE Canal(
ID_Canal int identity (1,1) primary key not null,
Nombre_Canal varchar(25) not null,
)

--Tabla Lugar de origen de la cuenta
CREATE TABLE Lugar (
ID_Lugar int identity (1,1) primary key not null,
Lugar varchar (15) not null,
)

--Tabla Tipo de moneda para la cuenta--
CREATE TABLE Tipo_Moneda(
ID_Moneda int identity (1,1) primary key not null,
Moneda varchar (15) not null,
)

--Tabla Tipo de cuenta para la cuenta--
CREATE TABLE Tipo_Cuenta(
ID_Tipo_cuenta int identity (1,1) primary key not null,
Cuenta varchar (25) not null,
)

--Tabla Categoria del comercio
CREATE TABLE Categoria (
ID_Giro_Negocio int identity (1,1) primary key not null,
Giro_Negocio varchar (50) not null
)

--Tabla Ciudad
CREATE TABLE Ciudad(
ID_Ciudad int identity (1,1) primary key not null,
Nombre_Ciudad varchar(50) not null,
)


/************************TABLAS CON PK y FK***************************************************/

--Tabla Usuario
CREATE TABLE Usuario(
ID_Usuario int identity (1,1) primary key not null,
ID_Tipo int foreign key references Tipo_Usuario (ID_Tipo),
ID_Tipo_Documento int foreign key references Tipo_Documento (ID_Tipo_Documento),
ID_Canal int foreign key references Canal (ID_Canal),
Nombres varchar (50) not null,
Correo varchar (50) not null,
Contrasenia varchar (25) not null,
Numero_Documento varchar(50) not null,
Terminos_Condiciones char(1) not null
)

/*******************************/

--Tabla Cuenta bancaria
CREATE TABLE Cuenta(
ID_Cuenta int identity (1,1) primary key not null,
ID_Banco int foreign key references Banco (ID_Banco) not null,
ID_Usuario int foreign key references Usuario (ID_Usuario) not null,
ID_Tipo_Cuenta int foreign key references Tipo_Cuenta (ID_Tipo_cuenta) not null,
ID_Moneda int foreign key references Tipo_Moneda (ID_Moneda) not null,
ID_Lugar int foreign key references Lugar (ID_Lugar) not null,
Numero_Cuenta varchar (50) not null,
)

/*******************************/

--Tabla Comercio
CREATE TABLE Comercio (
ID_Comercio int identity (1,1) primary key not null,
ID_Usuario int foreign key references Usuario (ID_Usuario) not null,
ID_Ciudad int foreign key references Ciudad (ID_Ciudad) not null,
ID_Giro_Negocio int foreign key references Categoria (ID_Giro_Negocio) not null,
Llave_Publica varchar (50) not null,
Nombre_Comercial varchar (25) not null,
URL_Comercio varchar (100), 
Celular int not null
)

/************************************************/

--Tabla Rubro
CREATE TABLE Rubro(
ID_Rubro int identity (1,1) primary key not null,
ID_Giro_Negocio int foreign key references Categoria (ID_Giro_Negocio) not null,
Nombre_Rubro varchar (50) not null,
)

/********************FIN TABLAS*********************/

--Otros--

select * from Usuario
insert into Usuario values (1,1,1,'Karina Samaritano','karina@gmail.com','12345678','76793341',1)

delete from Usuario where ID_Usuario=0

select * from Tipo_Usuario
insert into Tipo_Usuario values ('desarrollador')
insert into Tipo_Usuario values ('comerciante')


select * from Cuenta
insert into Cuenta values (1,1,1,'dolar','1234-1234-1234-1234','lima')

select * from Banco
insert into Banco values ('bbva')
insert into Banco values ('bcp')
insert into Banco values ('scotiabank')
insert into Banco values ('interbank')
insert into Banco values ('mibanco')

select * from Tipo_Cuenta
insert into Tipo_Cuenta values ('ahorro')
insert into Tipo_Cuenta values ('corriente')

select * from Tipo_Moneda
insert into Tipo_Moneda values ('dolar')
insert into Tipo_Moneda values ('soles')

select * from Canal
insert into Canal values ('busqueda en google')
insert into Canal values ('medios de prensa')
insert into Canal values ('por recomendación')
insert into Canal values ('redes sociales')

select * from Tipo_Documento
insert into Tipo_Documento values ('dni')
insert into Tipo_Documento values ('ruc')
insert into Tipo_Documento values ('carne extranjeria')


select * from Ciudad
insert into Ciudad values ('lima, peru')
insert into Ciudad values ('limadistric, peru')
insert into Ciudad values ('limatambo, peru')
insert into Ciudad values ('limabamba, peru')
insert into Ciudad values ('limapampa, peru')

select * from Rubro
--Para el giro de negocio servicios financieros
insert into Rubro values (2,'seguros')
insert into Rubro values (2,'agentes de valores y corredores de bolsa')
insert into Rubro values (2,'otros financieras')
--Para productos digitales
insert into Rubro values (4,'software')
insert into Rubro values (4,'ebook, audiolibros')
insert into Rubro values (4,'juegos')
insert into Rubro values (4,'otros')
--Para entretenimiento
insert into Rubro values (1,'cine')
insert into Rubro values (1,'musico, orquesta')
insert into Rubro values (1,'otras recreaciones')
--Para enseñanza
insert into Rubro values (3,'Servicio de cuidado infantil, guarderia')
insert into Rubro values (3,'institutos de estudios superiores o universidades')
insert into Rubro values (3,'centros de enseñanza primaria y secundaria')
insert into Rubro values (3,'organizaciones de membresia')
insert into Rubro values (3,'otros servicios educacionales')


select * from Categoria
insert into Categoria values ('actividades recreativas y entretenimiento')
insert into Categoria values ('servicios financieros')
insert into Categoria values ('enseñanza')
insert into Categoria values ('productos digitales')


SELECT c.ID_Giro_Negocio, c.Giro_Negocio, r.ID_Rubro, r.Nombre_Rubro FROM Categoria c, Rubro r WHERE ( c.ID_Giro_Negocio = r.ID_Giro_Negocio )