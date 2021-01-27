using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
        INICIO:
            Console.Clear();


            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Escolha a operação (+|-|x|/): ");
            char op = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (op)
            {
                default:
                    Console.WriteLine("Opeção errada, Tente novamente!!");
                    goto INICIO;
                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine("O resultado da soma é: " + resultado);
                    break;

                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine("O resultado da subtração é: " + resultado);
                    break;


                case 'x':
                case 'X':
                    resultado = num1 * num2;
                    Console.WriteLine("O resultado da Multiplicação é: " + resultado);
                    break;

                case '/':
                case ':':
                    
                    if (num2 == 0)
                    {
                        Console.WriteLine("Não é possivel dividir por 0.");
                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("O resultado da Divisão é: " + resultado);
                    }
                    
                    break;


            }

            Console.Write("Continuar calculando? (s / n): ");
            string op2 = Console.ReadLine();
            
            if (op2 == "s" || op2 == "S")
            {
                goto INICIO;
            }
            
          
        }
    }
}
