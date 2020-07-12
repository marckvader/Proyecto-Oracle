/*==============================================================*/
/* DBMS name:      ORACLE Version 11g                           */
/* Created on:     08/06/2020 21:32:24                          */
/*==============================================================*/


alter table TBL_BARRIOS
   drop constraint FK_TBL_BARR_REF_DISTR_TBL_DIST;

alter table TBL_BODEGAS
   drop constraint FK_TBL_BODE_REF_EMP_B_TBL_EMPR;

alter table TBL_CANTONES
   drop constraint FK_TBL_CANT_REF_PROV__TBL_PROV;

alter table TBL_CLIENT_PROV
   drop constraint FK_TBL_CLIE_REF_CLIPR_TBL_BARR;

alter table TBL_CLIENT_PROV
   drop constraint FK_TBL_CLIE_REF_CLIPR_TBL_CANT;

alter table TBL_CLIENT_PROV
   drop constraint FK_TBL_CLIE_REF_CLIPR_TBL_DIST;

alter table TBL_CLIENT_PROV
   drop constraint FK_TBL_CLIE_REF_EMP_C_TBL_EMPR;

alter table TBL_CLIENT_PROV
   drop constraint FK_TBL_CLIE_REF_ID_RE_TBL_TIPO;

alter table TBL_CLIENT_PROV
   drop constraint FK_TBL_CLIE_REF_PERSO_TBL_TIPO;

alter table TBL_CLIENT_PROV
   drop constraint FK_TBL_CLIE_REF_PROV__TBL_PROV;

alter table TBL_DETALLE_DEV
   drop constraint FK_TBL_DETA_REF_DET_I_TBL_INGR;

alter table TBL_DETALLE_VENTA
   drop constraint FK_TBL_DETA_REF_BODEG_TBL_BODE;

alter table TBL_DISTRITOS
   drop constraint FK_TBL_DIST_REF_CANTO_TBL_CANT;

alter table TBL_EMPRESA
   drop constraint FK_TBL_EMPR_REF_CIA_E_TBL_TIPO;

alter table TBL_INGRESOS_DEV
   drop constraint FK_TBL_INGR_REF_BOD_D_TBL_BODE;

alter table TBL_INGRESOS_DEV
   drop constraint FK_TBL_INGR_REF_DEV_V_TBL_VENT;

alter table TBL_INGRESOS_DEV
   drop constraint FK_TBL_INGR_REV_DEB_E_TBL_EMPR;

alter table TBL_INVENTARIO_ARTICULOS
   drop constraint FK_TBL_INVE_REF_ART_B_TBL_BODE;

alter table TBL_INVENTARIO_ARTICULOS
   drop constraint FK_TBL_INVE_REF_ART_U_TBL_UND_;

alter table TBL_INVENTARIO_ARTICULOS
   drop constraint FK_TBL_INVE_REF_CATEG_TBL_CATE;

alter table TBL_TIPO_CAMBIO
   drop constraint FK_TBL_TIPO_REF_TC_MO_TBL_MONE;

alter table TBL_USUARIOS
   drop constraint FK_TBL_USUA_REF_USER__TBL_PERM;

alter table TBL_VENTAS
   drop constraint FK_TBL_VENT_REF_DET_V_TBL_DETA;

alter table TBL_VENTAS
   drop constraint FK_TBL_VENT_REF_DET_V_TBL_TIPO;

alter table TBL_VENTAS
   drop constraint FK_TBL_VENT_REF_EMPRE_TBL_EMPR;

alter table TBL_VENTAS
   drop constraint FK_TBL_VENT_REF_USER__TBL_USUA;

drop table TBL_BARRIOS cascade constraints;

alter table TBL_BODEGAS
   drop primary key cascade;

drop table TBL_BODEGAS cascade constraints;

alter table TBL_CANTONES
   drop primary key cascade;

drop table TBL_CANTONES cascade constraints;

alter table TBL_CATEGORIA
   drop primary key cascade;

drop table TBL_CATEGORIA cascade constraints;

alter table TBL_CLIENT_PROV
   drop primary key cascade;

drop table TBL_CLIENT_PROV cascade constraints;

alter table TBL_DETALLE_DEV
   drop primary key cascade;

drop table TBL_DETALLE_DEV cascade constraints;

alter table TBL_DETALLE_VENTA
   drop primary key cascade;

drop table TBL_DETALLE_VENTA cascade constraints;

alter table TBL_DISTRITOS
   drop primary key cascade;

drop table TBL_DISTRITOS cascade constraints;

alter table TBL_EMPRESA
   drop primary key cascade;

drop table TBL_EMPRESA cascade constraints;

alter table TBL_INGRESOS_DEV
   drop primary key cascade;

drop table TBL_INGRESOS_DEV cascade constraints;

alter table TBL_INVENTARIO_ARTICULOS
   drop primary key cascade;

drop table TBL_INVENTARIO_ARTICULOS cascade constraints;

alter table TBL_MONEDAS
   drop primary key cascade;

drop table TBL_MONEDAS cascade constraints;

alter table TBL_PERMISOS_USUARIOS
   drop primary key cascade;

drop table TBL_PERMISOS_USUARIOS cascade constraints;

alter table TBL_PROVINCIAS
   drop primary key cascade;

drop table TBL_PROVINCIAS cascade constraints;

drop table TBL_TIPO_CAMBIO cascade constraints;

alter table TBL_TIPO_CIA
   drop primary key cascade;

drop table TBL_TIPO_CIA cascade constraints;

alter table TBL_TIPO_IDENTIFICACION
   drop primary key cascade;

drop table TBL_TIPO_IDENTIFICACION cascade constraints;

alter table TBL_TIPO_RELACION
   drop primary key cascade;

drop table TBL_TIPO_RELACION cascade constraints;

alter table TBL_UND_MED
   drop primary key cascade;

drop table TBL_UND_MED cascade constraints;

alter table TBL_USUARIOS
   drop primary key cascade;

drop table TBL_USUARIOS cascade constraints;

alter table TBL_VENTAS
   drop primary key cascade;

drop table TBL_VENTAS cascade constraints;

/*==============================================================*/
/* Table: TBL_BARRIOS                                           */
/*==============================================================*/
create table TBL_BARRIOS 
(
   ID_PROVINCIA         INTEGER,
   ID_CANTON            INTEGER,
   ID_DISTRITO          INTEGER,
   ID_BARRIO            INTEGER              not null,
   BARRIO               VARCHAR2(50)
);

/*==============================================================*/
/* Table: TBL_BODEGAS                                           */
/*==============================================================*/
create table TBL_BODEGAS 
(
   ID_CIA               INTEGER,
   ID_BODEGA            INTEGER              not null,
   ID_ARTICULO          INTEGER,
   COD_BODEGA           VARCHAR(10),
   DESCRIPCION          VARCHAR(100),
   UBICACION            VARCHAR(100),
   STOCK                INTEGER
);

alter table TBL_BODEGAS
   add constraint PK_TBL_BODEGAS primary key (ID_BODEGA);

/*==============================================================*/
/* Table: TBL_CANTONES                                          */
/*==============================================================*/
create table TBL_CANTONES 
(
   ID_PROVINCIA         INTEGER,
   ID_CANTON            INTEGER              not null,
   CANTON               VARCHAR2(20)
);

alter table TBL_CANTONES
   add constraint PK_TBL_CANTONES primary key (ID_CANTON);

/*==============================================================*/
/* Table: TBL_CATEGORIA                                         */
/*==============================================================*/
create table TBL_CATEGORIA 
(
   ID_CATEGORIA         INTEGER              not null,
   CATEGORIA            VARCHAR2(50),
   DESCRIPCION          VARCHAR2(255 BYTE),
   ESTADO               CHAR(1)
);

alter table TBL_CATEGORIA
   add constraint PK_TBL_CATEGORIA primary key (ID_CATEGORIA);

/*==============================================================*/
/* Table: TBL_CLIENT_PROV                                       */
/*==============================================================*/
create table TBL_CLIENT_PROV 
(
   ID_CIA               INTEGER,
   ID_CLI_PROV          INTEGER              not null,
   ID_TIPO_IDENTIFICACION INTEGER,
   ID_TIPO_RELACION     INTEGER,
   NOMBRE               VARCHAR2(100),
   NUM_DOC              VARCHAR2(20),
   ID_PROVINCIA         INTEGER,
   ID_CANTON            INTEGER,
   ID_DISTRITO          INTEGER,
   ID_BARRIO            INTEGER,
   DIRECCION            VARCHAR2(200),
   TELEFONO             VARCHAR2(20),
   EMAIL                VARCHAR2(50),
   WEB                  VARCHAR2(60)
);

alter table TBL_CLIENT_PROV
   add constraint PK_TBL_CLIENT_PROV primary key (ID_CLI_PROV);

/*==============================================================*/
/* Table: TBL_DETALLE_DEV                                       */
/*==============================================================*/
create table TBL_DETALLE_DEV 
(
   ID_ING_DEV           INTEGER              not null,
   ID_INGRESO           INTEGER,
   ID_ARTICULO          INTEGER,
   CANTIDAD             INTEGER,
   PRECIO               INTEGER
);

alter table TBL_DETALLE_DEV
   add constraint PK_TBL_DETALLE_DEV primary key (ID_ING_DEV);

/*==============================================================*/
/* Table: TBL_DETALLE_VENTA                                     */
/*==============================================================*/
create table TBL_DETALLE_VENTA 
(
   ID_DETALLE_VENTA     INTEGER              not null,
   ID_VENTA             INTEGER,
   ID_ARTICULO          INTEGER,
   ID_BODEGA            INTEGER,
   PRECIO               NUMBER(11,2),
   DESCUENTO            NUMBER(11,2)
);

alter table TBL_DETALLE_VENTA
   add constraint PK_TBL_DETALLE_VENTA primary key (ID_DETALLE_VENTA);

/*==============================================================*/
/* Table: TBL_DISTRITOS                                         */
/*==============================================================*/
create table TBL_DISTRITOS 
(
   ID_PROVINCIA         INTEGER,
   ID_CANTON            INTEGER,
   ID_DISTRITO          INTEGER              not null,
   DISTRITO             VARCHAR2(20)
);

alter table TBL_DISTRITOS
   add constraint PK_TBL_DISTRITOS primary key (ID_DISTRITO);

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
   DIRECCION            VARCHAR(255),
   TEL1                 VARCHAR(15),
   TEL2                 VARCHAR(15),
   FAX                  VARCHAR(15),
   CP                   VARCHAR(10),
   WEB                  VARCHAR(60),
   E_MAIL               VARCHAR(60)
);

alter table TBL_EMPRESA
   add constraint PK_TBL_EMPRESA primary key (ID_CIA);

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
   ID_BODEGA            INTEGER,
   ID_VENTA             INTEGER
);

alter table TBL_INGRESOS_DEV
   add constraint PK_TBL_INGRESOS_DEV primary key (ID_INGRESO);

/*==============================================================*/
/* Table: TBL_INVENTARIO_ARTICULOS                              */
/*==============================================================*/
create table TBL_INVENTARIO_ARTICULOS 
(
   ID_ARTICULO          INTEGER              not null,
   ID_CATEGORIA         INTEGER,
   ID_BODEGA            INTEGER,
   CODIGO               VARCHAR2(50),
   NOMBRE               VARCHAR2(100),
   ID_UND_MEDIDA        INTEGER,
   PRECIO_VENTA         NUMBER(11,2),
   DESCRIPCION          VARCHAR2(255),
   IMAGEN               VARCHAR2(20),
   ESTADO               CHAR(1)
);

alter table TBL_INVENTARIO_ARTICULOS
   add constraint PK_TBL_INVENTARIO_ARTICULOS primary key (ID_ARTICULO);

/*==============================================================*/
/* Table: TBL_MONEDAS                                           */
/*==============================================================*/
create table TBL_MONEDAS 
(
   ID_MONEDA            INTEGER              not null,
   COD_MONEDA           VARCHAR2(10),
   DESCRIPCION          VARCHAR2(20)
);

alter table TBL_MONEDAS
   add constraint PK_TBL_MONEDAS primary key (ID_MONEDA);

/*==============================================================*/
/* Table: TBL_PERMISOS_USUARIOS                                 */
/*==============================================================*/
create table TBL_PERMISOS_USUARIOS 
(
   ID_ROL               INTEGER              not null,
   NOMBRE               VARCHAR2(20),
   DESCRIPCION          VARCHAR2(255),
   ESTADO               VBIN1
);

alter table TBL_PERMISOS_USUARIOS
   add constraint PK_TBL_PERMISOS_USUARIOS primary key (ID_ROL);

/*==============================================================*/
/* Table: TBL_PROVINCIAS                                        */
/*==============================================================*/
create table TBL_PROVINCIAS 
(
   ID_PROVINCIA         INTEGER              not null,
   PROVINCIA            VARCHAR2(20)
);

alter table TBL_PROVINCIAS
   add constraint PK_TBL_PROVINCIAS primary key (ID_PROVINCIA);

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
);

/*==============================================================*/
/* Table: TBL_TIPO_CIA                                          */
/*==============================================================*/
create table TBL_TIPO_CIA 
(
   ID_TIPO_CIA          INTEGER              not null,
   TIPO_EMPRESA         VARCHAR2(50),
   DESCRIPCION          VARCHAR2(255)
);

alter table TBL_TIPO_CIA
   add constraint PK_TBL_TIPO_CIA primary key (ID_TIPO_CIA);

/*==============================================================*/
/* Table: TBL_TIPO_IDENTIFICACION                               */
/*==============================================================*/
create table TBL_TIPO_IDENTIFICACION 
(
   ID_TIPO_IDENTIFICACION INTEGER              not null,
   PERSONERIA           VARCHAR2(20)
);

alter table TBL_TIPO_IDENTIFICACION
   add constraint PK_TBL_TIPO_IDENTIFICACION primary key (ID_TIPO_IDENTIFICACION);

/*==============================================================*/
/* Table: TBL_TIPO_RELACION                                     */
/*==============================================================*/
create table TBL_TIPO_RELACION 
(
   ID_TIPO_RELACION     INTEGER              not null,
   RELACION             VARCHAR2(20)
);

alter table TBL_TIPO_RELACION
   add constraint PK_TBL_TIPO_RELACION primary key (ID_TIPO_RELACION);

/*==============================================================*/
/* Table: TBL_UND_MED                                           */
/*==============================================================*/
create table TBL_UND_MED 
(
   ID_UND_MEDIDA        INTEGER              not null,
   COD_MEDIDA           VARCHAR2(10),
   DESCRIPCION          VARCHAR2(30)
);

alter table TBL_UND_MED
   add constraint PK_TBL_UND_MED primary key (ID_UND_MEDIDA);

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
   ESTADO               CHAR(1)
);

alter table TBL_USUARIOS
   add constraint PK_TBL_USUARIOS primary key (ID_USUARIO);

/*==============================================================*/
/* Table: TBL_VENTAS                                            */
/*==============================================================*/
create table TBL_VENTAS 
(
   ID_CIA               INTEGER,
   ID_VENTA             INTEGER              not null,
   ID_DETALLE_VENTA     INTEGER,
   ID_CLIENTE           INTEGER,
   ID_USUARIO           INTEGER,
   ID_COMPROBANTE       VARCHAR2(10),
   FECHA                DATE,
   HORA                 DATE,
   IMPUESTO             NUMBER(10,2),
   TOTAL                NUMBER(10,2),
   ESTADO               CHAR(1),
   ID_TC                INTEGER
);

comment on table TBL_VENTAS is
'Esta Tabla lleva control de las transacciones de ventas o salidas de la bodega';

alter table TBL_VENTAS
   add constraint PK_TBL_VENTAS primary key (ID_VENTA);

alter table TBL_BARRIOS
   add constraint FK_TBL_BARR_REF_DISTR_TBL_DIST foreign key (ID_DISTRITO)
      references TBL_DISTRITOS (ID_DISTRITO);

alter table TBL_BODEGAS
   add constraint FK_TBL_BODE_REF_EMP_B_TBL_EMPR foreign key (ID_CIA)
      references TBL_EMPRESA (ID_CIA);

alter table TBL_CANTONES
   add constraint FK_TBL_CANT_REF_PROV__TBL_PROV foreign key (ID_PROVINCIA)
      references TBL_PROVINCIAS (ID_PROVINCIA);

alter table TBL_CLIENT_PROV
   add constraint FK_TBL_CLIE_REF_CLIPR_TBL_BARR foreign key (ID_BARRIO)
      references TBL_BARRIOS (ID_BARRIO);

alter table TBL_CLIENT_PROV
   add constraint FK_TBL_CLIE_REF_CLIPR_TBL_CANT foreign key (ID_CANTON)
      references TBL_CANTONES (ID_CANTON);

alter table TBL_CLIENT_PROV
   add constraint FK_TBL_CLIE_REF_CLIPR_TBL_DIST foreign key (ID_DISTRITO)
      references TBL_DISTRITOS (ID_DISTRITO);

alter table TBL_CLIENT_PROV
   add constraint FK_TBL_CLIE_REF_EMP_C_TBL_EMPR foreign key (ID_CIA)
      references TBL_EMPRESA (ID_CIA);

alter table TBL_CLIENT_PROV
   add constraint FK_TBL_CLIE_REF_ID_RE_TBL_TIPO foreign key (ID_TIPO_RELACION)
      references TBL_TIPO_RELACION (ID_TIPO_RELACION);

alter table TBL_CLIENT_PROV
   add constraint FK_TBL_CLIE_REF_PERSO_TBL_TIPO foreign key (ID_TIPO_IDENTIFICACION)
      references TBL_TIPO_IDENTIFICACION (ID_TIPO_IDENTIFICACION);

alter table TBL_CLIENT_PROV
   add constraint FK_TBL_CLIE_REF_PROV__TBL_PROV foreign key (ID_PROVINCIA)
      references TBL_PROVINCIAS (ID_PROVINCIA);

alter table TBL_DETALLE_DEV
   add constraint FK_TBL_DETA_REF_DET_I_TBL_INGR foreign key (ID_INGRESO)
      references TBL_INGRESOS_DEV (ID_INGRESO);

alter table TBL_DETALLE_VENTA
   add constraint FK_TBL_DETA_REF_BODEG_TBL_BODE foreign key (ID_BODEGA)
      references TBL_BODEGAS (ID_BODEGA);

alter table TBL_DISTRITOS
   add constraint FK_TBL_DIST_REF_CANTO_TBL_CANT foreign key (ID_CANTON)
      references TBL_CANTONES (ID_CANTON);

alter table TBL_EMPRESA
   add constraint FK_TBL_EMPR_REF_CIA_E_TBL_TIPO foreign key (ID_TIPO_CIA)
      references TBL_TIPO_CIA (ID_TIPO_CIA);

alter table TBL_INGRESOS_DEV
   add constraint FK_TBL_INGR_REF_BOD_D_TBL_BODE foreign key (ID_BODEGA)
      references TBL_BODEGAS (ID_BODEGA);

alter table TBL_INGRESOS_DEV
   add constraint FK_TBL_INGR_REF_DEV_V_TBL_VENT foreign key (ID_VENTA)
      references TBL_VENTAS (ID_VENTA);

alter table TBL_INGRESOS_DEV
   add constraint FK_TBL_INGR_REV_DEB_E_TBL_EMPR foreign key (ID_CIA)
      references TBL_EMPRESA (ID_CIA);

alter table TBL_INVENTARIO_ARTICULOS
   add constraint FK_TBL_INVE_REF_ART_B_TBL_BODE foreign key (ID_BODEGA)
      references TBL_BODEGAS (ID_BODEGA);

alter table TBL_INVENTARIO_ARTICULOS
   add constraint FK_TBL_INVE_REF_ART_U_TBL_UND_ foreign key (ID_UND_MEDIDA)
      references TBL_UND_MED (ID_UND_MEDIDA);

alter table TBL_INVENTARIO_ARTICULOS
   add constraint FK_TBL_INVE_REF_CATEG_TBL_CATE foreign key (ID_CATEGORIA)
      references TBL_CATEGORIA (ID_CATEGORIA);

alter table TBL_TIPO_CAMBIO
   add constraint FK_TBL_TIPO_REF_TC_MO_TBL_MONE foreign key (ID_MONEDA)
      references TBL_MONEDAS (ID_MONEDA);

alter table TBL_USUARIOS
   add constraint FK_TBL_USUA_REF_USER__TBL_PERM foreign key (ID_ROL)
      references TBL_PERMISOS_USUARIOS (ID_ROL);

alter table TBL_VENTAS
   add constraint FK_TBL_VENT_REF_DET_V_TBL_DETA foreign key (ID_DETALLE_VENTA)
      references TBL_DETALLE_VENTA (ID_DETALLE_VENTA);

alter table TBL_VENTAS
   add constraint FK_TBL_VENT_REF_DET_V_TBL_TIPO foreign key (ID_TC)
      references TBL_TIPO_CAMBIO (ID_TC);

alter table TBL_VENTAS
   add constraint FK_TBL_VENT_REF_EMPRE_TBL_EMPR foreign key (ID_CIA)
      references TBL_EMPRESA (ID_CIA);

alter table TBL_VENTAS
   add constraint FK_TBL_VENT_REF_USER__TBL_USUA foreign key (ID_USUARIO)
      references TBL_USUARIOS (ID_USUARIO);

