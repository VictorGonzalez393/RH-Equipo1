select * from FormasPago
delete from FormasPago



--Vista de formas de pago
create view FP as 
select idFormaPago ID, Nombre, Estatus from FormasPago where estatus <> 'I'