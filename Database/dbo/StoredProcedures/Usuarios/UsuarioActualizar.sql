CREATE PROCEDURE [dbo].[UsuarioActualizar]
	@IdUsuario int,
	@Usuario varchar(20),
    @Clave nvarchar(4000),
	@Rol int,
	@Estado bit
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
		
	UPDATE dbo.Usuarios SET
	Usuario=@Usuario,
    Clave=@Clave,
	Rol=@Rol,
	Estado=@Estado
	
	WHERE IdUsuario = @IdUsuario

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

