using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Tienda
{
    internal class Producto
    {
        public Producto(int id, string nombre, double precio, int inventario)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            InventarioStock = inventario;
            Ventas = 0;
        }

        private int Id {  get; set; }
        private string Nombre { get; set; }
        private double Precio { get; set; }
        private int InventarioStock { get; set; }
        private int Ventas { get; set; }


       
        public void VenderProducto()
        {
            int cantidadVender;
            do
            {
                try
                {
                    Console.WriteLine("-----VENDER PRODUCTO-----");
                    Console.WriteLine("\nCantidad en stock: " + InventarioStock);
                    
                    Console.Write("\n\nCuantas unidades desea vender?: ");
                    cantidadVender = int.Parse(Console.ReadLine());;
                    if (cantidadVender != 0 && cantidadVender <= InventarioStock)
                    {
                        break;
                    }
                    Console.WriteLine("No se puede ingresar cantidad 0 o nula");
                    Console.ReadKey();
                    Console.Clear();
                    if (cantidadVender > InventarioStock) Console.WriteLine("La cantidad a vender excede a la cantidad en stock");
                }
                catch (FormatException ex)
                {

                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Presione ENTER para continuar");
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Presione ENTER para continuar");
                    Console.ReadLine();
                    Console.Clear();
                }
                
            } while (true);
            Console.WriteLine("\nVenta realizada excitosamente!!");
            Console.WriteLine($"Porfavor pagar Q.{cantidadVender * Precio} en ventanilla");
            InventarioStock -= cantidadVender;
            Ventas += cantidadVender;
            Console.ReadKey();
            Console.Clear();

        }
        public void MostrarInformacion()
        {
            Console.Clear();
            Console.WriteLine("-----INFORMACION-----");
            Console.WriteLine("Id:" + Id);
            Console.WriteLine("Nombre: "+ Nombre);
            Console.WriteLine("Precio: Q." + Precio);
            Console.WriteLine("Inventario:  " + InventarioStock);
            Console.WriteLine("\n Presione ENTER para regresar");
            Console.ReadLine();
        }
        public Producto IngresarProducto(int id)
        {
            Producto producto;
            Console.Clear();
            Console.WriteLine("------Ingresar Producto------");
            Console.WriteLine("ID: " + id);
            Console.Write("\nIngrese Nombre: ");
            string nombre = Console.ReadLine();
            double precio = PedirPrecio();
            int stock;
            do
            {
                try
                {
                    Console.Write("Ingrese su cantidad en stock: ");
                    stock = int.Parse(Console.ReadLine());
                    if (stock != 0 && stock != null)
                    {
                        break;
                    }
                    Console.WriteLine("No se puede ingresar cantidad 0 o nula");
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Presione ENTER para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("------Ingresar Producto------");
                }
            } while (true);
            producto = new Producto(id, nombre, precio, stock);
            Console.WriteLine("\nProducto ingresado correctamente!!");
            Console.WriteLine("Presione ENTER para continuar");
            Console.ReadLine();
            return producto;
        }
        public void Resumen()
        {
            Console.Clear();
            Console.WriteLine("-----RESUMEN VENTAS-----");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Inventario restante:  " + InventarioStock);
            Console.WriteLine("Cantidad de ventas: " + Ventas);
            Console.WriteLine("\n Presione ENTER para regresar");
            Console.ReadLine();
        }
        public void ActualizarPrecio()
        {
            double nuevoPrecio;
            do
            {
                try
                {
                    Console.Clear();

                    Console.WriteLine("-----ACTUALIZAR PRECIO PRODUCTO-----");
                    Console.WriteLine("\nPrecio Actual: Q." + Precio);

                    Console.Write("\n\nCual es el nuevo precio?: Q.");
                    nuevoPrecio = double.Parse(Console.ReadLine());
                    if (nuevoPrecio != 0)
                    {
                        break;
                    }
                    Console.WriteLine("No se puede ingresar cantidad 0 o nula");
                }
                catch (FormatException ex)
                {

                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Presione ENTER para continuar");
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Presione ENTER para continuar");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (true);
            Console.WriteLine("\nActualizacion de precio realizado excitosamente!!");
            Precio = nuevoPrecio;
            Console.ReadKey();
            Console.Clear();
        }
        public void ReabastecerProducto()
        {
            int cantidadIngresar;
            do
            {
                try
                {
                    Console.WriteLine("-----INGRESAR PRODUCTO-----");
                    Console.WriteLine("\nCantidad en stock: " + InventarioStock);

                    Console.Write("\n\nCuantas unidades desea reabastecer?: ");
                    cantidadIngresar = int.Parse(Console.ReadLine());
                    if (cantidadIngresar != 0)
                    {
                        break;
                    }
                    Console.WriteLine("No se puede ingresar cantidad 0 o nula");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (FormatException ex)
                {

                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Presione ENTER para continuar");
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Presione ENTER para continuar");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (true);
            Console.WriteLine("\nReabastecimiento realizado excitosamente!!");
            InventarioStock += cantidadIngresar;
            Console.ReadKey();
            Console.Clear();
        }
        public double PedirPrecio()
        {
            do
            {
                try
                {

                    double precio;
                    do
                    {
                        Console.Write("Ingrese el precio de su producto: Q.");
                        precio = double.Parse(Console.ReadLine());
                        if (precio == 0 || precio == null)
                        {
                            Console.WriteLine("Valor no puede ser 0");
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

    }
}
