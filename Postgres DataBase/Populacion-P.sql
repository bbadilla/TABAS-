INSERT INTO Aeronave(Modelo, Capacidad, A_Economicos, A_Ejecutivos)
		VALUES 
		('747-400', 416, 250, 166),
		('777-200', 300, 200, 100),
		('A340-200', 440, 300, 145),
		('767-300ER', 375, 225, 150),
		('A330-300', 335, 200, 135),
		('757-200', 289, 175, 114),
		('737-700', 215, 150, 65),
		('MD-80', 172, 100, 72),
		('320', 150, 100, 150)
INSERT INTO public.vuelo(
	codigo, estado, c_economico, c_ejecutivo, f_salida, f_llegada, a_salida, a_llegada, millas, id_aeronave)
	VALUES ('A00D', '0', 100, 200, '2019-06-04', '2019-06-05', 'AAA', 'AAB', 1000, 1);
INSERT INTO public.bagcart(
	modelo, marca, c_vuelo, sello)
	VALUES ('2019', 1, 'A00D', NULL);
