CREATE PROCEDURE [dbo].[PeleaObtener]
	@IdAtleta INT=NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
		IdPelea,
		IdAtleta,
		Nombre,
		Fecha,
		Contrincante,
		Descripcion,
		Decision,
		Observaciones
	From dbo.Peleas
	where @IdAtleta is null or IdAtleta = @IdAtleta

END
GO
