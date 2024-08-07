USE [master]
GO
/****** Object:  Database [sena_inventario]    Script Date: 7/11/2024 9:55:00 AM ******/
CREATE DATABASE [sena_inventario]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'sena_inventario', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\sena_inventario.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'sena_inventario_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\sena_inventario_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [sena_inventario] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sena_inventario].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sena_inventario] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sena_inventario] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sena_inventario] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sena_inventario] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sena_inventario] SET ARITHABORT OFF 
GO
ALTER DATABASE [sena_inventario] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [sena_inventario] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sena_inventario] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sena_inventario] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sena_inventario] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [sena_inventario] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sena_inventario] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sena_inventario] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sena_inventario] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sena_inventario] SET  DISABLE_BROKER 
GO
ALTER DATABASE [sena_inventario] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sena_inventario] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sena_inventario] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sena_inventario] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [sena_inventario] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sena_inventario] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [sena_inventario] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sena_inventario] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [sena_inventario] SET  MULTI_USER 
GO
ALTER DATABASE [sena_inventario] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [sena_inventario] SET DB_CHAINING OFF 
GO
ALTER DATABASE [sena_inventario] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [sena_inventario] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [sena_inventario] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [sena_inventario] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [sena_inventario] SET QUERY_STORE = ON
GO
ALTER DATABASE [sena_inventario] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [sena_inventario]
GO
/****** Object:  Table [dbo].[categorias]    Script Date: 7/11/2024 9:55:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categorias](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_categoria] [varchar](50) NULL,
 CONSTRAINT [PK_categorias] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[elementos]    Script Date: 7/11/2024 9:55:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[elementos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_elemento] [varchar](50) NULL,
	[id_categoria] [int] NULL,
	[id_persona_encargada] [int] NULL,
	[id_estado] [int] NULL,
	[cantidad] [int] NULL,
	[codigo_elemento] [varchar](50) NULL,
 CONSTRAINT [PK_elementos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estado_elementos]    Script Date: 7/11/2024 9:55:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estado_elementos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_estado_elemento] [varchar](50) NULL,
 CONSTRAINT [PK_estado_elementos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estado_elementos_prestamos]    Script Date: 7/11/2024 9:55:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estado_elementos_prestamos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_estado_elemento] [int] NULL,
	[id_prestamo] [int] NULL,
 CONSTRAINT [PK_estado_elementos_prestamos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estado_prestamos]    Script Date: 7/11/2024 9:55:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estado_prestamos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_estado_prestamo] [varchar](50) NULL,
 CONSTRAINT [PK_estado_prestamos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[foto_elementos]    Script Date: 7/11/2024 9:55:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[foto_elementos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ruta_imagen] [varchar](100) NULL,
	[id_elemento] [int] NULL,
 CONSTRAINT [PK_foto_elementos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personas]    Script Date: 7/11/2024 9:55:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[correo] [varchar](50) NULL,
	[numero_documento] [varchar](15) NULL,
 CONSTRAINT [PK_personas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prestamos]    Script Date: 7/11/2024 9:55:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prestamos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_persona_prestamo] [int] NULL,
	[fecha_hora_prestamo] [datetime] NOT NULL,
	[fecha_limite] [date] NULL,
	[id_elemento] [int] NULL,
	[id_estado_prestamo] [int] NULL,
	[id_funcionario_autorizacion] [int] NULL,
	[id_portero] [int] NULL,
 CONSTRAINT [PK_prestamos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 7/11/2024 9:55:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[id] [int] NOT NULL,
	[nombre_rol] [varchar](50) NOT NULL,
 CONSTRAINT [PK_roles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 7/11/2024 9:55:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_usuario] [varchar](50) NULL,
	[contrasena] [varchar](50) NULL,
	[ir_rol] [int] NULL,
	[id_persona] [int] NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[categorias] ON 

INSERT [dbo].[categorias] ([id], [nombre_categoria]) VALUES (1, N'Informatica')
INSERT [dbo].[categorias] ([id], [nombre_categoria]) VALUES (2, N'Agricultura')
INSERT [dbo].[categorias] ([id], [nombre_categoria]) VALUES (3, N'Herramientas')
SET IDENTITY_INSERT [dbo].[categorias] OFF
GO
SET IDENTITY_INSERT [dbo].[elementos] ON 

INSERT [dbo].[elementos] ([id], [nombre_elemento], [id_categoria], [id_persona_encargada], [id_estado], [cantidad], [codigo_elemento]) VALUES (3, N'portatil', 1, 2, 1, 5, N'123123')
INSERT [dbo].[elementos] ([id], [nombre_elemento], [id_categoria], [id_persona_encargada], [id_estado], [cantidad], [codigo_elemento]) VALUES (5, N'llave Inglesa', 3, 2, 1, 20, N'123321')
INSERT [dbo].[elementos] ([id], [nombre_elemento], [id_categoria], [id_persona_encargada], [id_estado], [cantidad], [codigo_elemento]) VALUES (6, N'Pala Honda', 2, 2, 1, 32, N'202020')
SET IDENTITY_INSERT [dbo].[elementos] OFF
GO
SET IDENTITY_INSERT [dbo].[estado_elementos] ON 

INSERT [dbo].[estado_elementos] ([id], [nombre_estado_elemento]) VALUES (1, N'bueno')
INSERT [dbo].[estado_elementos] ([id], [nombre_estado_elemento]) VALUES (2, N'malo')
SET IDENTITY_INSERT [dbo].[estado_elementos] OFF
GO
SET IDENTITY_INSERT [dbo].[estado_prestamos] ON 

INSERT [dbo].[estado_prestamos] ([id], [nombre_estado_prestamo]) VALUES (1, N'prestado')
INSERT [dbo].[estado_prestamos] ([id], [nombre_estado_prestamo]) VALUES (2, N'devuelto')
SET IDENTITY_INSERT [dbo].[estado_prestamos] OFF
GO
SET IDENTITY_INSERT [dbo].[personas] ON 

INSERT [dbo].[personas] ([id], [nombre], [apellido], [correo], [numero_documento]) VALUES (1, N'robin', N'jimenez', N'robindannjf@gmail.com', N'1123970378')
INSERT [dbo].[personas] ([id], [nombre], [apellido], [correo], [numero_documento]) VALUES (2, N'alexander', N'loperena', N'alelope@gmail.com', N'123123123')
INSERT [dbo].[personas] ([id], [nombre], [apellido], [correo], [numero_documento]) VALUES (3, N'jhair', N'tiller', N'nalganegra@gmail.com', N'1111111')
INSERT [dbo].[personas] ([id], [nombre], [apellido], [correo], [numero_documento]) VALUES (4, N'Leidi Esther', N'Lizcano Arroyo', N'leidifandefnf@gmail.com', N'0987654123')
INSERT [dbo].[personas] ([id], [nombre], [apellido], [correo], [numero_documento]) VALUES (5, N'linner', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[personas] OFF
GO
SET IDENTITY_INSERT [dbo].[prestamos] ON 

INSERT [dbo].[prestamos] ([id], [id_persona_prestamo], [fecha_hora_prestamo], [fecha_limite], [id_elemento], [id_estado_prestamo], [id_funcionario_autorizacion], [id_portero]) VALUES (3, 1, CAST(N'2024-07-10T09:54:22.400' AS DateTime), CAST(N'2024-10-11' AS Date), 3, 1, 2, 3)
INSERT [dbo].[prestamos] ([id], [id_persona_prestamo], [fecha_hora_prestamo], [fecha_limite], [id_elemento], [id_estado_prestamo], [id_funcionario_autorizacion], [id_portero]) VALUES (4, 1, CAST(N'2024-07-10T09:57:23.927' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[prestamos] ([id], [id_persona_prestamo], [fecha_hora_prestamo], [fecha_limite], [id_elemento], [id_estado_prestamo], [id_funcionario_autorizacion], [id_portero]) VALUES (5, 1, CAST(N'2024-07-10T09:57:37.433' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[prestamos] ([id], [id_persona_prestamo], [fecha_hora_prestamo], [fecha_limite], [id_elemento], [id_estado_prestamo], [id_funcionario_autorizacion], [id_portero]) VALUES (7, 1, CAST(N'2024-07-10T10:29:04.213' AS DateTime), CAST(N'2024-07-19' AS Date), 3, NULL, 2, 1)
INSERT [dbo].[prestamos] ([id], [id_persona_prestamo], [fecha_hora_prestamo], [fecha_limite], [id_elemento], [id_estado_prestamo], [id_funcionario_autorizacion], [id_portero]) VALUES (8, 4, CAST(N'2024-07-10T11:35:53.923' AS DateTime), CAST(N'2024-08-01' AS Date), 3, NULL, 2, 4)
INSERT [dbo].[prestamos] ([id], [id_persona_prestamo], [fecha_hora_prestamo], [fecha_limite], [id_elemento], [id_estado_prestamo], [id_funcionario_autorizacion], [id_portero]) VALUES (9, 2, CAST(N'2024-07-11T09:13:06.670' AS DateTime), CAST(N'2024-07-24' AS Date), 5, NULL, 2, 1)
SET IDENTITY_INSERT [dbo].[prestamos] OFF
GO
INSERT [dbo].[roles] ([id], [nombre_rol]) VALUES (1, N'Administrador')
INSERT [dbo].[roles] ([id], [nombre_rol]) VALUES (2, N'funcionario')
INSERT [dbo].[roles] ([id], [nombre_rol]) VALUES (3, N'portero')
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([id], [nombre_usuario], [contrasena], [ir_rol], [id_persona]) VALUES (2, N'dann', N'123', 1, 1)
INSERT [dbo].[usuarios] ([id], [nombre_usuario], [contrasena], [ir_rol], [id_persona]) VALUES (3, N'alelope', N'321', 2, 2)
INSERT [dbo].[usuarios] ([id], [nombre_usuario], [contrasena], [ir_rol], [id_persona]) VALUES (4, N'jair', N'000', 3, 3)
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
ALTER TABLE [dbo].[prestamos] ADD  CONSTRAINT [DF_prestamos_fecha_hora_prestamo]  DEFAULT (getdate()) FOR [fecha_hora_prestamo]
GO
ALTER TABLE [dbo].[elementos]  WITH CHECK ADD  CONSTRAINT [FK_elementos_categorias] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[categorias] ([id])
GO
ALTER TABLE [dbo].[elementos] CHECK CONSTRAINT [FK_elementos_categorias]
GO
ALTER TABLE [dbo].[elementos]  WITH CHECK ADD  CONSTRAINT [FK_elementos_estado_elementos] FOREIGN KEY([id_estado])
REFERENCES [dbo].[estado_elementos] ([id])
GO
ALTER TABLE [dbo].[elementos] CHECK CONSTRAINT [FK_elementos_estado_elementos]
GO
ALTER TABLE [dbo].[elementos]  WITH CHECK ADD  CONSTRAINT [FK_elementos_personas] FOREIGN KEY([id_persona_encargada])
REFERENCES [dbo].[personas] ([id])
GO
ALTER TABLE [dbo].[elementos] CHECK CONSTRAINT [FK_elementos_personas]
GO
ALTER TABLE [dbo].[estado_elementos_prestamos]  WITH CHECK ADD  CONSTRAINT [FK_estado_elementos_prestamos_estado_elementos] FOREIGN KEY([id_estado_elemento])
REFERENCES [dbo].[estado_elementos] ([id])
GO
ALTER TABLE [dbo].[estado_elementos_prestamos] CHECK CONSTRAINT [FK_estado_elementos_prestamos_estado_elementos]
GO
ALTER TABLE [dbo].[estado_elementos_prestamos]  WITH CHECK ADD  CONSTRAINT [FK_estado_elementos_prestamos_prestamos] FOREIGN KEY([id_prestamo])
REFERENCES [dbo].[prestamos] ([id])
GO
ALTER TABLE [dbo].[estado_elementos_prestamos] CHECK CONSTRAINT [FK_estado_elementos_prestamos_prestamos]
GO
ALTER TABLE [dbo].[foto_elementos]  WITH CHECK ADD  CONSTRAINT [FK_foto_elementos_elementos] FOREIGN KEY([id_elemento])
REFERENCES [dbo].[elementos] ([id])
GO
ALTER TABLE [dbo].[foto_elementos] CHECK CONSTRAINT [FK_foto_elementos_elementos]
GO
ALTER TABLE [dbo].[prestamos]  WITH CHECK ADD  CONSTRAINT [FK_prestamos_elementos] FOREIGN KEY([id_elemento])
REFERENCES [dbo].[elementos] ([id])
GO
ALTER TABLE [dbo].[prestamos] CHECK CONSTRAINT [FK_prestamos_elementos]
GO
ALTER TABLE [dbo].[prestamos]  WITH CHECK ADD  CONSTRAINT [FK_prestamos_estado_prestamos] FOREIGN KEY([id_estado_prestamo])
REFERENCES [dbo].[estado_prestamos] ([id])
GO
ALTER TABLE [dbo].[prestamos] CHECK CONSTRAINT [FK_prestamos_estado_prestamos]
GO
ALTER TABLE [dbo].[prestamos]  WITH CHECK ADD  CONSTRAINT [FK_prestamos_personas] FOREIGN KEY([id_persona_prestamo])
REFERENCES [dbo].[personas] ([id])
GO
ALTER TABLE [dbo].[prestamos] CHECK CONSTRAINT [FK_prestamos_personas]
GO
ALTER TABLE [dbo].[prestamos]  WITH CHECK ADD  CONSTRAINT [FK_prestamos_personas1] FOREIGN KEY([id_portero])
REFERENCES [dbo].[personas] ([id])
GO
ALTER TABLE [dbo].[prestamos] CHECK CONSTRAINT [FK_prestamos_personas1]
GO
ALTER TABLE [dbo].[prestamos]  WITH CHECK ADD  CONSTRAINT [FK_prestamos_personas2] FOREIGN KEY([id_funcionario_autorizacion])
REFERENCES [dbo].[personas] ([id])
GO
ALTER TABLE [dbo].[prestamos] CHECK CONSTRAINT [FK_prestamos_personas2]
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_personas] FOREIGN KEY([id_persona])
REFERENCES [dbo].[personas] ([id])
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [FK_usuarios_personas]
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_roles] FOREIGN KEY([ir_rol])
REFERENCES [dbo].[roles] ([id])
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [FK_usuarios_roles]
GO
USE [master]
GO
ALTER DATABASE [sena_inventario] SET  READ_WRITE 
GO
