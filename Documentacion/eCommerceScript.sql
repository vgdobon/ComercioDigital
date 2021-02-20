USE [master]
GO
/****** Object:  Database [eCommerce]    Script Date: 21/02/2021 0:44:55 ******/
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
/****** Object:  Table [dbo].[Almacenes]    Script Date: 21/02/2021 0:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Almacenes](
	[IdProducto] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bolsos]    Script Date: 21/02/2021 0:44:55 ******/
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
/****** Object:  Table [dbo].[Calzados]    Script Date: 21/02/2021 0:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calzados](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdModa] [int] NULL,
	[Talla] [int] NULL,
	[Tipo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Calzados] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarritoProductos]    Script Date: 21/02/2021 0:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarritoProductos](
	[IdCarrito] [int] NOT NULL,
	[IdProducto] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carritos]    Script Date: 21/02/2021 0:44:55 ******/
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
/****** Object:  Table [dbo].[Joyas]    Script Date: 21/02/2021 0:44:55 ******/
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
/****** Object:  Table [dbo].[Modas]    Script Date: 21/02/2021 0:44:55 ******/
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
/****** Object:  Table [dbo].[Moviles]    Script Date: 21/02/2021 0:44:55 ******/
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
/****** Object:  Table [dbo].[Multimedias]    Script Date: 21/02/2021 0:44:55 ******/
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
/****** Object:  Table [dbo].[Musicas]    Script Date: 21/02/2021 0:44:55 ******/
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
/****** Object:  Table [dbo].[Ordenadores]    Script Date: 21/02/2021 0:44:55 ******/
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
/****** Object:  Table [dbo].[PedidoProductos]    Script Date: 21/02/2021 0:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PedidoProductos](
	[IdPedido] [int] NULL,
	[IdProducto] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedidos]    Script Date: 21/02/2021 0:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedidos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NULL,
 CONSTRAINT [PK_Pedidos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Peliculas]    Script Date: 21/02/2021 0:44:55 ******/
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
/****** Object:  Table [dbo].[Productos]    Script Date: 21/02/2021 0:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
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
/****** Object:  Table [dbo].[Ropas]    Script Date: 21/02/2021 0:44:55 ******/
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
/****** Object:  Table [dbo].[Tecnologicos]    Script Date: 21/02/2021 0:44:55 ******/
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
/****** Object:  Table [dbo].[Usuarios]    Script Date: 21/02/2021 0:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](50) NOT NULL,
	[Domicilio] [nvarchar](50) NOT NULL,
	[Saldo] [decimal](18, 2) NOT NULL,
	[IdCarrito] [int] NOT NULL,
	[IdPedido] [int] NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vendedores]    Script Date: 21/02/2021 0:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendedores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[Contrasenna] [nvarchar](50) NOT NULL,
	[Valoracion] [int] NULL,
 CONSTRAINT [PK_Vendedores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Videoconsolas]    Script Date: 21/02/2021 0:44:55 ******/
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
/****** Object:  Table [dbo].[Videojuegos]    Script Date: 21/02/2021 0:44:55 ******/
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
INSERT [dbo].[CarritoProductos] ([IdCarrito], [IdProducto]) VALUES (1, 2)
INSERT [dbo].[CarritoProductos] ([IdCarrito], [IdProducto]) VALUES (1, 3)
GO
SET IDENTITY_INSERT [dbo].[Carritos] ON 

INSERT [dbo].[Carritos] ([Id]) VALUES (0)
INSERT [dbo].[Carritos] ([Id]) VALUES (1)
INSERT [dbo].[Carritos] ([Id]) VALUES (2)
INSERT [dbo].[Carritos] ([Id]) VALUES (3)
INSERT [dbo].[Carritos] ([Id]) VALUES (4)
INSERT [dbo].[Carritos] ([Id]) VALUES (5)
INSERT [dbo].[Carritos] ([Id]) VALUES (6)
SET IDENTITY_INSERT [dbo].[Carritos] OFF
GO
SET IDENTITY_INSERT [dbo].[Joyas] ON 

INSERT [dbo].[Joyas] ([Id], [IdModa], [Medida]) VALUES (1, 1, N'15')
SET IDENTITY_INSERT [dbo].[Joyas] OFF
GO
SET IDENTITY_INSERT [dbo].[Modas] ON 

INSERT [dbo].[Modas] ([Id], [IdProducto], [Color], [Material], [Sexo]) VALUES (1, 3, N'Rosa', N'Oro', N'U')
SET IDENTITY_INSERT [dbo].[Modas] OFF
GO
SET IDENTITY_INSERT [dbo].[Moviles] ON 

INSERT [dbo].[Moviles] ([Id], [IdTecnologia], [Pantalla], [Bateria]) VALUES (1, 1, 6.5, 4500)
SET IDENTITY_INSERT [dbo].[Moviles] OFF
GO
SET IDENTITY_INSERT [dbo].[Multimedias] ON 

INSERT [dbo].[Multimedias] ([Id], [IdProducto], [Genero], [Formato], [Idioma], [FechaLanzamiento]) VALUES (1, 4, N'Accion', N'DVD', N'Español', CAST(N'2011-04-25' AS Date))
SET IDENTITY_INSERT [dbo].[Multimedias] OFF
GO
SET IDENTITY_INSERT [dbo].[Peliculas] ON 

INSERT [dbo].[Peliculas] ([Id], [IdMultimedia], [Actores], [Director], [EdadRecomendada], [Sinopsis]) VALUES (1, 1, N'Theo James, Shailene Woodley', N' Robert Schwentke', 16, N'En una sociedad futurista, la gente está dividida entre facciones basadas en sus personalidades. Después de que una joven descubre que ella es una divergente y nunca será de algún grupo, descubre un complot para destruir a quienes son como ella')
SET IDENTITY_INSERT [dbo].[Peliculas] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [Marca], [IdVendedor], [Descripcion], [Valoracion], [FechaPuestaVenta], [CodigoDescuento], [Stock]) VALUES (2, N'Smartphone Samsung A21', CAST(249.99 AS Decimal(18, 2)), N'Samsung', 1, N'Telefono Smartphone última generacion', 3, CAST(N'2021-11-02' AS Date), N'MovilA21', 5)
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [Marca], [IdVendedor], [Descripcion], [Valoracion], [FechaPuestaVenta], [CodigoDescuento], [Stock]) VALUES (3, N'Anillo compromiso', CAST(1050.00 AS Decimal(18, 2)), N'DIOR', 1, N'Anillo de compromiso de oro rosa y oro', 5, CAST(N'2019-12-01' AS Date), N'ANILLO', 2)
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [Marca], [IdVendedor], [Descripcion], [Valoracion], [FechaPuestaVenta], [CodigoDescuento], [Stock]) VALUES (4, N'Peliculas Saga Divergente', CAST(9.99 AS Decimal(18, 2)), N'Divergente', 1, N'La primera peliculas de la seria Divergente.', 5, CAST(N'2021-01-01' AS Date), N'DIVERGENTE', 10)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Tecnologicos] ON 

INSERT [dbo].[Tecnologicos] ([Id], [IdProducto], [Color], [Procesador], [SistemaOperativo], [Modelo], [FechaLanzamiento]) VALUES (1, 2, N'Blanco', N'SnapDragon', N'Android 11', N'Basic', CAST(N'2019-04-24' AS Date))
SET IDENTITY_INSERT [dbo].[Tecnologicos] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([Id], [Nombre], [Pass], [Domicilio], [Saldo], [IdCarrito], [IdPedido]) VALUES (5, N'Victor', N'1111', N'C/ Victor 24', CAST(2000.50 AS Decimal(18, 2)), 1, NULL)
INSERT [dbo].[Usuarios] ([Id], [Nombre], [Pass], [Domicilio], [Saldo], [IdCarrito], [IdPedido]) VALUES (10, N'cristinini', N'cristinini', N'C/ cristinini', CAST(10.00 AS Decimal(18, 2)), 2, NULL)
INSERT [dbo].[Usuarios] ([Id], [Nombre], [Pass], [Domicilio], [Saldo], [IdCarrito], [IdPedido]) VALUES (11, N'ibai', N'ibai', N'ibai', CAST(10.00 AS Decimal(18, 2)), 3, NULL)
INSERT [dbo].[Usuarios] ([Id], [Nombre], [Pass], [Domicilio], [Saldo], [IdCarrito], [IdPedido]) VALUES (12, N'knecro', N'knecro', N'knecro', CAST(10.00 AS Decimal(18, 2)), 5, NULL)
INSERT [dbo].[Usuarios] ([Id], [Nombre], [Pass], [Domicilio], [Saldo], [IdCarrito], [IdPedido]) VALUES (13, N'Ander', N'Ander', N'C/ Ander 22', CAST(10.00 AS Decimal(18, 2)), 6, NULL)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[Vendedores] ON 

INSERT [dbo].[Vendedores] ([Id], [Nombre], [Direccion], [Contrasenna], [Valoracion]) VALUES (1, N'Vendedor', N'C/Vendedor 24', N'1111', 4)
INSERT [dbo].[Vendedores] ([Id], [Nombre], [Direccion], [Contrasenna], [Valoracion]) VALUES (3, N'victor', N'C/Zaragoza 1', N'1111', 0)
INSERT [dbo].[Vendedores] ([Id], [Nombre], [Direccion], [Contrasenna], [Valoracion]) VALUES (5, N'qwerty', N'teclado', N'qwerty', 0)
INSERT [dbo].[Vendedores] ([Id], [Nombre], [Direccion], [Contrasenna], [Valoracion]) VALUES (13, N'Vendedor', N'C/Vendedor 24', N'1111', 0)
INSERT [dbo].[Vendedores] ([Id], [Nombre], [Direccion], [Contrasenna], [Valoracion]) VALUES (15, N'Aurelio', N'C/Aurelio 22', N'1111', 0)
SET IDENTITY_INSERT [dbo].[Vendedores] OFF
GO
ALTER TABLE [dbo].[Almacenes]  WITH CHECK ADD  CONSTRAINT [FK_almacenes_Productos] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([Id])
GO
ALTER TABLE [dbo].[Almacenes] CHECK CONSTRAINT [FK_almacenes_Productos]
GO
ALTER TABLE [dbo].[Bolsos]  WITH CHECK ADD  CONSTRAINT [FK_Bolsos_Moda] FOREIGN KEY([IdModa])
REFERENCES [dbo].[Modas] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bolsos] CHECK CONSTRAINT [FK_Bolsos_Moda]
GO
ALTER TABLE [dbo].[Calzados]  WITH CHECK ADD  CONSTRAINT [FK_Calzados_Modas] FOREIGN KEY([IdModa])
REFERENCES [dbo].[Modas] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Calzados] CHECK CONSTRAINT [FK_Calzados_Modas]
GO
ALTER TABLE [dbo].[CarritoProductos]  WITH CHECK ADD  CONSTRAINT [FK_CarritoProductos_Carritos] FOREIGN KEY([IdCarrito])
REFERENCES [dbo].[Carritos] ([Id])
GO
ALTER TABLE [dbo].[CarritoProductos] CHECK CONSTRAINT [FK_CarritoProductos_Carritos]
GO
ALTER TABLE [dbo].[CarritoProductos]  WITH CHECK ADD  CONSTRAINT [FK_CarritoProductos_Productos] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([Id])
GO
ALTER TABLE [dbo].[CarritoProductos] CHECK CONSTRAINT [FK_CarritoProductos_Productos]
GO
ALTER TABLE [dbo].[Joyas]  WITH CHECK ADD  CONSTRAINT [FK_Joyas_Modas] FOREIGN KEY([IdModa])
REFERENCES [dbo].[Modas] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Joyas] CHECK CONSTRAINT [FK_Joyas_Modas]
GO
ALTER TABLE [dbo].[Modas]  WITH CHECK ADD  CONSTRAINT [FK_Moda_Productos] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Modas] CHECK CONSTRAINT [FK_Moda_Productos]
GO
ALTER TABLE [dbo].[Moviles]  WITH CHECK ADD  CONSTRAINT [FK_Moviles_Tecnologicos] FOREIGN KEY([IdTecnologia])
REFERENCES [dbo].[Tecnologicos] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Moviles] CHECK CONSTRAINT [FK_Moviles_Tecnologicos]
GO
ALTER TABLE [dbo].[Multimedias]  WITH CHECK ADD  CONSTRAINT [FK_Multimedias_Productos] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Multimedias] CHECK CONSTRAINT [FK_Multimedias_Productos]
GO
ALTER TABLE [dbo].[Musicas]  WITH CHECK ADD  CONSTRAINT [FK_Musicas_Multimedias] FOREIGN KEY([IdMultimedia])
REFERENCES [dbo].[Multimedias] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Musicas] CHECK CONSTRAINT [FK_Musicas_Multimedias]
GO
ALTER TABLE [dbo].[Ordenadores]  WITH CHECK ADD  CONSTRAINT [FK_Ordenadores_Tecnologicos] FOREIGN KEY([IdTecnologia])
REFERENCES [dbo].[Tecnologicos] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ordenadores] CHECK CONSTRAINT [FK_Ordenadores_Tecnologicos]
GO
ALTER TABLE [dbo].[PedidoProductos]  WITH CHECK ADD  CONSTRAINT [FK_PedidoProductos_Pedidos] FOREIGN KEY([IdPedido])
REFERENCES [dbo].[Pedidos] ([Id])
GO
ALTER TABLE [dbo].[PedidoProductos] CHECK CONSTRAINT [FK_PedidoProductos_Pedidos]
GO
ALTER TABLE [dbo].[PedidoProductos]  WITH CHECK ADD  CONSTRAINT [FK_PedidoProductos_Productos] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([Id])
GO
ALTER TABLE [dbo].[PedidoProductos] CHECK CONSTRAINT [FK_PedidoProductos_Productos]
GO
ALTER TABLE [dbo].[Peliculas]  WITH CHECK ADD  CONSTRAINT [FK_Peliculas_Multimedias] FOREIGN KEY([IdMultimedia])
REFERENCES [dbo].[Multimedias] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
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
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ropas] CHECK CONSTRAINT [FK_Ropas_Modas]
GO
ALTER TABLE [dbo].[Tecnologicos]  WITH CHECK ADD  CONSTRAINT [FK_Tecnologicos_Productos] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tecnologicos] CHECK CONSTRAINT [FK_Tecnologicos_Productos]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Carritos] FOREIGN KEY([IdCarrito])
REFERENCES [dbo].[Carritos] ([Id])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Carritos]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Pedidos] FOREIGN KEY([IdPedido])
REFERENCES [dbo].[Pedidos] ([Id])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Pedidos]
GO
ALTER TABLE [dbo].[Videoconsolas]  WITH CHECK ADD  CONSTRAINT [FK_Videoconsolas_Tecnologicos] FOREIGN KEY([IdTecnologia])
REFERENCES [dbo].[Tecnologicos] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Videoconsolas] CHECK CONSTRAINT [FK_Videoconsolas_Tecnologicos]
GO
ALTER TABLE [dbo].[Videojuegos]  WITH CHECK ADD  CONSTRAINT [FK_Videojuegos_Multimedias] FOREIGN KEY([IdMultimedia])
REFERENCES [dbo].[Multimedias] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Videojuegos] CHECK CONSTRAINT [FK_Videojuegos_Multimedias]
GO
USE [master]
GO
ALTER DATABASE [eCommerce] SET  READ_WRITE 
GO
