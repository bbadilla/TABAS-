CREATE TABLE Usuario(
	Nombre			VARCHAR(20)		NOT NULL,
	Apellido1		VARCHAR(20)		NOT NULL,
	Apellido2		VARCHAR(20)		NOT NULL,
	Telefono		INT				NOT NULL,
	Carne			INT,
	Correo			VARCHAR(35)		NOT NULL,
	Contraseña		VARCHAR(10)		NOT NULL,
	ID_Rol			INT				NOT NULL
);
CREATE TABLE Roles(
	Identificador	INT				IDENTITY(1,1),
	Rol				VARCHAR(20)		NOT NULL
);
CREATE TABLE Programa(
	C_Usuario		VARCHAR(35)		NOT NULL,
	ID_Universidad	INT				NOT NULL,
	Millas			INT
);
CREATE TABLE Universidad(
	Identificador	INT				IDENTITY(1,1),
	Nombre			VARCHAR(4)		NOT NULL	
);