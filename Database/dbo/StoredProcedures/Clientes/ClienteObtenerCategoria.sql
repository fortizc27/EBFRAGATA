CREATE PROCEDURE [dbo].[ClienteObtenerCategoria]
	@Categoria VARCHAR(20)=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdCliente,
			Nombre,
			Peso,
			FechaNac

	From dbo.Clientes
	where Categoria = @Categoria

END
GO
