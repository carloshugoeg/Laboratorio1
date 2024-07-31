namespace Tienda
{
    public class Program
    {
        static void Main(string[] args)
        {
            int id = 0001;
            Producto producto = new Producto(0, "", 0.00, 0);
            producto = producto.IngresarProducto(id);
            id++;
            do
            {
                Console.Clear();
                Console.WriteLine("---------TIENDA------------\n");
                Console.WriteLine("    1. Ingresar Producto");
                Console.WriteLine("    2. Consultar informacion de producto");
                Console.WriteLine("    3. Venta un producto");
                Console.WriteLine("    4. Reabastecer producto");
                Console.WriteLine("    5. Actualizar precio producto");
                Console.WriteLine("    6. Mostrar Resumen de producto");
                Console.WriteLine("    7. Salir");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        producto = producto.IngresarProducto(id);
                        id += 1;
                        break;
                    case "2":
                        producto.MostrarInformacion();
                        break;
                    case "3":
                        producto.VenderProducto();
                        break;
                    case "4":
                        producto.ReabastecerProducto();
                        break;
                    case "5":
                        producto.ActualizarPrecio();
                        break;
                    case "6":
                        producto.Resumen();
                        break;
                    case "7":
                        Environment.Exit(0);
                        break;
                }

            } while (true);
        }
    }
}
