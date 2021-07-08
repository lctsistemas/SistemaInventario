use Dbinventario
GO
--   PROCEDIMIENTOS PARA EMPRESA
alter PROC manto.SP_AddEmpresa
@id_empresa int = null,
@ruc char(11), 
@razon_social varchar(100),
@nombre_comercial varchar(50),
@direccion nvarchar(250),
@domicilio_fiscal nvarchar(250),
@regimen varchar(80),
@estado varchar(15)
AS BEGIN
	SET @id_empresa = (SELECT count(e.id_empresa) FROM manto.Empresa e)
	IF(@id_empresa = 0)
		SET @id_empresa = 1	
	ELSE
		SET @id_empresa = (SELECT MAX(e.id_empresa)+1 FROM manto.Empresa e)

INSERT INTO manto.Empresa(id_empresa, ruc, razon_social, nombre_comercial, direccion, domicilio_fiscal, regimen, estado)
VALUES(@id_empresa, @ruc, @razon_social, @nombre_comercial, @direccion, @domicilio_fiscal, @regimen, @estado)
END
GO

CREATE PROC manto.SP_EditEmpresa
@id_empresa int,
@ruc char(11), 
@razon_social varchar(100),
@nombre_comercial varchar(50),
@direccion nvarchar(250),
@domicilio_fiscal nvarchar(250),
@regimen varchar(80),
@estado varchar(15)
AS BEGIN
UPDATE manto.Empresa SET ruc=@ruc, razon_social=@razon_social, nombre_comercial = @nombre_comercial, 
direccion = @direccion, domicilio_fiscal = @domicilio_fiscal, regimen = @regimen, estado = @estado
WHERE id_empresa = @id_empresa
END
GO

CREATE PROC manto.SP_DelteEmpresa
@id_empresa int,
@estado varchar(15)
AS BEGIN
UPDATE manto.Empresa SET estado = @estado
END
GO


CREATE PROC manto.SP_ShowEmpresa
@estado varchar(15)
AS BEGIN
SELECT  e.id_empresa, e.ruc, e.razon_social, e.nombre_comercial, e.direccion, 
e.domicilio_fiscal, e.regimen FROM manto.Empresa e WHERE e.estado = @estado
END
GO

--	PROCEDIMIENTO PARA CLIENTE PROVEEDOR
CREATE PROC manto.SP_AddCliProv
@idcliprov int = null,
@nom_prov varchar(60), 
@ruc char(11)
AS BEGIN
	SET @idcliprov = (SELECT count(c.idcliprov) FROM manto.clienteProv c)
	IF(@idcliprov = 0)
		SET @idcliprov = 1	
	ELSE
		SET @idcliprov = (SELECT MAX(c.idcliprov)+1 FROM manto.clienteProv c)

INSERT INTO manto.clienteProv(idcliprov, nom_prov, ruc)
VALUES(@idcliprov, @nom_prov, @ruc)
END
GO

--PROCEDIMIENTO PARA EDITAR PROVEEDOR
CREATE PROC manto.SP_EditCliProv
@idcliprov int,
@nom_prov varchar(60), 
@ruc char(11)
AS BEGIN
UPDATE manto.clienteProv SET nom_prov=@nom_prov, ruc=@ruc
WHERE idcliprov = @idcliprov
END
GO

ALTER PROC manto.SP_DeleteCliProv
@idcliprov int
AS BEGIN
	DELETE from clienteProv where idcliprov=@idcliprov
END
GO


CREATE PROC manto.SP_ShowCliProv
AS BEGIN
SELECT  c.idcliprov, c.nom_prov, c.ruc FROM manto.clienteProv c
END
GO

-- PROCEDIMIENTO PARA TIPO DE OPERACION
CREATE PROC manto.SP_AddTipoOper
@idtipOper int = null,
@codigo char(11), 
@descripcion varchar(100)
AS BEGIN
	SET @idtipOper = (SELECT count(t.idTipoOper) FROM manto.TipoOperacion t)
	IF(@idtipOper = 0)
		SET @idtipOper = 1	
	ELSE
		SET @idtipOper = (SELECT MAX(t.idTipoOper)+1 FROM manto.TipoOperacion t)

INSERT INTO manto.TipoOperacion(idTipoOper, codigo, descripcion)
VALUES(@idtipOper, @codigo, @descripcion)
END
GO

--PROCEDIMIENTO PARA EDITAR TIPO OPERACION
CREATE PROC manto.SP_EditTipoOper
@idtipOper int,
@codigo char(11), 
@descripcion varchar(100)
AS BEGIN
UPDATE manto.TipoOperacion SET codigo=@codigo, descripcion=@descripcion
WHERE idTipoOper = @idtipOper
END
GO

ALTER PROC manto.SP_DeleteTipoOpera
@idtipOper int
AS BEGIN
	DELETE from TipoOperacion where idTipoOper=@idtipOper
END
go

CREATE PROC manto.SP_ShowTipoOper
AS BEGIN
SELECT  t.idTipoOper, t.codigo, t.descripcion FROM manto.TipoOperacion t
END
GO

-- PROCEDIMIENTO PARA MONEDA
CREATE PROC manto.SP_AddMoneda
@idmoneda int = null,
@codigo char(11),
@nom_moneda varchar(10),
@abrev varchar(5),
@simbolo varchar(3),
@descripcion varchar(100)
AS BEGIN
	SET @idmoneda = (SELECT count(m.idMoneda) FROM manto.Moneda m)
	IF(@idmoneda = 0)
		SET @idmoneda = 1	
	ELSE
		SET @idmoneda = (SELECT MAX(m.idMoneda)+1 FROM manto.Moneda m)

INSERT INTO manto.Moneda(idMoneda, codigo, nom_moneda, abrev, simbolo, descripcion)
VALUES(@idmoneda, @codigo, @nom_moneda,@abrev,@simbolo,@descripcion)
END
GO

--PROCEDIMIENTO PARA EDITAR MONEDA
CREATE PROC manto.SP_EditMoneda
@idmoneda int,
@codigo char(11), 
@nom_moneda varchar(10),
@abrev varchar(5),
@simbolo varchar(3),
@descripcion varchar(100)
AS BEGIN
UPDATE manto.Moneda SET codigo=@codigo, nom_moneda=@nom_moneda,abrev=@abrev,simbolo=@simbolo,descripcion=@descripcion
WHERE idMoneda=@idmoneda
END
GO

--PROCEDIMIENTO PARA ELIMINAR MONEDA
CREATE PROC manto.SP_DeleteMoneda
@idmoneda int
AS BEGIN
	DELETE from Moneda where idMoneda=@idmoneda
END
go

--PROCEDIMIENTO PARA MOSTRAR MONEDA
CREATE PROC manto.SP_ShowMon
AS BEGIN
SELECT  m.idMoneda, m.codigo,m.nom_moneda, m.abrev,m.simbolo,m.descripcion FROM manto.Moneda m
END
GO

-- PROCEDIMIENTO PARA DOCUMENTO
CREATE PROC manto.SP_AddDocumento
@iddoc int = null,
@codigo char(11), 
@descripcion varchar(100)
AS BEGIN
	SET @iddoc = (SELECT count(d.idTipoDoc) FROM manto.TipoDocumento d)
	IF(@iddoc = 0)
		SET @iddoc = 1	
	ELSE
		SET @iddoc = (SELECT MAX(d.idTipoDoc)+1 FROM manto.TipoDocumento d)

INSERT INTO manto.TipoDocumento(idTipoDoc, codigo, descripcion)
VALUES(@iddoc, @codigo, @descripcion)
END
GO

--PROCEDIMIENTO PARA EDITAR DOCUMENTO
CREATE PROC manto.SP_EditDocumento
@iddoc int,
@codigo char(11), 
@descripcion varchar(100)
AS BEGIN
UPDATE manto.TipoDocumento SET codigo=@codigo, descripcion=@descripcion
WHERE idTipoDoc=@iddoc
END
GO

--PROCEDIMIENTO PARA MOSTRAR DOCUMENTO
CREATE PROC manto.SP_ShowDoc
AS BEGIN
SELECT  t.idTipoDoc, t.codigo, t.descripcion FROM manto.TipoDocumento t
END
GO

-- PROCEDIMIENTO PARA UNIDAD DE MEDIDA
CREATE PROC manto.sp_AddUnidadMedida
@idUnidadMedida int = null,
@codigo char(11), 
@abrev varchar(5),
@descripcion varchar(60)
AS BEGIN
	SET @idUnidadMedida = (SELECT count(um.idUnidadMedida) FROM manto.UnidadMedida um)
	IF(@idUnidadMedida = 0)
		SET @idUnidadMedida = 1	
	ELSE
		SET @idUnidadMedida = (SELECT MAX(um.idUnidadMedida)+1 FROM manto.UnidadMedida um)

INSERT INTO manto.UnidadMedida(idUnidadMedida, codigo, abrev, descripcion)
VALUES(@idUnidadMedida, @codigo, @abrev, @descripcion)
END

GO

--PROCEDIMIENTO PARA EDITAR UNIDAD MEDIDA
CREATE PROC manto.SP_EditUnidMedida
@idUnidadMedida int,
@codigo char(11), 
@abrev varchar(5),
@descripcion varchar(60)
AS BEGIN
UPDATE manto.UnidadMedida SET codigo=@codigo, abrev=@abrev, descripcion=@descripcion
WHERE idUnidadMedida=@idUnidadMedida
END
GO

--PROCEDIMIENTO PARA MOSTRAR UNIDAD MEDIDA
CREATE PROC manto.SP_ShowUnidadMed
AS BEGIN
SELECT  u.idUnidadMedida,u.codigo,u.abrev,u.descripcion FROM manto.UnidadMedida u
END
GO


/*  PROCEDIMIENTO DE INICIO DE SESION  */

/*   SCRIP PARA PERIODO       */
CREATE PROC manto.ShowPeriodo
@periodo int,
@idperiodo int output
AS BEGIN	
	SET @idperiodo=(SELECT p.idperiodo FROM manto.Periodo p WHERE p.desc_periodo=@periodo)			
END
GO

/* MES */

CREATE PROC manto.sp_showMes
as begin
select idmes, nombre_mes from manto.Mes
end
go

--   PROCEDIMIENTO PARA REGISTRAR INVENTARIO MASIVO 1
CREATE TYPE invent.Detail AS TABLE(
id int,
cod_catalogo varchar(2), 
tipo_existencia varchar(4), 
cod_existencia varchar(30), 
fecha_emision date,
tipo_documento char(2),
serie varchar(30),
num_documento varchar(30),
tipo_operacion char(2),
existencia varchar(100),
unida_medida varchar(4),
entradas decimal(14,2),
salidas decimal (14,2),
id_empresa int, 
idperiodo smallint,
idmes tinyint
primary key(id)
)
GO

ALTER PROC invent.SP_GUARDAR_INV
@ListInventario invent.Detail READONLY
AS BEGIN

INSERT INTO invent.Inventario(id_inventario, cod_catalogo, tipo_existencia,cod_existencia, 
fecha_emision, tipo_documento, serie, num_documento, tipo_operacion, existencia, 
unida_medida, entradas, salidas, id_empresa, idperiodo, idmes)

SELECT @id_inventario, cod_catalogo, tipo_existencia,cod_existencia, 
fecha_emision, tipo_documento, serie, num_documento, tipo_operacion, existencia,
unida_medida, entradas, salidas, id_empresa, idperiodo, idmes FROM @ListInventario
END
GO

-- PROCEDIMIENTO PARA REGISTRAR INVENTARIO MASIVO 2 PERO CON FOREACH EN C#
CREATE PROC invent.SP_RegistrarInv
@cod_catalogo varchar(2), 
@tipo_existencia varchar(4), 
@cod_existencia varchar(30), 
@fecha_emision date,
@tipo_documento char(2),
@serie varchar(30),
@num_documento varchar(30),
@tipo_operacion char(2),
@existencia varchar(100),
@unida_medida varchar(4),
@entradas decimal(14,2),
@salidas decimal (14,2),
@id_empresa int, 
@idperiodo smallint,
@idmes tinyint
AS BEGIN
DECLARE @id_inventario bigint
SET @id_inventario = (SELECT ISNULL(MAX(i.id_inventario), 0) + 1 FROM invent.Inventario i)

INSERT INTO invent.Inventario(id_inventario, cod_catalogo, tipo_existencia,cod_existencia, 
fecha_emision, tipo_documento, serie, num_documento, tipo_operacion, existencia, 
unida_medida, entradas, salidas, id_empresa, idperiodo, idmes)
VALUES (@id_inventario, @cod_catalogo, @tipo_existencia, @cod_existencia, 
@fecha_emision, @tipo_documento, @serie, @num_documento, @tipo_operacion, @existencia, 
@unida_medida, @entradas, @salidas, @id_empresa, @idperiodo, @idmes)
END
GO

-- PROCEDIMIENTO PARA VALIDAR INVENTARIO


@idempresa int,
@idmes tinyint,
@idperiodo smallint,
@output bit output
AS BEGIN
IF(EXISTS(SELECT  i.id_inventario FROM invent.Inventario i WHERE i.id_empresa = @idempresa AND i.idmes = @idmes AND i.idperiodo = @idperiodo))
SET @output = 0 --false
ELSE
SET @output = 1 --true
END
GO

select * from invent.Inventario  where  existencia = 'CHOCOLATE NESTLE BOLSA (12u+15u)'
delete from invent.Inventario where existencia = 'CHOCOLATE NESTLE BOLSA (12u+15u)'
GO
CREATE PROC invent.SP_ 
select COUNT(i.id_inventario) as Nro,i.cod_existencia, i.existencia, SUM(i.entradas)as entradas, SUM(i.salidas) as salidas, 
(SUM(i.entradas) - SUM(i.salidas)) as final from invent.Inventario i
group by i.cod_existencia, i.existencia