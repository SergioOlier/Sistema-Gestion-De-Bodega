using System;
using System.Collections.Generic;

namespace SistemaGestionDeBodega
{
    public class Bodega
    {
        // Listas para gestionar productos, proveedores y empleados
        public List<Producto> Productos { get; set; }
        public List<Proveedor> Proveedores { get; set; }
        public List<Empleado> Empleados { get; set; }

        // Constructor que inicializa las listas
        public Bodega()
        {
            Productos = new List<Producto>();
            Proveedores = new List<Proveedor>();
            Empleados = new List<Empleado>();
        }

        // Método para agregar productos
        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
            Console.WriteLine($"Producto {producto.Nombre} agregado correctamente.");
        }

        // Método para mostrar productos
        public void MostrarProductos()
        {
            Console.WriteLine("Productos en la bodega:");
            foreach (var producto in Productos)
            {
                Console.WriteLine(producto.ToString());
            }
        }

        // Método para registrar proveedores
        public void RegistrarProveedor(Proveedor proveedor)
        {
            Proveedores.Add(proveedor);
            Console.WriteLine($"Proveedor {proveedor.Nombre} registrado correctamente.");
        }

        // Método para mostrar proveedores
        public void MostrarProveedores()
        {
            Console.WriteLine("Proveedores registrados:");
            foreach (var proveedor in Proveedores)
            {
                Console.WriteLine(proveedor.ToString());
            }
        }

        // Método para realizar un pedido
        public void RealizarPedido(Pedido pedido)
        {
            foreach (var producto in pedido.ProductosSolicitados)
            {
                if (producto.CantidadEnStock < 0)
                {
                    Console.WriteLine($"No hay suficiente stock de {producto.Nombre}");
                    return;
                }
            }
            Console.WriteLine($"Pedido {pedido.NumeroPedido} realizado correctamente.");
        }

        // Método para registrar empleados
        public void RegistrarEmpleado(Empleado empleado)
        {
            Empleados.Add(empleado);
            Console.WriteLine($"Empleado {empleado.Nombre} registrado correctamente.");
        }

        // Método para mostrar empleados
        public void MostrarEmpleados()
        {
            Console.WriteLine("Empleados registrados:");
            foreach (var empleado in Empleados)
            {
                Console.WriteLine(empleado.ToString());
            }
        }
    }
}

