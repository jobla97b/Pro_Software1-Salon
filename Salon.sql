Create database Salon
use Salon;

Create table Cliente(
Id_Cliente smallint  primary key identity(1,1) not null,
Cedula char(14) not null unique,
Nombre1 varchar(12) not null,
Nombre2 varchar(12),
Apellido1 varchar(15) not null,
Apeliido2 varchar(15),
Telefono char(8),
Correo nvarchar(30),--Se tuvo que quitar la propiedad unique debido a q el campo es requerido sea obligatorio, para que verifique la no duplicidad. si queda vacio no dejara agregar mas de un campo vacio. Asi que verificar que no se repita al momento de realizar el procedimiento almacenado.
Direccion varchar (150),
Estado bit not null --/*/*0:Inactivo - 1:Activo*/
)


create table Cargo(
Id_cargo int primary key identity(1,1) not null,
Nombre varchar(14) not null,
Estado bit not null/*0:Inactivo - 1:Activo*/
)

Create table Empleado(
Id_Empleado smallint  primary key identity(1,1) not null,
Cedula char(14) not null unique,
Nombre1 varchar(12) not null,
Nombre2 varchar(12),
Apellido1 varchar(15) not null,
Apeliido2 varchar(15),
Telefono char(8),
Correo nvarchar(30)unique not null,-----Se modifico a ser necesario y obligatorio el correo de un empleado.
Direccion varchar (150) not null,
Id_Cargo int foreign key references Cargo(Id_Cargo) not null,
Estado bit not null/*0:Inactivo - 1:Activo*/
)

Create table Users(
Id_Usuario smallint primary key identity(1,1) not null,
Id_Empleado smallint foreign key references Empleado(Id_Empleado) not null,
Nombre_Usuario nvarchar(12) not null unique,
Contraseña nvarchar(64) not null
)

Create table Categoria_servicio(
Id_Categoria smallint primary key identity(1,1) not null,
Nombre nvarchar(18) not null,
Moneda char(1) not null, --*C: cordobas - d: Dolares*-- 
Cambio_Oficial smallmoney, /*Cambio para los servicios Dolarizados*/
Estado bit not null /*0:Inactivo - 1:Activo*/
)

Create table Servicios(
Id_Servicio smallint primary key identity(1,1) not null,
Id_Categoria smallint foreign key references Categoria_servicio(Id_Categoria) not null,
Descripcion varchar(25)not null,
Duracion time(0) not null,                                    
Costo smallmoney not null, 
Estado bit not null/*0:No Disponible - 1:Disponible*/
)

Create table Cita(
Id_Cita smallint primary key identity(1,1) not null,
Id_Cliente smallint foreign key references Cliente(Id_Cliente) not null,
Fecha date not null,
Hora time(0) not null,
Hora_fin time(0),
Estado char(1) not null /*F:facturada - C:cancelada de realizar - P:pendiente a realizar*/
)

Create table Detalle_Cita(
Id_Cita smallint foreign key references Cita(Id_Cita) not null,
Id_Servicio smallint foreign key references Servicios(Id_Servicio) not null,
Id_Empleado smallint foreign key references Empleado(Id_Empleado) not null,
Costo_Serv smallmoney not null, 
primary key(Id_Cita,Id_Servicio)
)

Create table Factura(
Id_Factura int primary key identity(1,1) not null,
Id_cita smallint foreign key references Cita(Id_Cita) not null,
Id_Empleado smallint foreign key references Empleado(Id_Empleado) not null,
Fecha date not null,
Iva smallmoney,
Total smallmoney, 
Estado bit not null/*0:Anulado - 1:Activo*/
)

Create table Modo_Pago(
Id_Pago int primary key identity(1,1) not null,
Id_Factura int foreign key references Factura(Id_Factura) not null,
Tipo_Pago char(1) not null, /*E:Efectivo - C:Tarjeta*/
Moneda char(1) not null, /*C:Cordoba - C:Dolar*/
Importe_F smallmoney not null, /*Importe sobre el total de la factura*/
Pago_Efectuado smallmoney, ---Cantidad $ con la cual cancela el cliente
Cambio_Dolar smallmoney---cambio diario oficial de dolar con respecto al cordoba
)

-------------------------------------------------------------------------------------------
----------------------------------2da Parte------------------------------------------------

create table Proveedor(
Id_Proveedor smallint primary key identity(1,1) not null,
Nombre nvarchar(15) not null,
Telefono char(8) not null,
Correo nvarchar(30) unique,
Direccion varchar(150) not null,
Estado bit not null,/*0:Inactivo - 1:Activo*/

)

create table Producto(
Codigo smallint primary key identity(1,1) not null,
Nombre varchar(15) not null,
Descripcion varchar(15) not null, ---Discutir la viabilidad del campo----- 
Presentacion_unitaria varchar(5) not null, -----Tipo de presentacion del producto sea ml,lbs,onz,unidades,etc.------
Contenido_unitario smallint not null, -----Cantidad de contenido de producto que contiene 1 unidad. Verificar si el dato sera de tipo "entero" o "decimal"----
Existencia int not null,
Precio_unitario smallmoney not null,
Estado bit /*0:Inactivo - 1:Activo*/
)

create table Compras(
N_Factura char(9) primary key not null,----Pueden ser 6,7,8.... caracteres posibles de una factura en dependencia del proveedor
Fecha date not null,
Id_Proveedor smallint foreign key references Proveedor(Id_Proveedor) not  null,
Total_Facturado smallmoney,
Estado bit not null,/*0:Inactivo - 1:Activo*/---Verificar
)

create table Detalle_Compras(
N_Factura char(9) foreign key references Compras(N_Factura) not  null,
Codigo smallint foreign key references Producto(Codigo) not null,
Costo_P smallmoney not null,
Cantidad_P decimal(5,2) not null, ----Verificar como se ejecutan las compras de insumos
primary key(N_Factura,Codigo)
)

create table Detalle_Servicio(
Id_servicio smallint foreign key references Servicios(Id_servicio) not null,
Codigo smallint foreign key references Producto(Codigo) not null,
Cantidad_utilizada decimal(5,2) not null,----Verificar el tipo de dato
primary key(Id_servicio,Codigo)
)

create table Extras(
Id_Cita smallint foreign key references Cita(Id_Cita) not null,
Codigo smallint foreign key references Producto(Codigo) not null,
Cantidad_Utilizada decimal(5,2) not null,----Verificar el tipo de dato
Descripcion varchar(100) not null,----Opcional a verificar
Costo float not null, ----- Opcional a verificar
)

create table Devolucion_Compra(
N_factura char(9)foreign key references Compras(N_factura) not null,
Fecha_dev date not null,
total_dev smallmoney
primary key(N_factura)
)

create table Detalle_dev(
N_factura char(9)foreign key references Devolucion_compra(N_factura) not null,
Codigo smallint foreign key references Producto(Codigo)not null,
Cantidad_dev smallint not null
)