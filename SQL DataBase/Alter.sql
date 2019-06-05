ALTER TABLE Roles
	ADD PRIMARY KEY (Identificador)

ALTER TABLE Usuario
	ADD PRIMARY KEY	(Correo),
		FOREIGN KEY (ID_Rol)			REFERENCES	Roles(Identificador);

ALTER TABLE Universidad
	ADD PRIMARY KEY	(Identificador);

ALTER TABLE Programa
	ADD FOREIGN KEY (C_Usuario)			REFERENCES	Usuario(Correo),
		FOREIGN KEY (ID_Universidad)	REFERENCES	Universidad(Identificador),
		DEFAULT		0					FOR			Millas;