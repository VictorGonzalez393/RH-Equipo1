Create view NominasDeducciones_Tabla as
	select nd.idNomina 'idNomina', nd.idDeduccion 'idDeduc', nd.importe 'importe', nd.estatus 'estatus', d.Nombre 'nombreD',
	d.Descripcion 'descripcionD' from Deducciones d join NominasDeducciones nd on d.idDeduccion = nd.idDeduccion
	where nd.estatus='A' 
	go 

select * from NominasDeducciones_Tabla where idNomina=1;
delete from NominasDeducciones where idNomina=1 and idDeduccion=3 
select * from Nominas_Tabla;

update NominasDeducciones set estatus='A' where idNomina=1 and idDeduccion=3

Create view NominasPercepciones_Tabla as
select np.idNomina 'idNomina', np.idPercepcion 'idPerc', np.importe 'importe', np.estatus 'estatus', p.Nombre 'nombreP',
p.Descripcion 'descripcionP' from Percepciones p join NominasPercepciones np on p.idPercepcion = np.idPercepcion
where np.estatus='A'
go

select * from NominasPercepciones_Tabla

create view HistorialPuestos_Tabla as
select h.idEmpleado 'ID', h.idPuesto'Puesto', h.idDepartamento 'Departamento', h.fechaInicio 'F.Inicio', h.fechaFin'F.Fin',h.salario 'Salario',
e.nombre 'NombreE', p.nombre'NombreP',d.Nombre'NombreD'
from HistorialPuestos h join Empleados e on h.idEmpleado = e.idEmpleado join  Puestos p on p.idPuesto = h.idPuesto join Departamentos d on d.idDepartamento
= h.idDepartamento

select * from HistorialPuestos_Tabla