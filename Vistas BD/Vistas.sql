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
	select e.idEmpleado 'ID', e.nombre 'Nombre', e.apaterno 'Apaterno', e.amaterno 'Amaterno', e.sexo 'Sexo', e.fechaContratacion 'Fecha Contratacion',
	e.salario 'Salario', e.nss 'NSS', e.estadoCivil 'Estado Civil', e.diasVacaciones 'Dias Vacaciones', e.diasPermiso 'Dias Permiso', e.fotografia 'Fotografia',
	e.direccion 'Direccion', e.colonia 'Colonia', e.codigoPostal 'Codigo Postal', e.escolaridad 'Escolaridad', e.porcentajeComision 'Porcentaje Comision',
	e.estatus 'Estatus', d.nombre 'Departamento', p.nombre 'Puesto', c.nombre 'Ciudad', s.nombre 'Sucursal' from Empleados e 
	join Departamentos d on d.idDepartamento=e.idDepartamento join Sucursales s on s.idSucursal=e.idSucursal
	join Puestos p on p.idPuesto=e.idPuesto join Ciudades c on c.idCiudad=e.idCiudad 
	 where e.estatus='A'
	 go

create view Puestos_Tabla as
	select idPuesto 'ID', nombre 'Nombre', salarioMinimo 'SalarioMinimo', salarioMaximo 'SalarioMaximo', estatus 'Estatus'
	from Puestos where estatus='A'
	go





Select * from Departamentos_Tabla
Select * from Percepciones_Tabla
Select * from Deducciones_Tabla
Select * from Estados_Tabla
Select * from Ciudades_Tabla
select * from Empleados_Tabla
select * from Puestos_Tabla
