CREATE PROCEDURE [dbo].[UsuarioInsertar]
	@Usuario varchar(20),
    @Clave nvarchar(4000),
	@Rol varchar(20),
	@Estado bit
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
		
		INSERT INTO dbo.Usuarios
		(
	    Usuario,
		Clave,
		Rol,
		Estado
		)
		VALUES
		(
	    @Usuario,
		@Clave,
		@Rol,
		@Estado
		)

		COMMIT TRANSACTION TRASA
		
		SELECT 0 AS CodeError, '' AS MsgError

	END TRY

	BEGIN CATCH
		SELECT 
				ERROR_NUMBER() AS CodeError
			,	ERROR_MESSAGE() AS MsgError

			ROLLBACK TRANSACTION TRASA
	END CATCH

END
GO