CREATE PROCEDURE [dbo].[FichaTecObtener]
	@IdAtleta INT=NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
		IdFicha,
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
	From dbo.FichasTecnicas
	where @IdAtleta is null or IdAtleta = @IdAtleta

END
GO