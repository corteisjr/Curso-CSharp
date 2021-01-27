using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coleccao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vetores
            /*
            int[] numeros = new int[5];

            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

            string[] nomes = { 
                "Corteis",
                "Arcenio",
                "Carlos"
            };

            nomes[0] = "Logan";
            //nomes[1] = "Arcenio";
            //nomes[2] = "Carlos";

            Console.WriteLine(nomes[0]);
            Console.WriteLine(numeros[0]);

            */
            #endregion

            int[,] numeros = new int[2, 3];

            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 30;
            
            numeros[1, 0] = 40;
            numeros[1, 1] = 50;
            numeros[1, 2] = 60;



            Console.Write("[" + numeros[0,0] + "]");
            Console.Write("[" + numeros[0,1] + "]");
            Console.Write("[" + numeros[0,2] + "]");

            Console.WriteLine();

            Console.Write("[" + numeros[1,0] + "]");
            Console.Write("[" + numeros[1,1] + "]");
            Console.Write("[" + numeros[1,2] + "]");

            string[,] nomes = 
            {
                {"Arcenio", "Carlos", "Flavio" },
                {"Yanick", "Gloria", "Pedro" }
            
            };

            Console.WriteLine();

            Console.WriteLine(nomes[0,1]);

            Console.ReadKey();
        }
    }
}
