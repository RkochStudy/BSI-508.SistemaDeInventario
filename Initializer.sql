GO
ALTER DATABASE [Inventario] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Inventario] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Inventario] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Inventario] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Inventario] SET ARITHABORT OFF 
GO
ALTER DATABASE [Inventario] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Inventario] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Inventario] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Inventario] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Inventario] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Inventario] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Inventario] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Inventario] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Inventario] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Inventario] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Inventario] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Inventario] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Inventario] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Inventario] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Inventario] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Inventario] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Inventario] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Inventario] SET RECOVERY FULL 
GO
ALTER DATABASE [Inventario] SET  MULTI_USER 
GO
ALTER DATABASE [Inventario] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Inventario] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Inventario] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Inventario] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Inventario] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Inventario', N'ON'
GO
USE [Inventario]
GO
/****** Object:  Table [dbo].[Activo]    Script Date: 04/08/2016 1:56:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Activo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NumeroSerie] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
	[Marca] [varchar](50) NULL,
	[Descripcion] [varchar](400) NULL,
	[Cantidad] [int] NULL,
	[Tipo] [varchar](50) NULL,
	[Departamento] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 04/08/2016 1:56:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departamento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](45) NULL,
	[Encargado] [int] NOT NULL,
	[Subencargado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Opciones]    Script Date: 04/08/2016 1:56:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Opciones](
	[OpcionesID] [int] NULL,
	[Idioma] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Prestamo]    Script Date: 04/08/2016 1:56:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Prestamo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Activo] [varchar](50) NULL,
	[DepartamentoOrigen] [int] NOT NULL,
	[DepartamentoPrestamo] [int] NOT NULL,
	[Cantidad] [int] NULL,
	[FechaRetorno] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Registro]    Script Date: 04/08/2016 1:56:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registro](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Accion] [nchar](100) NULL,
	[Fecha] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sistema]    Script Date: 04/08/2016 1:56:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sistema](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NULL,
	[Rol] [int] NULL,
 CONSTRAINT [PK_Sistema] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 04/08/2016 1:56:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](45) NULL,
	[Contrasena] [varchar](45) NULL,
	[Correo] [varchar](45) NULL,
	[Nombre] [varchar](45) NULL,
	[Edad] [int] NULL,
	[Rol] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Activo]  WITH CHECK ADD  CONSTRAINT [FK_Activo_Departamento] FOREIGN KEY([Departamento])
REFERENCES [dbo].[Departamento] ([Id])
GO
ALTER TABLE [dbo].[Activo] CHECK CONSTRAINT [FK_Activo_Departamento]
GO
ALTER TABLE [dbo].[Departamento]  WITH CHECK ADD  CONSTRAINT [fk_Departamento_Usuarios1] FOREIGN KEY([Encargado])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Departamento] CHECK CONSTRAINT [fk_Departamento_Usuarios1]
GO
ALTER TABLE [dbo].[Departamento]  WITH CHECK ADD  CONSTRAINT [fk_Departamento_Usuarios2] FOREIGN KEY([Subencargado])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Departamento] CHECK CONSTRAINT [fk_Departamento_Usuarios2]
GO
ALTER TABLE [dbo].[Prestamo]  WITH CHECK ADD  CONSTRAINT [FK_Prestamo_DepartamentoO] FOREIGN KEY([DepartamentoOrigen])
REFERENCES [dbo].[Departamento] ([Id])
GO
ALTER TABLE [dbo].[Prestamo] CHECK CONSTRAINT [FK_Prestamo_DepartamentoO]
GO
ALTER TABLE [dbo].[Prestamo]  WITH CHECK ADD  CONSTRAINT [FK_Prestamo_DepartamentoP] FOREIGN KEY([DepartamentoPrestamo])
REFERENCES [dbo].[Departamento] ([Id])
GO
ALTER TABLE [dbo].[Prestamo] CHECK CONSTRAINT [FK_Prestamo_DepartamentoP]
GO
USE [master]
GO
ALTER DATABASE [Inventario] SET  READ_WRITE 
GO
