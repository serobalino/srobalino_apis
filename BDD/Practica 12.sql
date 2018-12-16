/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2016                    */
/* Created on:     16/12/2018 15:41:14                          */
/*==============================================================*/


if exists (select 1
            from  sysobjects
           where  id = object_id('personas')
            and   type = 'U')
   drop table personas
go

/*==============================================================*/
/* Table: personas                                              */
/*==============================================================*/
create table personas (
   id_pe                bigint               identity,
   nombres_pe           varchar(250)         null,
   email_pe             varchar(250)         null,
   bio_pe               text                 null,
   web_pe               varchar(500)         null,
   foto_pe              varchar(500)         null,
   dni_pe               varchar(250)         null,
   fecha_pe             date                 null,
   constraint pk_personas primary key (id_pe)
)
go

