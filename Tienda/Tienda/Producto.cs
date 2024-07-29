using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    internal class Producto
    {
        public Producto(string id, string nombre, double precio, int inventario)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            InventarioStock = inventario;
        }

        private string Id {  get; set; }
        private string Nombre { get; set; }
        private double Precio { get; set; }
        private int InventarioStock { get; set; }
        private int Ventas { get; set; }

        public void MostrarInformacion()
        {
            Console.Clear();
            Console.WriteLine("-----INFORMACION-----");
            Console.WriteLine("Id:" + Id);
            Console.WriteLine("Nombre: "+ Nombre);
            Console.WriteLine("Precio: Q." + Precio);
            Console.WriteLine("Inventario: " + InventarioStock);
            Console.WriteLine("Cantidad de ventas" + Ventas);
            Console.WriteLine("\n Presione ENTER para regresar");
            Console.ReadLine();
        }
    }
}
