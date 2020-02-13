--crear roles
create role Administrador authorization dbo
create role Contador authorization dbo

--Asignar permisos queda pendiente:

--crear logins 
create login May with password='Hola.123' must_change,
default_database=ERP2020, check_expiration=on
create login Victor with password='Hola.123' must_change,
default_database=ERP2020, check_expiration=on
create login LaLiz with password='Hola.123' must_change,
default_database=ERP2020, check_expiration=on
create login AmigaMaritza with password='Hola.123' must_change,
default_database=ERP2020, check_expiration=on
create login Profe with password='Hola.123' must_change,
default_database=ERP2020, check_expiration=on
create login Jenifer with password='Hola.123' must_change,
default_database=ERP2020, check_expiration=on

--crear usuarios
create user May 
create user Victor
create user LaLiz 
create user AmigaMaritza
create user Profe 
create user Jenifer

--agregar usuarios a roles
exec sp_addrolemember Administrador,May
exec sp_addrolemember Administrador,LaLiz
exec sp_addrolemember Administrador,Profe
exec sp_addrolemember Contador,AmigaMaritza
exec sp_addrolemember Contador,Victor
exec sp_addrolemember Contador,Jenifer