use ERP2020

--Justificaciones
create view AusenciasJustificadas_Tabla as
	select a.idAusencia 'ID', a.fechaSolicitud 'FechaSolicitud', a.fechaInicio 'FechaInicio', a.fechaFin 'FechaFin',
	a.tipo 'Tipo', a.idEmpleadoS 'ID_EmpleadoS', es.nombre'Nombre_EmpleadoS', es.apaterno 'ApellidoP_ES',  a.idEmpleadoA 'ID_EmpleadoA', ea.nombre'Nombre_EmpleadoA', ea.apaterno 'ApellidoP_EA', a.estatus 'Estatus' from AusenciasJustificadas a 
	join Empleados es on a.idEmpleadoS=es.idEmpleado join Empleados ea on a.idEmpleadoA=ea.idEmpleado where  a.estatus='A'
	go

alter table AusenciasJustificadas alter column fechaSolicitud varchar(20) not null
alter table AusenciasJustificadas alter column fechaInicio varchar(20) not null
alter table AusenciasJustificadas alter column fechaFin varchar(20) not null
---
select * from FormasPago
insert into FormasPago values(1, 'Crédito','A')
EXEC sp_RENAME 'FormasPago.estaus' , 'estatus', 'COLUMN'
insert into Nominas values(1,'4/15/2020',3500,1000,2500,15,0,'4/1/2020','4/15/2020',1,1,'A')
select * from Nominas

--Modificaciones tabla nóminas
alter table Nominas add estatus char(1) not null
go
alter table Nominas alter column fechaPago varchar(20) not null
go
alter table Nominas alter column fechaInicio varchar(20) not null
go
alter table Nominas alter column fechaFin varchar(20) not null
go

--Vista tabla nóminas
alter view Nominas_Tabla as
	select n.idNomina 'ID',n.idEmpleado 'ID_Empleado', n.fechaPago 'Fecha_pago', n.totalP 'Total_percepciones',
	n.totalD 'Total_deducciones', n.cantidadNeta 'Cantidad_neta', n.diasTrabajados 'Dias_trabajados',
	faltas 'Faltas', n.fechaInicio 'Fecha_inicio', n.fechaFin 'Fecha_Fin', f.nombre 'Forma_de_pago', n.estatus 'Estatus' from Nominas n join FormasPago f on n.idFormaPago=f.idFormaPago where n.estatus='A'
	go 
select * from Nominas_Tabla where ID_Empleado=1

--Procedimiento insertar nómina
alter procedure sp_agrega_nomina 
		@fPago varchar(20),
		@tP float,
		@tD float,
		@diasT int,
		@fal int,
		@fInicio varchar(20),
		@fFin varchar(20),
		@idEmp int,
		@idForP int,
		@msg varchar(max) out
as
   declare @cantN float
   set @cantN=@tP-@tD
	if not exists(select * from Nominas where fechaInicio=@fInicio and fechafin=@fFin and idEmpleado=@idEmp 
	and fechaPago=@fPago and estatus='A')
	begin
	if(@cantN>0)
		begin
		begin try
			declare @id int
			
			select @id=max(idNomina)+1 from Nominas
			begin tran
				insert into Nominas values(@id,@fPago,@tP,@tD,@cantN,@diasT,@fal,@fInicio,@fFin,@idEmp,@idForP,'A')
				commit
			end try
			begin catch
				set @msg='No se puede registrar la nómina'
				rollback
			end catch
		end
		else
		begin
			set @msg='Error en la cantidad neta'
		end
	end
	else
	begin
		set @msg='La nómina ya existe'
	end
go
--Prueba

/**declare @msg varchar(max)
exec sp_agrega_nomina '4/15/2020',500,1000,15,0,'4/1/2020','4/15/2020',3,1,@msg out
select @msg
go*/
select * from Nominas

--Procedimiento editar nómina
create procedure sp_editar_nomina 
		@id int,
		@fPago varchar(20),
		@tP float,
		@tD float,
		@diasT int,
		@fal int,
		@fInicio varchar(20),
		@fFin varchar(20),
		@idEmp int,
		@idForP int,
		@est char,
		@msg varchar(max) out
as
   declare @cantN float
   set @cantN=@tP-@tD
	if exists(select * from Nominas where fechaInicio=@fInicio and fechafin=@fFin and idEmpleado=@idEmp and fechaPago=@fPago and estatus='A')
	begin
	if(@cantN>0)
		begin
		begin try
			begin tran
				update Nominas set fechaPago=@fPago, totalP=@tP,totalD=@tD,cantidadNeta=@cantN,diasTrabajados=@diasT,faltas=@fal,fechaInicio=@fInicio,fechaFin=@fFin,idEmpleado=@idEmp,idFormaPago=@idForP,estatus=@est where idNomina=@id
				commit
			end try
			begin catch
				set @msg='No se puede editar la nómina'
				rollback
			end catch
		end
		else
		begin
			set @msg='Error en la cantidad neta'
		end
	end
go
--Prueba
/**
declare @msg varchar(max)
exec sp_editar_nomina 1,'4/15/2020',3000,500,15,0,'4/1/2020','4/15/2020',1,1,'A', @msg out
select @msg
go
select * from Nominas
**/ 

select * from NominasPercepciones

--Procedimiento agregar nómina percepción
create procedure sp_agregar_nominaPercepcion
	@idN int,
	@idP int,
	@importe float,
	@msg varchar(max) out
as
	if not exists (select * from NominasPercepciones where idNomina=@idN and idPercepcion=@idP)
	begin
		begin try
			begin tran
				update Nominas set cantidadNeta+=@importe, totalP+=@importe where idNomina=@idN 
				insert into NominasPercepciones values (@idN,@idP,@importe,'A')
				commit
			end try
			begin catch
				set @msg='Error al registrar la nómina de percepción'
				rollback
			end catch
	end
	else
	begin
	 if exists(select * from NominasPercepciones where idNomina=@idN and idPercepcion=@idP and estatus='I')
	 begin
		begin try
			begin tran
				update Nominas set cantidadNeta+=@importe, totalP+=@importe where idNomina=@idN 
				update NominasPercepciones set  idNomina=@idN,idPercepcion=@idP,importe=@importe, estatus='A'
				commit
			end try
			begin catch
				set @msg='Error al registrar la nómina de percepción'
				rollback
			end catch
		end
	end
	go 

--Procedimiento editar nómina percepciones
create procedure sp_editar_nominaPercepcion
	@idN int,
	@idP int,
	@importe float,
	@msg varchar(max) out
as
	
	if exists (select * from NominasPercepciones where idNomina=@idN and idPercepcion=@idP)
	begin
		begin try
			begin tran
				declare @iAnt float --Importe anterior
				select @iAnt=importe from NominasPercepciones where idNomina=@idN and idPercepcion=@idP
				update Nominas set cantidadNeta-=@iAnt, totalP-=@iAnt where idNomina=@idN 
				update NominasPercepciones set importe=@importe where idNomina=@idN and idPercepcion=@idP 
				update Nominas set cantidadNeta+=@importe, totalP+=@importe where idNomina=@idN
				commit
			end try
			begin catch
				set @msg='Error al editar la nómina de percepción'
				rollback
			end catch
	end
	go 

--Procedimiento agregar nómina deducción
create procedure sp_agregar_nominaDeduccion
	@idN int,
	@idD int,
	@importe float,
	@msg varchar(max) out
as
	if not exists (select * from NominasDeducciones where idNomina=@idN and idDeduccion=@idD)
	begin
		begin try
			begin tran
				update Nominas set cantidadNeta-=@importe, totalD+=@importe where idNomina=@idN 
				insert into NominasPercepciones values (@idN,@idD,@importe,'A')
				commit
			end try
			begin catch
				set @msg='Error al registrar la nómina de deducción'
				rollback
			end catch
	end
	else
	begin
	 if exists(select * from NominasDeducciones where idNomina=@idN and idDeduccion=@idD and estatus='I')
	 begin
		begin try
			begin tran
				update Nominas set cantidadNeta-=@importe, totalP+=@importe where idNomina=@idN 
				update NominasPercepciones set  idNomina=@idN,idPercepcion=@idD,importe=@importe, estatus='A'
				commit
			end try
			begin catch
				set @msg='Error al registrar la nómina de deducción'
			end catch
		end
	end
	go  

--Procedimiento editar nómina deducción
create procedure sp_editar_nominaDeduccion
	@idN int,
	@idD int,
	@importe float,
	@msg varchar(max) out
as
	
	if exists (select * from NominasDeducciones where idNomina=@idN and idDeduccion=@idD)
	begin
		begin try
			begin tran
				declare @iAnt float --Importe anterior
				select @iAnt=importe from NominasDeducciones where idNomina=@idN and idDeduccion=@idD
				update Nominas set cantidadNeta+=@iAnt, totalD-=@iAnt where idNomina=@idN 
				update NominasDeducciones set importe=@importe where idNomina=@idN and idDeduccion=@idD 
				update Nominas set cantidadNeta-=@importe, totalD+=@importe where idNomina=@idN
				commit
			end try
			begin catch
				set @msg='Error al editar la nómina de deducción'
				rollback
			end catch
	end
	go 