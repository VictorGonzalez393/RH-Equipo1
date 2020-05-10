Create view NominasDeducciones_Tabla as
	select nd.idNomina 'idNomina', nd.idDeduccion 'idDeduc', nd.importe 'importe', nd.estatus 'estatus', d.Nombre 'nombreD',
	d.Descripcion 'descripcionD' from Deducciones d join NominasDeducciones nd on d.idDeduccion = nd.idDeduccion
	where nd.estatus='A' 
	go 

select * from NominasDeducciones_Tabla where idNomina=1;