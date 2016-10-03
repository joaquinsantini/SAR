USE [DBMUSERS]
GO

/****** Object:  Table [dbo].[Requerimientos]    Script Date: 2/10/2016 10:33:47 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Requerimientos](
	[Numero] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](63) NULL,
	[Detalle] [varchar](2046) NULL,
	[PSSolicitante] [varchar](255) NULL,
	[FAlta] [datetime] NULL DEFAULT (getdate()),
	[PSAlta] [varchar](255) NULL,
	[Prioridad] [varchar](255) NULL,
	[FEntrega_Estimada] [varchar](8) NULL,
	[FEntrega_Real] [varchar](8) NULL,
	[Estado] [varchar](255) NULL,
	[HorasCargadas] [int] NULL DEFAULT ((0)),
	[Carpeta] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


