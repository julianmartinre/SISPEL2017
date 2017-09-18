USE [master]
GO
CREATE DATABASE [SISPELDB]
GO
USE [SISPELDB]
GO
ALTER DATABASE [SISPELDB2017] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SISPELDB2017].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SISPELDB2017] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SISPELDB2017] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SISPELDB2017] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SISPELDB2017] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SISPELDB2017] SET ARITHABORT OFF 
GO
ALTER DATABASE [SISPELDB2017] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SISPELDB2017] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SISPELDB2017] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SISPELDB2017] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SISPELDB2017] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SISPELDB2017] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SISPELDB2017] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SISPELDB2017] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SISPELDB2017] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SISPELDB2017] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SISPELDB2017] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SISPELDB2017] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SISPELDB2017] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SISPELDB2017] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SISPELDB2017] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SISPELDB2017] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SISPELDB2017] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SISPELDB2017] SET RECOVERY FULL 
GO
ALTER DATABASE [SISPELDB2017] SET  MULTI_USER 
GO
ALTER DATABASE [SISPELDB2017] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SISPELDB2017] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SISPELDB2017] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SISPELDB2017] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SISPELDB2017] SET DELAYED_DURABILITY = DISABLED 
GO
USE [SISPELDB2017]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 18/09/2017 9:46:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleado](
	[empleado_nombre] [varchar](50) NOT NULL,
	[empleado_apellido] [varchar](50) NOT NULL,
	[empleado_dni] [int] NOT NULL,
	[empleado_activo] [bit] NOT NULL,
	[empleado_id] [int] IDENTITY(1,1) NOT NULL,
	[empleado_userName] [varchar](50) NOT NULL,
	[empleado_password] [varchar](50) NOT NULL,
	[empleado_fechaDeNacimiento] [date] NULL,
	[empleado_telefono] [int] NULL,
	[empleado_domicilio] [varchar](50) NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[empleado_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [SISPELDB2017] SET  READ_WRITE 
GO
