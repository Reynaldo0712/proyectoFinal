USE [master]
GO
/****** Object:  Database [ProyectoFinal]    Script Date: 4/9/2020 12:16:30 PM ******/
CREATE DATABASE [ProyectoFinal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProyectoFinal', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ProyectoFinal.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProyectoFinal_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ProyectoFinal_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ProyectoFinal] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProyectoFinal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProyectoFinal] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProyectoFinal] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProyectoFinal] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProyectoFinal] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProyectoFinal] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProyectoFinal] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProyectoFinal] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProyectoFinal] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProyectoFinal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProyectoFinal] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProyectoFinal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProyectoFinal] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProyectoFinal] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProyectoFinal] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProyectoFinal] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProyectoFinal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProyectoFinal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProyectoFinal] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProyectoFinal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProyectoFinal] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProyectoFinal] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProyectoFinal] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProyectoFinal] SET RECOVERY FULL 
GO
ALTER DATABASE [ProyectoFinal] SET  MULTI_USER 
GO
ALTER DATABASE [ProyectoFinal] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProyectoFinal] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProyectoFinal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProyectoFinal] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProyectoFinal] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProyectoFinal', N'ON'
GO
ALTER DATABASE [ProyectoFinal] SET QUERY_STORE = OFF
GO
USE [ProyectoFinal]
GO
/****** Object:  Table [dbo].[AltaMedica1]    Script Date: 4/9/2020 12:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AltaMedica1](
	[Id] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Numero] [int] NULL,
	[fecha_Salida] [date] NOT NULL,
	[total] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Citas]    Script Date: 4/9/2020 12:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citas](
	[Fecha] [date] NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Doctor] [varchar](20) NOT NULL,
	[Hora] [varchar](20) NOT NULL,
	[ID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctores]    Script Date: 4/9/2020 12:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctores](
	[Id] [int] NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Exequatur] [varchar](20) NOT NULL,
	[Especialidad] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Doctores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Habitaciones]    Script Date: 4/9/2020 12:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Habitaciones](
	[Id] [int] NOT NULL,
	[Numero] [int] NOT NULL,
	[Tipo] [varchar](20) NOT NULL,
	[Precio] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingresos]    Script Date: 4/9/2020 12:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingresos](
	[Fecha] [date] NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Numero] [int] NOT NULL,
	[Id_Ingreso] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 4/9/2020 12:16:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[Id] [int] NOT NULL,
	[Cedula] [varchar](20) NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Asegurado] [varchar](2) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[AltaMedica1] ([Id], [fecha], [Nombre], [Numero], [fecha_Salida], [total]) VALUES (15, CAST(N'2020-04-04' AS Date), N'Alanna', 57, CAST(N'2020-04-10' AS Date), 4200)
GO
INSERT [dbo].[Citas] ([Fecha], [Nombre], [Doctor], [Hora], [ID]) VALUES (CAST(N'2020-04-04' AS Date), N'jose', N'kevin', N'10:25 pm', 10)
GO
INSERT [dbo].[Citas] ([Fecha], [Nombre], [Doctor], [Hora], [ID]) VALUES (CAST(N'2020-04-09' AS Date), N'Jose', N'Reynaldo', N'10:25 Pm', 1)
GO
INSERT [dbo].[Doctores] ([Id], [Nombre], [Exequatur], [Especialidad]) VALUES (1, N'Jose', N'500500', N'Cirujano')
GO
INSERT [dbo].[Doctores] ([Id], [Nombre], [Exequatur], [Especialidad]) VALUES (5, N'Kevin', N'600500', N'Cirijuno')
GO
INSERT [dbo].[Doctores] ([Id], [Nombre], [Exequatur], [Especialidad]) VALUES (10, N'Alanna', N'60006000', N'Pediatra')
GO
INSERT [dbo].[Doctores] ([Id], [Nombre], [Exequatur], [Especialidad]) VALUES (400, N'Alanna', N'600600', N'pediatra')
GO
INSERT [dbo].[Doctores] ([Id], [Nombre], [Exequatur], [Especialidad]) VALUES (50015336, N'Jose', N'600600', N'Cirujano')
GO
INSERT [dbo].[Habitaciones] ([Id], [Numero], [Tipo], [Precio]) VALUES (501, 45, N'Privada', 500)
GO
INSERT [dbo].[Habitaciones] ([Id], [Numero], [Tipo], [Precio]) VALUES (5002, 57, N'Privada', 5000)
GO
INSERT [dbo].[Habitaciones] ([Id], [Numero], [Tipo], [Precio]) VALUES (2, 57, N'Suite', 700)
GO
INSERT [dbo].[Ingresos] ([Fecha], [Nombre], [Numero], [Id_Ingreso]) VALUES (CAST(N'2020-04-04' AS Date), N'Alanna', 57, 15)
GO
INSERT [dbo].[Pacientes] ([Id], [Cedula], [Nombre], [Asegurado]) VALUES (10, N'505', N'Jose', N'Si')
GO
INSERT [dbo].[Pacientes] ([Id], [Cedula], [Nombre], [Asegurado]) VALUES (50015333, N'40226291314', N'Ciprina', N'No')
GO
INSERT [dbo].[Pacientes] ([Id], [Cedula], [Nombre], [Asegurado]) VALUES (500, N'455555', N'Alanna', N'No')
GO
INSERT [dbo].[Pacientes] ([Id], [Cedula], [Nombre], [Asegurado]) VALUES (454, N'88888', N'Alanna', N'Si')
GO
USE [master]
GO
ALTER DATABASE [ProyectoFinal] SET  READ_WRITE 
GO
