CREATE PROCEDURE [dbo].[BitacoraObtener]
	@IdBitacora INT=NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
		IdBItacora,
		Usuario,
		Registro,
		Accion
	From dbo.Bitacoras
	where @IdBitacora is null or IdBitacora = @IdBitacora

END
GO
