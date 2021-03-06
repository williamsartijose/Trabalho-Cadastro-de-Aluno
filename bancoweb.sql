USE [WEB]
GO
/****** Object:  Table [dbo].[Aluno]    Script Date: 15/10/2016 21:26:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Aluno](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NULL,
	[endereco] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[cidade] [varchar](50) NULL,
	[estado] [varchar](50) NULL,
 CONSTRAINT [PK_Aluno] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Avaliacao]    Script Date: 15/10/2016 21:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Avaliacao](
	[nota] [int] NOT NULL,
	[ano] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Curso]    Script Date: 15/10/2016 21:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[id] [int] NOT NULL,
	[descricao] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Funcionarioo]    Script Date: 15/10/2016 21:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionarioo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [nvarchar](50) NULL,
	[perfil] [nvarchar](50) NULL
) ON [PRIMARY]

GO
