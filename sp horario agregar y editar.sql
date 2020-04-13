/*
-- pruebas
declare @msg varchar(max)
exec sp_agregar_horarios 1, 'Lunes', '12:00:00', '13:00:00', @msg out
select @msg
select * from Horarios
*/
go
alter procedure sp_agregar_horarios
	@idEmp int,
	@dia varchar(30),
	@horaI time,
	@horaF time,
	@msg varchar(max) out
as
	IF NOT EXISTS (SELECT * FROM Horarios WHERE dias = @dia and idEmpleado=@idEmp)
	BEGIN 
		begin try
			declare @id int
			select @id = max(idHorario)+1 from Horarios
			begin tran
				insert into Horarios values(@id,@horaI,@horaF,@dia,@idEmp,'A') 
				commit
		end try
		begin catch
			set @msg='No se pudo registrar 1'
			rollback
		end catch
	end
	else
	begin
	IF EXISTS (SELECT * FROM Horarios WHERE dias = @dia and idEmpleado=@idEmp AND estatus='I')
	BEGIN
		begin try
			begin tran
			update Horarios set horaInicio=@horaI, horaFin=@horaF, Estatus='A' where idEmpleado=@idEmp AND dias = @dia
			commit
		end try
		begin catch
			set @msg='No se pudo registrar 2'
			rollback		
		end catch
	end
end

--ok----------------------------------------------------------------------
create procedure sp_editar_horarios 
@idEmp int,
@dia varchar(30),
@horaI time,
@horaF time,
@msg varchar(max) out
as
IF EXISTS (SELECT * FROM Horarios WHERE dias = @dia and idEmpleado=@idEmp)
BEGIN
begin try
begin tran
update Horarios set horaInicio=@horaI, horaFin=@horaF where idEmpleado=@idEmp AND dias = @dia
commit
end try
begin catch
set @msg='No se pudo editar'
rollback
end catch
end
else
begin
set @msg = 'Ese dia no existe'
end