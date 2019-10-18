
use Inventario
create table Producto1
(
ID_Producto int NOT NULL UNIQUE,
Nombre varchar(50) NOT NULL,
Cantidad int NOT NULL,
Precio money NOT NULL,
Proveedor varchar (50)
)