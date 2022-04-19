CREATE PROCEDURE [dbo].[RolesObtener]
	@IdRol INT=NULL
AS BEGIN
	SET NOCOUNT ON

	SELECT
		IdRol,
		NombreRol,
		Usuarios,
		Roles,
		Clientes,
		FichasTecnicas,
		Peleas,
		Bitacoras,
		Reportes,
		Estado
	From dbo.Roles
	where @IdRol is null or IdRol = @IdRol

END
GO
