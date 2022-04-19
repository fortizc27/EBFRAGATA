CREATE PROCEDURE [dbo].[RolesInsertar]
	@NombreRol varchar(20),
	@Usuarios bit,
	@Roles bit,
	@Clientes bit,
	@FichasTecnicas bit,
	@Peleas bit,
	@Reportes bit,
	@Bitacoras bit,
	@Estado bit
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
		
		INSERT INTO dbo.Roles
		(
		NombreRol,
		Usuarios,
		Roles,
		Clientes,
		FichasTecnicas,
		Peleas,
		Reportes,
		Bitacoras,
		Estado
		)
		VALUES
		(
		@NombreRol,
		@Usuarios,
		@Roles,
		@Clientes,
		@FichasTecnicas,
		@Peleas,
		@Reportes,
		@Bitacoras,
		@Estado
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
