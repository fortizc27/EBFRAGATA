CREATE PROCEDURE [dbo].[RolesActualizar]
	@IdRol int,
    @NombreRol varchar(20),
	@Usuarios bit,
	@Roles bit,
	@Clientes bit,
	@FichasTecnicas bit,
	@Peleas bit,
	@Bitacoras bit,
	@Reportes bit,
	@Estado bit
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
		
	UPDATE dbo.Roles SET
		NombreRol=@NombreRol,
		Usuarios=@Usuarios,
		Roles=@Roles,
		Clientes=@Clientes,
		FichasTecnicas=@FichasTecnicas,
		Peleas=@Peleas,
		Bitacoras=@Bitacoras,
		Reportes=@Reportes,
		Estado=@Estado
	WHERE IdRol = @IdRol

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