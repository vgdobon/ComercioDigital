USE [master]
GO
/****** Object:  Database [eCommerce]    Script Date: 11/02/2021 0:11:03 ******/
CREATE DATABASE [eCommerce]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'eCommerce', FILENAME = N'I:\SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\eCommerce.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'eCommerce_log', FILENAME = N'I:\SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\eCommerce_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [eCommerce] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [eCommerce].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [eCommerce] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [eCommerce] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [eCommerce] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [eCommerce] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [eCommerce] SET ARITHABORT OFF 
GO
ALTER DATABASE [eCommerce] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [eCommerce] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [eCommerce] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [eCommerce] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [eCommerce] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [eCommerce] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [eCommerce] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [eCommerce] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [eCommerce] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [eCommerce] SET  DISABLE_BROKER 
GO
ALTER DATABASE [eCommerce] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [eCommerce] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [eCommerce] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [eCommerce] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [eCommerce] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [eCommerce] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [eCommerce] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [eCommerce] SET RECOVERY FULL 
GO
ALTER DATABASE [eCommerce] SET  MULTI_USER 
GO
ALTER DATABASE [eCommerce] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [eCommerce] SET DB_CHAINING OFF 
GO
ALTER DATABASE [eCommerce] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [eCommerce] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [eCommerce] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [eCommerce] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'eCommerce', N'ON'
GO
ALTER DATABASE [eCommerce] SET QUERY_STORE = OFF
GO
USE [eCommerce]
GO
/****** Object:  Table [dbo].[Bolsos]    Script Date: 11/02/2021 0:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bolsos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdModa] [int] NOT NULL,
	[Tipo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Bolsos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Calzados]    Script Date: 11/02/2021 0:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calzados](
	[Id] [int] NOT NULL,
	[IdModa] [int] NULL,
	[Talla] [int] NULL,
	[Tipo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Calzados] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarritoProductos]    Script Date: 11/02/2021 0:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarritoProductos](
	[IdCarrito] [int] NOT NULL,
	[IdProducto] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carritos]    Script Date: 11/02/2021 0:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carritos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Carritos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Joyas]    Script Date: 11/02/2021 0:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Joyas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdModa] [int] NOT NULL,
	[Medida] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Joyas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modas]    Script Date: 11/02/2021 0:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProducto] [int] NULL,
	[Color] [nvarchar](50) NOT NULL,
	[Material] [nvarchar](50) NOT NULL,
	[Sexo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Moda] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Moviles]    Script Date: 11/02/2021 0:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Moviles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdTecnologia] [int] NULL,
	[Pantalla] [float] NULL,
	[Bateria] [int] NULL,
 CONSTRAINT [PK_Moviles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Multimedias]    Script Date: 11/02/2021 0:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Multimedias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProducto] [int] NULL,
	[Genero] [nvarchar](50) NOT NULL,
	[Formato] [nvarchar](50) NOT NULL,
	[Idioma] [nvarchar](50) NOT NULL,
	[FechaLanzamiento] [date] NOT NULL,
 CONSTRAINT [PK_Multimedias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musicas]    Script Date: 11/02/2021 0:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musicas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdMultimedia] [int] NULL,
	[Artista] [nvarchar](50) NULL,
 CONSTRAINT [PK_Musicas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordenadores]    Script Date: 11/02/2021 0:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordenadores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdTecnologia] [int] NOT NULL,
	[PlacaBase] [nvarchar](50) NOT NULL,
	[Tipo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Ordenadores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Peliculas]    Script Date: 11/02/2021 0:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Peliculas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdMultimedia] [int] NOT NULL,
	[Actores] [nvarchar](150) NOT NULL,
	[Director] [nvarchar](150) NOT NULL,
	[EdadRecomendada] [int] NOT NULL,
	[Sinopsis] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Peliculas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 11/02/2021 0:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Precio] [float] NOT NULL,
	[Marca] [nvarchar](50) NOT NULL,
	[IdVendedor] [int] NOT NULL,
	[Descripcion] [nvarchar](150) NOT NULL,
	[Valoracion] [int] NULL,
	[FechaPuestaVenta] [date] NOT NULL,
	[CodigoDescuento] [nvarchar](10) NOT NULL,
	[Stock] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ropas]    Script Date: 11/02/2021 0:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ropas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdModa] [int] NULL,
	[Talla] [nvarchar](50) NOT NULL,
	[Tipo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Ropas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tecnologicos]    Script Date: 11/02/2021 0:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tecnologicos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Color] [nvarchar](50) NOT NULL,
	[Procesador] [nvarchar](50) NOT NULL,
	[SistemaOperativo] [nvarchar](50) NOT NULL,
	[Modelo] [nvarchar](50) NOT NULL,
	[FechaLanzamiento] [date] NOT NULL,
 CONSTRAINT [PK_Tecnologicos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/02/2021 0:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](50) NOT NULL,
	[Domicilio] [nvarchar](50) NOT NULL,
	[Saldo] [float] NOT NULL,
	[IdCarrito] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vendedores]    Script Date: 11/02/2021 0:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendedores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[Contrasenna] [nvarchar](50) NOT NULL,
	[Valoracion] [int] NOT NULL,
 CONSTRAINT [PK_Vendedores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Videoconsolas]    Script Date: 11/02/2021 0:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Videoconsolas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdTecnologia] [int] NOT NULL,
 CONSTRAINT [PK_Videoconsolas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Videojuegos]    Script Date: 11/02/2021 0:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Videojuegos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdMultimedia] [int] NOT NULL,
	[Plataforma] [nvarchar](50) NOT NULL,
	[EdadRecomendada] [int] NOT NULL,
 CONSTRAINT [PK_Videojuegos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bolsos]  WITH CHECK ADD  CONSTRAINT [FK_Bolsos_Moda] FOREIGN KEY([IdModa])
REFERENCES [dbo].[Modas] ([Id])
GO
ALTER TABLE [dbo].[Bolsos] CHECK CONSTRAINT [FK_Bolsos_Moda]
GO
ALTER TABLE [dbo].[Calzados]  WITH CHECK ADD  CONSTRAINT [FK_Calzados_Modas] FOREIGN KEY([IdModa])
REFERENCES [dbo].[Modas] ([Id])
GO
ALTER TABLE [dbo].[Calzados] CHECK CONSTRAINT [FK_Calzados_Modas]
GO
ALTER TABLE [dbo].[CarritoProductos]  WITH CHECK ADD  CONSTRAINT [FK_CarritoProductos_Carritos] FOREIGN KEY([IdCarrito])
REFERENCES [dbo].[Carritos] ([Id])
GO
ALTER TABLE [dbo].[CarritoProductos] CHECK CONSTRAINT [FK_CarritoProductos_Carritos]
GO
ALTER TABLE [dbo].[Joyas]  WITH CHECK ADD  CONSTRAINT [FK_Joyas_Modas] FOREIGN KEY([IdModa])
REFERENCES [dbo].[Modas] ([Id])
GO
ALTER TABLE [dbo].[Joyas] CHECK CONSTRAINT [FK_Joyas_Modas]
GO
ALTER TABLE [dbo].[Modas]  WITH CHECK ADD  CONSTRAINT [FK_Moda_Productos] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([Id])
GO
ALTER TABLE [dbo].[Modas] CHECK CONSTRAINT [FK_Moda_Productos]
GO
ALTER TABLE [dbo].[Moviles]  WITH CHECK ADD  CONSTRAINT [FK_Moviles_Tecnologicos] FOREIGN KEY([IdTecnologia])
REFERENCES [dbo].[Tecnologicos] ([Id])
GO
ALTER TABLE [dbo].[Moviles] CHECK CONSTRAINT [FK_Moviles_Tecnologicos]
GO
ALTER TABLE [dbo].[Multimedias]  WITH CHECK ADD  CONSTRAINT [FK_Multimedias_Productos] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([Id])
GO
ALTER TABLE [dbo].[Multimedias] CHECK CONSTRAINT [FK_Multimedias_Productos]
GO
ALTER TABLE [dbo].[Musicas]  WITH CHECK ADD  CONSTRAINT [FK_Musicas_Multimedias] FOREIGN KEY([IdMultimedia])
REFERENCES [dbo].[Multimedias] ([Id])
GO
ALTER TABLE [dbo].[Musicas] CHECK CONSTRAINT [FK_Musicas_Multimedias]
GO
ALTER TABLE [dbo].[Ordenadores]  WITH CHECK ADD  CONSTRAINT [FK_Ordenadores_Tecnologicos] FOREIGN KEY([IdTecnologia])
REFERENCES [dbo].[Tecnologicos] ([Id])
GO
ALTER TABLE [dbo].[Ordenadores] CHECK CONSTRAINT [FK_Ordenadores_Tecnologicos]
GO
ALTER TABLE [dbo].[Peliculas]  WITH CHECK ADD  CONSTRAINT [FK_Peliculas_Multimedias] FOREIGN KEY([IdMultimedia])
REFERENCES [dbo].[Multimedias] ([Id])
GO
ALTER TABLE [dbo].[Peliculas] CHECK CONSTRAINT [FK_Peliculas_Multimedias]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Vendedores] FOREIGN KEY([IdVendedor])
REFERENCES [dbo].[Vendedores] ([Id])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Producto_Vendedores]
GO
ALTER TABLE [dbo].[Ropas]  WITH CHECK ADD  CONSTRAINT [FK_Ropas_Modas] FOREIGN KEY([IdModa])
REFERENCES [dbo].[Modas] ([Id])
GO
ALTER TABLE [dbo].[Ropas] CHECK CONSTRAINT [FK_Ropas_Modas]
GO
ALTER TABLE [dbo].[Tecnologicos]  WITH CHECK ADD  CONSTRAINT [FK_Tecnologicos_Productos] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([Id])
GO
ALTER TABLE [dbo].[Tecnologicos] CHECK CONSTRAINT [FK_Tecnologicos_Productos]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Carritos] FOREIGN KEY([IdCarrito])
REFERENCES [dbo].[Carritos] ([Id])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Carritos]
GO
ALTER TABLE [dbo].[Videoconsolas]  WITH CHECK ADD  CONSTRAINT [FK_Videoconsolas_Tecnologicos] FOREIGN KEY([IdTecnologia])
REFERENCES [dbo].[Tecnologicos] ([Id])
GO
ALTER TABLE [dbo].[Videoconsolas] CHECK CONSTRAINT [FK_Videoconsolas_Tecnologicos]
GO
ALTER TABLE [dbo].[Videojuegos]  WITH CHECK ADD  CONSTRAINT [FK_Videojuegos_Multimedias] FOREIGN KEY([IdMultimedia])
REFERENCES [dbo].[Multimedias] ([Id])
GO
ALTER TABLE [dbo].[Videojuegos] CHECK CONSTRAINT [FK_Videojuegos_Multimedias]
GO
USE [master]
GO
ALTER DATABASE [eCommerce] SET  READ_WRITE 
GO
