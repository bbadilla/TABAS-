ALTER TABLE Modelos
	ADD PRIMARY KEY (Identificador);
ALTER TABLE Aeronave
	ADD PRIMARY KEY (Identificador),
	ADD	FOREIGN KEY (Modelo)		REFERENCES	 Modelos(Identificador);
ALTER TABLE Vuelo
	ADD PRIMARY KEY	(Codigo),
	ADD	FOREIGN KEY (ID_Aeronave)	REFERENCES	Aeronave(Identificador),
	ALTER COLUMN Estado set default '0';
ALTER TABLE BagCart
	ADD	PRIMARY KEY (Identificador),
	ADD	FOREIGN KEY (C_Vuelo)		REFERENCES	Vuelo(Codigo),
	ADD	FOREIGN KEY (Modelo)		REFERENCES	 Modelos(Identificador);
ALTER TABLE Maleta
	ADD	PRIMARY KEY (Identificador),
	ADD	FOREIGN KEY (ID_BagCart)		REFERENCES	BagCart(Identificador),
	ADD	FOREIGN KEY (ID_Avion)			REFERENCES	Aeronave(Identificador),
	ALTER COLUMN Validez set default '0';