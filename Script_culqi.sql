USE [culqi_db]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 3/07/2020 10:56:54 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[ID_Giro_Neg] [int] IDENTITY(1,1) NOT NULL,
	[Giro_n] [varchar](25) NOT NULL,
 CONSTRAINT [PK__Categori__04E7C70A1DD98E2A] PRIMARY KEY CLUSTERED 
(
	[ID_Giro_Neg] ASC
)
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comercio]    Script Date: 3/07/2020 10:56:54 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comercio](
	[Llave_Publica] [varchar](30) NOT NULL,
	[ID_Usuario] [int] NULL,
	[ID_Giro_Negn] [int] NULL,
	[Nombre_Comercio] [varchar](25) NOT NULL,
	[URL_Comercio] [varchar](100) NULL,
	[celular] [int] NOT NULL,
	[Pais] [varchar](20) NOT NULL,
	[Terminos_condiicones] [varchar](10) NOT NULL,
	[Rubro] [varchar](25) NOT NULL,
	[ID_Comercio] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Comercio] PRIMARY KEY CLUSTERED 
(
	[ID_Comercio] ASC
)
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cuenta]    Script Date: 3/07/2020 10:56:54 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuenta](
	[ID_Cuenta] [int] IDENTITY(1,1) NOT NULL,
	[ID_Marca] [int] NOT NULL,
	[Tipo_Moneda] [varchar](10) NOT NULL,
	[ID_Usuario] [int] NULL,
	[Numero_cuenta] [varchar](22) NOT NULL,
 CONSTRAINT [PK__Cuenta__820D611F19BB217F] PRIMARY KEY CLUSTERED 
(
	[ID_Cuenta] ASC
)
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deposito]    Script Date: 3/07/2020 10:56:54 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deposito](
	[ID_Deposito] [int] IDENTITY(1,1) NOT NULL,
	[Monto] [float] NULL,
	[Fecha] [date] NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK__Deposito__5C5B848E8B2B65BA] PRIMARY KEY CLUSTERED 
(
	[ID_Deposito] ASC
)
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Deposito]    Script Date: 3/07/2020 10:56:54 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Deposito](
	[ID_Deposito] [int] NOT NULL,
	[N_Operacion] [int] NULL,
	[Fecha_Desposito] [datetime] NULL,
	[Concepto] [varchar](15) NULL,
	[Monto] [float] NULL,
	[Comision] [float] NULL,
	[Monto_Depo] [float] NULL,
	[ID_Detalle_Deposito] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_Oper] [datetime] NULL,
 CONSTRAINT [PK_Detalle_Deposito] PRIMARY KEY CLUSTERED 
(
	[ID_Detalle_Deposito] ASC
)
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Venta]    Script Date: 3/07/2020 10:56:54 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Venta](
	[ID_Venta] [int] NOT NULL,
	[fecha_hora] [datetime] NULL,
	[Descripcion] [varchar](30) NULL,
	[correo_electronico] [varchar](30) NOT NULL,
	[Nombres] [varchar](30) NULL,
	[Apellidos] [varchar](30) NULL,
	[Pais] [varchar](25) NULL,
	[Ciudad] [varchar](25) NULL,
	[ID_Detalle_Venta] [int] IDENTITY(1,1) NOT NULL,
	[Dirección] [varchar](30) NULL,
 CONSTRAINT [PK_Detalle_Venta] PRIMARY KEY CLUSTERED 
(
	[ID_Detalle_Venta] ASC
)
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Efectivo]    Script Date: 3/07/2020 10:56:54 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Efectivo](
	[ID_referencia] [int] IDENTITY(1,1) NOT NULL,
	[Ent_financiera] [varchar](20) NOT NULL,
	[Monto] [int] NOT NULL,
 CONSTRAINT [PK__Efectivo__E22935F72AD6FB8C] PRIMARY KEY CLUSTERED 
(
	[ID_referencia] ASC
)
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 3/07/2020 10:56:54 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marca](
	[ID_Marca] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](15) NOT NULL,
	[Tipo_marca] [varchar](15) NOT NULL,
 CONSTRAINT [PK__Marca__9B8F8DB26106912F] PRIMARY KEY CLUSTERED 
(
	[ID_Marca] ASC
)
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tarjeta]    Script Date: 3/07/2020 10:56:54 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tarjeta](
	[ID_Tarjeta] [int] IDENTITY(1,1) NOT NULL,
	[ID_Marca] [int] NULL,
	[Num_tarjeta] [int] NOT NULL,
	[CVV] [int] NOT NULL,
	[fec_tarjeta] [datetime] NOT NULL,
 CONSTRAINT [PK__tarjeta__ECA5F952FCC4921C] PRIMARY KEY CLUSTERED 
(
	[ID_Tarjeta] ASC
)
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Documento]    Script Date: 3/07/2020 10:56:54 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Documento](
	[ID_Tipo_Doc] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](15) NOT NULL,
 CONSTRAINT [PK__Tipo_Doc__DDF3983029C0CFC0] PRIMARY KEY CLUSTERED 
(
	[ID_Tipo_Doc] ASC
)
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Usuario]    Script Date: 3/07/2020 10:56:54 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Usuario](
	[ID_Tipo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Tipo_Usu__D34E6619FB4C4579] PRIMARY KEY CLUSTERED 
(
	[ID_Tipo] ASC
)
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 3/07/2020 10:56:54 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[ID_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[ID_Tipo] [int] NOT NULL,
	[ID_Tipo_Doc] [int] NOT NULL,
	[Nombres] [varchar](30) NOT NULL,
	[Correo] [varchar](30) NOT NULL,
	[Contrasenia] [varchar](25) NOT NULL,
 CONSTRAINT [PK__Usuario__DE4431C5A3E1A4D4] PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC
)
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 3/07/2020 10:56:54 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[ID_Venta] [int] IDENTITY(1,1) NOT NULL,
	[ID_Comercio] [int] NOT NULL,
	[ID_referencia] [int] NOT NULL,
	[ID_Tarjeta] [int] NOT NULL,
	[ID_Deposito] [int] NOT NULL,
	[Nombre_Comercio] [varchar](25) NULL,
	[Monto] [float] NULL,
	[Correo] [varchar](30) NULL,
	[Estado] [varchar](20) NULL,
	[Fecha_Hora] [datetime] NULL,
 CONSTRAINT [PK__Venta__3CD842E5178DD63B] PRIMARY KEY CLUSTERED 
(
	[ID_Venta] ASC
)
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Comercio]  WITH CHECK ADD  CONSTRAINT [FK__Comercio__ID_Gir__3B75D760] FOREIGN KEY([ID_Giro_Negn])
REFERENCES [dbo].[Categoria] ([ID_Giro_Neg])
GO
ALTER TABLE [dbo].[Comercio] CHECK CONSTRAINT [FK__Comercio__ID_Gir__3B75D760]
GO
ALTER TABLE [dbo].[Comercio]  WITH CHECK ADD  CONSTRAINT [FK__Comercio__ID_Usu__3A81B327] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[Usuario] ([ID_Usuario])
GO
ALTER TABLE [dbo].[Comercio] CHECK CONSTRAINT [FK__Comercio__ID_Usu__3A81B327]
GO
ALTER TABLE [dbo].[Cuenta]  WITH CHECK ADD  CONSTRAINT [FK__Cuenta__ID_Marca__300424B4] FOREIGN KEY([ID_Marca])
REFERENCES [dbo].[Marca] ([ID_Marca])
GO
ALTER TABLE [dbo].[Cuenta] CHECK CONSTRAINT [FK__Cuenta__ID_Marca__300424B4]
GO
ALTER TABLE [dbo].[Cuenta]  WITH CHECK ADD  CONSTRAINT [FK_Cuenta_Usuario] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[Usuario] ([ID_Usuario])
GO
ALTER TABLE [dbo].[Cuenta] CHECK CONSTRAINT [FK_Cuenta_Usuario]
GO
ALTER TABLE [dbo].[Detalle_Deposito]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Deposito_Deposito] FOREIGN KEY([ID_Deposito])
REFERENCES [dbo].[Deposito] ([ID_Deposito])
GO
ALTER TABLE [dbo].[Detalle_Deposito] CHECK CONSTRAINT [FK_Detalle_Deposito_Deposito]
GO
ALTER TABLE [dbo].[Detalle_Venta]  WITH CHECK ADD  CONSTRAINT [FK__Detalle_V__ID_Ve__4316F928] FOREIGN KEY([ID_Venta])
REFERENCES [dbo].[Venta] ([ID_Venta])
GO
ALTER TABLE [dbo].[Detalle_Venta] CHECK CONSTRAINT [FK__Detalle_V__ID_Ve__4316F928]
GO
ALTER TABLE [dbo].[tarjeta]  WITH CHECK ADD  CONSTRAINT [FK__tarjeta__ID_Marc__37A5467C] FOREIGN KEY([ID_Marca])
REFERENCES [dbo].[Marca] ([ID_Marca])
GO
ALTER TABLE [dbo].[tarjeta] CHECK CONSTRAINT [FK__tarjeta__ID_Marc__37A5467C]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__ID_Tipo__32E0915F] FOREIGN KEY([ID_Tipo])
REFERENCES [dbo].[Tipo_Usuario] ([ID_Tipo])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK__Usuario__ID_Tipo__32E0915F]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__ID_Tipo__33D4B598] FOREIGN KEY([ID_Tipo_Doc])
REFERENCES [dbo].[Tipo_Documento] ([ID_Tipo_Doc])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK__Usuario__ID_Tipo__33D4B598]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK__Venta__ID_Deposi__412EB0B6] FOREIGN KEY([ID_Deposito])
REFERENCES [dbo].[Deposito] ([ID_Deposito])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK__Venta__ID_Deposi__412EB0B6]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK__Venta__ID_refere__3F466844] FOREIGN KEY([ID_referencia])
REFERENCES [dbo].[Efectivo] ([ID_referencia])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK__Venta__ID_refere__3F466844]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK__Venta__ID_Tarjet__403A8C7D] FOREIGN KEY([ID_Tarjeta])
REFERENCES [dbo].[tarjeta] ([ID_Tarjeta])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK__Venta__ID_Tarjet__403A8C7D]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Comercio] FOREIGN KEY([ID_Comercio])
REFERENCES [dbo].[Comercio] ([ID_Comercio])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Comercio]
GO