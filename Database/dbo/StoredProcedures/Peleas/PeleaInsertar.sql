CREATE PROCEDURE [dbo].[PeleaInsertar]
	@IdAtleta INT,
	@Nombre VARCHAR(50),
    @Fecha DATE,
	@Contrincante VARCHAR(50),
	@Descripcion VARCHAR(255),
	@Decision VARCHAR(50),
	@Observaciones varchar(255)

AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
		
		INSERT INTO dbo.Peleas
		(
		IdAtleta,
	    Nombre,
		Fecha,
		Contrincante,
		Descripcion,
		Decision,
		Observaciones
		)
		VALUES
		(
		@IdAtleta,
	    @Nombre,
		@Fecha,
		@Contrincante,
		@Descripcion,
		@Decision,
		@Observaciones
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
