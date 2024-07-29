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
    Console.Clear();
    Console.WriteLine("----NUEVA VENTA----");

    Console.WriteLine("Ingrese nuevo producto: ");

}