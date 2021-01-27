using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatico
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Estática
            /*
            Matematica.taxa = 20;

            int valor1 = Matematica.Adicionar(200);
            int valor2 = Matematica.Diminuir(200);

            Console.WriteLine("Valor 1: " + valor1);
            Console.WriteLine("Valor 2: " + valor2);
            */
            #endregion

            Pessoa.maioridade = 21;

            Pessoa p1 = new Pessoa();
            p1.nome = "Corteis";
            p1.idade = Pessoa.CalcularIdade(1999);

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
 

            Console.ReadKey();


        }
    }
}
