select *from Horarios

create procedure sp_agregar_horarios
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
set @msg='No se pudo registrar'
rollback
end catch
end
else
begin
IF EXISTS (SELECT * FROM Horarios WHERE dias = @dia and idEmpleado=@idEmp AND estatus='I')
BEGIN
begin try
begin tran
update Horarios set horaInicio=@horaI, horaFin=@horaF where idEmpleado=@idEmp AND dias = @dia
commit
end try
begin catch
set @msg='No se pudo registrar'
rollback
end catch
end
set @msg='No se pudo registrar'
end

----------------------------------------------------------------------
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

