--   PROCEDIMIENTOS PARA EMPRESA
CREATE PROC manto.SP_AddEmpresa
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

ALTER PROC manto.SP_EditEmpresa
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

CREATE PROC manto.SP_ShowEmpresa
@estado varchar(15)
AS BEGIN
SELECT  e.id_empresa, e.ruc, e.razon_social, e.nombre_comercial, e.direccion, 
e.domicilio_fiscal, e.regimen FROM manto.Empresa e WHERE e.estado = @estado
END
GO

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

exec manto.SP_AddEmpresa null,'20456578451','fsd','asd','av. asdas','av. dasdda','rus','ACTIVO';