Execute sp_rename 'Empleados.fechaNacimineto','fechaNacimiento'
alter table Empleados alter column fechaContratacion varchar(20)
alter table Empleados alter column fechaNacimiento varchar(20)

create VIEW Empleados_Tabla AS 
	select e.idEmpleado 'ID', e.nombre 'Nombre', e.apaterno 'Apaterno', e.amaterno 'Amaterno', e.sexo 'Sexo', e.fechaContratacion 'Fecha Contratacion',
	e.fechaNacimiento 'FechaNacimiento',e.salario 'Salario', e.nss 'NSS', e.estadoCivil 'Estado Civil', e.diasVacaciones 'Dias Vacaciones', e.diasPermiso 'Dias Permiso', 
	e.direccion 'Direccion', e.colonia 'Colonia', e.codigoPostal 'Codigo Postal', e.escolaridad 'Escolaridad', e.porcentajeComision 'Porcentaje Comision',
	e.estatus 'Estatus', d.nombre 'Departamento', p.nombre 'Puesto', c.nombre 'Ciudad', s.nombre 'Sucursal' from Empleados e 
	join Departamentos d on d.idDepartamento=e.idDepartamento join Sucursales s on s.idSucursal=e.idSucursal
	join Puestos p on p.idPuesto=e.idPuesto join Ciudades c on c.idCiudad=e.idCiudad 
	 where e.estatus='A'
	 go
---Modificación liz
alter table Empleados alter column fotografia varbinary(max)
	 
	 select * from Empleados_Tabla;