----------------------------------------------------------------------------------------------------
----------------------------Funcion para el calculo de tiempo de duracion de una cita-----------------------------------------------
 create function Calcular_tiempo
 (@hora_cita time(0))----Para calcular el tiempo estimado requerido para brindar los servicios solicitados, sera necesario acceder a el detalle de Citas a traves de Id_Cita
 returns time(0)
 as
 begin
Declare @hora time(0),
@hora1 time(0),
@hora2 time(0),
@hora3 int,
@hora4 int,
@resultado int;
set @hora= @hora_cita
set @hora1= (Select Duracion from Servicios where Id_Servicio=2)------Aqui deberia de venir el parametro de duracion del detalle de de servicios 
set @hora3= sum(Datepart(second,@hora) + 60 * Datepart(minute,@hora) +3600 * DATEPART(Hour,@hora))
set @hora4= sum(Datepart(second,@hora1) + 60 * Datepart(minute,@hora1) +3600 * DATEPART(Hour,@hora1))
set @resultado= @hora3 + @hora4
set @hora2 = (Select Cast(dateadd(second,@resultado,0)as time(0)))
return @hora2
end
-------------------------------------------------------------------------------------------------------------
--------------------Vista de como podria ser la consulta para ver La hora de final de la cita--------------------------------------
Select cli.Id_Cliente, cli.Nombre1, cli.Apellido1, ci.Fecha, ci.Hora, dbo.Calcular_tiempo(ci.Hora) as Final,ci.Estado from Cita ci inner join 
Cliente cli on cli.Id_Cliente=ci.Id_Cliente where Fecha='01/07/18' order by Hora asc



use Salon

select * from Users

Create Procedure Login
@Usuario as nvarchar(12),
@Contraseña as nvarchar(64)
as
Declare @var1 nvarchar(12)
Declare @var2 nvarchar(64)
set @var1 =(Select Nombre_Usuario from Users where Nombre_Usuario=@Usuario)
set @var2= (Select Contraseña from Users where Nombre_Usuario = @Usuario)
if(@Usuario = @var1)
begin
	if(@Contraseña = @var2)
	begin
		Select u.Id_Usuario, u.Id_Empleado, e.Nombre1, e.Apellido1, e.Id_Cargo, c.Nombre, u.Nombre_Usuario
		from Users u inner join Empleado e on u.Id_Empleado=e.Id_Empleado inner join Cargo c on c.Id_cargo=e.Id_Cargo
		where u.Nombre_Usuario=@Usuario and u.Contraseña=@Contraseña and e.Estado='true'
	end
	else
	begin
		print ('Contraseña incorrecta por favor verifique')
	end
end
else
begin 
	print('Ususario no encontrado. Por favor verificar los datos')
end

Execute Login 'marialb02','marialberto07'
Select * from Empleado
Select * from Cargo
Select * from Users
