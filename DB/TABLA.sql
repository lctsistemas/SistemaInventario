--schemas inventario
--schemas mantenimiento
--create database Dbinventario
use Dbinventario
go
--create schema manto authorization dbo
go
--create schema invent authorization dbo
go

-- TABLA EMPRESA
CREATE TABLE manto.Empresa(
id_empresa int not null,
ruc char(11) not null CONSTRAINT UNQ_ruc UNIQUE,
razon_social varchar(100) not null,
nombre_comercial varchar(50) null,
direccion nvarchar(250) not null,
domicilio_fiscal nvarchar(250) null,
regimen varchar(80) not null,
estado varchar(15) not null,
)
GO

CREATE TABLE manto.clienteProv(
idcliprov int not null,
nom_prov varchar(60) not null,
ruc char(11) not null CONSTRAINT UNQ_ruc_prov UNIQUE,
)
GO

CREATE TABLE manto.TipoOperacion(
idTipoOper int not null,
codigo char(11) not null CONSTRAINT UNQ_codigo UNIQUE,
descripcion varchar(100) not null
)

CREATE TABLE manto.Moneda(
idMoneda int not null,
codigo char(11) not null CONSTRAINT UNQ_cod_mon UNIQUE,
nom_moneda varchar(10),
abrev varchar(5) CONSTRAINT UNQ_abrev UNIQUE,
simbolo char(3),
descripcion varchar(50)
)

CREATE TABLE manto.TipoDocumento(
idTipoDoc int not null,
codigo char(11) not null CONSTRAINT UNQ_cod_doc UNIQUE,
descripcion varchar(50)
)

CREATE TABLE manto.UnidadMedida(
idUnidadMedida int not null,
codigo char(11) not null CONSTRAINT UNQ_cod_um UNIQUE,
abrev varchar(5) CONSTRAINT UNQ_abrev_um UNIQUE,
descripcion varchar(60),
)
go

