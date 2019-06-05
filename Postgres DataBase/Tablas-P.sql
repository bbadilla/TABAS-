CREATE TABLE Vuelo(
	Codigo			VARCHAR(4)			NOT NULL,	
	Estado			BIT,
	C_Economico		INT				NOT NULL,	
	C_Ejecutivo		INT				NOT NULL,
	F_Salida		TIMESTAMP 			NOT NULL,
	F_Llegada		TIMESTAMP 			NOT NULL,
	A_Salida		VARCHAR(3)			NOT NULL,
	A_Llegada		VARCHAR(3)			NOT NULL,
	Millas			INT				NOT NULL,
	ID_Aeronave		INT				NOT NULL
);
CREATE TABLE Aeronave(
	Identificador		SERIAL,
	Modelo			VARCHAR(20)			NOT NULL,
	Capacidad		INT				NOT NULL,
	A_Economicos		INT				NOT NULL,
	A_Ejecutivos		INT				NOT NULL
);
CREATE TABLE Maleta(
	Identificador		SERIAL,
	Color			VARCHAR(10)			NOT NULL,
	Peso			INT				NOT NULL,
	Costo			INT				NOT NULL,
	C_Usuario		VARCHAR(35)			NOT NULL,
	ID_BagCart		INT				NOT NULL,
	ID_Avion		INT				NOT NULL
);
CREATE TABLE Modelos(
	Identificador		SERIAL,
	Modelo			VARCHAR(35)			NOT NULL
);
CREATE TABLE Marcas(
	Identificador		SERIAL,
	Modelo			VARCHAR(35)			NOT NULL
);
CREATE TABLE BagCart(
	Identificador		SERIAL,
	Modelo			VARCHAR(35)			NOT NULL,
	Marca			VARCHAR(35)			NOT NULL,
	C_Vuelo			VARCHAR(4)			NOT NULL,
	Sello			VARCHAR(10)			NOT NULL
