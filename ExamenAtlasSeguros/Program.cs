using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAtlasSeguros
{
    public class Program
    {
        static void Main(string[] args)
        {
            NumerosPares();
            //EstructuraWhile();
            Console.ReadKey();
        }
        public static void EstructuraWhile()
        {
            int i = 1;
            decimal numero = 0;
            decimal operacion = 0;

            while (i < 101) 
            {
                Console.WriteLine("Ingresa un numero");
                numero = Convert.ToDecimal(Console.ReadLine());
                operacion = numero * i;
                Console.WriteLine(operacion);
                Console.WriteLine("*******************************");
                i = i + 3;
            }
            
        }
        public static void NumerosPares()
        {
            for (int i = 1; i < 101; i++)
            {
                int operacion = i % 2;
                if (operacion == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
