using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjectos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objectos
            /*
            MinhaClasse mClass = new MinhaClasse();
            MinhaClasse m2 = null;

            OutraClasse outra = new OutraClasse();
            OutraClasse outra2 = outra;
            */
            #endregion


            Pessoa p1 = new Pessoa();
            p1.nome = "Arcenio";
            p1.sobrenome = "Corteis";
            p1.anoNascimento = 1999;

            Pessoa p2 = new Pessoa()
            {
                nome = "Yanick",
                sobrenome = "Djuma",
                anoNascimento = 2014
            };

            p1.nome = "Ngoku";

            Console.WriteLine("Pessoa1: " + p1.nome);
            Console.WriteLine("Pessoa1: " + p1.sobrenome);
            Console.WriteLine("Pessoa1: " + p1.anoNascimento);
            p1.Cumprimentar();

            Console.WriteLine();


            Console.WriteLine("Pessoa2: " + p2.nome);
            Console.WriteLine("Pessoa2: " + p2.sobrenome);
            Console.WriteLine("Pessoa2: " + p2.anoNascimento);
            p2.Cumprimentar();

            Console.ReadKey();
        }
    }

    class MinhaClasse
    {
    
    }
}
