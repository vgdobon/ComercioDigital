USE [master]
GO
/****** Object:  Database [eCommerce]    Script Date: 25/02/2021 0:53:21 ******/
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
/****** Object:  Table [dbo].[Almacenes]    Script Date: 25/02/2021 0:53:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Almacenes](
	[IdProducto] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bolsos]    Script Date: 25/02/2021 0:53:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bolsos](
	[Id] [int] NOT NULL,
	[Tipo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Bolsos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Calzados]    Script Date: 25/02/2021 0:53:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calzados](
	[Id] [int] NOT NULL,
	[Talla] [int] NOT NULL,
	[Tipo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Calzados] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarritoProductos]    Script Date: 25/02/2021 0:53:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarritoProductos](
	[IdCarrito] [int] NOT NULL,
	[IdProducto] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carritos]    Script Date: 25/02/2021 0:53:21 ******/
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
/****** Object:  Table [dbo].[Joyas]    Script Date: 25/02/2021 0:53:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Joyas](
	[Id] [int] NOT NULL,
	[Medida] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Joyas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modas]    Script Date: 25/02/2021 0:53:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modas](
	[Id] [int] NOT NULL,
	[Color] [nvarchar](50) NOT NULL,
	[Material] [nvarchar](50) NOT NULL,
	[Sexo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Moda] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Moviles]    Script Date: 25/02/2021 0:53:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Moviles](
	[Id] [int] NOT NULL,
	[Pantalla] [float] NOT NULL,
	[Bateria] [int] NOT NULL,
 CONSTRAINT [PK_Moviles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Multimedias]    Script Date: 25/02/2021 0:53:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Multimedias](
	[Id] [int] NOT NULL,
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
/****** Object:  Table [dbo].[Musicas]    Script Date: 25/02/2021 0:53:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musicas](
	[Id] [int] NOT NULL,
	[Artista] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Musicas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordenadores]    Script Date: 25/02/2021 0:53:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordenadores](
	[Id] [int] NOT NULL,
	[PlacaBase] [nvarchar](50) NOT NULL,
	[Tipo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Ordenadores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PedidoProductos]    Script Date: 25/02/2021 0:53:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PedidoProductos](
	[IdPedido] [int] NULL,
	[IdProducto] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedidos]    Script Date: 25/02/2021 0:53:21 ******/
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
/****** Object:  Table [dbo].[Peliculas]    Script Date: 25/02/2021 0:53:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Peliculas](
	[Id] [int] NOT NULL,
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
/****** Object:  Table [dbo].[Productos]    Script Date: 25/02/2021 0:53:21 ******/
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
/****** Object:  Table [dbo].[Ropas]    Script Date: 25/02/2021 0:53:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ropas](
	[Id] [int] NOT NULL,
	[Talla] [nvarchar](50) NOT NULL,
	[Tipo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Ropas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tecnologicos]    Script Date: 25/02/2021 0:53:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tecnologicos](
	[Id] [int] NOT NULL,
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
/****** Object:  Table [dbo].[Usuarios]    Script Date: 25/02/2021 0:53:21 ******/
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
/****** Object:  Table [dbo].[Vendedores]    Script Date: 25/02/2021 0:53:21 ******/
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
/****** Object:  Table [dbo].[Videoconsolas]    Script Date: 25/02/2021 0:53:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Videoconsolas](
	[Id] [int] NOT NULL,
 CONSTRAINT [PK_Videoconsolas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Videojuegos]    Script Date: 25/02/2021 0:53:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Videojuegos](
	[Id] [int] NOT NULL,
	[Plataforma] [nvarchar](50) NOT NULL,
	[EdadRecomendada] [int] NOT NULL,
 CONSTRAINT [PK_Videojuegos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Bolsos] ([Id], [Tipo]) VALUES (1020, N'Bolso')
GO
INSERT [dbo].[Calzados] ([Id], [Talla], [Tipo]) VALUES (1019, 44, N'Bota')
GO
SET IDENTITY_INSERT [dbo].[Carritos] ON 

INSERT [dbo].[Carritos] ([Id]) VALUES (0)
INSERT [dbo].[Carritos] ([Id]) VALUES (1)
INSERT [dbo].[Carritos] ([Id]) VALUES (2)
INSERT [dbo].[Carritos] ([Id]) VALUES (3)
INSERT [dbo].[Carritos] ([Id]) VALUES (4)
INSERT [dbo].[Carritos] ([Id]) VALUES (5)
INSERT [dbo].[Carritos] ([Id]) VALUES (6)
INSERT [dbo].[Carritos] ([Id]) VALUES (7)
INSERT [dbo].[Carritos] ([Id]) VALUES (8)
SET IDENTITY_INSERT [dbo].[Carritos] OFF
GO
INSERT [dbo].[Joyas] ([Id], [Medida]) VALUES (1021, N'17')
GO
INSERT [dbo].[Modas] ([Id], [Color], [Material], [Sexo]) VALUES (1018, N'Azul', N'Vaquero', N'H')
INSERT [dbo].[Modas] ([Id], [Color], [Material], [Sexo]) VALUES (1019, N'Marrón', N'Cuero', N'H')
INSERT [dbo].[Modas] ([Id], [Color], [Material], [Sexo]) VALUES (1020, N'Negro', N'Lentejuelas', N'M')
INSERT [dbo].[Modas] ([Id], [Color], [Material], [Sexo]) VALUES (1021, N'Amarillo', N'Oro y diamante', N'M')
GO
INSERT [dbo].[Moviles] ([Id], [Pantalla], [Bateria]) VALUES (1015, 6.1999998092651367, 4000)
GO
INSERT [dbo].[Multimedias] ([Id], [Genero], [Formato], [Idioma], [FechaLanzamiento]) VALUES (1022, N'Latina', N'MP3', N'Español', CAST(N'2020-09-01' AS Date))
INSERT [dbo].[Multimedias] ([Id], [Genero], [Formato], [Idioma], [FechaLanzamiento]) VALUES (1023, N'Shooter', N'DVD', N'Español', CAST(N'2012-08-12' AS Date))
INSERT [dbo].[Multimedias] ([Id], [Genero], [Formato], [Idioma], [FechaLanzamiento]) VALUES (1024, N'Dance y electrónica', N'MP3', N'Español', CAST(N'2021-01-01' AS Date))
INSERT [dbo].[Multimedias] ([Id], [Genero], [Formato], [Idioma], [FechaLanzamiento]) VALUES (1025, N'Acción', N'Blu-Ray', N'Español', CAST(N'2021-04-02' AS Date))
GO
INSERT [dbo].[Musicas] ([Id], [Artista]) VALUES (1022, N'Pablo Alboran')
INSERT [dbo].[Musicas] ([Id], [Artista]) VALUES (1024, N'David Guetta')
GO
INSERT [dbo].[Ordenadores] ([Id], [PlacaBase], [Tipo]) VALUES (1013, N'HP Placa base PC Pro 3010 MT', N'Sobremesa')
GO
INSERT [dbo].[Peliculas] ([Id], [Actores], [Director], [EdadRecomendada], [Sinopsis]) VALUES (1025, N'Vin Diesel,Michelle Rodriguez,Charlize Theron,John Cena,Don Omar', N'Justin Lin', 18, N'Instalados en su vida familiar, Dom y Letty viven en el campo con Brian, el hijo de Dom.Jakob se ha unido con Cipher para causar estragos y cumplir un deseo de venganza.El equipo se reunirá una vez más para mantener a la familia unida.')
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [Marca], [IdVendedor], [Descripcion], [Valoracion], [FechaPuestaVenta], [CodigoDescuento], [Stock]) VALUES (1013, N'Pc sobremesa HP', CAST(500.99 AS Decimal(18, 2)), N'HP', 1, N'Potente y silencioso ordenador de sobremesa', 0, CAST(N'2021-02-24' AS Date), N'HP', 10)
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [Marca], [IdVendedor], [Descripcion], [Valoracion], [FechaPuestaVenta], [CodigoDescuento], [Stock]) VALUES (1014, N'PlayStation 5', CAST(699.99 AS Decimal(18, 2)), N'Sony', 1, N'Consola de videojuegos 2021', 0, CAST(N'2021-02-24' AS Date), N'PLAY5', 10)
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [Marca], [IdVendedor], [Descripcion], [Valoracion], [FechaPuestaVenta], [CodigoDescuento], [Stock]) VALUES (1015, N'Smartphone Samsung S21 Blanco', CAST(1300.00 AS Decimal(18, 2)), N'Samsung', 1, N'Nuevo smartphone Samsung el mas potente del mercado', 0, CAST(N'2021-02-24' AS Date), N'Blanco', 10)
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [Marca], [IdVendedor], [Descripcion], [Valoracion], [FechaPuestaVenta], [CodigoDescuento], [Stock]) VALUES (1018, N'Pantalon vaquero', CAST(70.00 AS Decimal(18, 2)), N'Levi´s', 1, N'Pantalón vaquero corte clásico', 0, CAST(N'2021-02-24' AS Date), N'LEVIS', 10)
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [Marca], [IdVendedor], [Descripcion], [Valoracion], [FechaPuestaVenta], [CodigoDescuento], [Stock]) VALUES (1019, N'Bota alta', CAST(50.50 AS Decimal(18, 2)), N'GUESS', 1, N'Bota alta de vesti', 0, CAST(N'2021-02-24' AS Date), N'BOTAGUESS', 6)
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [Marca], [IdVendedor], [Descripcion], [Valoracion], [FechaPuestaVenta], [CodigoDescuento], [Stock]) VALUES (1020, N'Bolso de fiesta', CAST(350.00 AS Decimal(18, 2)), N'Dolce & Gabanna', 1, N'Bolso de fiesta pequeño', 0, CAST(N'2021-02-24' AS Date), N'D&G', 10)
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [Marca], [IdVendedor], [Descripcion], [Valoracion], [FechaPuestaVenta], [CodigoDescuento], [Stock]) VALUES (1021, N'Anillo compromiso', CAST(1250.00 AS Decimal(18, 2)), N'Gucci', 1, N'Anilllo de compromiso de alta calidad', 0, CAST(N'2021-02-24' AS Date), N'ANILLO', 2)
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [Marca], [IdVendedor], [Descripcion], [Valoracion], [FechaPuestaVenta], [CodigoDescuento], [Stock]) VALUES (1022, N'Album Vértigo Pablo Alboran', CAST(11.90 AS Decimal(18, 2)), N'Pablo Alboran', 1, N'Ultimo albúm de Pablo Alboran 2021', 0, CAST(N'2021-02-24' AS Date), N'ALBORAN', 10)
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [Marca], [IdVendedor], [Descripcion], [Valoracion], [FechaPuestaVenta], [CodigoDescuento], [Stock]) VALUES (1023, N'Call of Duty: Black Ops II', CAST(10.50 AS Decimal(18, 2)), N'Activision', 1, N'Juego de disparos en primera persona y modo Zombies', 0, CAST(N'2021-02-24' AS Date), N'BO2', 4)
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [Marca], [IdVendedor], [Descripcion], [Valoracion], [FechaPuestaVenta], [CodigoDescuento], [Stock]) VALUES (1024, N'Nothing but the Beat (Ultimate Edition)', CAST(7.43 AS Decimal(18, 2)), N'David Guetta', 1, N'Sonido actual y unos cuantos éxitos del año pasado. El primer disco es vocal y el segundo más electrónico.', 0, CAST(N'2021-02-24' AS Date), N'GUETTA', 100)
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [Marca], [IdVendedor], [Descripcion], [Valoracion], [FechaPuestaVenta], [CodigoDescuento], [Stock]) VALUES (1025, N'Fast and Furious 9', CAST(9.00 AS Decimal(18, 2)), N'Universal Studios', 1, N'Pelicula de acción y conduccion peligrosa', 0, CAST(N'2021-02-24' AS Date), N'F&F9', 100)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
INSERT [dbo].[Ropas] ([Id], [Talla], [Tipo]) VALUES (1018, N'L', N'Pantalon')
GO
INSERT [dbo].[Tecnologicos] ([Id], [Color], [Procesador], [SistemaOperativo], [Modelo], [FechaLanzamiento]) VALUES (1013, N'Negro', N'Intel® CoreT i7-10700F', N'Windows', N'OMEN 25L GT11-0011ns', CAST(N'2020-05-10' AS Date))
INSERT [dbo].[Tecnologicos] ([Id], [Color], [Procesador], [SistemaOperativo], [Modelo], [FechaLanzamiento]) VALUES (1014, N'Negro', N'AMD Zen 2 de 8 núcleos a 3.5 GHz', N'PlayStation 5 system software', N'Pro', CAST(N'2020-04-10' AS Date))
INSERT [dbo].[Tecnologicos] ([Id], [Color], [Procesador], [SistemaOperativo], [Modelo], [FechaLanzamiento]) VALUES (1015, N'Blanco', N'Qualcomm SM8350 Snapdragon 888', N'Android 11', N'Ultra 5G', CAST(N'2020-05-10' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([Id], [Nombre], [Pass], [Domicilio], [Saldo], [IdCarrito], [IdPedido]) VALUES (5, N'Victor', N'1111', N'C/ Victor 24', CAST(2000.50 AS Decimal(18, 2)), 1, NULL)
INSERT [dbo].[Usuarios] ([Id], [Nombre], [Pass], [Domicilio], [Saldo], [IdCarrito], [IdPedido]) VALUES (10, N'cristinini', N'cristinini', N'C/ cristinini', CAST(10.00 AS Decimal(18, 2)), 2, NULL)
INSERT [dbo].[Usuarios] ([Id], [Nombre], [Pass], [Domicilio], [Saldo], [IdCarrito], [IdPedido]) VALUES (11, N'ibai', N'ibai', N'ibai', CAST(10.00 AS Decimal(18, 2)), 3, NULL)
INSERT [dbo].[Usuarios] ([Id], [Nombre], [Pass], [Domicilio], [Saldo], [IdCarrito], [IdPedido]) VALUES (12, N'knecro', N'knecro', N'knecro', CAST(10.00 AS Decimal(18, 2)), 5, NULL)
INSERT [dbo].[Usuarios] ([Id], [Nombre], [Pass], [Domicilio], [Saldo], [IdCarrito], [IdPedido]) VALUES (13, N'Ander', N'Ander', N'C/ Ander 22', CAST(10.00 AS Decimal(18, 2)), 6, NULL)
INSERT [dbo].[Usuarios] ([Id], [Nombre], [Pass], [Domicilio], [Saldo], [IdCarrito], [IdPedido]) VALUES (14, N'patricia', N'1111', N'ramiro I de aragon', CAST(10.00 AS Decimal(18, 2)), 7, NULL)
INSERT [dbo].[Usuarios] ([Id], [Nombre], [Pass], [Domicilio], [Saldo], [IdCarrito], [IdPedido]) VALUES (15, N'usuariO', N'USUARIO', N'USUARIO', CAST(9110.00 AS Decimal(18, 2)), 8, NULL)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[Vendedores] ON 

INSERT [dbo].[Vendedores] ([Id], [Nombre], [Direccion], [Contrasenna], [Valoracion]) VALUES (1, N'VENDEDOR', N'C/Vendedor 24', N'1111', 4)
SET IDENTITY_INSERT [dbo].[Vendedores] OFF
GO
INSERT [dbo].[Videoconsolas] ([Id]) VALUES (1014)
GO
INSERT [dbo].[Videojuegos] ([Id], [Plataforma], [EdadRecomendada]) VALUES (1023, N'PS3', 18)
GO
ALTER TABLE [dbo].[Almacenes]  WITH CHECK ADD  CONSTRAINT [FK_almacenes_Productos] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([Id])
GO
ALTER TABLE [dbo].[Almacenes] CHECK CONSTRAINT [FK_almacenes_Productos]
GO
ALTER TABLE [dbo].[Bolsos]  WITH CHECK ADD  CONSTRAINT [FK_Bolsos_Modas] FOREIGN KEY([Id])
REFERENCES [dbo].[Modas] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bolsos] CHECK CONSTRAINT [FK_Bolsos_Modas]
GO
ALTER TABLE [dbo].[Calzados]  WITH CHECK ADD  CONSTRAINT [FK_Calzados_Modas] FOREIGN KEY([Id])
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
ALTER TABLE [dbo].[Joyas]  WITH CHECK ADD  CONSTRAINT [FK_Joyas_Modas] FOREIGN KEY([Id])
REFERENCES [dbo].[Modas] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Joyas] CHECK CONSTRAINT [FK_Joyas_Modas]
GO
ALTER TABLE [dbo].[Modas]  WITH CHECK ADD  CONSTRAINT [FK_Modas_Productos] FOREIGN KEY([Id])
REFERENCES [dbo].[Productos] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Modas] CHECK CONSTRAINT [FK_Modas_Productos]
GO
ALTER TABLE [dbo].[Moviles]  WITH CHECK ADD  CONSTRAINT [FK_Moviles_Tecnologicos] FOREIGN KEY([Id])
REFERENCES [dbo].[Tecnologicos] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Moviles] CHECK CONSTRAINT [FK_Moviles_Tecnologicos]
GO
ALTER TABLE [dbo].[Multimedias]  WITH CHECK ADD  CONSTRAINT [FK_Multimedias_Productos] FOREIGN KEY([Id])
REFERENCES [dbo].[Productos] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Multimedias] CHECK CONSTRAINT [FK_Multimedias_Productos]
GO
ALTER TABLE [dbo].[Musicas]  WITH CHECK ADD  CONSTRAINT [FK_Musicas_Multimedias] FOREIGN KEY([Id])
REFERENCES [dbo].[Multimedias] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Musicas] CHECK CONSTRAINT [FK_Musicas_Multimedias]
GO
ALTER TABLE [dbo].[Ordenadores]  WITH CHECK ADD  CONSTRAINT [FK_Ordenadores_Tecnologicos] FOREIGN KEY([Id])
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
ALTER TABLE [dbo].[Peliculas]  WITH CHECK ADD  CONSTRAINT [FK_Peliculas_Multimedias] FOREIGN KEY([Id])
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
ALTER TABLE [dbo].[Ropas]  WITH CHECK ADD  CONSTRAINT [FK_Ropas_Modas] FOREIGN KEY([Id])
REFERENCES [dbo].[Modas] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ropas] CHECK CONSTRAINT [FK_Ropas_Modas]
GO
ALTER TABLE [dbo].[Tecnologicos]  WITH CHECK ADD  CONSTRAINT [FK_Tecnologicos_Productos] FOREIGN KEY([Id])
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
ALTER TABLE [dbo].[Videoconsolas]  WITH CHECK ADD  CONSTRAINT [FK_Videoconsolas_Tecnologicos] FOREIGN KEY([Id])
REFERENCES [dbo].[Tecnologicos] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Videoconsolas] CHECK CONSTRAINT [FK_Videoconsolas_Tecnologicos]
GO
ALTER TABLE [dbo].[Videojuegos]  WITH CHECK ADD  CONSTRAINT [FK_Videojuegos_Multimedias] FOREIGN KEY([Id])
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
