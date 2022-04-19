CREATE PROCEDURE [dbo].[ClienteActualizar]
	@IdCliente VARCHAR(50),
	@Fecha DATE,
    @Categoria VARCHAR(20),
	@Nombre VARCHAR(50),
	@Genero VARCHAR(20),
	@FechaNac DATE,	
	@Nacionalidad VARCHAR(20),
	@Correo VARCHAR(255),
	@Celular INT,
	@Particular INT,
	@Sangre VARCHAR(10),
	@Direccion VARCHAR(255),
	@NombreCE VARCHAR(50),
	@IdCE VARCHAR(50),
	@GeneroCE VARCHAR(20),
	@FechaNacCE DATE,	
	@NacionalidadCE VARCHAR(20),
	@CorreoCE varchar(255),
	@CelularCE INT,
	@ParticularCE INT

AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
		
	UPDATE dbo.Clientes SET
	Fecha=@Fecha,
    Categoria=@Categoria,
	Nombre=@Nombre,
	Genero=@Genero,
	FechaNac=@FechaNac,	
	Nacionalidad=@Nacionalidad,
	Correo=@Correo,
	Celular=@Celular,
	Particular=@Particular,
	Sangre=@Sangre,
	Direccion=@Direccion,
	NombreCE=@NombreCE,
	IdCE=@IdCE,
	GeneroCE=@GeneroCE,
	FechaNacCE=@FechaNacCE,	
	NacionalidadCE=@NacionalidadCE,
	CorreoCE=@CorreoCE,
	CelularCE=@CelularCE,
	ParticularCE=@ParticularCE

	WHERE IdCliente = @IdCliente

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
