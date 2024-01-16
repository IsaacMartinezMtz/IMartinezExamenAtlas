using DL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddProductos();
            Console.ReadKey();
        }
        public static void AddProductos()
        {
            string Tipos = "";
            string respuesta = "";
            bool query = false;
            ML.Productos productos = new ML.Productos();
            productos.Tipo = new ML.Tipo();
            do
            {
                Console.WriteLine("Ingresa el nombre del producto");
                productos.Nombre = Console.ReadLine();
                if (productos.Nombre == "")
                {
                    Console.WriteLine("No acepta valores nulos");
                    productos.Nombre = Console.ReadLine();
                }
                Console.WriteLine("Ingresa el Tipo de Productos");
                Console.WriteLine("Opciones: ");
                Console.WriteLine("A");
                Console.WriteLine("B");
                Tipos = Console.ReadLine();
                if (Tipos == "")
                {
                    Console.WriteLine("No acepta valores nulos");
                    Tipos = Console.ReadLine();
                }
                if (Tipos != "A" && Tipos != "B")
                {
                    Console.WriteLine("Ingresa un valor permitido");
                    Tipos = Console.ReadLine();
                }
                else
                {
                    productos.Tipo.IdTipo = (Tipos == "A") ? 1 : 2;
                }
                Console.WriteLine("Ingresa el Costo del producto");
                productos.Precio = Convert.ToDecimal(Console.ReadLine());
                if (productos.Precio == 0)
                {
                    Console.WriteLine("No acepta valores nulos");
                    productos.Precio = Convert.ToDecimal(Console.ReadLine());
                }
                query = BL.Productos.AddProductos(productos);
                if (query)
                {
                    Console.WriteLine("Agergado correcatmente");
                }
                else
                {
                    Console.WriteLine("Error al agregar el producto");
                }
                Console.WriteLine("Desea volver a ingresar un producto");
                Console.WriteLine("Si/No");
                respuesta = Console.ReadLine();
            } while (respuesta == "Si");

        }
    }
}
