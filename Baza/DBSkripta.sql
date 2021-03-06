USE [master]
GO
/****** Object:  Database [1547_DB]    Script Date: 14.2.2017. 11:24:15 ******/
CREATE DATABASE [1547_DB] ON  PRIMARY 
( NAME = N'1547_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\1547_DB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'1547_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\1547_DB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [1547_DB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [1547_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [1547_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [1547_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [1547_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [1547_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [1547_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [1547_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [1547_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [1547_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [1547_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [1547_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [1547_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [1547_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [1547_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [1547_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [1547_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [1547_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [1547_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [1547_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [1547_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [1547_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [1547_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [1547_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [1547_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [1547_DB] SET  MULTI_USER 
GO
ALTER DATABASE [1547_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [1547_DB] SET DB_CHAINING OFF 
GO
USE [1547_DB]
GO
/****** Object:  User [1547_User]    Script Date: 14.2.2017. 11:24:16 ******/
CREATE USER [1547_User] FOR LOGIN [1547_User] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [1547_User]
GO
/****** Object:  Table [dbo].[Aktivnosti]    Script Date: 14.2.2017. 11:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aktivnosti](
	[sifra_aktivnosti] [char](5) NOT NULL,
	[naziv_aktivnosti] [char](20) NOT NULL,
 CONSTRAINT [PK_Aktivnosti] PRIMARY KEY CLUSTERED 
(
	[sifra_aktivnosti] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Osoba_Projekt]    Script Date: 14.2.2017. 11:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Osoba_Projekt](
	[mat_br] [int] NOT NULL,
	[sifra_projekta] [int] NOT NULL,
	[posto_place] [int] NOT NULL,
	[sifra_aktivnosti] [char](5) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Osobe]    Script Date: 14.2.2017. 11:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Osobe](
	[mat_br] [int] NOT NULL,
	[prezime_i_ime] [char](35) NOT NULL,
	[oib] [char](11) NOT NULL,
	[iznos_place] [decimal](6, 2) NOT NULL,
 CONSTRAINT [PK_Osobe] PRIMARY KEY CLUSTERED 
(
	[mat_br] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Plan_izvrsenja_projekta]    Script Date: 14.2.2017. 11:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plan_izvrsenja_projekta](
	[godina] [int] NOT NULL,
	[mjesec] [int] NOT NULL,
	[sifra_projekta] [int] NOT NULL,
	[mjes_budzet] [decimal](8, 2) NOT NULL,
	[mjesec_potroseno] [decimal](8, 2) NOT NULL,
	[status_pr] [char](4) NOT NULL,
 CONSTRAINT [IX_Plan_izvrsenja_projekta] UNIQUE CLUSTERED 
(
	[godina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Projekti]    Script Date: 14.2.2017. 11:24:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projekti](
	[sifra_projekta] [int] NOT NULL,
	[naziv_projekta] [char](35) NOT NULL,
	[opis_projekta] [char](200) NOT NULL,
	[pocetak_projekta] [date] NOT NULL,
	[zavrsetak_projekta] [date] NOT NULL,
	[budget] [decimal](9, 2) NOT NULL,
	[potroseno] [decimal](9, 2) NOT NULL,
 CONSTRAINT [PK_Projekti] PRIMARY KEY CLUSTERED 
(
	[sifra_projekta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Index [IX_Osoba_Projekt]    Script Date: 14.2.2017. 11:24:16 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Osoba_Projekt] ON [dbo].[Osoba_Projekt]
(
	[mat_br] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Plan_izvrsenja_projekta_1]    Script Date: 14.2.2017. 11:24:16 ******/
CREATE NONCLUSTERED INDEX [IX_Plan_izvrsenja_projekta_1] ON [dbo].[Plan_izvrsenja_projekta]
(
	[mjesec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Plan_izvrsenja_projekta_2]    Script Date: 14.2.2017. 11:24:16 ******/
CREATE NONCLUSTERED INDEX [IX_Plan_izvrsenja_projekta_2] ON [dbo].[Plan_izvrsenja_projekta]
(
	[sifra_projekta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Osoba_Projekt]  WITH CHECK ADD  CONSTRAINT [FK_Osoba_Projekt_Osobe] FOREIGN KEY([mat_br])
REFERENCES [dbo].[Osobe] ([mat_br])
GO
ALTER TABLE [dbo].[Osoba_Projekt] CHECK CONSTRAINT [FK_Osoba_Projekt_Osobe]
GO
ALTER TABLE [dbo].[Osoba_Projekt]  WITH CHECK ADD  CONSTRAINT [FK_Osoba_Projekt_Projekti] FOREIGN KEY([sifra_projekta])
REFERENCES [dbo].[Projekti] ([sifra_projekta])
GO
ALTER TABLE [dbo].[Osoba_Projekt] CHECK CONSTRAINT [FK_Osoba_Projekt_Projekti]
GO
ALTER TABLE [dbo].[Plan_izvrsenja_projekta]  WITH CHECK ADD  CONSTRAINT [FK_Plan_izvrsenja_projekta_Projekti] FOREIGN KEY([sifra_projekta])
REFERENCES [dbo].[Projekti] ([sifra_projekta])
GO
ALTER TABLE [dbo].[Plan_izvrsenja_projekta] CHECK CONSTRAINT [FK_Plan_izvrsenja_projekta_Projekti]
GO
ALTER TABLE [dbo].[Projekti]  WITH CHECK ADD  CONSTRAINT [FK_Projekti_Projekti] FOREIGN KEY([sifra_projekta])
REFERENCES [dbo].[Projekti] ([sifra_projekta])
GO
ALTER TABLE [dbo].[Projekti] CHECK CONSTRAINT [FK_Projekti_Projekti]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'primary key' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Projekti', @level2type=N'COLUMN',@level2name=N'sifra_projekta'
GO
USE [master]
GO
ALTER DATABASE [1547_DB] SET  READ_WRITE 
GO
