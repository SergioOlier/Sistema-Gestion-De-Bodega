using SistemaGestionDeBodega;

using System;

class Program
{
    static void Main(string[] args)
    {
        Bodega bodega = new Bodega();

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n--- Sistema de Gestión de Bodega ---");
            Console.WriteLine("1. Registrar Proveedor");
            Console.WriteLine("2. Agregar Producto");
            Console.WriteLine("3. Registrar Empleado");
            Console.WriteLine("4. Realizar Pedido");
            Console.WriteLine("5. Mostrar Productos");
            Console.WriteLine("6. Mostrar Proveedores");
            Console.WriteLine("7. Mostrar Empleados");
            Console.WriteLine("8. Salir\n");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarProveedor(bodega);
                    break;
                case "2":
                    AgregarProducto(bodega);
                    break;
                case "3":
                    RegistrarEmpleado(bodega);
                    break;
                case "4":
                    RealizarPedido(bodega);
                    break;
                case "5":
                    bodega.MostrarProductos();
                    break;
                case "6":
                    bodega.MostrarProveedores();
                    break;
                case "7":
                    bodega.MostrarEmpleados();
                    break;
                case "8":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void RegistrarProveedor(Bodega bodega)
    {
        Console.Write("\nIngrese el ID del proveedor: ");
        string id = Console.ReadLine();
        Console.Write("Ingrese el nombre del proveedor: ");
        string nombre = Console.ReadLine();

        Proveedor nuevoProveedor = new Proveedor(id, nombre);
        bodega.RegistrarProveedor(nuevoProveedor);
    }

    static void AgregarProducto(Bodega bodega)
    {
        Console.Write("\nIngrese el código del producto: ");
        string codigo = Console.ReadLine();
        Console.Write("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese la descripción del producto: ");
        string descripcion = Console.ReadLine();
        Console.Write("Ingrese el precio unitario del producto: ");
        decimal precio = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Ingrese la cantidad en stock: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nSeleccione el proveedor para este producto: ");
        bodega.MostrarProveedores();
        Console.Write("\nIngrese el ID del proveedor: ");
        string idProveedor = Console.ReadLine();
        Proveedor proveedorSeleccionado = bodega.Proveedores.Find(p => p.ID == idProveedor);

        if (proveedorSeleccionado != null)
        {
            Producto nuevoProducto = new Producto(codigo, nombre, descripcion, precio, cantidad, proveedorSeleccionado);
            bodega.AgregarProducto(nuevoProducto);
        }
        else
        {
            Console.WriteLine("Proveedor no encontrado.");
        }
    }

    static void RegistrarEmpleado(Bodega bodega)
    {
        Console.Write("\nIngrese el ID del empleado: ");
        string id = Console.ReadLine();
        Console.Write("Ingrese el nombre del empleado: ");
        string nombre = Console.ReadLine();

        Console.WriteLine("Seleccione el rol del empleado:");
        Console.WriteLine("1. Administrador");
        Console.WriteLine("2. Encargado de Almacén");
        string rol = Console.ReadLine();

        if (rol == "1")
        {
            Administrador nuevoEmpleado = new Administrador(id, nombre);
            bodega.RegistrarEmpleado(nuevoEmpleado);
        }
        else if (rol == "2")
        {
            EncargadoAlmacen nuevoEmpleado = new EncargadoAlmacen(id, nombre);
            bodega.RegistrarEmpleado(nuevoEmpleado);
        }
        else
        {
            Console.WriteLine("Rol no válido.");
        }
    }

    static void RealizarPedido(Bodega bodega)
    {
        Console.Write("\nIngrese el número del pedido: ");
        int numeroPedido = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Seleccione el proveedor para este pedido:");
        bodega.MostrarProveedores();
        Console.Write("\nIngrese el ID del proveedor: ");
        string idProveedor = Console.ReadLine();
        Proveedor proveedorSeleccionado = bodega.Proveedores.Find(p => p.ID == idProveedor);

        if (proveedorSeleccionado != null)
        {
            Console.WriteLine("\nSeleccione el empleado que gestiona el pedido:");
            bodega.MostrarEmpleados();
            Console.Write("\nIngrese el ID del empleado: ");
            string idEmpleado = Console.ReadLine();
            Empleado empleadoSeleccionado = bodega.Empleados.Find(e => e.ID == idEmpleado);

            if (empleadoSeleccionado != null)
            {
                Pedido nuevoPedido = new Pedido(numeroPedido, proveedorSeleccionado, empleadoSeleccionado);

                bool agregarProductos = true;
                while (agregarProductos)
                {
                    Console.WriteLine("\nSeleccione el producto que desea agregar al pedido:");
                    bodega.MostrarProductos();
                    Console.Write("\nIngrese el código del producto: ");
                    string codigoProducto = Console.ReadLine();
                    Producto productoSeleccionado = bodega.Productos.Find(p => p.Codigo == codigoProducto);

                    if (productoSeleccionado != null)
                    {
                        Console.Write("Ingrese la cantidad a solicitar: ");
                        int cantidad = Convert.ToInt32(Console.ReadLine());

                        nuevoPedido.AgregarProducto(productoSeleccionado, cantidad);
                    }
                    else
                    {
                        Console.WriteLine("Producto no encontrado.");
                    }

                    Console.Write("\n¿Desea agregar otro producto al pedido? (S/N): ");
                    string respuesta = Console.ReadLine().ToUpper();
                    agregarProductos = respuesta == "S";
                }

                bodega.RealizarPedido(nuevoPedido);
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }
        else
        {
            Console.WriteLine("Proveedor no encontrado.");
        }
    }
}
