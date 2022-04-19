﻿CREATE TABLE [dbo].[Roles]
(
	[IdRol] INT IDENTITY(1,1) NOT NULL,
	[NombreRol] VARCHAR(20) NOT NULL,
	[Usuarios] BIT NOT NULL,
	[Roles] BIT NOT NULL,
	[Clientes] BIT NOT NULL,
	[FichasTecnicas] BIT NOT NULL,
	[Peleas] BIT NOT NULL,
	[Reportes] BIT NOT NULL,
	[Bitacoras] BIT NOT NULL,
	[Estado] BIT NOT NULL

	CONSTRAINT [PK_TableRoles] PRIMARY KEY CLUSTERED 
	([IdRol])WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO