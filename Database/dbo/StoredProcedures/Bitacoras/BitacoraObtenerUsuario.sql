CREATE PROCEDURE [dbo].[BitacoraObtenerUsuario]
	@Usuario VARCHAR(20)=NULL,
	@FechaInicio DATE,
	@FechaFin DATE
AS BEGIN
	SET NOCOUNT ON

	SELECT
		IdBItacora,
		Usuario,
		Registro,
		Accion
	From dbo.Bitacoras
	where (@Usuario is null or Usuario = @Usuario) and (Registro >= @FechaInicio and Registro <= @FechaFin)

END
GO
