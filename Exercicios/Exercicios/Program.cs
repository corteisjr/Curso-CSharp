using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite o primeiro numero: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("\nDigite o segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = num1 + num2;

            Console.WriteLine("A soma dos valores é: {0}", resultado);

            Console.ReadKey();
        }
    }
}
