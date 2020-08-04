create or replace PROCEDURE "LISTAR_TBL_MONEDAS" (REGISTROS OUT SYS_REFCURSOR)
AS
BEGIN
  OPEN REGISTROS FOR SELECT * FROM LISTAR_MONEDAS;
END LISTAR_TBL_MONEDAS;  
/*------------------------------------------------------------------------------------------------------*/  
  
  CREATE OR REPLACE FORCE VIEW "FERREDB"."LISTAR_MONEDAS" ("ID_MONEDA", "COD_MONEDA", "DESCRIPCION") AS 
  SELECT "ID_MONEDA", "COD_MONEDA", "DESCRIPCION"
    FROM TBL_MONEDAS
ORDER BY ID_MONEDA;
/*------------------------------------------------------------------------------------------------------*/
create or replace PROCEDURE           "BUSCAR_TBL_MONEDAS" 
(MON IN TBL_MONEDAS.DESCRIPCION%TYPE, 
REGISTROS OUT SYS_REFCURSOR)
IS
BEGIN
    OPEN REGISTROS FOR SELECT ID_MONEDA,COD_MONEDA
    FROM TBL_MONEDAS
    WHERE DESCRIPCION LIKE '%' ||MON|| '%'
    ORDER BY ID_MONEDA;
END BUSCAR_TBL_MONEDAS;
/*------------------------------------------------------------------------------------------------------*/
create or replace PROCEDURE "INSERTAR_TBL_MONEDAS" 
(IDM IN NUMBER,
COD_MON IN VARCHAR2,
DESCRIP IN VARCHAR2)
AS 
BEGIN
    INSERT INTO TBL_MONEDAS(ID_MONEDA, COD_MONEDA, DESCRIPCION)
    VALUES (IDM, COD_MON,DESCRIP);
    COMMIT;
END INSERTAR_TBL_MONEDAS;
/*------------------------------------------------------------------------------------------------------*/
create or replace PROCEDURE ACTUALIZAR_TBL_MONEDAS
(IDM IN NUMBER,
COD_MON IN VARCHAR2,
DESCRIP IN VARCHAR2)
AS
BEGIN
   UPDATE TBL_MONEDAS
   SET COD_MONEDA = COD_MON,DESCRIPCION = DESCRIP
   WHERE ID_MONEDA = IDM;
   COMMIT;
END;

/*------------------------------------------------------------------------------------------------------*/

create or replace PROCEDURE           "BORRAR_TBL_MONEDAS" 
(ID_MON IN NUMBER)
AS 
  VARID number:=ID_MON;
BEGIN
    DELETE FROM TBL_MONEDAS
    WHERE ID_MONEDA = ID_MON;
END BORRAR_TBL_MONEDAS;