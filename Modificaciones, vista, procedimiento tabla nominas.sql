use ERP2020
select * from FormasPago
insert into FormasPago values(1, 'Cr�dito','A')
insert into Nominas values(1,'4/15/2020',3500,1000,2500,15,0,'4/1/2020','4/15/2020',1,1,'A')
select * from Nominas

--Modificaciones tabla n�minas
alter table Nominas add estatus char(1) not null
go
alter table Nominas alter column fechaPago varchar(20) not null
go
alter table Nominas alter column fechaInicio varchar(20) not null
go
alter table Nominas alter column fechaFin varchar(20) not null
go

--Vista tabla n�minas
alter view Nominas_Tabla as
	select n.idNomina 'ID',n.idEmpleado 'ID_Empleado', n.fechaPago 'Fecha pago', n.totalP 'Total percepciones',
	n.totalD 'Total deducciones', n.cantidadNeta 'Cantidad neta', n.diasTrabajados 'Dias trabajados',
	faltas 'Faltas', n.fechaInicio 'Fecha inicio', n.fechaFin 'Fecha Fin', f.nombre 'Forma de pago', n.estatus 'Estatus' from Nominas n join FormasPago f on n.idFormaPago=f.idFormaPago where n.estatus='A'
	go 

--Procedimiento insertar n�mina
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
	if not exists(select * from Nominas where fechaInicio=@fInicio and fechafin=@fFin and idEmpleado=@idEmp and fechaPago=@fPago and estatus='A')
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
				set @msg='No se puede registrar la n�mina'
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
		set @msg='La n�mina ya existe'
	end
go
--Prueba

/**declare @msg varchar(max)
exec sp_agrega_nomina '4/15/2020',500,1000,15,0,'4/1/2020','4/15/2020',3,1,@msg out
select @msg
go*/
select * from Nominas

--Procedimiento editar n�mina
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
				set @msg='No se puede editar la n�mina'
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

--Procedimiento agregar n�mina percepci�n
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
				set @msg='Error al registrar la n�mina de percepci�n'
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
				set @msg='Error al registrar la n�mina de percepci�n'
				rollback
			end catch
		end
	end
	go 

--Procedimiento editar n�mina percepciones
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
				set @msg='Error al editar la n�mina de percepci�n'
				rollback
			end catch
	end
	go 

--Procedimiento agregar n�mina deducci�n
create procedure sp_agregar_nominaDeducci�n
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
				set @msg='Error al registrar la n�mina de deducci�n'
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
				set @msg='Error al registrar la n�mina de deducci�n'
			end catch
		end
	end
	go  

--Procedimiento editar n�mina deducci�n
create procedure sp_editar_nominaDeducci�n
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
				set @msg='Error al editar la n�mina de deducci�n'
				rollback
			end catch
	end
	go 