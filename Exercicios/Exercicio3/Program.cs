using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do vendendor: ");
            string nome = Console.ReadLine();

            Console.Write("Salário fixo: ");
            double sFixo = double.Parse(Console.ReadLine());

            Console.Write("Total vendas: ");
            double tVendas = double.Parse(Console.ReadLine());

            double comissao = (tVendas * 15)/100;
            double sMensal = comissao + sFixo;

            Console.WriteLine("O nome do vendendor é: " + nome);
            Console.WriteLine("O salário do vendendor é: " + sFixo);
            Console.WriteLine("O salário do final do mês é: " + sMensal);

            Console.ReadKey();

        }
    }
}
