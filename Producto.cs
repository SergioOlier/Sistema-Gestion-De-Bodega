using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionDeBodega
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int CantidadEnStock { get; set; }
        public Proveedor ProveedorAsociado { get; set; }

        public Producto(string codigo, string nombre, string descripcion, decimal precioUnitario, int cantidadEnStock, Proveedor proveedor)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioUnitario = precioUnitario;
            CantidadEnStock = cantidadEnStock;
            ProveedorAsociado = proveedor;
        }

        public override string ToString()
        {
            return $"Código: {Codigo}, Nombre: {Nombre}, Precio: {PrecioUnitario}, Cantidad: {CantidadEnStock}, Proveedor: {ProveedorAsociado.Nombre}";
        }
    }

}
