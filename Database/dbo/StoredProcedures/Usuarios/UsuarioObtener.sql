CREATE PROCEDURE [dbo].[UsuarioObtener]
	@IdUsuario VARCHAR(20)=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
			U.IdUsuario,
			U.Usuario,
			U.Clave,
			U.Estado,
			U.Rol,
			R.NombreRol

	From dbo.Usuarios U
	INNER JOIN dbo.Roles R
	ON U.Rol = R.IdRol
	where @IdUsuario is null or IdUsuario = @IdUsuario

END
GO

