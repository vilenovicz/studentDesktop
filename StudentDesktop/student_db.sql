USE [master]
GO
/****** Object:  Database [student]    Script Date: 06.12.2019 17:20:28 ******/
CREATE DATABASE [student]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'student', FILENAME = N'd:\dbdata\student.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'student_log', FILENAME = N'd:\dbdata\student_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [student] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [student].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [student] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [student] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [student] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [student] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [student] SET ARITHABORT OFF 
GO
ALTER DATABASE [student] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [student] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [student] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [student] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [student] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [student] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [student] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [student] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [student] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [student] SET  DISABLE_BROKER 
GO
ALTER DATABASE [student] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [student] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [student] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [student] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [student] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [student] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [student] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [student] SET RECOVERY FULL 
GO
ALTER DATABASE [student] SET  MULTI_USER 
GO
ALTER DATABASE [student] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [student] SET DB_CHAINING OFF 
GO
ALTER DATABASE [student] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [student] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [student] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'student', N'ON'
GO
ALTER DATABASE [student] SET QUERY_STORE = OFF
GO
USE [student]
GO
/****** Object:  UserDefinedFunction [dbo].[ufnGetCompetenceList]    Script Date: 06.12.2019 17:20:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[ufnGetCompetenceList]
(
	-- Add the parameters for the function here
	@person_id int
)
RETURNS varchar(max)
AS
BEGIN
	-- Declare the return variable here
	declare @comp_id int;

	declare @comp_code nvarchar(20), @comp_list varchar(max);
	set @comp_code = '';
	set @comp_list = '';


	-- Add the T-SQL statements to compute the return value here


	declare comp cursor for
	select competenceId from person_competence where personid = @person_id;

	open comp
	fetch next from comp into @comp_id
	--set @comp_code = (select code from competences where id = @comp_id)
	--select @comp_list = @comp_list + @comp_code

	while @@fetch_status = 0
	begin
		set @comp_code = (select code from competences where id = @comp_id);
		if(@comp_list != '')
		begin
			set @comp_list = @comp_list + ', ' + @comp_code;
			--select @comp_list
		end
		else
			set @comp_list = @comp_code;
		fetch next from comp into @comp_id
	end
	close comp
	deallocate comp

	--select @comp_list

	-- Return the result of the function
	RETURN @comp_list

END
GO
/****** Object:  Table [dbo].[Competences]    Script Date: 06.12.2019 17:20:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Competences](
	[Id] [int] NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 06.12.2019 17:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[Id] [int] NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[person_competence]    Script Date: 06.12.2019 17:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[person_competence](
	[Id] [int] NOT NULL,
	[PersonId] [int] NOT NULL,
	[CompetenceId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persons]    Script Date: 06.12.2019 17:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[Id] [int] NOT NULL,
	[LastName] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[Birthday] [date] NULL,
	[DepartmentId] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Competences] ([Id], [Code], [Name]) VALUES (1, N'Tech:PC', N'Базовые компьютерные знания')
GO
INSERT [dbo].[Competences] ([Id], [Code], [Name]) VALUES (2, N'SQL:SS', N'SQL Server')
GO
INSERT [dbo].[Competences] ([Id], [Code], [Name]) VALUES (3, N'SQL:TSQL', N'T-SQL')
GO
INSERT [dbo].[Departments] ([Id], [Code], [Name]) VALUES (1, N'АУ', N'Аппарат управления')
GO
INSERT [dbo].[Departments] ([Id], [Code], [Name]) VALUES (2, N'ДСИ', N'Департамент системной интеграции')
GO
INSERT [dbo].[Departments] ([Id], [Code], [Name]) VALUES (3, N'КД', N'Департамент коммерции')
GO
INSERT [dbo].[person_competence] ([Id], [PersonId], [CompetenceId]) VALUES (1, 1, 1)
GO
INSERT [dbo].[person_competence] ([Id], [PersonId], [CompetenceId]) VALUES (2, 1, 2)
GO
INSERT [dbo].[person_competence] ([Id], [PersonId], [CompetenceId]) VALUES (3, 1, 3)
GO
INSERT [dbo].[Persons] ([Id], [LastName], [FirstName], [Birthday], [DepartmentId]) VALUES (1, N'Иванов', N'Иван', CAST(N'1978-08-08' AS Date), 1)
GO
INSERT [dbo].[Persons] ([Id], [LastName], [FirstName], [Birthday], [DepartmentId]) VALUES (2, N'Петров', N'Петр', CAST(N'1999-01-01' AS Date), 2)
GO
INSERT [dbo].[Persons] ([Id], [LastName], [FirstName], [Birthday], [DepartmentId]) VALUES (3, N'Сидоров', N'Сидор', CAST(N'1985-03-03' AS Date), 3)
GO
USE [master]
GO
ALTER DATABASE [student] SET  READ_WRITE 
GO
