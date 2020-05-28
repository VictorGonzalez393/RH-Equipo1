--Borrar tabla de Historial de puestos y volverla a crear
create table HistorialPuestos
(
	idEmpleado integer not null,
	idPuesto integer not null,
	idDepartamento integer not null,
	fechaInicio varchar(20) not null,
	fechaFin varchar(20) not null,
	salario float not null,
	estatus char not null,
	constraint PK_HistorialPuestos primary key(idEmpleado, idPuesto, idDepartamento, fechaInicio)
)

alter view HistorialPuestos_Tabla AS
	select e.idEmpleado 'ID', p.nombre 'Puesto', d.nombre'Departamento', h.fechaInicio'F.Inicio', h.fechaFin'F.Fin', h.salario 'Salario',e.nombre'Nombre'
	from HistorialPuestos h join Empleados e on h.idEmpleado=e.idEmpleado join Puestos p on h.idPuesto=p.idPuesto join Departamentos d on h.idDepartamento= d.idDepartamento where h.estatus='A'

	select * from HistorialPuestos_Tabla

insert into HistorialPuestos values (1,1,1,'01/19/2010','01/10/2020',2500,'A')
	select *from HistorialPuestos