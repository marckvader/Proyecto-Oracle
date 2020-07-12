/*==============================================================*/
/* DBMS name:      ORACLE Version 11g                           */
/* Created on:     01/06/2020 22:06:19                          */
/*==============================================================*/


alter table TBL_BARRIOS
   drop constraint FK_TBL_BARR_DISTR_BAR_TBL_DIST;

alter table TBL_CANTONES
   drop constraint FK_TBL_CANT_PROV_CANT_TBL_PROV;

alter table TBL_CLIENT_PROV
   drop constraint FK_TBL_CLIE_ID_RELACI_TBL_TIPO;

alter table TBL_CLIENT_PROV
   drop constraint FK_TBL_CLIE_PERSONERI_TBL_TIPO;

alter table TBL_DISTRITOS
   drop constraint FK_TBL_DIST_CANTON_DI_TBL_CANT;

drop table TBL_BARRIOS cascade constraints;

drop table TBL_CANTONES cascade constraints;

drop table TBL_CLIENT_PROV cascade constraints;

drop table TBL_DISTRITOS cascade constraints;

drop table TBL_MONEDAS cascade constraints;

drop table TBL_PROVINCIAS cascade constraints;

drop table TBL_TIPO_PERSONERIA cascade constraints;

drop table TBL_TIPO_RELACION cascade constraints;

drop table TBL_UND_MED cascade constraints;

drop table TBL_USUARIOS cascade constraints;

/*==============================================================*/
/* Table: TBL_BARRIOS                                           */
/*==============================================================*/
create table TBL_BARRIOS 
(
   ID_PROVINCIA         INTEGER,
   ID_CANTON            INTEGER,
   ID_DISTRITO          INTEGER,
   ID_BARRIO            INT                  not null,
   BARRIO               VARCHAR2(50),
   constraint PK_TBL_BARRIOS primary key (ID_BARRIO)
);

/*==============================================================*/
/* Table: TBL_CANTONES                                          */
/*==============================================================*/
create table TBL_CANTONES 
(
   ID_PROVINCIA         INTEGER,
   ID_CANTON            INTEGER              not null,
   CANTON               VARCHAR2(20),
   constraint PK_TBL_CANTONES primary key (ID_CANTON)
);

/*==============================================================*/
/* Table: TBL_CLIENT_PROV                                       */
/*==============================================================*/
create table TBL_CLIENT_PROV 
(
   ID_CLI_PROV          INTEGER              not null,
   TBL_ID_TIPO_PERSONERIA INTEGER,
   ID_TIPO_PERSONERIA   VARCHAR2(20),
   NOMBRE               VARCHAR2(100),
   ID_TIPO_RELACION     INTEGER,
   NUM_DOC              VARCHAR2(20),
   DIRECCION            VARCHAR2(200),
   TELEFONO             VARCHAR2(20),
   EMAIL                VARCHAR2(50),
   WEB                  VARCHAR2(60),
   constraint PK_TBL_CLIENT_PROV primary key (ID_CLI_PROV)
);

/*==============================================================*/
/* Table: TBL_DISTRITOS                                         */
/*==============================================================*/
create table TBL_DISTRITOS 
(
   ID_PROVINCIA         INTEGER,
   ID_CANTON            INTEGER,
   ID_DISTRITO          INTEGER              not null,
   DISTRITO             VARCHAR2(20),
   constraint PK_TBL_DISTRITOS primary key (ID_DISTRITO)
);

/*==============================================================*/
/* Table: TBL_MONEDAS                                           */
/*==============================================================*/
create table TBL_MONEDAS 
(
   ID_MONEDA            INTEGER              not null,
   COD_MONEDA           VARCHAR2(10),
   DESCRIPCION          VARCHAR2(20),
   constraint PK_TBL_MONEDAS primary key (ID_MONEDA)
);

/*==============================================================*/
/* Table: TBL_PROVINCIAS                                        */
/*==============================================================*/
create table TBL_PROVINCIAS 
(
   ID_PROVINCIA         Int                  not null,
   PROVINCIA            VARCHAR2(20),
   constraint PK_TBL_PROVINCIAS primary key (ID_PROVINCIA)
);

/*==============================================================*/
/* Table: TBL_TIPO_PERSONERIA                                   */
/*==============================================================*/
create table TBL_TIPO_PERSONERIA 
(
   ID_TIPO_PERSONERIA   INTEGER              not null,
   PERSONERIA           VARCHAR2(20),
   constraint PK_TBL_TIPO_PERSONERIA primary key (ID_TIPO_PERSONERIA)
);

/*==============================================================*/
/* Table: TBL_TIPO_RELACION                                     */
/*==============================================================*/
create table TBL_TIPO_RELACION 
(
   ID_TIPO_RELACION     INTEGER              not null,
   RELACION             VARCHAR2(20),
   constraint PK_TBL_TIPO_RELACION primary key (ID_TIPO_RELACION)
);

/*==============================================================*/
/* Table: TBL_UND_MED                                           */
/*==============================================================*/
create table TBL_UND_MED 
(
   ID_UND_MEDIDA        INT                  not null,
   COD_MEDIDA           VARCHAR2(10),
   DESCRIPCION          VARCHAR2(30),
   constraint PK_TBL_UND_MED primary key (ID_UND_MEDIDA)
);

/*==============================================================*/
/* Table: TBL_USUARIOS                                          */
/*==============================================================*/
create table TBL_USUARIOS 
(
   ID_USUARIO           INT                  not null,
   ID_ROL               INT,
   NOMBRE               VARCHAR2(50),
   APELLIDO_1           VARCHAR2(50),
   APELLIDO_2           VARCHAR2(50),
   ID_TIPO_DOCUMENTO    VARCHAR2(20),
   NUM_IDENTIFICACION   VARCHAR2(20),
   DIRECCION            VARCHAR2(255),
   TELEFONO             VARCHAR2(20),
   EMAIL                VARCHAR2(255),
   PASSWORD             VARCHAR2(15),
   ESTADO               SMALLINT,
   constraint PK_TBL_USUARIOS primary key (ID_USUARIO)
);

alter table TBL_BARRIOS
   add constraint FK_TBL_BARR_DISTR_BAR_TBL_DIST foreign key (ID_DISTRITO)
      references TBL_DISTRITOS (ID_DISTRITO);

alter table TBL_CANTONES
   add constraint FK_TBL_CANT_PROV_CANT_TBL_PROV foreign key (ID_PROVINCIA)
      references TBL_PROVINCIAS (ID_PROVINCIA);

alter table TBL_CLIENT_PROV
   add constraint FK_TBL_CLIE_ID_RELACI_TBL_TIPO foreign key (ID_TIPO_RELACION)
      references TBL_TIPO_RELACION (ID_TIPO_RELACION);

alter table TBL_CLIENT_PROV
   add constraint FK_TBL_CLIE_PERSONERI_TBL_TIPO foreign key (TBL_ID_TIPO_PERSONERIA)
      references TBL_TIPO_PERSONERIA (ID_TIPO_PERSONERIA);

alter table TBL_DISTRITOS
   add constraint FK_TBL_DIST_CANTON_DI_TBL_CANT foreign key (ID_CANTON)
      references TBL_CANTONES (ID_CANTON);

