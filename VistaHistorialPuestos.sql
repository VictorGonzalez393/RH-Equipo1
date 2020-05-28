create view HistorialPuestos_Tabla AS
	select e.idEmpleado 'ID', p.nombre 'Puesto', d.nombre'Departamento', h.fechaInicio'F.Inicio', h.fechaFin'F.Fin', h.salario 'Salario',e.nombre'Nombre'
	from HistorialPuestos h join Empleados e on h.idEmpleado=e.idEmpleado join Puestos p on h.idPuesto=p.idPuesto join Departamentos d on h.idDepartamento= d.idDepartamento

	select * from HistorialPuestos_Tabla

insert into HistorialPuestos values (1,1,1,'30-01-19','20-01-20',2500)
	select *from Empl