CREATE PROCEDURE [dbo].[UsuarioLogin]
	@Usuario VARCHAR(20),	
	@Clave NVARCHAR(4000)
AS BEGIN
SET NOCOUNT ON

	--Si el usuario no existe, throw error
	IF NOT EXISTS(SELECT * FROM [dbo].[Usuarios] WHERE Usuario = @Usuario) BEGIN
		SELECT -1 AS CodeError, 'El nombre de usuario no existe' AS MsgError
	END
	--Si el usuario existe, pero la contrasena esta incorrecta, throw error
	ELSE IF  NOT EXISTS( SELECT * FROM [dbo].[Usuarios] WHERE Usuario = @Usuario AND Clave = @Clave) BEGIN
		SELECT -1 AS CodeError, 'La contraseña es incorrecta por favor volver a intentar' AS MsgError
	END
	--Si el usuario existe, tiene la contrasena correcta, pero esta inactivo
	ELSE IF NOT EXISTS( SELECT * FROM [dbo].[Usuarios] WHERE Usuario = @Usuario AND Clave = @Clave AND Estado = 'true') BEGIN
		SELECT -1 AS CodeError, 'Usuario deshabilitado' AS MsgError
	END
	--Si el rol esta inactivo
	ELSE IF NOT EXISTS( SELECT * FROM [dbo].[Roles] WHERE IdRol = (SELECT Rol FROM [dbo].[Usuarios] WHERE Usuario = @Usuario AND Clave = @Clave AND Estado = 'true') AND Estado = 'true') BEGIN
		SELECT -1 AS CodeError, 'Rol de usuario deshabilitado' AS MsgError
	END
	ELSE BEGIN
		SELECT  0 AS CodeError,
				Usuario,
				Clave,
				Rol
		FROM [dbo].[Usuarios] 
		WHERE Usuario = @Usuario AND
			  Clave = @Clave
	END
END