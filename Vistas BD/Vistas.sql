Create VIEW Percepciones_Tabla AS
	select idPercepcion 'ID', nombre 'Nombre', descripcion 'Descripción', diasPagar 'Dias a pagar', estatus 'Estatus'
	from Percepciones where estatus='A';
	go
create VIEW Deducciones_Tabla AS
	select idDeduccion 'ID', nombre 'Nombre', descripcion 'Descripción', porcentaje 'Porcentaje', estatus 'Estatus' from Deducciones where estatus='A';
	go

create VIEW Estados_Tabla AS
	select idEstado 'ID', nombre 'Nombre', siglas 'Siglas', estatus 'Estatus' from Estados where estatus='A';
	go
create VIEW Ciudades_Tabla As
	select c.idCiudad 'ID', c.nombre 'Ciudad', e.nombre 'Estado', c.estatus from Ciudades c join Estados e on c.idEstado=e.idEstado where c.estatus='A';
	go

Select * from Percepciones_Tabla
Select * from Deducciones_Tabla
Select * from Estados_Tabla
Select * from Ciudades_Tabla