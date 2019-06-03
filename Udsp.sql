-- EXECUTE udsp_ins_universidad 'TEC'
CREATE PROCEDURE udsp_ins_universidad(
	@Nombre			VARCHAR(4))
AS
BEGIN TRANSACTION
	IF EXISTS (SELECT Identificador FROM Universidad WHERE Nombre = @Nombre)
		BEGIN
			RAISERROR('Esta universidad ya ha sido registrada',1,1)
			ROLLBACK TRANSACTION
		END
	ELSE
		BEGIN
			INSERT INTO Universidad(Nombre)
				VALUES
					(@Nombre)
			COMMIT TRANSACTION
		END
GO

-- EXECUTE udsp_ins_rol 'Master'
-- EXECUTE udsp_ins_rol 'Recepcionista'
-- EXECUTE udsp_ins_rol 'Escaner'
-- EXECUTE udsp_ins_rol 'Cargador'
-- EXECUTE udsp_ins_rol 'Cliente'

CREATE PROCEDURE udsp_ins_rol(
	@Rol			VARCHAR(20))
AS
BEGIN TRANSACTION
	IF EXISTS (SELECT Identificador FROM Roles WHERE Rol = @Rol)
		BEGIN
			RAISERROR('Este rol ya ha sido registrado',1,1)
			ROLLBACK TRANSACTION
		END
	ELSE
		BEGIN
			INSERT INTO Roles(Rol)
				VALUES
					(@Rol)
			COMMIT TRANSACTION
		END
GO

-- EXECUTE udsp_ins_usuario 'Vinicio', 'Monge', 'Avendaño', 88888888, 2016128536, 'vinicio@gmail.com', 'password', 1, 'TEC'
CREATE PROCEDURE udsp_ins_usuario(
	@Nombre			VARCHAR(20),
	@Apellido1		VARCHAR(20),
	@Apellido2		VARCHAR(20),
	@Telefono		INT,
	@Carne			INT,
	@Correo			VARCHAR(35),
	@Contraseña		VARCHAR(10),
	@Rol			INT,
	@Universidad	VARCHAR(4))
AS
BEGIN TRANSACTION
	IF EXISTS (SELECT Correo FROM Usuario WHERE Correo = @Correo)
		BEGIN
			RAISERROR('Este usuario ya ha sido registrado',1,1)
			ROLLBACK TRANSACTION
		END
	ELSE
		BEGIN
			IF @Carne IS NULL
				BEGIN
					INSERT INTO	Usuario(Nombre, Apellido1, Apellido2, Telefono, Carne, Correo, Contraseña, ID_Rol) 
						VALUES(
							@Nombre,
							@Apellido1,
							@Apellido2,
							@Telefono,
							@Carne,
							@Correo,
							@Contraseña,
							@Rol)
				END
			ELSE
				BEGIN
					INSERT INTO	Usuario(Nombre, Apellido1, Apellido2, Telefono, Carne, Correo, Contraseña, ID_Rol) 
						VALUES(
							@Nombre,
							@Apellido1,
							@Apellido2,
							@Telefono,
							@Carne,
							@Correo,
							@Contraseña,
							@Rol)
					DECLARE @ID_Universidad INT
					SET @ID_Universidad = (
					SELECT	Identificador 
					FROM	Universidad 
					WHERE	Nombre = @Universidad)
					INSERT INTO Programa(C_Usuario, ID_Universidad, Millas) 
						VALUES(
							@Correo,			
							@ID_Universidad,
							0)
				END
			COMMIT TRANSACTION
		END
GO