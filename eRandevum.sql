USE 
GO
/****** Object:  Database [eRandevum]    Script Date: 1/6/2020 3:06:14 PM ******/
CREATE DATABASE [eRandevum]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'eRandevum', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\eRandevum.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'eRandevum_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\eRandevum_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [eRandevum].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [eRandevum] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [eRandevum] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [eRandevum] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [eRandevum] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [eRandevum] SET ARITHABORT OFF 
GO
ALTER DATABASE [eRandevum] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [eRandevum] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [eRandevum] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [eRandevum] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [eRandevum] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [eRandevum] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [eRandevum] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [eRandevum] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [eRandevum] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [eRandevum] SET  DISABLE_BROKER 
GO
ALTER DATABASE [eRandevum] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [eRandevum] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [eRandevum] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [eRandevum] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [eRandevum] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [eRandevum] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [eRandevum] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [eRandevum] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [eRandevum] SET  MULTI_USER 
GO
ALTER DATABASE [eRandevum] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [eRandevum] SET DB_CHAINING OFF 
GO
ALTER DATABASE [eRandevum] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [eRandevum] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [eRandevum] SET DELAYED_DURABILITY = DISABLED 
GO
USE [eRandevum]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 1/6/2020 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminId] [nvarchar](20) NOT NULL,
	[Sifre] [nchar](20) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Adres]    Script Date: 1/6/2020 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adres](
	[AdresId] [int] IDENTITY(1,1) NOT NULL,
	[Il] [nvarchar](50) NULL,
	[Ilce] [nvarchar](50) NULL,
	[Sokak] [nvarchar](50) NULL,
	[KapiNo] [int] NULL,
	[DaireNo] [int] NULL,
 CONSTRAINT [PK_Adres] PRIMARY KEY CLUSTERED 
(
	[AdresId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bilgiler]    Script Date: 1/6/2020 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bilgiler](
	[IsyeriId] [int] NULL,
	[IsyeriAdi] [nvarchar](50) NULL,
	[CalisanBilgi] [text] NULL,
	[FirmaGecmisi] [text] NULL,
	[RandevuDetayi] [text] NULL,
	[Il] [text] NULL,
	[Ilce] [text] NULL,
	[Sokak] [text] NULL,
	[No] [text] NULL,
	[Tel] [text] NULL,
	[Email] [text] NULL,
	[router] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IsYeri]    Script Date: 1/6/2020 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IsYeri](
	[IsyeriId] [int] IDENTITY(1,1) NOT NULL,
	[IsYeriAdi] [nvarchar](50) NULL,
	[KategoriId] [int] NULL,
	[YetkiliId] [int] NULL,
	[AdresId] [int] NULL,
	[Telefon] [nchar](20) NULL,
 CONSTRAINT [PK_IsYeri] PRIMARY KEY CLUSTERED 
(
	[IsyeriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IsYeriAdres]    Script Date: 1/6/2020 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IsYeriAdres](
	[AdresId] [int] IDENTITY(1,1) NOT NULL,
	[Il] [nvarchar](50) NULL,
	[Ilce] [nvarchar](50) NULL,
	[Sokak] [nvarchar](50) NULL,
	[KapiNo] [int] NULL,
	[DaireNo] [int] NULL,
 CONSTRAINT [PK_IsYeriAdres] PRIMARY KEY CLUSTERED 
(
	[AdresId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 1/6/2020 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[KullaniciId] [int] IDENTITY(1,1) NOT NULL,
	[Isim] [nvarchar](50) NULL,
	[Soyisim] [nvarchar](50) NULL,
	[Sifre] [nvarchar](50) NULL,
	[Eposta] [nvarchar](50) NULL,
	[AdresId] [int] NULL,
	[Telefon] [nvarchar](50) NULL,
	[SonGirisSaati] [time](7) NULL,
	[YetkiliId] [int] NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[KullaniciId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Puan]    Script Date: 1/6/2020 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Puan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[IsyeriId] [int] NULL,
	[puan] [int] NULL,
 CONSTRAINT [PK_Puan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Randevu]    Script Date: 1/6/2020 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Randevu](
	[RandevuId] [int] IDENTITY(1,1) NOT NULL,
	[IsyeriId] [int] NULL,
	[KullaniciId] [int] NULL,
	[RandevuSaat] [nvarchar](30) NULL,
	[RandevuTarih] [nvarchar](30) NULL,
	[RandevuOnay] [bit] NULL,
 CONSTRAINT [PK_Randevu] PRIMARY KEY CLUSTERED 
(
	[RandevuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SoruCevap]    Script Date: 1/6/2020 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SoruCevap](
	[SoruId] [int] IDENTITY(1,1) NOT NULL,
	[IsyeriId] [int] NULL,
	[KullaniciId] [int] NULL,
	[SoruMetni] [text] NULL,
	[CevapMetni] [text] NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_SoruCevap] PRIMARY KEY CLUSTERED 
(
	[SoruId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yetkili]    Script Date: 1/6/2020 3:06:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yetkili](
	[YetkiliId] [int] IDENTITY(1,1) NOT NULL,
	[Isim] [nvarchar](50) NULL,
	[Soyisim] [nvarchar](50) NULL,
	[Sifre] [nvarchar](50) NULL,
	[Telefon] [nvarchar](50) NULL,
	[DogumTarihi] [nvarchar](50) NULL,
	[TcKimlikNo] [nvarchar](50) NULL,
	[IsyeriId] [int] NULL,
	[AdresId] [int] NULL,
	[YetkiOnay] [bit] NULL,
 CONSTRAINT [PK_Yetkili] PRIMARY KEY CLUSTERED 
(
	[YetkiliId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Admin] ([AdminId], [Sifre]) VALUES (N'admin', N'0000                ')
INSERT [dbo].[Bilgiler] ([IsyeriId], [IsyeriAdi], [CalisanBilgi], [FirmaGecmisi], [RandevuDetayi], [Il], [Ilce], [Sokak], [No], [Tel], [Email], [router]) VALUES (8, N'Mest Cafe', N'Firmada 4 asçi, 1 sef, 5 komi, 1 vale olmak üzere toplamda 11 kisi çalismaktadir. Özellikle Diaz sefin dikkat çektigi Mest Cafe de müsteriler çalisanlardan oldukça memnun ayriliyor. ', N'Mest Cafe 21 eylül 1998''de Ahmet Raif tarafindan kuruldu. Bu günlerde Oglu Ayhan  Raif Tarafindan yönetilern Mest Cafe ayni zamanda 5 subeye sahiptir. ', N'Randevularimiz Hafta içi sabah 8.00 ile 17.00 arasinda bulunmaktadir. Ayni zamanda 12.00 ile 13.00 arasinda da randevu vermiyoruz.', N'Izmir', N'Konak', N'9132', N'12', N'0212 323 23 32', N'mest@gmail.com', N'mestcafe')
INSERT [dbo].[Bilgiler] ([IsyeriId], [IsyeriAdi], [CalisanBilgi], [FirmaGecmisi], [RandevuDetayi], [Il], [Ilce], [Sokak], [No], [Tel], [Email], [router]) VALUES (9, N'Hilton Otel', N'Hilton toplamda 12.000 den fazla elemana sahiptir. Çok fazla subeye sahip oldugu için 12.000 den fazla elemanla hizmet veriyor olmasi hiç de sasirtici degil.', N'Conrad Hilton, ‘En Muhtesem Otel’ olarak bilinen, New York’taki Waldorf Astoria’yi satin aldi. Onun bagliliginin, liderliginin ve yenilikçiliginin bir sonucu olarak bugün Hilton büyük bir dev olmakta.', N'Randevularimiz Hafta içi sabah 8.00 ile 17.00 arasinda bulunmaktadir. Ayni zamanda 12.00 ile 13.00 arasinda da randevu vermiyoruz.', N'Izmir', N'Konak', N'9132', N'11', N'212 66 66', N'hilton@gmail.com', N'hilton')
INSERT [dbo].[Bilgiler] ([IsyeriId], [IsyeriAdi], [CalisanBilgi], [FirmaGecmisi], [RandevuDetayi], [Il], [Ilce], [Sokak], [No], [Tel], [Email], [router]) VALUES (10, N'Batıgoz Hastahane', N'Batigöz Saglik Grubu sadece Türkiye''de 4.600 çalisan bünyesinde barindirmaktadir. Unutulmamalidir ki Bati Göz sadece Türkiye''de hizmet vermemektedir.', N'2004 yilinda Izmir''de kurulan Batigöz Saglik Grubu, göz sagligi alaninda kaliteli hizmet anlayisi ile büyümeye devam etmektedir', N'Randevularimiz Hafta içi sabah 8.00 ile 17.00 arasinda bulunmaktadir. Ayni zamanda 12.00 ile 13.00 arasinda da randevu vermiyoruz.', N'Izmir', N'Karabaglar', N'2131', N'32', N'212 43 34', N'batigoz@gmail.com', N'batigoz')
INSERT [dbo].[Bilgiler] ([IsyeriId], [IsyeriAdi], [CalisanBilgi], [FirmaGecmisi], [RandevuDetayi], [Il], [Ilce], [Sokak], [No], [Tel], [Email], [router]) VALUES (11, N'Deniz Restorant', N'Firmada 3 asçi, 2 sef, 6 komi, 3 vale olmak üzere toplamda 14 kisi çalismaktadir. Özellikle Ahmet sefin dikkat çektigi Mest Cafe de müsteriler çalisanlardan oldukça memnun ayriliyor.', N'Deniz Restoran 12 ekim 1978''de Ali Keser tarafindan kuruldu. Bu günlerde Oglu Mehmet Keser Tarafindan yönetilern Deniz Restoran ayni zamanda 2 subeye sahiptir.', N'Randevularimiz Hafta içi sabah 8.00 ile 17.00 arasinda bulunmaktadir. Ayni zamanda 12.00 ile 13.00 arasinda da randevu vermiyoruz.', N'Istanbul', N'Kadiköy', N'3423', N'23', N'323 32 23', N'denizRestoran@gmail.com', N'denizRestorant')
INSERT [dbo].[Bilgiler] ([IsyeriId], [IsyeriAdi], [CalisanBilgi], [FirmaGecmisi], [RandevuDetayi], [Il], [Ilce], [Sokak], [No], [Tel], [Email], [router]) VALUES (12, N'Fen Bilimleri', N'Fen Bilimleri toplamda 2.000 den fazla ögretim Görevlisine sahiptir. Çok fazla subeye sahip oldugu için 2.000 den fazla elemanla hizmet veriyor olmasi hiç de sasirtici degil.', N'1965 yilinda kurulan Fen Bilimleri Dershanesi kuruldu.Istanbul-Besiktas’ta tek sube olarak faaliyetini sürdüren Fen Bilimleri,Nazmi ARIKAN tarafindan 1997 yilinda devralindiktan sonra 1999 yilinda Bakirköy’de,2000 yilinda Kadiköy’de yeni subelerini açti.', N'Randevularimiz Hafta içi sabah 8.00 ile 17.00 arasinda bulunmaktadir. Ayni zamanda 12.00 ile 13.00 arasinda da randevu vermiyoruz.', N'Izmir', N'Çankaya', N'5644', N'54', N'212 43 43', N'fenbilileri@gmail.com', N'fenBilimleri')
INSERT [dbo].[Bilgiler] ([IsyeriId], [IsyeriAdi], [CalisanBilgi], [FirmaGecmisi], [RandevuDetayi], [Il], [Ilce], [Sokak], [No], [Tel], [Email], [router]) VALUES (13, N'Avrupadent Diş', N'Türkiye''de 2.600 çalisan bünyesinde barindirmaktadir. Unutulmamalidir ki Bati Göz sadece Türkiye''de hizmet vermemektedir.Çalisanlari Genellikle çok memnundur.', N'2002 yilinda Istanbul''da kurulan Avrupadent , Dis sagligi alaninda kaliteli hizmet anlayisi ile büyümeye devam etmektedir', N'Randevularimiz Hafta içi sabah 8.00 ile 17.00 arasinda bulunmaktadir. Ayni zamanda 12.00 ile 13.00 arasinda da randevu vermiyoruz.', N'Izmir ', N'Karsiyaka', N'922', N'1', N'212 12 12', NULL, N'Avrupadent')
INSERT [dbo].[Bilgiler] ([IsyeriId], [IsyeriAdi], [CalisanBilgi], [FirmaGecmisi], [RandevuDetayi], [Il], [Ilce], [Sokak], [No], [Tel], [Email], [router]) VALUES (14, N'Mona Psikoloji', N'Toplamda 421 çalisani bulunan Mona Psikoloji, genellikle alaninda uzman kisilerden olusan saygin kisilerle hizmet vermektedir.', N'2001 yilinda Prof. Dr. Ahmet Berrak tarafindan kurulan kurum hizla büyüyerek günümüzde en iyi psikoloji kurumlari içinde gösterilmektedir.', N'Randevularimiz Hafta içi sabah 8.00 ile 17.00 arasinda bulunmaktadir. Ayni zamanda 12.00 ile 13.00 arasinda da randevu vermiyoruz.', N'Izmir ', N'Buca', N'1342', N'43', N'212 32 23', N'mona@gmial.com', N'monaPsikoloj')
INSERT [dbo].[Bilgiler] ([IsyeriId], [IsyeriAdi], [CalisanBilgi], [FirmaGecmisi], [RandevuDetayi], [Il], [Ilce], [Sokak], [No], [Tel], [Email], [router]) VALUES (15, N'Mövenpick Otel', N'Mövenpick toplamda 3.000 den fazla elemana sahiptir. Çok fazla subeye sahip oldugu sölenemez ve genelde tatil yerlerinde bulunmaktadir.', N'Mövenpick ilk olarak Avrupada subeler açmis  2013 yilindan itibaren ise  Türkiye''de hizmet vermeye baslamistir. Ilk kurulus yili ise 12 haziran 1933 tür.', N'Randevularimiz Hafta içi sabah 8.00 ile 17.00 arasinda bulunmaktadir. Ayni zamanda 12.00 ile 13.00 arasinda da randevu vermiyoruz.', N'Izmir ', N'Alsancak', N'92', N'34', N'212 11 11', N'mövenpick@gmail.com', N'movenpick')
INSERT [dbo].[Bilgiler] ([IsyeriId], [IsyeriAdi], [CalisanBilgi], [FirmaGecmisi], [RandevuDetayi], [Il], [Ilce], [Sokak], [No], [Tel], [Email], [router]) VALUES (16, N'Tüvtürk Araç Muayene', N'Tüvtürk genel olarak uzmanlardan olusan 1.100 kisilik bir ekibe sahiptir. Çalisanlarinin alaninda uzman olmasi neden bu kadar tercih edildigini çok güzel açikliyor.', N'2001 yilinda Istanbul''da açilan TüvTürk, olarak alaninda tek oldugu için hizlica subeler açarak Türkiye''nin her yerine yerlesmis ve araç konusunda uzmanlasmislardir.', N'Randevularimiz Hafta içi sabah 8.00 ile 17.00 arasinda bulunmaktadir. Ayni zamanda 12.00 ile 13.00 arasinda da randevu vermiyoruz.', N'Izmir ', N'Gaziemir', N'332', N'4', N'212 44 33', N'tüvürk@gmail.com', N'tuvturkAracMuayene')
INSERT [dbo].[Bilgiler] ([IsyeriId], [IsyeriAdi], [CalisanBilgi], [FirmaGecmisi], [RandevuDetayi], [Il], [Ilce], [Sokak], [No], [Tel], [Email], [router]) VALUES (16, N'deniztec', N'denmee ', N'deneme', N'denmee ', N'deneme', N'deneme', N'12', N'12', N'21312123', N'tunikbutik@gmail.com', N'deniztec')
INSERT [dbo].[Bilgiler] ([IsyeriId], [IsyeriAdi], [CalisanBilgi], [FirmaGecmisi], [RandevuDetayi], [Il], [Ilce], [Sokak], [No], [Tel], [Email], [router]) VALUES (38, N'tunaytec', N'calisan bilgisi', N'tunaytec 2019 yilinda kurulmustur iyi bir firmadir.', N'randevu detayi', N'izmir', N'karabaglar', N'12', N'12', N'21312123', N'tunikbutik@gmail.com', N'tunaytec')
INSERT [dbo].[Bilgiler] ([IsyeriId], [IsyeriAdi], [CalisanBilgi], [FirmaGecmisi], [RandevuDetayi], [Il], [Ilce], [Sokak], [No], [Tel], [Email], [router]) VALUES (37, N'deniztec', N'jkadshk', N'dslakjkasdh', N'jkash', N'jkash', N'hkajh', N'1', N'1', N'2', N'tunikbutik@gmail.com', N'deniztec')
SET IDENTITY_INSERT [dbo].[IsYeri] ON 

INSERT [dbo].[IsYeri] ([IsyeriId], [IsYeriAdi], [KategoriId], [YetkiliId], [AdresId], [Telefon]) VALUES (8, N'mest', NULL, 5, 1, N'0232 121 21 21      ')
INSERT [dbo].[IsYeri] ([IsyeriId], [IsYeriAdi], [KategoriId], [YetkiliId], [AdresId], [Telefon]) VALUES (9, N'hilton', NULL, 6, NULL, N'0232 231 32 32      ')
INSERT [dbo].[IsYeri] ([IsyeriId], [IsYeriAdi], [KategoriId], [YetkiliId], [AdresId], [Telefon]) VALUES (10, N'batıgoz', NULL, 7, NULL, NULL)
INSERT [dbo].[IsYeri] ([IsyeriId], [IsYeriAdi], [KategoriId], [YetkiliId], [AdresId], [Telefon]) VALUES (11, N'deniz', NULL, 8, NULL, NULL)
INSERT [dbo].[IsYeri] ([IsyeriId], [IsYeriAdi], [KategoriId], [YetkiliId], [AdresId], [Telefon]) VALUES (12, N'fenbilimleri', NULL, 9, NULL, NULL)
INSERT [dbo].[IsYeri] ([IsyeriId], [IsYeriAdi], [KategoriId], [YetkiliId], [AdresId], [Telefon]) VALUES (13, N'avrupadent', NULL, 10, NULL, NULL)
INSERT [dbo].[IsYeri] ([IsyeriId], [IsYeriAdi], [KategoriId], [YetkiliId], [AdresId], [Telefon]) VALUES (14, N'mona', NULL, 11, NULL, NULL)
INSERT [dbo].[IsYeri] ([IsyeriId], [IsYeriAdi], [KategoriId], [YetkiliId], [AdresId], [Telefon]) VALUES (15, N'movenpick', NULL, 12, NULL, NULL)
INSERT [dbo].[IsYeri] ([IsyeriId], [IsYeriAdi], [KategoriId], [YetkiliId], [AdresId], [Telefon]) VALUES (16, N'tuvturk', NULL, 13, NULL, NULL)
INSERT [dbo].[IsYeri] ([IsyeriId], [IsYeriAdi], [KategoriId], [YetkiliId], [AdresId], [Telefon]) VALUES (36, N'deniztec', NULL, 38, NULL, NULL)
INSERT [dbo].[IsYeri] ([IsyeriId], [IsYeriAdi], [KategoriId], [YetkiliId], [AdresId], [Telefon]) VALUES (37, N'deniztec', NULL, 39, NULL, NULL)
INSERT [dbo].[IsYeri] ([IsyeriId], [IsYeriAdi], [KategoriId], [YetkiliId], [AdresId], [Telefon]) VALUES (38, N'tunaytec', NULL, 40, NULL, NULL)
SET IDENTITY_INSERT [dbo].[IsYeri] OFF
SET IDENTITY_INSERT [dbo].[IsYeriAdres] ON 

INSERT [dbo].[IsYeriAdres] ([AdresId], [Il], [Ilce], [Sokak], [KapiNo], [DaireNo]) VALUES (1, N'izmir', N'buca', N'92311', 12, 1)
INSERT [dbo].[IsYeriAdres] ([AdresId], [Il], [Ilce], [Sokak], [KapiNo], [DaireNo]) VALUES (2, N'izmir', N'konak', N'9989', 98, 8)
INSERT [dbo].[IsYeriAdres] ([AdresId], [Il], [Ilce], [Sokak], [KapiNo], [DaireNo]) VALUES (3, N'izmir', N'aliağa', N'1231', 2, 12)
INSERT [dbo].[IsYeriAdres] ([AdresId], [Il], [Ilce], [Sokak], [KapiNo], [DaireNo]) VALUES (4, N'istanbul', N'kadıköy', N'3242', 3, 3)
INSERT [dbo].[IsYeriAdres] ([AdresId], [Il], [Ilce], [Sokak], [KapiNo], [DaireNo]) VALUES (5, N'izmir', N'alsancak', N'3242', 3, 3)
INSERT [dbo].[IsYeriAdres] ([AdresId], [Il], [Ilce], [Sokak], [KapiNo], [DaireNo]) VALUES (6, N'izmir', N'bostanlı', N'3223', 34, 43)
SET IDENTITY_INSERT [dbo].[IsYeriAdres] OFF
SET IDENTITY_INSERT [dbo].[Kullanici] ON 

INSERT [dbo].[Kullanici] ([KullaniciId], [Isim], [Soyisim], [Sifre], [Eposta], [AdresId], [Telefon], [SonGirisSaati], [YetkiliId]) VALUES (3, N'a', N'bb', N'1111', N'aa@gmail.com', NULL, N'0543 434 43', NULL, NULL)
INSERT [dbo].[Kullanici] ([KullaniciId], [Isim], [Soyisim], [Sifre], [Eposta], [AdresId], [Telefon], [SonGirisSaati], [YetkiliId]) VALUES (4, N'b', N'cc', N'2222', N'bb@gmail.com', NULL, N'9840328402', NULL, NULL)
INSERT [dbo].[Kullanici] ([KullaniciId], [Isim], [Soyisim], [Sifre], [Eposta], [AdresId], [Telefon], [SonGirisSaati], [YetkiliId]) VALUES (5, N'ali', N'deniz', N'0000', N'ali@gmail.com', NULL, N'4329749823', NULL, NULL)
INSERT [dbo].[Kullanici] ([KullaniciId], [Isim], [Soyisim], [Sifre], [Eposta], [AdresId], [Telefon], [SonGirisSaati], [YetkiliId]) VALUES (6, N'veli', N'kul', N'9999', N'veli@gmail.com', NULL, N'0545 545 54 54', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
SET IDENTITY_INSERT [dbo].[Puan] ON 

INSERT [dbo].[Puan] ([id], [IsyeriId], [puan]) VALUES (3, 15, 5)
INSERT [dbo].[Puan] ([id], [IsyeriId], [puan]) VALUES (4, 16, 1)
INSERT [dbo].[Puan] ([id], [IsyeriId], [puan]) VALUES (5, 8, 1)
INSERT [dbo].[Puan] ([id], [IsyeriId], [puan]) VALUES (6, 16, 5)
SET IDENTITY_INSERT [dbo].[Puan] OFF
SET IDENTITY_INSERT [dbo].[Randevu] ON 

INSERT [dbo].[Randevu] ([RandevuId], [IsyeriId], [KullaniciId], [RandevuSaat], [RandevuTarih], [RandevuOnay]) VALUES (21, 8, 3, N'11.00 - 12.00', N'12.12.2019', 1)
INSERT [dbo].[Randevu] ([RandevuId], [IsyeriId], [KullaniciId], [RandevuSaat], [RandevuTarih], [RandevuOnay]) VALUES (22, 9, 3, N'9.00 - 10.00', N'01.01.2019', 1)
INSERT [dbo].[Randevu] ([RandevuId], [IsyeriId], [KullaniciId], [RandevuSaat], [RandevuTarih], [RandevuOnay]) VALUES (23, 8, 4, N'14.00 - 15.00', N'01.02.2019', 1)
INSERT [dbo].[Randevu] ([RandevuId], [IsyeriId], [KullaniciId], [RandevuSaat], [RandevuTarih], [RandevuOnay]) VALUES (25, 16, 3, N'10.00 - 11.00', N'12.12.2019', NULL)
INSERT [dbo].[Randevu] ([RandevuId], [IsyeriId], [KullaniciId], [RandevuSaat], [RandevuTarih], [RandevuOnay]) VALUES (26, 16, 4, N'13.00 - 14.00', N'16.12.2019', NULL)
INSERT [dbo].[Randevu] ([RandevuId], [IsyeriId], [KullaniciId], [RandevuSaat], [RandevuTarih], [RandevuOnay]) VALUES (31, 9, 3, N'10.00 - 11.00', N'16.1.2020', NULL)
INSERT [dbo].[Randevu] ([RandevuId], [IsyeriId], [KullaniciId], [RandevuSaat], [RandevuTarih], [RandevuOnay]) VALUES (32, 16, 3, N'16.00 - 17.00', N'25.3.2020', NULL)
SET IDENTITY_INSERT [dbo].[Randevu] OFF
SET IDENTITY_INSERT [dbo].[SoruCevap] ON 

INSERT [dbo].[SoruCevap] ([SoruId], [IsyeriId], [KullaniciId], [SoruMetni], [CevapMetni], [Durum]) VALUES (1, 8, 3, N'fiyatlar ne kadar?', NULL, 1)
INSERT [dbo].[SoruCevap] ([SoruId], [IsyeriId], [KullaniciId], [SoruMetni], [CevapMetni], [Durum]) VALUES (2, 8, 4, N'ne zaman kapaniyor?', NULL, 1)
INSERT [dbo].[SoruCevap] ([SoruId], [IsyeriId], [KullaniciId], [SoruMetni], [CevapMetni], [Durum]) VALUES (3, 9, 3, N'nasilsiniz', NULL, 1)
SET IDENTITY_INSERT [dbo].[SoruCevap] OFF
SET IDENTITY_INSERT [dbo].[Yetkili] ON 

INSERT [dbo].[Yetkili] ([YetkiliId], [Isim], [Soyisim], [Sifre], [Telefon], [DogumTarihi], [TcKimlikNo], [IsyeriId], [AdresId], [YetkiOnay]) VALUES (5, N'ymest', N'ymest', N'1234', N'0543910293', N'12.12.1990', N'233434232', 8, NULL, 1)
INSERT [dbo].[Yetkili] ([YetkiliId], [Isim], [Soyisim], [Sifre], [Telefon], [DogumTarihi], [TcKimlikNo], [IsyeriId], [AdresId], [YetkiOnay]) VALUES (6, N'yhilton', N'yhilton', N'0000', N'0532983289', N'11.11.1990', N'321321321', 9, NULL, 1)
INSERT [dbo].[Yetkili] ([YetkiliId], [Isim], [Soyisim], [Sifre], [Telefon], [DogumTarihi], [TcKimlikNo], [IsyeriId], [AdresId], [YetkiOnay]) VALUES (7, N'ybatıgoz', N'ybatıgoz', N'0000', N'0532432432', N'10.10.1989', N'231331231', 10, NULL, 1)
INSERT [dbo].[Yetkili] ([YetkiliId], [Isim], [Soyisim], [Sifre], [Telefon], [DogumTarihi], [TcKimlikNo], [IsyeriId], [AdresId], [YetkiOnay]) VALUES (8, N'ydeniz', N'ydeniz', N'0000', N'0532232322', N'09.09.1987', N'232342423', 11, NULL, 1)
INSERT [dbo].[Yetkili] ([YetkiliId], [Isim], [Soyisim], [Sifre], [Telefon], [DogumTarihi], [TcKimlikNo], [IsyeriId], [AdresId], [YetkiOnay]) VALUES (9, N'yfenbilimleri', N'yfenbilimleri', N'0000', N'0543543319', N'08.08.1978', N'384827843', 12, NULL, 1)
INSERT [dbo].[Yetkili] ([YetkiliId], [Isim], [Soyisim], [Sifre], [Telefon], [DogumTarihi], [TcKimlikNo], [IsyeriId], [AdresId], [YetkiOnay]) VALUES (10, N'yavrupadent', N'yavrupadent', N'0000', N'0902342304', N'09.09.1991', N'234214312', 13, NULL, NULL)
INSERT [dbo].[Yetkili] ([YetkiliId], [Isim], [Soyisim], [Sifre], [Telefon], [DogumTarihi], [TcKimlikNo], [IsyeriId], [AdresId], [YetkiOnay]) VALUES (11, N'ymona ', N'ymona ', N'0000', N'9908390284', N'09.09.1991', N'382998232', 14, NULL, NULL)
INSERT [dbo].[Yetkili] ([YetkiliId], [Isim], [Soyisim], [Sifre], [Telefon], [DogumTarihi], [TcKimlikNo], [IsyeriId], [AdresId], [YetkiOnay]) VALUES (12, N'ymovenpick', N'ymovenpick', N'0000', N'3824982378', N'11.11.1991', N'231142322', 15, NULL, NULL)
INSERT [dbo].[Yetkili] ([YetkiliId], [Isim], [Soyisim], [Sifre], [Telefon], [DogumTarihi], [TcKimlikNo], [IsyeriId], [AdresId], [YetkiOnay]) VALUES (13, N'ytuvturk', N'ytuvturk', N'0000', N'3244802332', N'11.11.1990', N'213123113', 16, NULL, NULL)
INSERT [dbo].[Yetkili] ([YetkiliId], [Isim], [Soyisim], [Sifre], [Telefon], [DogumTarihi], [TcKimlikNo], [IsyeriId], [AdresId], [YetkiOnay]) VALUES (38, N'muhammed', N'deniz', N'0000', N'123412', N'12.32.321', NULL, 16, NULL, NULL)
INSERT [dbo].[Yetkili] ([YetkiliId], [Isim], [Soyisim], [Sifre], [Telefon], [DogumTarihi], [TcKimlikNo], [IsyeriId], [AdresId], [YetkiOnay]) VALUES (39, N'dklsa', N'kladsj', N'0000', N'123412', N'12.32.23', NULL, 37, NULL, NULL)
INSERT [dbo].[Yetkili] ([YetkiliId], [Isim], [Soyisim], [Sifre], [Telefon], [DogumTarihi], [TcKimlikNo], [IsyeriId], [AdresId], [YetkiOnay]) VALUES (40, N'tunay', N'toksöz', N'1234', N'123412', N'12.32.321', NULL, 38, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Yetkili] OFF
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD  CONSTRAINT [FK_Admin_Admin] FOREIGN KEY([AdminId])
REFERENCES [dbo].[Admin] ([AdminId])
GO
ALTER TABLE [dbo].[Admin] CHECK CONSTRAINT [FK_Admin_Admin]
GO
ALTER TABLE [dbo].[IsYeri]  WITH CHECK ADD  CONSTRAINT [FK_IsYeri_IsYeriAdres_AdresId] FOREIGN KEY([AdresId])
REFERENCES [dbo].[IsYeriAdres] ([AdresId])
GO
ALTER TABLE [dbo].[IsYeri] CHECK CONSTRAINT [FK_IsYeri_IsYeriAdres_AdresId]
GO
ALTER TABLE [dbo].[IsYeri]  WITH CHECK ADD  CONSTRAINT [FK_IsYeri_Yetkili_YetkiliId] FOREIGN KEY([YetkiliId])
REFERENCES [dbo].[Yetkili] ([YetkiliId])
GO
ALTER TABLE [dbo].[IsYeri] CHECK CONSTRAINT [FK_IsYeri_Yetkili_YetkiliId]
GO
ALTER TABLE [dbo].[Kullanici]  WITH CHECK ADD  CONSTRAINT [FK_Kullanici_Kullanici_AdresId] FOREIGN KEY([AdresId])
REFERENCES [dbo].[Adres] ([AdresId])
GO
ALTER TABLE [dbo].[Kullanici] CHECK CONSTRAINT [FK_Kullanici_Kullanici_AdresId]
GO
ALTER TABLE [dbo].[Kullanici]  WITH CHECK ADD  CONSTRAINT [FK_Kullanici_Yetkili_YetkiliId] FOREIGN KEY([YetkiliId])
REFERENCES [dbo].[Yetkili] ([YetkiliId])
GO
ALTER TABLE [dbo].[Kullanici] CHECK CONSTRAINT [FK_Kullanici_Yetkili_YetkiliId]
GO
ALTER TABLE [dbo].[Randevu]  WITH CHECK ADD  CONSTRAINT [FK_Randevu_IsYeri_isyeriId] FOREIGN KEY([IsyeriId])
REFERENCES [dbo].[IsYeri] ([IsyeriId])
GO
ALTER TABLE [dbo].[Randevu] CHECK CONSTRAINT [FK_Randevu_IsYeri_isyeriId]
GO
ALTER TABLE [dbo].[Randevu]  WITH CHECK ADD  CONSTRAINT [FK_Randevu_Kullanici_KullaniciId] FOREIGN KEY([KullaniciId])
REFERENCES [dbo].[Kullanici] ([KullaniciId])
GO
ALTER TABLE [dbo].[Randevu] CHECK CONSTRAINT [FK_Randevu_Kullanici_KullaniciId]
GO
ALTER TABLE [dbo].[SoruCevap]  WITH CHECK ADD  CONSTRAINT [FK_SoruCevap_IsYeri_KullaniciId] FOREIGN KEY([KullaniciId])
REFERENCES [dbo].[Kullanici] ([KullaniciId])
GO
ALTER TABLE [dbo].[SoruCevap] CHECK CONSTRAINT [FK_SoruCevap_IsYeri_KullaniciId]
GO
ALTER TABLE [dbo].[Yetkili]  WITH CHECK ADD  CONSTRAINT [FK_Yetkili_Adres_AdresId] FOREIGN KEY([AdresId])
REFERENCES [dbo].[Adres] ([AdresId])
GO
ALTER TABLE [dbo].[Yetkili] CHECK CONSTRAINT [FK_Yetkili_Adres_AdresId]
GO
USE [master]
GO
ALTER DATABASE [eRandevum] SET  READ_WRITE 
GO
