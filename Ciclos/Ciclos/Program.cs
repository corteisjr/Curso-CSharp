using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ciclo While
            /*
            int valor = 20;
            while (valor < 10)
            {
                Console.WriteLine("O valor é " + valor);
                valor++;
            }
            */
            #endregion

            #region Ciclo Do while
            /*
            int valor = 20;

            do
            {
                Console.WriteLine("O valor é " + valor);
                valor++;
            } while (valor < 10);
            */
            #endregion

            #region Ciclo For
            /*
            for (int valor = 0, j = 10; valor < 10; valor++, j--)
            {
                Console.WriteLine("Valor = " + valor + "|" + "J = " + j);
            }
            */
            #endregion

            #region Ciclo ForEach

            string[] nomes = { "Corteis", "Pedro", "Nick", "Arthur" };

            foreach (string nome in nomes)
            {
                Console.WriteLine("Nome: " + nome);
            }
            #endregion
            Console.ReadKey();
        }
    }
}
