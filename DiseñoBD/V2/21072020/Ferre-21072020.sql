/*==============================================================*/
/* DBMS name:      ORACLE Version 11g                           */
/* Created on:     21/07/2020 2:26:11 PM                        */
/*==============================================================*/



-- Type package declaration
create or replace package PDTypes  
as
    TYPE ref_cursor IS REF CURSOR;
end;

-- Integrity package declaration
create or replace package IntegrityPackage AS
 procedure InitNestLevel;
 function GetNestLevel return number;
 procedure NextNestLevel;
 procedure PreviousNestLevel;
 end IntegrityPackage;
/

-- Integrity package definition
create or replace package body IntegrityPackage AS
 NestLevel number;

-- Procedure to initialize the trigger nest level
 procedure InitNestLevel is
 begin
 NestLevel := 0;
 end;


-- Function to return the trigger nest level
 function GetNestLevel return number is
 begin
 if NestLevel is null then
     NestLevel := 0;
 end if;
 return(NestLevel);
 end;

-- Procedure to increase the trigger nest level
 procedure NextNestLevel is
 begin
 if NestLevel is null then
     NestLevel := 0;
 end if;
 NestLevel := NestLevel + 1;
 end;

-- Procedure to decrease the trigger nest level
 procedure PreviousNestLevel is
 begin
 NestLevel := NestLevel - 1;
 end;

 end IntegrityPackage;
/


drop trigger COMPOUNDDELETETRIGGER_TBL_DETA
/

drop trigger COMPOUNDINSERTTRIGGER_TBL_DETA
/

drop trigger COMPOUNDUPDATETRIGGER_TBL_DETA
/

drop trigger TIB_TBL_DETALLE_DEV
/

drop trigger TUB_TBL_DETALLE_DEV
/

drop trigger COMPOUNDDELETETRIGGER_TBL_INGR
/

drop trigger COMPOUNDINSERTTRIGGER_TBL_INGR
/

drop trigger COMPOUNDUPDATETRIGGER_TBL_INGR
/

drop trigger TDA_TBL_INGRESOS_DEV
/

drop trigger TUB_TBL_INGRESOS_DEV
/

alter table TBL_BODEGAS
   drop constraint FK_TBL_BODE_REF_BOD_D_TBL_INGR
/

alter table TBL_BODEGAS
   drop constraint FK_TBL_BODE_REF_EMP_B_TBL_EMPR
/

alter table TBL_CLIENT_PROV
   drop constraint FK_TBL_CLIE_REF_EMP_C_TBL_EMPR
/

alter table TBL_CLIENT_PROV
   drop constraint FK_TBL_CLIE_REF_PERSO_TBL_TIPO
/

alter table TBL_CLIENT_PROV
   drop constraint FK_TBL_CLIE_REF_PROV__TBL_PROV
/

alter table TBL_DETALLE_VENTA
   drop constraint FK_TBL_DETA_REF_BODEG_TBL_BODE
/

alter table TBL_EMPRESA
   drop constraint FK_TBL_EMPR_REF_CIA_E_TBL_TIPO
/

alter table TBL_EMPRESA
   drop constraint FK_TBL_EMPR_REF_EMPRE_TBL_PROV
/

alter table TBL_INGRESOS_DEV
   drop constraint FK_TBL_INGR_REF_DEV_V_TBL_VENT
/

alter table TBL_INGRESOS_DEV
   drop constraint FK_TBL_INGR_REV_DEB_E_TBL_EMPR
/

alter table TBL_INVENTARIO_ARTICULOS
   drop constraint FK_TBL_INVE_REF_ART_B_TBL_BODE
/

alter table TBL_INVENTARIO_ARTICULOS
   drop constraint FK_TBL_INVE_REF_ART_U_TBL_UND_
/

alter table TBL_INVENTARIO_ARTICULOS
   drop constraint FK_TBL_INVE_REF_CATEG_TBL_CATE
/

alter table TBL_TIPO_CAMBIO
   drop constraint FK_TBL_TIPO_REF_TC_MO_TBL_MONE
/

alter table TBL_USUARIOS
   drop constraint FK_TBL_USUA_REF_USER__TBL_PERM
/

alter table TBL_VENTAS
   drop constraint FK_TBL_VENT_REF_DET_V_TBL_DETA
/

alter table TBL_VENTAS
   drop constraint FK_TBL_VENT_REF_DET_V_TBL_TIPO
/

alter table TBL_VENTAS
   drop constraint FK_TBL_VENT_REF_EMPRE_TBL_EMPR
/

alter table TBL_VENTAS
   drop constraint FK_TBL_VENT_REF_USER__TBL_USUA
/

drop table TBL_BODEGAS cascade constraints
/

drop table TBL_CATEGORIA cascade constraints
/

drop table TBL_CLIENT_PROV cascade constraints
/

drop table TBL_DETALLE_DEV cascade constraints
/

drop table TBL_DETALLE_VENTA cascade constraints
/

drop table TBL_EMPRESA cascade constraints
/

drop table TBL_INGRESOS_DEV cascade constraints
/

drop table TBL_INVENTARIO_ARTICULOS cascade constraints
/

drop table TBL_MONEDAS cascade constraints
/

drop table TBL_PERMISOS_USUARIOS cascade constraints
/

drop table TBL_PROVINCIAS cascade constraints
/

drop table TBL_TIPO_CAMBIO cascade constraints
/

drop table TBL_TIPO_CIA cascade constraints
/

drop table TBL_TIPO_IDENTIFICACION cascade constraints
/

drop table TBL_UND_MED cascade constraints
/

drop table TBL_USUARIOS cascade constraints
/

drop table TBL_VENTAS cascade constraints
/

/*==============================================================*/
/* Table: TBL_BODEGAS                                           */
/*==============================================================*/
create table TBL_BODEGAS 
(
   ID_CIA               INTEGER,
   ID_INGRESO           INTEGER,
   ID_BODEGA            INTEGER              not null,
   ID_ARTICULO          INTEGER,
   COD_BODEGA           VARCHAR(10),
   DESCRIPCION          VARCHAR(100),
   UBICACION            VARCHAR(100),
   STOCK                INTEGER
)
/

/*==============================================================*/
/* Table: TBL_CATEGORIA                                         */
/*==============================================================*/
create table TBL_CATEGORIA 
(
   ID_CATEGORIA         INTEGER              not null,
   CATEGORIA            VARCHAR2(50),
   DESCRIPCION          VARCHAR2(255 BYTE),
   ESTADO               CHAR(1),
   constraint PK_TBL_CATEGORIA primary key (ID_CATEGORIA)
)
/

/*==============================================================*/
/* Table: TBL_CLIENT_PROV                                       */
/*==============================================================*/
create table TBL_CLIENT_PROV 
(
   ID_CIA               INTEGER,
   ID_CLI_PROV          INTEGER              not null,
   ID_TIPO_IDENTIFICACION INTEGER,
   NOMBRE               VARCHAR2(100),
   NUM_DOC              VARCHAR2(20),
   ID_PROVINCIA         INTEGER,
   DIRECCION            VARCHAR2(200),
   TELEFONO             VARCHAR2(20),
   EMAIL                VARCHAR2(50),
   WEB                  VARCHAR2(60),
   constraint PK_TBL_CLIENT_PROV primary key (ID_CLI_PROV)
)
/

/*==============================================================*/
/* Table: TBL_DETALLE_DEV                                       */
/*==============================================================*/
create table TBL_DETALLE_DEV 
(
   ID_ING_DEV           INTEGER              not null,
   ID_INGRESO           INTEGER,
   ID_ARTICULO          INTEGER,
   CANTIDAD             INTEGER,
   PRECIO               INTEGER,
   constraint PK_TBL_DETALLE_DEV primary key (ID_ING_DEV)
)
/

/*==============================================================*/
/* Table: TBL_DETALLE_VENTA                                     */
/*==============================================================*/
create table TBL_DETALLE_VENTA 
(
   ID_DETALLE_VENTA     INTEGER              not null,
   ID_VENTA             INTEGER,
   ID_ARTICULO          INTEGER,
   PRECIO               NUMBER(11,2),
   DESCUENTO            NUMBER(11,2)
)
/

/*==============================================================*/
/* Table: TBL_EMPRESA                                           */
/*==============================================================*/
create table TBL_EMPRESA 
(
   ID_CIA               INTEGER              not null,
   ID_TIPO_CIA          INTEGER,
   ID_TIPO_IDENTIFICACION INTEGER,
   NUM_ID               VARCHAR2(20),
   RAZON_SOCIAL         VARCHAR2(50),
   NOMBRE               VARCHAR2(50),
   ID_PROVINCIA         INTEGER,
   DIRECCION            VARCHAR(255),
   TEL1                 VARCHAR(15),
   TEL2                 VARCHAR(15),
   FAX                  VARCHAR(15),
   CP                   VARCHAR(10),
   WEB                  VARCHAR(60),
   E_MAIL               VARCHAR(60),
   constraint PK_TBL_EMPRESA primary key (ID_CIA)
)
/

/*==============================================================*/
/* Table: TBL_INGRESOS_DEV                                      */
/*==============================================================*/
create table TBL_INGRESOS_DEV 
(
   ID_INGRESO           INTEGER              not null,
   ID_CIA               INTEGER,
   ID_CLI_PROV          INTEGER,
   ID_USUARIO           INTEGER,
   TIPO_COMPROBANTE     VARCHAR2(20),
   CONSECUTIVO          INTEGER,
   FECHA                DATE,
   IMPUESTO             NUMBER(11,2),
   TOTAL                NUMBER(11,2),
   ESTADO               VARCHAR2(20),
   ID_VENTA             INTEGER,
   ID_BODEGA            INTEGER,
   constraint PK_TBL_INGRESOS_DEV primary key (ID_INGRESO)
)
/

/*==============================================================*/
/* Table: TBL_INVENTARIO_ARTICULOS                              */
/*==============================================================*/
create table TBL_INVENTARIO_ARTICULOS 
(
   ID_ARTICULO          INT                  not null,
   ID_CATEGORIA         INTEGER,
   ID_BODEGA            INTEGER,
   CODIGO               VARCHAR2(50),
   NOMBRE               VARCHAR2(100),
   ID_UND_MEDIDA        INTEGER,
   PRECIO_VENTA         NUMBER(11,2),
   DESCRIPCION          VARCHAR2(255),
   IMAGEN               VARCHAR2(20),
   ESTADO               CHAR(1),
   constraint PK_TBL_INVENTARIO_ARTICULOS primary key (ID_ARTICULO)
)
/

/*==============================================================*/
/* Table: TBL_MONEDAS                                           */
/*==============================================================*/
create table TBL_MONEDAS 
(
   ID_MONEDA            INTEGER              not null,
   COD_MONEDA           VARCHAR2(10),
   DESCRIPCION          VARCHAR2(20),
   constraint PK_TBL_MONEDAS primary key (ID_MONEDA)
)
/

/*==============================================================*/
/* Table: TBL_PERMISOS_USUARIOS                                 */
/*==============================================================*/
create table TBL_PERMISOS_USUARIOS 
(
   ID_ROL               INTEGER              not null,
   NOMBRE               VARCHAR2(20),
   DESCRIPCION          VARCHAR2(255),
   ESTADO               CHAR(1),
   constraint PK_TBL_PERMISOS_USUARIOS primary key (ID_ROL)
)
/

/*==============================================================*/
/* Table: TBL_PROVINCIAS                                        */
/*==============================================================*/
create table TBL_PROVINCIAS 
(
   ID_PROVINCIA         INTEGER              not null,
   PROVINCIA            VARCHAR2(20),
   constraint PK_TBL_PROVINCIAS primary key (ID_PROVINCIA)
)
/

/*==============================================================*/
/* Table: TBL_TIPO_CAMBIO                                       */
/*==============================================================*/
create table TBL_TIPO_CAMBIO 
(
   ID_TC                INTEGER,
   ID_MONEDA            INTEGER,
   COMPRA               INTEGER,
   VENTA                INTEGER,
   FECHA                DATE
)
/

/*==============================================================*/
/* Table: TBL_TIPO_CIA                                          */
/*==============================================================*/
create table TBL_TIPO_CIA 
(
   ID_TIPO_CIA          INTEGER              not null,
   TIPO_EMPRESA         VARCHAR2(50),
   DESCRIPCION          VARCHAR2(255),
   constraint PK_TBL_TIPO_CIA primary key (ID_TIPO_CIA)
)
/

/*==============================================================*/
/* Table: TBL_TIPO_IDENTIFICACION                               */
/*==============================================================*/
create table TBL_TIPO_IDENTIFICACION 
(
   ID_TIPO_IDENTIFICACION INTEGER              not null,
   PERSONERIA           VARCHAR2(20),
   constraint PK_TBL_TIPO_IDENTIFICACION primary key (ID_TIPO_IDENTIFICACION)
)
/

/*==============================================================*/
/* Table: TBL_UND_MED                                           */
/*==============================================================*/
create table TBL_UND_MED 
(
   ID_UND_MEDIDA        INTEGER              not null,
   COD_MEDIDA           VARCHAR2(10),
   DESCRIPCION          VARCHAR2(30),
   constraint PK_TBL_UND_MED primary key (ID_UND_MEDIDA)
)
/

/*==============================================================*/
/* Table: TBL_USUARIOS                                          */
/*==============================================================*/
create table TBL_USUARIOS 
(
   ID_USUARIO           INTEGER              not null,
   ID_ROL               INTEGER,
   NOMBRE               VARCHAR2(50),
   APELLIDO_1           VARCHAR2(50),
   APELLIDO_2           VARCHAR2(50),
   ID_TIPO_DOCUMENTO    VARCHAR2(20),
   NUM_IDENTIFICACION   VARCHAR2(20),
   DIRECCION            VARCHAR2(255),
   TELEFONO             VARCHAR2(20),
   EMAIL                VARCHAR2(255),
   PASSWORD             VARCHAR2(15),
   ESTADO               CHAR(1),
   constraint PK_TBL_USUARIOS primary key (ID_USUARIO)
)
/

/*==============================================================*/
/* Table: TBL_VENTAS                                            */
/*==============================================================*/
create table TBL_VENTAS 
(
   ID_CIA               INTEGER,
   ID_VENTA             INTEGER              not null,
   ID_CLIENTE           INTEGER,
   ID_USUARIO           INTEGER,
   ID_COMPROBANTE       VARCHAR2(10),
   FECHA                DATE,
   HORA                 DATE,
   IMPUESTO             NUMBER(10,2),
   TOTAL                NUMBER(10,2),
   ESTADO               CHAR(1),
   ID_TC                INTEGER,
   constraint PK_TBL_VENTAS primary key (ID_VENTA)
)
/

comment on table TBL_VENTAS is
'Esta Tabla lleva control de las transacciones de ventas o salidas de la bodega'
/

alter table TBL_BODEGAS
   add constraint FK_TBL_BODE_REF_BOD_D_TBL_INGR foreign key (ID_INGRESO)
      references TBL_INGRESOS_DEV (ID_INGRESO)
      on delete cascade
/

alter table TBL_BODEGAS
   add constraint FK_TBL_BODE_REF_EMP_B_TBL_EMPR foreign key (ID_CIA)
      references TBL_EMPRESA (ID_CIA)
/

alter table TBL_CLIENT_PROV
   add constraint FK_TBL_CLIE_REF_EMP_C_TBL_EMPR foreign key (ID_CIA)
      references TBL_EMPRESA (ID_CIA)
/

alter table TBL_CLIENT_PROV
   add constraint FK_TBL_CLIE_REF_PERSO_TBL_TIPO foreign key (ID_TIPO_IDENTIFICACION)
      references TBL_TIPO_IDENTIFICACION (ID_TIPO_IDENTIFICACION)
/

alter table TBL_CLIENT_PROV
   add constraint FK_TBL_CLIE_REF_PROV__TBL_PROV foreign key (ID_PROVINCIA)
      references TBL_PROVINCIAS (ID_PROVINCIA)
/

alter table TBL_DETALLE_VENTA
   add constraint FK_TBL_DETA_REF_BODEG_TBL_BODE foreign key (ID_ARTICULO)
      references TBL_BODEGAS (ID_ARTICULO)
/

alter table TBL_EMPRESA
   add constraint FK_TBL_EMPR_REF_CIA_E_TBL_TIPO foreign key (ID_TIPO_CIA)
      references TBL_TIPO_CIA (ID_TIPO_CIA)
/

alter table TBL_EMPRESA
   add constraint FK_TBL_EMPR_REF_EMPRE_TBL_PROV foreign key (ID_PROVINCIA)
      references TBL_PROVINCIAS (ID_PROVINCIA)
/

alter table TBL_INGRESOS_DEV
   add constraint FK_TBL_INGR_REF_DEV_V_TBL_VENT foreign key (ID_VENTA)
      references TBL_VENTAS (ID_VENTA)
/

alter table TBL_INGRESOS_DEV
   add constraint FK_TBL_INGR_REV_DEB_E_TBL_EMPR foreign key (ID_CIA)
      references TBL_EMPRESA (ID_CIA)
      on delete cascade
/

alter table TBL_INVENTARIO_ARTICULOS
   add constraint FK_TBL_INVE_REF_ART_B_TBL_BODE foreign key (ID_BODEGA)
      references TBL_BODEGAS (ID_BODEGA)
      on delete cascade
/

alter table TBL_INVENTARIO_ARTICULOS
   add constraint FK_TBL_INVE_REF_ART_U_TBL_UND_ foreign key (ID_UND_MEDIDA)
      references TBL_UND_MED (ID_UND_MEDIDA)
/

alter table TBL_INVENTARIO_ARTICULOS
   add constraint FK_TBL_INVE_REF_CATEG_TBL_CATE foreign key (ID_CATEGORIA)
      references TBL_CATEGORIA (ID_CATEGORIA)
/

alter table TBL_TIPO_CAMBIO
   add constraint FK_TBL_TIPO_REF_TC_MO_TBL_MONE foreign key (ID_MONEDA)
      references TBL_MONEDAS (ID_MONEDA)
      on delete cascade
/

alter table TBL_USUARIOS
   add constraint FK_TBL_USUA_REF_USER__TBL_PERM foreign key (ID_ROL)
      references TBL_PERMISOS_USUARIOS (ID_ROL)
      on delete cascade
/

alter table TBL_VENTAS
   add constraint FK_TBL_VENT_REF_DET_V_TBL_DETA foreign key (ID_VENTA)
      references TBL_DETALLE_VENTA (ID_VENTA)
      on delete cascade
/

alter table TBL_VENTAS
   add constraint FK_TBL_VENT_REF_DET_V_TBL_TIPO foreign key (ID_TC)
      references TBL_TIPO_CAMBIO (ID_TC)
/

alter table TBL_VENTAS
   add constraint FK_TBL_VENT_REF_EMPRE_TBL_EMPR foreign key (ID_CIA)
      references TBL_EMPRESA (ID_CIA)
      on delete cascade
/

alter table TBL_VENTAS
   add constraint FK_TBL_VENT_REF_USER__TBL_USUA foreign key (ID_USUARIO)
      references TBL_USUARIOS (ID_USUARIO)
/


create or replace trigger COMPOUNDDELETETRIGGER_TBL_DETA
for delete on TBL_DETALLE_DEV compound trigger
// Declaration
// Body
  before statement is
  begin
     NULL;
  end before statement;

  before each row is
  begin
     NULL;
  end before each row;

  after each row is
  begin
     NULL;
  end after each row;

  after statement is
  begin
     NULL;
  end after statement;

END
/


create or replace trigger COMPOUNDINSERTTRIGGER_TBL_DETA
for insert on TBL_DETALLE_DEV compound trigger
// Declaration
// Body
  before statement is
  begin
     NULL;
  end before statement;

  before each row is
  begin
     NULL;
  end before each row;

  after each row is
  begin
     NULL;
  end after each row;

  after statement is
  begin
     NULL;
  end after statement;

END
/


create or replace trigger COMPOUNDUPDATETRIGGER_TBL_DETA
for update on TBL_DETALLE_DEV compound trigger
// Declaration
// Body
  before statement is
  begin
     NULL;
  end before statement;

  before each row is
  begin
     NULL;
  end before each row;

  after each row is
  begin
     NULL;
  end after each row;

  after statement is
  begin
     NULL;
  end after statement;

END
/


create trigger TIB_TBL_DETALLE_DEV before insert
on TBL_DETALLE_DEV for each row
declare
    integrity_error  exception;
    errno            integer;
    errmsg           char(200);
    dummy            integer;
    found            boolean;
    --  Declaration of InsertChildParentExist constraint for the parent "TBL_INGRESOS_DEV"
    cursor cpk1_tbl_detalle_dev(var_id_ingreso integer) is
       select 1
       from   TBL_INGRESOS_DEV
       where  ID_INGRESO = var_id_ingreso
        and   var_id_ingreso is not null;

begin
    --  Parent "TBL_INGRESOS_DEV" must exist when inserting a child in "TBL_DETALLE_DEV"
    if :new.ID_INGRESO is not null then
       open  cpk1_tbl_detalle_dev(:new.ID_INGRESO);
       fetch cpk1_tbl_detalle_dev into dummy;
       found := cpk1_tbl_detalle_dev%FOUND;
       close cpk1_tbl_detalle_dev;
       if not found then
          errno  := -20002;
          errmsg := 'Parent does not exist in "TBL_INGRESOS_DEV". Cannot create child in "TBL_DETALLE_DEV".';
          raise integrity_error;
       end if;
    end if;


--  Errors handling
exception
    when integrity_error then
       raise_application_error(errno, errmsg);
end;
/


create trigger TUB_TBL_DETALLE_DEV before update
of ID_ING_DEV,
   ID_INGRESO
on TBL_DETALLE_DEV for each row
declare
    integrity_error  exception;
    errno            integer;
    errmsg           char(200);
    dummy            integer;
    found            boolean;
    seq NUMBER;
    --  Declaration of UpdateChildParentExist constraint for the parent "TBL_INGRESOS_DEV"
    cursor cpk1_tbl_detalle_dev(var_id_ingreso integer) is
       select 1
       from   TBL_INGRESOS_DEV
       where  ID_INGRESO = var_id_ingreso
        and   var_id_ingreso is not null;

begin
    seq := IntegrityPackage.GetNestLevel;
    --  Parent "TBL_INGRESOS_DEV" must exist when updating a child in "TBL_DETALLE_DEV"
    if (:new.ID_INGRESO is not null) and (seq = 0) then
       open  cpk1_tbl_detalle_dev(:new.ID_INGRESO);
       fetch cpk1_tbl_detalle_dev into dummy;
       found := cpk1_tbl_detalle_dev%FOUND;
       close cpk1_tbl_detalle_dev;
       if not found then
          errno  := -20003;
          errmsg := 'Parent does not exist in "TBL_INGRESOS_DEV". Cannot update child in "TBL_DETALLE_DEV".';
          raise integrity_error;
       end if;
    end if;


--  Errors handling
exception
    when integrity_error then
       raise_application_error(errno, errmsg);
end;
/


create or replace trigger COMPOUNDDELETETRIGGER_TBL_INGR
for delete on TBL_INGRESOS_DEV compound trigger
// Declaration
// Body
  before statement is
  begin
     NULL;
  end before statement;

  before each row is
  begin
     NULL;
  end before each row;

  after each row is
  begin
     NULL;
  end after each row;

  after statement is
  begin
     NULL;
  end after statement;

END
/


create or replace trigger COMPOUNDINSERTTRIGGER_TBL_INGR
for insert on TBL_INGRESOS_DEV compound trigger
// Declaration
// Body
  before statement is
  begin
     NULL;
  end before statement;

  before each row is
  begin
     NULL;
  end before each row;

  after each row is
  begin
     NULL;
  end after each row;

  after statement is
  begin
     NULL;
  end after statement;

END
/


create or replace trigger COMPOUNDUPDATETRIGGER_TBL_INGR
for update on TBL_INGRESOS_DEV compound trigger
// Declaration
// Body
  before statement is
  begin
     NULL;
  end before statement;

  before each row is
  begin
     NULL;
  end before each row;

  after each row is
  begin
     NULL;
  end after each row;

  after statement is
  begin
     NULL;
  end after statement;

END
/


create trigger TDA_TBL_INGRESOS_DEV after delete
on TBL_INGRESOS_DEV for each row
declare
    integrity_error  exception;
    errno            integer;
    errmsg           char(200);
    dummy            integer;
    found            boolean;

begin
    IntegrityPackage.NextNestLevel;
    --  Delete all children in "TBL_DETALLE_DEV"
    delete TBL_DETALLE_DEV
    where  ID_INGRESO = :old.ID_INGRESO;

    IntegrityPackage.PreviousNestLevel;

--  Errors handling
exception
    when integrity_error then
       begin
       IntegrityPackage.InitNestLevel;
       raise_application_error(errno, errmsg);
       end;
end;
/


create trigger TUB_TBL_INGRESOS_DEV before update
of ID_INGRESO,
   ID_CIA,
   ID_VENTA
on TBL_INGRESOS_DEV for each row
declare
    integrity_error  exception;
    errno            integer;
    errmsg           char(200);
    dummy            integer;
    found            boolean;
    --  Declaration of UpdateParentRestrict constraint for "TBL_DETALLE_DEV"
    cursor cfk1_tbl_detalle_dev(var_id_ingreso integer) is
       select 1
       from   TBL_DETALLE_DEV
       where  ID_INGRESO = var_id_ingreso
        and   var_id_ingreso is not null;

begin
    --  Cannot modify parent code in "TBL_INGRESOS_DEV" if children still exist in "TBL_DETALLE_DEV"
    if (updating('ID_INGRESO') and :old.ID_INGRESO != :new.ID_INGRESO) then
       open  cfk1_tbl_detalle_dev(:old.ID_INGRESO);
       fetch cfk1_tbl_detalle_dev into dummy;
       found := cfk1_tbl_detalle_dev%FOUND;
       close cfk1_tbl_detalle_dev;
       if found then
          errno  := -20005;
          errmsg := 'Children still exist in "TBL_DETALLE_DEV". Cannot modify parent code in "TBL_INGRESOS_DEV".';
          raise integrity_error;
       end if;
    end if;


--  Errors handling
exception
    when integrity_error then
       raise_application_error(errno, errmsg);
end;
/

