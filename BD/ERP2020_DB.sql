
CREATE DATABASE ERP2020
GO
-- =========================================
-- Tablas de Recursos Humanos
-- =========================================
USE ERP2020

CREATE TABLE Ciudades
(
	idCiudad integer not null,
	nombre varchar(80) not null,
	idEstado integer,
	estatus char,
	CONSTRAINT PK_Ciudades PRIMARY KEY (idCiudad)
)
GO

create table Estados
(
	idEstado integer not null,
	nombre varchar(60) not null,
	siglas varchar(10) not null,
	estatus char,
	constraint PK_Estados primary key (idEstado)
)
go

create table Incapacidades 
(
	idIncapacidad integer not null,
	fechaInicio date not null,
	fechaFin date not null,
	enfermedad varchar(150) not null,
	evidencia varbinary not null,
	idEmpleado integer not null,
	constraint PK_Incapacidades primary key (idIncapacidad)
)

create table Empleados 
(
	idEmpleado integer not null,
	nombre varchar(30) not null,
	apaterno varchar(30) not null,
	amaterno varchar(30) not null,
	sexo char not null,
	fechaContratacion date not null,
	fechaNacimineto date not null,
	salario float not null,
	nss varchar(10) not null,
	estadoCivil varchar (20) not null,
	diasVacaciones integer not null,
	diasPermiso integer not null,
	fotografia varbinary not null,
	direccion varchar(80) not null,
	colonia varchar(50) not null,
	codigoPostal varchar(5) not null,
	escolaridad varchar (80) not null,
	porcentajeComision float not null,
	estatus char not null,
	idDepartamento integer not null,
	idPuesto integer not null,
	idCiudad integer not null,
	idSucursal integer not null,
	constraint PK_Empleados primary key (idEmpleado)
)

create table Horarios 
(
	idHorario integer not null,
	horaInicio date not null,
	horaFin date not null,
	dias varchar (30) not null,
	idEmpleado integer not null,
	constraint PK_Horarios primary key (idHorario)
)

create table AusenciasJustificadas 
(
	idAusencia integer not null,
	fechaSolicitud date not null,
	fechaInicio date not null,
	fechaFin date not null,
	tipo char not null,
	idEmpleadoS integer not null,
	idEmpleadoA integer not null,
	estatus char not null,
	constraint PK_Ausencias primary key (idAusencia)
)

create table FormasPago
(
	idFormaPago integer not null,
	nombre varchar(50) not null,
	estaus char not null,
	constraint PK_FormasPago primary key (idFormaPago)
)

Create table DocumentacionEmpleado
(
	idDocumento integer not null,
	nombreDocumento varchar(80) not null,
	fechaEntrega date not null,
	documento varbinary not null,
	estatus char not null,
	idEmpleado Integer not null,
	constraint PK_Documentacion primary key(idDocumento)
)

create table Puestos 
(
	idPuesto integer not null,
	nombre varchar(60) not null,
	salarioMinimo float not null,
	salarioMaximo float not null,
	estatus char not null,
	constraint PK_Puestos primary key (idPuesto)
)

create table Departamentos 
(
	idDepartamento integer not null,
	nombre varchar (50) not null,
	estatus char not null,
	constraint PK_Departamentos primary key (idDepartamento)
)

create table HistorialPuestos
(
	idEmpleado integer not null,
	idPuesto integer not null,
	idDepartamento integer not null,
	fechaInicio date not null,
	fechaFin date not null,
	salario float not null,
	estatus char not null,
	constraint PK_HistorialPuestos primary key(idEmpleado, idPuesto, idDepartamento, fechaInicio)
)

create table Percepciones
(
	idPercepcion integer not null,
	nombre varchar (30) not null,
	descripcion varchar (80) not null,
	diasPagar integer not null,
	constraint PK_Percepciones primary key (idPercepcion)
)

create table Nominas
(
	idNomina integer not null,
	fechaPago date not null,
	totalP float not null,
	totalD float not null,
	cantidadNeta float not null,
	diasTrabajados integer not null,
	faltas integer not null,
	fechaInicio date not null,
	fechaFin date not null,
	idEmpleado integer not null,
	idFormaPago integer not null,
	constraint PK_Nominas primary key (idNomina)
)

create table Deducciones 
(
	idDeduccion integer not null,
	nombre varchar (30) not null,
	descripcion varchar (80) not null,
	porcentaje float not null,
	constraint PK_Deducciones primary key (idDeduccion)
)

create table NominasDeducciones 
(
	idNomina integer not null,
	idDeduccion integer not null,
	importe float not null,
	estatus char not null,
	constraint PK_NominasDeducciones primary key (idNomina, idDeduccion)
)

create table NominasPercepciones  
(
	idNomina integer not null,
	idPercepcion integer not null,
	importe float not null,
	estatus char not null,
	constraint PK_NominasPercepciones primary key (idNomina, idPercepcion)
)

create table Usuarios 
(
	nombre varchar(30) not null,
	contrasenia varchar (20) not null,
	estatus char not null,
	idEmpleado integer not null,
	idTipoUsuario integer not null,
	constraint PK_Usuarios primary key (nombre)
)

create table TipoUsuario
(
	idTipoUsuario integer not null,
	nombre varchar (80) not null,
	estatus char not null,
	constraint PK_TipoUsuario primary key (idTipoUsuario)
)

---------------------------------------------------------------------
--Tablas de Ventas
---------------------------------------------------------------------
create table OfertasAsociacion 
(
	idAsociacion integer not null,
	idOferta integer not null,
	estatus char not null,
	constraint PK_OfertasAsociacion primary key (idAsociacion, idOferta)
)

create table Asociaciones 
(
	idAsociacion integer not null,
	nombre varchar (100) not null,
	estatus char not null,
	constraint PK_Asociaciones primary key (idAsociacion)
)

Create table Miembros 
(
	idCliente integer not null,
	idAsociacion integer not null,
	estatus char not null,
	fechaIncorporacion date not null,
	constraint PK_Miembros primary key (idAsociacion, idCliente)
)

create table Cultivos
(
	idCultivo integer not null,
	nombre varchar(100) not null,
	costoAsesoria float not null,
	estatus char not null,
	constraint PK_Cultivos primary key (idCultivo)
)

create table VentasDetalle 
(
	idVentaDetalle integer not null,
	precioVenta float not null,
	cantidad float not null,
	subtotal float not null,
	idVenta integer not null,
	idPresentacion integer not null,
	constraint PK_VentasDetalle primary key (idVentaDetalle)
)

create table clientes 
(
	idCliente integer not null,
	nombre varchar (100) not null,
	razonSocial varchar(100) not null,
	limiteCredito float not null,
	direccion varchar(80) not null,
	codigoPosta char(5) not null,
	rfc char(13) not null,
	telefono char(12) not null,
	email varchar(100) not null,
	estatus char not null,
	tipo char not null,
	idCiudad integer not null,
	constraint PK_Clietes primary key (idCliente)
)

create table ClientesCultivos
(
	idClienteCultivo integer not null,
	extension float not null,
	ubicacion varchar(100) not null,
	estatus char not null,
	idCliente integer not null,
	idCultivo integer not null,
	idCiudad integer not null,
	constraint Pk_ClientesCultivos primary key (idClienteCultivo)
)

create table Ventas
(
	idVenta integer not null,
	fecha date not null,
	totalPagar float not null,
	cantPagada float not null,
	comentarios varchar (100) not null,
	estatus char not null,
	tipo char not null,
	idCliente integer not null,
	idSucursal integer not null,
	idEmpleado integer not null,
	constraint PK_Ventas primary key (idVenta)
)

create table Facturas 
(
	Folio char not null,
	subtotal float not null,
	iva float not null,
	total float not null,
	nombreDocXML varchar(100) not null,
	documentoXML varbinary not null,
	nombreDocPDF varchar(100) not null,
	documentoPDF varbinary not null,
	estatus char not null,
	idVenta integer not null,
	constraint PK_Facturas primary key (Folio)
)

create table Visitas 
(
	idVisita integer not null,
	fechaPlaneada date not null,
	fechaReal date not null,
	comentarios varchar(200) not null,
	estatus char not null,
	costo float not null,
	idClienteCultivo integer not null,
	idEmpleado integer not null,
	idUnidadTransporte integer not null,
	constraint PK_Visitas primary key (idVisita)

)

create table Tripulacion
(
	idEmpleado integer not null,
	idEnvio integer not null,
	rol varchar(50) not null,
	constraint PK_Tripulacion primary key(rol, idEmpleado, idEnvio)
)

create table Cobros
(
	idCobro integer not null,
	fecha date not null,
	importe float not null,
	idVenta integer not null,
	idFormaPago integer not null,
	constraint PK_Pagos primary key (idCobro)
)

create table UnidadesTransporte 
(
	idUnidadTransporte integer not null,
	placas varchar(10) not null,
	marcas varchar(80) not null,
	modelo varchar(80) not null,
	anio integer not null,
	capacidad integer not null,
	constraint PK_UnidadesTransporte primary key (idUnidadTransporte) 
)

Create table Mantenimientos 
(
	idMantenimiento integer not null,
	fecha date not null,
	taller varchar (100) not null,
	costo float not null,
	comentarios varchar (200) not null,
	tipo varchar(30) not null,
	estatus char not null,
	idUnidadTransporte integer not null,
	constraint PK_mantenimientos primary key (idMantenimiento)
)

create table Envios 
(
	idEnvio integer not null,
	fechaEntregaPlaneada date not null,
	fechaEntregaReal date not null,
	direccion varchar(100) not null,
	codigoPostal varchar(5) not null,
	idVenta integer not null,
	idUnidadTransporte integer not null,
	idCiudad integer not null,
	constraint PK_Envios primary key (idEnvio)
)

--------------------------------------------------------------------------
--Tablas de Compras
--------------------------------------------------------------------------
CREATE TABLE Productos(
	idProducto INTEGER not null,
    nombre VARCHAR(50) not null,
    descripcion VARCHAR(100),
    puntoReorden INTEGER not null,
    precioCompra FLOAT not null,
    precioVenta FLOAT not null,
    ingredienteActivo VARCHAR(100) not null,
    bandaToxicologica VARCHAR(80) not null,
    aplicacion VARCHAR(200) not null,
    uso VARCHAR(200) not null,
    estatus CHAR not null,
    idLaboratorio INTEGER not null,
    idCategoria INTEGER not null,
    CONSTRAINT Productos_PK PRIMARY KEY (idProducto)
);

CREATE TABLE Laboratorios(
	idLaboratorio INTEGER not null,
    nombre VARCHAR(50) not null,
    origen VARCHAR(30) not null,
    estatus CHAR not null,
    CONSTRAINT Marcas_PK PRIMARY KEY (idLaboratorio)
);

CREATE TABLE Categorias(
	idCategoria INTEGER not null,
    nombre VARCHAR(30) not null,
    estatus CHAR not null,
    CONSTRAINT Categorias_PK PRIMARY KEY (idCategoria)
);

CREATE TABLE Empaques(
	idEmpaque INTEGER not null,
    nombre VARCHAR(80) not null,
    capacidad FLOAT not null,
    estatus CHAR not null,
    idUnidad INTEGER not null,
    CONSTRAINT Presentaciones_PK PRIMARY KEY (idEmpaque)
);

CREATE TABLE UnidadMedida(
	idUnidad INTEGER not null,
    nombre VARCHAR(80) not null,
    siglas VARCHAR(20) not null,
    estatus CHAR not null,
    CONSTRAINT UnidadMedia_PK PRIMARY KEY (idUnidad)
);

CREATE TABLE PresentacionesProducto(
	idPresentacion INTEGER not null,
    precioCompra FLOAT not null,
    precioVenta FLOAT not null,
    puntoReorden FLOAT not null,
    idProducto INTEGER not null,
    idEmpaque INTEGER not null,
    CONSTRAINT PresentacionesProducto_PK PRIMARY KEY (idPresentacion)
);

CREATE TABLE ExistenciasSucursal(
	idPresentacion INTEGER not null,
    idSucursal INTEGER not null,
    cantidad FLOAT not null,
    CONSTRAINT ExistenciasSucursal_PK PRIMARY KEY (idPresentacion, idSucursal)
);

CREATE TABLE Sucursales(
	idSucursal INTEGER not null,
    nombre VARCHAR(50) not null,
    telefono VARCHAR(15),
    direccion VARCHAR(80) not null,
    colonia VARCHAR(50),
    codigoPostal VARCHAR(5),
    presupuesto FLOAT,
    estatus CHAR not null,
    idCiudad INTEGER not null,
    CONSTRAINT Sucursales_PK PRIMARY KEY (idSucursal)
);

CREATE TABLE ImagenesProducto(
	idImagen INTEGER not null,
    nombreImagen VARCHAR(100),
    imagen varbinary,
    principal CHAR not null,
    idProducto INTEGER not null,
    CONSTRAINT ImagenesProducto_PK PRIMARY KEY (idImagen)
);

CREATE TABLE ProductosProveedor(
	idProveedor INTEGER not null,
    idPresentacion INTEGER not null,
    diasRetardo INTEGER,
    precioEstandar FLOAT,
    precioUltimaCompra FLOAT,
    cantMinPedir INTEGER,
    cantMaxPedir INTEGER,
    CONSTRAINT ProductosProveedor_PK PRIMARY KEY (idProveedor, idPresentacion)
);

CREATE TABLE PedidoDetalle(
	idPedidoDetalle INTEGER not null,
    cantPedida INTEGER not null,
    precioCompra FLOAT not null,
    subtotal FLOAT,
    cantRecibida INTEGER,
    cantRechazada INTEGER,
    cantAceptada FLOAT,
    idPedido INTEGER not null,
    idPresentacion INTEGER not null,
    CONSTRAINT PedidoDetalle_PK PRIMARY KEY (idPedidoDetalle)
);

CREATE TABLE Pedidos(
	idPedido INTEGER not null,
    fechaRegistro DATE not null,
    fechaRecepcion DATE not null,
    totalPagar FLOAT,
    cantidadPagada FLOAT,
    estatus CHAR not null,
    idProveedor INTEGER not null,
    idSucursal INTEGER not null,
    idEmpleado INTEGER not null,
    CONSTRAINT Pedidos_PK PRIMARY KEY (idPedido)
);

CREATE TABLE ContactosProveedor(
	idContacto INTEGER not null,
    nombre VARCHAR(80) not null,
    telefono VARCHAR(12) not null,
    email VARCHAR(100) not null,
    idProveedor INTEGER not null,
    CONSTRAINT ContactosProveedor_PK PRIMARY KEY (idContacto)
);

CREATE TABLE Proveedores(
	idProveedor INTEGER not null,
    nombre VARCHAR(80) not null,
    telefono VARCHAR(12) not null,
    email VARCHAR(100) not null,
    direccion VARCHAR(80) not null,
    colonia VARCHAR(50),
    codigoPostal VARCHAR(5),
    idCiudad INTEGER not null,
    CONSTRAINT Proveedores_PK PRIMARY KEY (idProveedor)
);

CREATE TABLE CuentasProveedor(
	idCuentaProveedor INTEGER not null,
    idProveedor INTEGER not null,
    noCuenta VARCHAR(10) not null,
    banco VARCHAR(30) not null,
    CONSTRAINT CuentasProveedor_PK PRIMARY KEY (idCuentaProveedor)
);

CREATE TABLE Pagos(
	idPago INTEGER not null,
    fecha DATE not null,
    importe FLOAT not null,
    idPedido INTEGER not null,
    idFormaPago INTEGER not null,
    idCuentaProveedor INTEGER not null,
    CONSTRAINT Pagos_PK PRIMARY KEY (idPago)
);

create table Ofertas 
(
	idOferta integer not null,
	nombre varchar (50) not null,
	descripcion varchar(80) not null,
	porDescuento float not null,
	fechaInicio date not null,
	fechaFin date not null,
	canMinProducto integer not null,
	estatus char not null,
	idProducto integer not null,
	constraint PK_Ofertas primary key (idOferta)
)
--------------------------------------------------------------------
--Creacion de las foreign key
--------------------------------------------------------------------
--Productos
alter table Productos add constraint FK_prod_lab foreign key (idLaboratorio) references Laboratorios (idLaboratorio)
alter table Productos add constraint FK_prod_cat foreign key (idCategoria) references Categorias (idCategoria)
--ImagenesProducto
alter table ImagenesProducto add constraint FK_imgProd_prod foreign key (idProducto) references Productos (idProducto)
--ContactosProveedor
alter table ContactosProveedor add constraint FK_contProv_prov foreign key (idProveedor) references Proveedores (idProveedor)
--ProductosProveedor
alter table ProductosProveedor add constraint FK_Prodprov_Prov foreign key (idProveedor) references Proveedores (idProveedor)
--Empaques
alter table Empaques add constraint FK_Empaqu_Unidad foreign key (idUnidad) references UnidadMedida (idUnidad)
--PresentacionesProducto
alter table PresentacionesProducto add constraint FK_PresProd_Empaq foreign key (idEmpaque) references Empaques (idEmpaque)
alter table PresentacionesProducto add constraint FK_PresProd_prod foreign key (idProducto) references Productos (idProducto)
--PedidoDetalle
alter table PedidoDetalle add constraint FK_PedDet_Ped foreign key (idPedido) references Pedidos (idPedido)
alter table PedidoDetalle add constraint FK_PedDet_PresProd foreign key (idPresentacion) references PresentacionesProducto (idPresentacion)
--Proveedores
alter table proveedores add constraint FK_Prov_Ciud foreign key (idCiudad) references Ciudades (idCiudad)
--CuentasProveedor
alter table CuentasProveedor add constraint FK_CuenProv_Prove foreign key (idProveedor) references Proveedores (idProveedor)
--Pagos
alter table Pagos add constraint FK_Pagos_Ped foreign key (idPedido) references Pedidos (idPedido)
alter table Pagos add constraint FK_Pagos_FormPag foreign key (idFormaPago) references FormasPago (idFormaPago)
alter table Pagos add constraint FK_Pagos_CuentProv foreign key (idCuentaProveedor) references CuentasProveedor(idCuentaProveedor)--Correccion
--Pedidos
alter table Pedidos add constraint FK_Pedidos_Prove foreign key (idProveedor) references Proveedores (idProveedor)
alter table Pedidos add constraint FK_Pedidos_Suc foreign key (idSucursal) references Sucursales (idSucursal)
alter table Pedidos add constraint FK_Pedidos_Empl foreign key (idEmpleado) references Empleados (idEmpleado)
--Sucursales
alter table Sucursales add constraint FK_Suc_Ciu foreign key (idCiudad) references Ciudades (idCiudad)
--ExistenciaSucursal
alter table ExistenciasSucursal add constraint FK_ExisSuc_PresProd foreign key (idPresentacion) references PresentacionesProducto (idPresentacion)
alter table ExistenciasSucursal add constraint FK_ExisSuc_Suc foreign key (idSucursal) references Sucursales (idSucursal)
-------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------
--ofertas
alter table Ofertas add constraint FK_Ofertas_Prod foreign key (idProducto) references Productos (idProducto)
--Ciudades
alter table ciudades add constraint FK_Ciuda_Estdo foreign key (idEstado) references Estados (idEstado)
--Incapacidades
alter table Incapacidades add constraint FK_Incap_Empl foreign key (idEmpleado) references Empleados (idEmpleado)
--Usuarios
alter table Usuarios add constraint FK_Usuar_Empl foreign key (idEmpleado) references Empleados (idEmpleado)
alter table Usuarios add constraint FK_Usuar_TipoUsua foreign key (idTipoUsuario) references TipoUsuario (idTipoUsuario)
--Empleados
alter table Empleados add constraint FK_Empl_Dep foreign key (idDepartamento) references Departamentos (idDepartamento)
alter table Empleados add constraint FK_Emp_Pues foreign key (idPuesto) references Puestos (idPuesto)
alter table Empleados add constraint FK_Emp_Ciu foreign key (idCiudad) references Ciudades (idCiudad)
alter table Empleados add constraint FK_Emp_Sucur foreign key (idSucursal) references sucursales (idSucursal)
--Horarios
alter table Horarios add constraint FK_Horar_Emple foreign key (idEmpleado) references Empleados (idEmpleado)
--AusenciasJustificadas
alter table AusenciasJustificadas add constraint FK_Ausen_EmpS foreign key (idEmpleadoS) references Empleados (idEmpleado)
alter table AusenciasJustificadas add constraint FK_Ausen_EmpA foreign key (idEmpleadoA) references Empleados (idEmpleado)

--HistorialPuestos
alter table HistorialPuestos add constraint FK_HistorialPues_Emple foreign key (idEmpleado) references Empleados (idEmpleado)
alter table HistorialPuestos add constraint FK_HistoriaPues_Puest foreign key (idPuesto) references Puestos (idPuesto)
alter table HistorialPuestos add constraint FK_HistorialPues_Depart foreign key (idDepartamento) references Departamentos (idDepartamento)
--DocumentacionEmpleado
alter table DocumentacionEmpleado add constraint FK_DocEmpl_Emp foreign key (idEmpleado) references Empleados (idEmpleado)
--Nominas
alter table Nominas add constraint FK_Nomias_Emple foreign key (idEmpleado) references Empleados (idEmpleado)
alter table Nominas add constraint FK_Nomias_FormaPag foreign key (idFormaPago) references FormasPago (idFormaPago)
--NominasPercepciones
alter table NominasPercepciones add constraint FK_NomPerc_Nom foreign key (idNomina) references Nominas (idNomina)
alter table NominasPercepciones add constraint FK_NomPerc_Percep foreign key (idPercepcion) references Percepciones (idPercepcion)
--Nominas Deducciones
alter table NominasDeducciones add constraint FK_NomDed_Nom foreign key (idNomina) references Nominas (idNomina)
alter table NominasDeducciones add constraint FK_NomDed_Ded foreign key (idDeduccion) references Deducciones (idDeduccion)
-------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------
--OfertasAsociacion 
alter table OfertasAsociacion add constraint FK_OfertAsoc_Asocia foreign key (idAsociacion) references Asociaciones (idAsociacion)
alter table OfertasAsociacion add constraint FK_OfertAsoc_Ofert foreign key (idOferta) references Ofertas (idOferta)
--Miembros
alter table Miembros add constraint FK_Miembr_Client foreign key (idCliente) references Clientes (idCliente)
alter table Miembros add constraint FK_Miembr_Asocia foreign key (idAsociacion) references Asociaciones (idAsociacion)
--VentasDetalle
alter table VentasDetalle add constraint FK_VentDet_Vent foreign key (idVenta) references Ventas (idVenta)
alter table VentasDetalle add constraint FK_VentDet_PresProd foreign key (idPresentacion) references PresentacionesProducto (idPresentacion)
--Clientes
alter table Clientes add constraint FK_Client_Ciud foreign key (idCiudad) references Ciudades (idCiudad)
--ClientesCultivos
alter table ClientesCultivos add constraint FK_ClienCult_Client foreign key (idCliente) references Clientes (idCliente)
alter table ClientesCultivos add constraint FK_ClienCult_Cult foreign key (idCultivo) references Cultivos (idCultivo)
alter table ClientesCultivos add constraint FK_ClienCult_Ciu foreign key (idCiudad) references Ciudades (idCiudad)
--Ventas
alter table Ventas add constraint FK_Ventas_Client foreign key (idCliente) references clientes (idCliente)
alter table Ventas add constraint FK_Ventas_Sucursal foreign key (idSucursal) references Sucursales (idSucursal)
alter table Ventas add constraint FK_Ventas_Empleado foreign key (idEmpleado) references Empleados (idEmpleado)
--Facturas
alter table Facturas add constraint FK_Fact_Vent foreign key (idVenta) references Ventas (idVenta)
--Visistas
alter table Visitas add constraint FK_Visist_CliCult foreign key (idClienteCultivo) references ClientesCultivos (idClienteCultivo)
alter table Visitas add constraint FK_Visit_Empl foreign key (idEmpleado) references Empleados (idEmpleado)
alter table Visitas add constraint FK_Vist_UnTrans foreign key (idUnidadTransporte) references UnidadesTransporte (idUnidadTransporte)
--Tripulacion
alter table Tripulacion add constraint FK_Trip_Emp foreign key (idEmpleado) references Empleados (idEmpleado)
alter table Tripulacion add constraint FK_Trip_Env foreign key (idEnvio) references Envios (idEnvio)
--Cobros
alter table Cobros add constraint FK_Cob_Vent foreign key (idVenta) references Ventas (idVenta)
alter table Cobros add constraint FK_Cob_FormPag foreign key (idFormaPago) references FormasPago (idFormaPago)
--Envios
alter table Envios add constraint FK_Env_Vent foreign key (idVenta) references Ventas (idVenta)
alter table Envios add constraint FK_Env_UnidTras foreign key (idUnidadTransporte) references UnidadesTransporte (idUnidadTransporte)
alter table Envios add constraint FK_Env_Ciu foreign key (idCiudad) references Ciudades (idCiudad)
--Mantenimientos
alter table Mantenimientos add constraint FK_Mant_UnidTrans foreign key (idUnidadTransporte)  references UnidadesTransporte (idUnidadTransporte)








