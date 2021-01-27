using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("### CONVERSOR DE TEMPERATURA ###");
            Console.Write("Insira a temperatura em Celsius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");

            // (c*9/5) + 32 = F

            f = (c * 9 / 5) + 32;

            // c + 273,15

            k = c + 273.15;


            Console.WriteLine(c + " graus Celcius = " + f + " graus Fahrenheit");
            Console.WriteLine(c + " graus Celcius = " + k + " graus Kelvin");
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();

        }
    }
}
