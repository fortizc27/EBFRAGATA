CREATE PROCEDURE [dbo].[BitacoraInsertar]
	@Usuario VARCHAR(20),
	@Registro DATETIME,
	@Accion VARCHAR(255)

AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	INSERT INTO dbo.Bitacoras
		(
	    Usuario,
		Registro,
		Accion
		)
		VALUES
		(
	    @Usuario,
		@Registro,
		@Accion
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
