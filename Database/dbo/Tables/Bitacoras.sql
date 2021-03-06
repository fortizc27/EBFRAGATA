CREATE TABLE [dbo].[Bitacoras]
(
	[IdBitacora] INT IDENTITY(1,1) NOT NULL,
	[Usuario] VARCHAR(20) NOT NULL,
	[Registro] DATETIME NOT NULL,
	[Accion] VARCHAR(255) NOT NULL

	CONSTRAINT [PK_TableBitacoras] PRIMARY KEY CLUSTERED 
	(
		[IdBitacora] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
