do
{
    try
    {
        Console.Clear();
        Console.WriteLine("Menu");
        Console.WriteLine("     1. Ingresar Venta");
        Console.WriteLine("     2. Salir");
        string option = Console.ReadLine();
        switch (option)
        {
            case "1":
                MenuVenta();
                break;

        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.ReadLine();
        Console.Clear();
    }

} while (true);

static void MenuVenta()
{
    List<string> productosList = new List<string>();
    List<double> preciosList = new List<double>();
    string producto;
    do
    {
        try
        {
            Console.Clear();
            Console.WriteLine("----NUEVA VENTA----");
            Console.Write("Ingrese nuevo producto: ");
            producto = Console.ReadLine();
            if (producto.Length > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("El producto no puede ser nulo, intentelo de nuevo");
                Console.ReadLine();
            }            
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
            Console.Clear();
        }
            
    }while (true);
    productosList.Add(producto);


}
double PedirPrecio()
{
    do
    {
        try
        {
            double precio;
            do
            {
                Console.WriteLine("Ingrese el precio de su producto: ");
                precio = double.Parse(Console.ReadLine());
                if (precio == 0)
                {
                    Console.WriteLine("Number cannot be 0. Please try again");
                    Console.ReadLine();
                }
            } while (precio == 0);
            return precio;
        }
        catch (FormatException ex)
        {
            Console.WriteLine("INPUT INVALIDO");
            Console.WriteLine(ex.Message);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("-----Nueva Venta-----");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("EL numero es demasiado grande");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("-----Nueva Venta-----");
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR");
            Console.WriteLine(ex.Message);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("-----Nueva Venta-----");
        }
    } while (true);
}