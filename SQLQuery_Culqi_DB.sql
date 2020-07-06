create database culqi_db
use culqi_db

/***************************************************************************************/

--Tabla Deposito
CREATE TABLE Deposito(
ID_Deposito int identity (1,1) primary key not null,
Monto float null,
Fecha date null,
Estado integer not null,
)

--Tabla Marca
CREATE TABLE Marca (
ID_Marca int identity (1,1) primary key not null,
Nombre varchar (15) not null,
Tipo_marca varchar (15)not null,
)

/*******************************/

--Tabla pago en efectivo
CREATE TABLE Efectivo (
ID_referencia int identity (1,1) primary key not null,
Ent_financiera varchar (20) not null,
Monto int not null
)

/*******************************/

--Tabla Categoria del comercio
CREATE TABLE Categoria (
ID_Giro_Neg int identity (1,1) primary key not null,
Giro_n varchar (25) not null
)

--Tabla Tipo de usuario
CREATE TABLE Tipo_Usuario (
ID_Tipo int identity (1,1) primary key not null,
Descripcion varchar (15),
)

--Tabla Tipo documento
CREATE TABLE Tipo_Documento(
ID_Tipo_Doc int identity (1,1) primary key not null,
Descripcion varchar (15) not null,
)

/**************TABLAS CON FK*****************/
--Tabla Usuario
CREATE TABLE Usuario(
ID_Usuario int identity (1,1) primary key not null,
ID_Tipo int foreign key references Tipo_Usuario (ID_Tipo),
ID_Tipo_Doc int foreign key references Tipo_Documento (ID_Tipo_Doc),
Nombres varchar (30) not null,
Correo varchar (30) not null,
Contrasenia varchar (25) not null,
)

/*******************************/

--Tabla Cuenta bancaria
CREATE TABLE Cuenta(
ID_Cuenta int identity (1,1) primary key not null,
ID_Marca int foreign key references Marca (ID_Marca) not null,
ID_Usuario int foreign key references Usuario (ID_Usuario) not null,
Tipo_Moneda varchar (10) not null,
Numero_cuenta varchar (22) not null,
)

/*******************************/

--Tabla Tarjeta
CREATE TABLE Tarjeta (
ID_Tarjeta int identity (1,1) primary key not null,
ID_Marca int foreign key references Marca (ID_Marca),
Num_tarjeta int not null,
CVV int not null,
fec_tarjeta datetime not null
)

--Tabla Comercio
CREATE TABLE Comercio (
ID_Comercio int identity (1,1) primary key not null,
ID_Usuario int foreign key references Usuario (ID_Usuario),
ID_Giro_Negn int foreign key references Categoria (Id_Giro_Neg),
Llave_Publica varchar (30) not null,
Nombre_Comercio varchar (25) not null,
URL_Comercio varchar (100), /**/
celular int not null,
Pais varchar (20) not null,
Terminos_condiciones varchar (10) not null,
Rubro varchar (25) not null,
)

/************************************************/

--Tabla Venta
CREATE TABLE Venta (
ID_Venta int identity (1,1) primary key not null,
ID_Comercio int foreign key references Comercio (ID_Comercio) not null,
ID_referencia int foreign key references Efectivo (ID_referencia) not null,
ID_Tarjeta int foreign key references Tarjeta(ID_Tarjeta) not null,
ID_Deposito int foreign key references Deposito (ID_Deposito) not null,
Nombre_Comercio varchar (25) null,
Monto float null, 
Correo varchar (30) null,
Estado varchar (20) null,
Fecha_Hora datetime null,
)

/* el mismo ID se usa en Venta y Detalle Venta https://www.youtube.com/watch?v=kst99aPgTYo     */

--Tabla Detalle_Venta
CREATE TABLE Detalle_Venta (
ID_Detalle_Venta int identity (1,1) primary key not null,
ID_Venta int foreign key references Venta (ID_Venta) not null,
fecha_hora datetime null,
Descripcion varchar (30) null,
correo_electronico varchar (30) not null,
Nombres varchar (30) null,
Apellidos varchar (30) null,
Pais varchar (25) null,
Ciudad varchar (25) null,
Dirección varchar (30) null,
)


/* https://www.youtube.com/watch?v=Pl8qG71zvIw  */
/* solo se ve el calendario en deposito con el monto y estado, más no se ven los campos que se declararon 
en el diagrama de datos con respecto a depositos */

--Tabla Detalle Deposito
CREATE TABLE Detalle_Deposito(
ID_Detalle_Deposito int identity (1,1) primary key not null,
ID_Deposito int foreign key references Deposito (ID_Deposito) not null,
N_Operacion int null, 
Fecha_Desposito datetime null,
Concepto varchar (15) null,
/* N_pedido en el video sale vacio */
Monto float null,
Comision float null,
Monto_Depo float null, 
Fecha_Oper datetime null,
)

select * from Tipo_Usuario

select * from Usuario

insert into Usuario values (1,1,'Karina Samaritano','karina@gmail.com','12345678')

insert into Tipo_Usuario (Descripcion) values ('Desarrollador')
insert into Tipo_Usuario (Descripcion) values ('Comerciante')

select * from Tipo_Documento
insert into Tipo_Documento (Descripcion) values ('DNI')
insert into Tipo_Documento (Descripcion) values ('RUC')

delete from Usuario where ID_Usuario=12
delete from Usuario where ID_Usuario=13
delete from Usuario where ID_Usuario=14
delete from Usuario where ID_Usuario=16
delete from Usuario where ID_Usuario=17
delete from Usuario where ID_Usuario=18


select * from Venta