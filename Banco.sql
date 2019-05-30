
---Paso 1.-Creación de la BD:
Create database Proyecto_Banco
Go
use Proyecto_Banco
Go

---Paso 2.-Creación de tablas:
Create Table Tipo_Cuenta
(
[ID] int identity(100,5),---PK
[Nombre] varchar(60) not null,
[MontoMinimo] money not null,
[Descripcion] varchar(80) not null
)
Go

Create Table Cuenta
(
[Clave] int not null,---PK
[Saldo] money not null,
[ID_TipoCuenta] int not null--FK
)
Go

Create Table Cliente
(
[ID] int identity(1000,2),---PK
[Nombre] varchar(60) not null,
[Domicilio] varchar(80) not null,
[Ciudad] varchar(60),
[Telefono] varchar(60) not null
)
Go

Create Table Movimiento
(
[Folio] int identity(1000,2),---PK
[Monto] money not null,
[Tipo] char(1) not null,
[Fecha] date not null,
[Hora] time not null
)
Go

Create Table Cuenta_Cliente
(
[ID_Cliente] int not null,--Fk
[Clave_Cuenta] int not null---FK
)
Go

Create Table Movimiento_Cuenta
(
[Folio_Movimiento] int not null,---FK
[Clave_Cuenta] int not null---FK
)
Go

---Paso 3.-Creación de PK:
Alter Table Tipo_Cuenta Add Constraint [PK_TipoCuenta]
Primary Key (ID)
GO

Alter Table Cuenta	Add Constraint [PK_Cuenta]
Primary Key (Clave)
Go

Alter Table Cliente Add Constraint [PK_Cliente]
Primary Key (ID)
Go

Alter Table Movimiento Add Constraint [PK_Movimiento]
Primary Key (Folio)
Go

Alter Table Cuenta_Cliente add Constraint [PK_Cuenta_Cliente]
Primary Key([ID_Cliente],[Clave_Cuenta])
Go

Alter Table Movimiento_Cuenta add constraint [PK_Movimiento_Cuenta]
Primary Key([Folio_Movimiento],[Clave_Cuenta])
Go

---Paso 4.-Creación de FK
Alter Table Cuenta Add Constraint [FK_Cuenta]
Foreign Key (ID_TipoCuenta) References Tipo_Cuenta(ID)
Go

Alter Table Cuenta_Cliente Add Constraint [FK_CuentaCliente_Cliente]
Foreign Key (ID_Cliente) References Cliente(ID)
Go

Alter Table Cuenta_Cliente Add Constraint[FK_CuentaCliente_Cuenta]
Foreign Key (Clave_Cuenta) References Cuenta(Clave)
Go

Alter Table Movimiento_Cuenta Add Constraint [FK_MovimientoCliente_Movimiento]
Foreign Key (Folio_Movimiento) References Movimiento(Folio)
Go

Alter Table Movimiento_Cuenta Add Constraint [FK_MovimientoCuenta_Cuenta]
Foreign Key (Clave_Cuenta) References Cuenta(Clave)
Go

---Paso 5.-Creación de Restricciones:
Alter Table Tipo_Cuenta add Constraint CK_MontoMinimo
check([MontoMinimo]>=0)
Go

Alter Table Movimiento add Constraint CK_Tipo_Movimiento
check ([Tipo] in ('D','R'))
Go

Alter Table Movimiento add Constraint CK_Monto_Movimiento
check ([Monto]>0)
Go

Alter Table Tipo_Cuenta add Constraint UQ_Nombre_Tipo
unique([Nombre])
Go

Alter Table Cliente add Constraint UQ_Nombre_Usuario
unique([Nombre])
Go

Alter Table Cuenta_Cliente add constraint UQ_Cuenta_Cliente
unique([Clave_Cuenta])
Go

Alter Table [Movimiento_Cuenta] add Constraint UQ_Folio_Movimiento
unique([Folio_Movimiento])
Go

---Paso 6.-Triggers:

Create Trigger TG_Saldo_Cuenta
on Cuenta after insert,update
as
begin
declare @Saldo money
declare @MontoMinimo money
select @Saldo=i.Saldo,@MontoMinimo=t.MontoMinimo from inserted i inner join Tipo_Cuenta t on t.ID=i.ID_TipoCuenta

if(@Saldo<@MontoMinimo)
	begin
		Throw 51000,'No se puede realizar la transacción debido a que el saldo de la cuenta debe de ser igual o mayor al monto minimo asociado',1
		rollback;
	end
end
Go

---Paso 7.-Inserciones:

insert into Tipo_Cuenta(Nombre,MontoMinimo,Descripcion)
values ('PREMIUM',20000,'PRIVILEGIOS BASICOS. NO INCLUYE TARJETA FISICA')
insert into Tipo_Cuenta(Nombre,MontoMinimo,Descripcion)
values ('BASICA',4000,'REQUIERE SALDO MINIMO')
insert into Tipo_Cuenta(Nombre,MontoMinimo,Descripcion)
values ('NOMINA',0,'DEPOSITOS DE NOMINA')


select ID, Nombre, Domicilio, Ciudad, Telefono from Cliente