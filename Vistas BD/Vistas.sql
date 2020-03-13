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
	select c.idCiudad 'ID', c.nombre 'Ciudad', e.nombre 'Estado', c.estatus 'Estatus' from Ciudades c join Estados e on c.idEstado=e.idEstado where c.estatus='A';
	go

create view Departamentos_Tabla as
	select idDepartamento 'ID', nombre 'Nombre', estatus 'Estatus'
	from Departamentos where estatus='A'
	go

create VIEW Empleados_Tabla AS 
	select idEmpleado 'ID', nombre 'Nombre', apaterno 'Apaterno', amaterno 'Amaterno', sexo 'Sexo', fechaContratacion 'FechaContratacion',
	salario 'Salario', nss 'Nss', estadoCivil 'estadoCivil', diasVacaciones 'DiasVacaciones', diasPermiso 'DiasPermiso', fotografia 'Fotografia',
	direccion 'Direccion', colonia 'Colonia', codigoPostal 'CodigoPostal', escolaridad 'Escolaridad', porcentajeComision 'PorcentajeComision',
	estatus 'Estatus', idDepartamento 'IdDepartamento', idPuesto 'IdPuesto', idCiudad 'IdCiudad', idSucursal 'IdSucursal' 
	from Empleados where estatus='A'

Select * from Departamentos_Tabla
Select * from Percepciones_Tabla
Select * from Deducciones_Tabla
Select * from Estados_Tabla
Select * from Ciudades_Tabla
select * from Empleados_Tabla
