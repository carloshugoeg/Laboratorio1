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
    do
    {
        try
        {
            Console.Clear();
            Console.WriteLine("----NUEVA VENTA----");
            Console.Write("Ingrese nuevo producto: ");
            string producto = Console.ReadLine();
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

}