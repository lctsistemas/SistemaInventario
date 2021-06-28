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
id_empresa int not null,0
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
GO

CREATE TABLE manto.Moneda(
idMoneda int not null,
codigo char(11) not null CONSTRAINT UNQ_cod_mon UNIQUE,
nom_moneda varchar(10),
abrev varchar(5) CONSTRAINT UNQ_abrev UNIQUE,
simbolo char(3),
descripcion varchar(50)
)
GO

CREATE TABLE manto.TipoDocumento(
idTipoDoc int not null,
codigo char(11) not null CONSTRAINT UNQ_cod_doc UNIQUE,
descripcion varchar(50)
)
GO

CREATE TABLE manto.UnidadMedida(
idUnidadMedida int not null,
codigo char(11) not null CONSTRAINT UNQ_cod_um UNIQUE,
abrev varchar(5) CONSTRAINT UNQ_abrev_um UNIQUE,
descripcion varchar(60),
)
GO

CREATE TABLE manto.Mes(
idmes tinyint identity(1,1),
nombre_mes varchar(10) not null
)
GO

CREATE TABLE manto.Periodo(
idperiodo smallint identity(1,1),
desc_periodo int
)
GO

--PRIMARY KEY
ALTER TABLE manto.Empresa ADD CONSTRAINT PK_idempresa PRIMARY KEY(id_empresa)
ALTER TABLE manto.clienteProv ADD CONSTRAINT PK_idclipro PRIMARY KEY(idcliprov)
ALTER TABLE manto.Moneda ADD CONSTRAINT PK_idmoneda PRIMARY KEY(idMoneda)
ALTER TABLE manto.TipoDocumento ADD CONSTRAINT PK_idtipodoc PRIMARY KEY(idTipoDoc)
ALTER TABLE manto.TipoOperacion ADD CONSTRAINT PK_idtipooper PRIMARY KEY(idTipoOper)
ALTER TABLE manto.UnidadMedida ADD CONSTRAINT PK_iduni_med PRIMARY KEY(idUnidadMedida)
ALTER TABLE manto.Mes ADD CONSTRAINT PK_idmes PRIMARY KEY(idmes)
GO

--INSERTAR
INSERT INTO manto.Mes(nombre_mes) VALUES
('ENERO'),('FEBRERO'),('MARZO'),
('ABRIL'),('MAYO'),('JUNIO'),
('JULIO'),('AGOSTO'),('SETIEMBRE'),
('OCTUBRE'),('NOVIEMBRE'),('DICIEMBRE')
GO
select * from manto.mes
GO

CREATE TABLE manto.Inventario(
id_inventario bigint not null,
cod_catalogo varchar(2), --1 dig
tipo_existencia varchar(4), -- 2 dig
cod_existencia varchar(30), --hasta 24 dig
fecha_emision date not null,
tipo_documento char(2) not null,
serie varchar(30) not null, --hasta 20 dig
num_documento varchar(30) not null, -- hasta 20 dig
tipo_operacion char(2) not null,
existencia varchar(100) not null, -- hasta 80 dig
unida_medida varchar(4) not null, -- hasta 3 dig
entradas decimal(14,2)not null,
salidas decimal (14,2)not null,
id_empresa int not null,
idperiodo int not null,
idmes int not null
)
select * from manto.Inventario