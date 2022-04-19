CREATE PROCEDURE [dbo].[ClienteObtener]
	@IdCliente VARCHAR(50)=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
			IdCliente,
			Fecha,
			Categoria,
			Nombre,
			Genero,
			FechaNac,	
			Nacionalidad,
			Correo,
			Celular,
			Particular,
			Sangre,
			Direccion,
			NombreCE,
			IdCE,
			GeneroCE,
			FechaNacCE,	
			NacionalidadCE,
			CorreoCE,
			CelularCE,
			ParticularCE

	From dbo.Clientes
	where @IdCliente is null or IdCliente = @IdCliente

END
GO
