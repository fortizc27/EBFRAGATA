CREATE PROCEDURE [dbo].[FichaTecInsertar]
	@Fecha date,
	@Nombre varchar(50),
    @IdAtleta int,
	@Padecimientos varchar(255),
	@Peso int,
	@Altura int,
	@Lateralidad varchar(20),	
	@Alcance int,
	@Talla varchar(10),
	@Pecho int,
	@Abdomen int,
	@Gluteo int,
	@BicepD int,
	@BicepI int,
	@MusloD int,
	@MusloI int,
	@PantorrillaD int,	
	@PantorrillaI int

AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
		
		INSERT INTO dbo.FichasTecnicas
		(
		Fecha,
		Nombre,
		IdAtleta,
		Padecimientos,
		Peso,
		Altura,
		Lateralidad,	
		Alcance,
		Talla,
		Pecho,
		Abdomen,
		Gluteo,
		BicepD,
		BicepI,
		MusloD,
		MusloI,
		PantorrillaD,	
		PantorrillaI
		)
		VALUES
		(
		@Fecha,
		@Nombre,
		@IdAtleta,
		@Padecimientos,
		@Peso,
		@Altura,
		@Lateralidad,	
		@Alcance,
		@Talla,
		@Pecho,
		@Abdomen,
		@Gluteo,
		@BicepD,
		@BicepI,
		@MusloD,
		@MusloI,
		@PantorrillaD,	
		@PantorrillaI
		)

		UPDATE Clientes
		SET Peso = @Peso
		WHERE IdCliente = @IdAtleta

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
