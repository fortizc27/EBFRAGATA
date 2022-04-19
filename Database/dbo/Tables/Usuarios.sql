﻿CREATE TABLE [dbo].[Usuarios]
(
	[IdUsuario] INT IDENTITY(1,1) NOT NULL,
	[Usuario] VARCHAR(20) NOT NULL,
	[Clave] NVARCHAR(4000) /*COLLATE Latin1_General_BIN2 ENCRYPTED WITH (COLUMN_ENCRYPTION_KEY = [CEK_Auto1], ENCRYPTION_TYPE = Deterministic, ALGORITHM = 'AEAD_AES_256_CBC_HMAC_SHA_256')*/ NOT NULL,
	[Rol] INT NOT NULL,
	[Estado] BIT NOT NULL

	CONSTRAINT [PK_TableUsuario] PRIMARY KEY CLUSTERED 
	(
		[IdUsuario] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY], 
    CONSTRAINT [FK_TableUsuarios_ToRoles] FOREIGN KEY ([Rol]) REFERENCES [Roles]([IdRol])
) ON [PRIMARY]
GO