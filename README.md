## Sistema de Gestión de una Bodega

Se desea desarrollar un sistema de gestión para una bodega que permita
administrar la información de productos, proveedores, pedidos y empleados. Cada
producto tiene un código único, nombre, descripción, precio unitario y cantidad en
stock. Cada proveedor tiene un número de identificación único, nombre y lista de
productos que suministra. Cada pedido está asociado a un proveedor, contiene una
lista de productos solicitados con cantidades específicas y está gestionado por un
empleado de la bodega. Los empleados tienen un número de identificación único,
nombre y rol dentro de la bodega (por ejemplo, administrador, encargado de
almacén).

El sistema debe soportar las siguientes operaciones:

* **Gestionar Productos:**
    * Se debe poder agregar productos al sistema especificando todos sus
    detalles, incluyendo proveedor asociado y cantidad en stock.
* **Gestionar Proveedores:**
    * Se debe poder registrar proveedores en el sistema con todos sus
    detalles y gestionar la lista de productos que suministran.
* **Gestionar Pedidos:**
    * Los empleados de la bodega deben poder realizar pedidos a los
    proveedores, especificando los productos solicitados y las cantidades
    requeridas.
* **Gestionar Empleados:**
    * Se debe poder registrar empleados en el sistema con su información
    básica y asignarles roles específicos dentro de la bodega.

**Requerimientos específicos:**

* Implementar herencia para diferenciar entre diferentes roles de empleados
dentro de la bodega, como administradores y encargados de almacén, que
pueden tener responsabilidades y permisos distintos en el sistema.
* Se debe establecer relaciones y su correspondiente cardinalidad.
* Se debe establecer por lo menos una relación de composición y una de
agregación.
* Definir la multiplicidad adecuada para cada relación, como, por ejemplo, que
un producto debe estar asociado a exactamente un proveedor, pero un
proveedor puede suministrar varios productos.

