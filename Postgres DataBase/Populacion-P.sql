INSERT INTO Aeronave(Modelo, Capacidad, A_Economicos, A_Ejecutivos) VALUES(1,10,8,2)
INSERT INTO public.vuelo(
	codigo, estado, c_economico, c_ejecutivo, f_salida, f_llegada, a_salida, a_llegada, millas, id_aeronave)
	VALUES ('A00D', '0', 100, 200, '2019-06-04', '2019-06-05', 'AAA', 'AAB', 1000, 1);
INSERT INTO public.bagcart(
	modelo, marca, c_vuelo, sello)
	VALUES ('2019', 1, 'A00D', NULL);