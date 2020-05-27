alter table Incapacidades alter column fechaInicio varchar(20) not null
go
alter table Incapacidades alter column fechaFin varchar(20) not null
go
alter table Incapacidades alter column evidencia varbinary(max) null
go

alter view Incapacidades_Tabla as
	select i.idIncapacidad 'ID', i.idEmpleado'IdEmp', e.nombre 'Nombre',e.apaterno 'ApellidoP',e.amaterno 'ApellidoM', i.enfermedad 'Enfermedad',
	i.fechaInicio 'FechaInicio',i.fechaFin 'FechaFin',i.evidencia 'Evidencia' from Incapacidades i join Empleados e on i.idEmpleado = e.idEmpleado 
	go
select * from Incapacidades
select * from Incapacidades_Tabla

create view HistorialPuestos_Tabla as
select e.idEmpleado 'ID', e.idPuesto'Puesto', e.idDepartamento 'Departamento', h.fechaInicio 'F.Inicio', h.fechaFin'F.Fin',e.salario 'Salario'
from HistorialPuestos h join Empleados e on e.idEmpleado
