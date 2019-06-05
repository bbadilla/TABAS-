CREATE OR REPLACE PROCEDURE udsp_ins_bagcart(text, int)
LANGUAGE 'plpgsql'
AS $$
BEGIN
 	INSERT INTO BagCart(Modelo, Marca, C_Vuelo, Sello)
		VALUES($1,$2,NULL,NULL);
    COMMIT;
END;
$$
CREATE OR REPLACE PROCEDURE udsp_upd_BagcartVuelo(int, text)
LANGUAGE 'plpgsql'
AS $$
BEGIN
 	UPDATE Bagcart
	SET C_Vuelo = $2 
	WHERE Identificador = $1;
    COMMIT;
END;
$$
CREATE OR REPLACE PROCEDURE udsp_upd_CerrarBagcart(int, text)
LANGUAGE 'plpgsql'
AS $$
BEGIN
 	UPDATE Bagcart
	SET Sello = $2 
	WHERE Identificador = $1;
    COMMIT;
END;
$$
CREATE OR REPLACE PROCEDURE udsp_upd_Vuelo(int, text)
LANGUAGE 'plpgsql'
AS $$
BEGIN
 	UPDATE Vuelo
	SET Id_Aeronave = $1
	WHERE Codigo = $2;
    COMMIT;
END;
$$