CREATE PROCEDURE [dbo].[ClienteInsertar]
	@IdCliente VARCHAR(50),
	@Fecha DATETIME,
    @Categoria VARCHAR(20),
	@Nombre VARCHAR(50),
	@Genero VARCHAR(20),
	@FechaNac DATETIME,	
	@Nacionalidad VARCHAR(20),
	@Correo VARCHAR(255),
	@Celular INT,
	@Particular INT,
	@Sangre VARCHAR(10),
	@Direccion VARCHAR(255),
	@NombreCE VARCHAR(50),
	@IdCE VARCHAR(50),
	@GeneroCE VARCHAR(20),
	@FechaNacCE DATETIME,	
	@NacionalidadCE VARCHAR(20),
	@CorreoCE varchar(255),
	@CelularCE INT,
	@ParticularCE INT
	
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
		
		INSERT INTO dbo.Clientes
		(
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
		)
		VALUES
		(
		@IdCliente,
	    @Fecha,
		@Categoria,
		@Nombre,
		@Genero,
		@FechaNac,	
		@Nacionalidad,
		@Correo,
		@Celular,
		@Particular,
		@Sangre,
		@Direccion,
		@NombreCE,
		@IdCE,
		@GeneroCE,
		@FechaNacCE,	
		@NacionalidadCE,
		@CorreoCE,
		@CelularCE,
		@ParticularCE
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