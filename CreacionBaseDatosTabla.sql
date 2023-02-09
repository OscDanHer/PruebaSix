GO
CREATE DATABASE PruebaSix;
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[usuID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[apellido] [varchar](100) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[usuID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Usuario] ([nombre], [apellido]) VALUES ('Oscar Daniel','Herrera Peñaloza')
GO
INSERT [dbo].[Usuario] ([nombre], [apellido]) VALUES ('William','Herrera')
GO
INSERT [dbo].[Usuario] ([nombre], [apellido]) VALUES ('Johanna','Peñaloza')
GO
INSERT [dbo].[Usuario] ([nombre], [apellido]) VALUES ('Daily','Martinez')
GO
INSERT [dbo].[Usuario] ([nombre], [apellido]) VALUES ('Javier','Peñaloza')
GO
