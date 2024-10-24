using System;
using System.Collections.Generic;

namespace SistemaGestionDeBodega
{
    public class Pedido
    {
        public int NumeroPedido { get; set; }
        public Proveedor Proveedor { get; set; }
        public List<Producto> ProductosSolicitados { get; set; }
        public Empleado EmpleadoGestion { get; set; }

        // Constructor que inicializa el pedido con un número, proveedor y empleado
        public Pedido(int numeroPedido, Proveedor proveedor, Empleado empleado)
        {
            NumeroPedido = numeroPedido;
            Proveedor = proveedor;
            EmpleadoGestion = empleado;
            ProductosSolicitados = new List<Producto>();
        }

        // Método para agregar productos a un pedido
        public void AgregarProducto(Producto producto, int cantidad)
        {
            // Verifica si hay suficiente stock del producto
            if (producto.CantidadEnStock >= cantidad)
            {
                ProductosSolicitados.Add(producto);  // Añade el producto a la lista de productos solicitados
                producto.CantidadEnStock -= cantidad;  // Reduce el stock del producto
                Console.WriteLine($"{cantidad} unidades de {producto.Nombre} añadidas al pedido.");
            }
            else
            {
                Console.WriteLine($"No hay suficiente stock para {producto.Nombre}.");
            }
        }

        // Sobrescribir ToString para mostrar información del pedido
        public override string ToString()
        {
            return $"Pedido #{NumeroPedido}, gestionado por {EmpleadoGestion.Nombre}, para el proveedor {Proveedor.Nombre}.";
        }
    }
}
