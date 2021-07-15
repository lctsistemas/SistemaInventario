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
	set @id_empresa = (SELECT isnull(MAX(e.id_empresa), 0 )+1 FROM  manto.Empresa e)

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


ALTER PROC manto.SP_ShowEmpresa
@estado varchar(15)
AS BEGIN
SELECT  e.id_empresa, e.ruc, e.razon_social, e.nombre_comercial, e.direccion, 
e.domicilio_fiscal, e.regimen FROM manto.Empresa e WHERE e.estado = @estado
END
GO

exec manto.SP_ShowEmpresa 'ACTIVO'

--	PROCEDIMIENTO PARA CLIENTE PROVEEDOR
ALTER PROC manto.SP_AddCliProv
@idcliprov int = null,
@nom_prov varchar(60), 
@ruc char(11)
AS BEGIN
	set @idcliprov = (SELECT isnull(MAX(c.idcliprov), 0 )+1 FROM manto.clienteProv c)

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
ALTER PROC manto.SP_AddTipoOper
@idtipOper int = null,
@codigo char(11), 
@descripcion varchar(100)
AS BEGIN
	set @idtipOper = (SELECT isnull(MAX(t.idTipoOper), 0 )+1 FROM manto.TipoOperacion t)

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

CREATE PROC manto.SP_DeleteTipoOpera
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
ALTER PROC manto.SP_AddMoneda
@idmoneda int = null,
@codigo char(11),
@nom_moneda varchar(10),
@abrev varchar(5),
@simbolo varchar(3),
@descripcion varchar(100)
AS BEGIN
	set @idmoneda = (SELECT isnull(MAX(m.idMoneda), 0 )+1 FROM manto.Moneda m)
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
ALTER PROC manto.SP_AddDocumento
@iddoc int = null,
@codigo char(11), 
@descripcion varchar(100)
AS BEGIN
	set @iddoc = (SELECT isnull(MAX(d.idTipoDoc), 0 )+1 FROM manto.TipoDocumento d)
INSERT INTO manto.TipoDocumento(idTipoDoc, codigo, descripcion)
VALUES(@iddoc, @codigo, @descripcion)
END
GO

 exec manto.SP_AddDocumento 1,'00','dsds'


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

--PROCEDIMIENTO PARA ELIMINAR DOCUMENTO
CREATE PROC manto.SP_DeleteDocumento
@iddocumento int
AS BEGIN
	DELETE from TipoDocumento where idTipoDoc=@iddocumento
END
go

--PROCEDIMIENTO PARA MOSTRAR DOCUMENTO
CREATE PROC manto.SP_ShowDoc
AS BEGIN
SELECT  t.idTipoDoc, t.codigo, t.descripcion FROM manto.TipoDocumento t
END
GO

-- PROCEDIMIENTO PARA UNIDAD DE MEDIDA
CREATE PROC manto.sp_AddUnidadMedida
@idUnidadMedida int = null,
@abrev varchar(5),
@descripcion varchar(60)
AS BEGIN
	set @idUnidadMedida = (SELECT isnull(MAX(um.idUnidadMedida), 0 )+1 FROM manto.UnidadMedida um)

INSERT INTO manto.UnidadMedida(idUnidadMedida, abrev, descripcion)
VALUES(@idUnidadMedida, @abrev, @descripcion)
END
GO

--PROCEDIMIENTO PARA EDITAR UNIDAD MEDIDA
ALTER PROC manto.SP_EditUnidMedida
@idUnidadMedida int,
@abrev varchar(5),
@descripcion varchar(60)
AS BEGIN
UPDATE manto.UnidadMedida SET abrev=@abrev, descripcion=@descripcion
WHERE idUnidadMedida=@idUnidadMedida
END
GO

--PROCEDIMIENTO PARA MOSTRAR UNIDAD MEDIDA
ALTER PROC manto.SP_ShowUnidadMed
AS BEGIN
SELECT  u.idUnidadMedida,u.abrev,u.descripcion FROM manto.UnidadMedida u
END
GO

--PROCEDIMIENTO PARA ELIMINAR UNIDAD MEDIDA
CREATE PROC manto.SP_DeleteUnidMed
@idUnidadMedida int
AS BEGIN
	DELETE from UnidadMedida where idUnidadMedida=@idUnidadMedida
END
go

--PROCEDIMIENTO PARA AGREGAR TIPO EXISTENCIA
CREATE PROC manto.SP_AddTipoExist
@idtip_exist int = null,
@codigo char(2), 
@descripcion varchar(100)
AS BEGIN
	set @idtip_exist = (SELECT isnull(MAX(te.idTipoExist), 0 )+1 FROM manto.TipoExistencia te)
INSERT INTO manto.TipoExistencia(idTipoExist, codigo, descripcion)
VALUES(@idtip_exist, @codigo, @descripcion)
END
GO

--PROCEDIMIENTO PARA EDITAR TIPO EXISTENCIA
CREATE PROC manto.SP_EditTipoExist
@idtip_exist int,
@codigo char(2),
@descripcion varchar(60)
AS BEGIN
UPDATE manto.TipoExistencia SET codigo=@codigo, descripcion=@descripcion
WHERE idTipoExist=@idtip_exist
END
GO

--PROCEDIMIENTO PARA MOSTRAR TIPO EXISTENCIA
CREATE PROC manto.SP_ShowTipoExist
AS BEGIN
SELECT  t.idTipoExist,t.codigo,t.descripcion FROM manto.TipoExistencia t
END
GO

EXEC manto.SP_ShowTipoExist

--PROCEDIMIENTO PARA ELIMINAR TIPO EXISTENCIA
CREATE PROC manto.SP_DeleteTipoExist
@idtip_exist int
AS BEGIN
	DELETE from TipoExistencia where idTipoExist=@idtip_exist
END
go

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
alter proc invent.SP_ValidarInventario
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