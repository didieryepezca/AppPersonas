USE [master]
GO
/****** Object:  Database [PersonasApplication]    Script Date: 8/11/2021 14:44:41 ******/
CREATE DATABASE [PersonasApplication]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PersonasApplication', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PersonasApplication.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PersonasApplication_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PersonasApplication_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PersonasApplication] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PersonasApplication].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PersonasApplication] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PersonasApplication] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PersonasApplication] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PersonasApplication] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PersonasApplication] SET ARITHABORT OFF 
GO
ALTER DATABASE [PersonasApplication] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PersonasApplication] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PersonasApplication] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PersonasApplication] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PersonasApplication] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PersonasApplication] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PersonasApplication] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PersonasApplication] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PersonasApplication] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PersonasApplication] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PersonasApplication] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PersonasApplication] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PersonasApplication] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PersonasApplication] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PersonasApplication] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PersonasApplication] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PersonasApplication] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PersonasApplication] SET RECOVERY FULL 
GO
ALTER DATABASE [PersonasApplication] SET  MULTI_USER 
GO
ALTER DATABASE [PersonasApplication] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PersonasApplication] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PersonasApplication] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PersonasApplication] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PersonasApplication] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PersonasApplication] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PersonasApplication', N'ON'
GO
ALTER DATABASE [PersonasApplication] SET QUERY_STORE = OFF
GO
USE [PersonasApplication]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 8/11/2021 14:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](50) NOT NULL,
	[APELLIDO] [varchar](50) NOT NULL,
	[DOCUMENTO] [varchar](12) NOT NULL,
	[TIPO_DOCUMENTO] [varchar](20) NULL,
	[ESTADO] [varchar](20) NULL,
	[EDAD] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Personas] ON 

INSERT [dbo].[Personas] ([ID], [NOMBRE], [APELLIDO], [DOCUMENTO], [TIPO_DOCUMENTO], [ESTADO], [EDAD]) VALUES (1, N'DIDIER', N'YÉPEZ CABANILLAS', N'71889573', N'BREVETE', N'ACTIVO', 29)
INSERT [dbo].[Personas] ([ID], [NOMBRE], [APELLIDO], [DOCUMENTO], [TIPO_DOCUMENTO], [ESTADO], [EDAD]) VALUES (2, N'BRAYAN', N'INTO CORREA', N'70879077', N'BREVETE', N'ACTIVO', 28)
INSERT [dbo].[Personas] ([ID], [NOMBRE], [APELLIDO], [DOCUMENTO], [TIPO_DOCUMENTO], [ESTADO], [EDAD]) VALUES (3, N'CARLOS', N'MORILLAS ALTAMIRANO', N'74562123', N'DNI', N'ACTIVO', 30)
INSERT [dbo].[Personas] ([ID], [NOMBRE], [APELLIDO], [DOCUMENTO], [TIPO_DOCUMENTO], [ESTADO], [EDAD]) VALUES (6, N'DANIEL', N'SANCHEZ', N'70563214', N'DNI', N'ACTIVO', 26)
INSERT [dbo].[Personas] ([ID], [NOMBRE], [APELLIDO], [DOCUMENTO], [TIPO_DOCUMENTO], [ESTADO], [EDAD]) VALUES (7, N'ANA FIORELA', N'DIAZ DIAZ', N'75857412', N'DNI', N'INACTIVO', 29)
INSERT [dbo].[Personas] ([ID], [NOMBRE], [APELLIDO], [DOCUMENTO], [TIPO_DOCUMENTO], [ESTADO], [EDAD]) VALUES (8, N'ANTONELLA', N'FLORES', N'75758454', N'DNI', N'ACTIVO', 26)
INSERT [dbo].[Personas] ([ID], [NOMBRE], [APELLIDO], [DOCUMENTO], [TIPO_DOCUMENTO], [ESTADO], [EDAD]) VALUES (9, N'CARLOS', N'REYES', N'718548755', N'DNI', N'ACTIVO', 29)
INSERT [dbo].[Personas] ([ID], [NOMBRE], [APELLIDO], [DOCUMENTO], [TIPO_DOCUMENTO], [ESTADO], [EDAD]) VALUES (11, N'MARIA JOSE', N'ROJAS GUERRA', N'74548548', N'PASAPORTE', N'ACTIVO', 42)
INSERT [dbo].[Personas] ([ID], [NOMBRE], [APELLIDO], [DOCUMENTO], [TIPO_DOCUMENTO], [ESTADO], [EDAD]) VALUES (12, N'PEDRO', N'MENDOZA', N'75825412', N'BREVETE', N'ACTIVO', 31)
INSERT [dbo].[Personas] ([ID], [NOMBRE], [APELLIDO], [DOCUMENTO], [TIPO_DOCUMENTO], [ESTADO], [EDAD]) VALUES (13, N'DJALMA', N'RUIZ', N'28954574', N'PASAPORTE', N'INACTIVO', 41)
INSERT [dbo].[Personas] ([ID], [NOMBRE], [APELLIDO], [DOCUMENTO], [TIPO_DOCUMENTO], [ESTADO], [EDAD]) VALUES (15, N'RENZO FABIO', N'MONTOYA ALVAREZ', N'27589654', N'PASAPORTE', N'INACTIVO', 51)
INSERT [dbo].[Personas] ([ID], [NOMBRE], [APELLIDO], [DOCUMENTO], [TIPO_DOCUMENTO], [ESTADO], [EDAD]) VALUES (16, N'JUAN MANUEL', N'FERNANDEZ ARANA', N'75854121', N'DNI', N'INACTIVO', 35)
INSERT [dbo].[Personas] ([ID], [NOMBRE], [APELLIDO], [DOCUMENTO], [TIPO_DOCUMENTO], [ESTADO], [EDAD]) VALUES (17, N'JOSSEP', N'PEREZ', N'758457451', N'DNI', N'ACTIVO', 27)
INSERT [dbo].[Personas] ([ID], [NOMBRE], [APELLIDO], [DOCUMENTO], [TIPO_DOCUMENTO], [ESTADO], [EDAD]) VALUES (19, N'JOSSEP JOHN', N'PEÑA', N'75948231', N'DNI', N'ACTIVO', 28)
INSERT [dbo].[Personas] ([ID], [NOMBRE], [APELLIDO], [DOCUMENTO], [TIPO_DOCUMENTO], [ESTADO], [EDAD]) VALUES (20, N'FLOR DE MARIA', N'QUINTANA', N'76845216', N'DNI', N'ACTIVO', 31)
INSERT [dbo].[Personas] ([ID], [NOMBRE], [APELLIDO], [DOCUMENTO], [TIPO_DOCUMENTO], [ESTADO], [EDAD]) VALUES (21, N'ALEX', N'SANCHEZ', N'79525414', N'DNI', N'ACTIVO', 27)
SET IDENTITY_INSERT [dbo].[Personas] OFF
GO
/****** Object:  StoredProcedure [dbo].[Sp_Count_DocumentType_GroupBy]    Script Date: 8/11/2021 14:44:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Didier Yepez
-- Create date: 16/10/2021
-- Description:	Obtener Cantidad de Personas Por Tipo de Documento
-- =============================================
CREATE PROCEDURE [dbo].[Sp_Count_DocumentType_GroupBy]
AS
BEGIN


SELECT COUNT(TIPO_DOCUMENTO) CANTIDAD_PERSONAS, TIPO_DOCUMENTO 
FROM Personas
GROUP BY TIPO_DOCUMENTO



END
GO
USE [master]
GO
ALTER DATABASE [PersonasApplication] SET  READ_WRITE 
GO
