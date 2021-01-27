using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o segundo valor: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("A soma de " + num1 + " e " + num2 + " é = " + (num1 + num2));
            Console.WriteLine("\nA subtração de " + num1 + " e " + num2 + " é = " + (num1 - num2));
            Console.WriteLine("\nA multiplicação de " + num1 + " e " + num2 + " é = " + (num1 * num2));
            Console.WriteLine("\nA divisão de " + num1 + " e " + num2 + " é = " + (num1 / num2));

            Console.ReadKey();
        }
    }
}
