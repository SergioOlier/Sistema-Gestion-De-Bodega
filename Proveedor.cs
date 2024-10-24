using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionDeBodega
{
    public class Proveedor
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public List<Producto> Productos { get; set; }

        public Proveedor(string id, string nombre)
        {
            ID = id;
            Nombre = nombre;
            Productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        public override string ToString()
        {
            return $"ID: {ID}, Nombre: {Nombre}";
        }
    }

}
