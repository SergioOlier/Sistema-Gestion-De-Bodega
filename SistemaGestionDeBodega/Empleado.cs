using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionDeBodega
{
    public class Empleado
    {
        public string ID { get; set; }
        public string Nombre { get; set; }

        public Empleado(string id, string nombre)
        {
            ID = id;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Nombre: {Nombre}";
        }
    }

    public class Administrador : Empleado
    {
        public Administrador(string id, string nombre) : base(id, nombre) { }

        public void GestionarEmpleados()
        {
            Console.WriteLine("Gestionando empleados...");
        }
    }

    public class EncargadoAlmacen : Empleado
    {
        public EncargadoAlmacen(string id, string nombre) : base(id, nombre) { }

        public void GestionarInventario()
        {
            Console.WriteLine("Gestionando inventario...");
        }
    }

}
