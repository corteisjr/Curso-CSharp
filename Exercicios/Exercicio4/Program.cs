using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pokemons = new string[2];

            pokemons[0] = "Jesie";
            pokemons[1] = "Serena";

            Console.WriteLine("POKEMON'S");

            foreach (string pokemon in pokemons)
            {
                Console.WriteLine("\nNome: " + pokemon);
            }

            Console.ReadKey();
        }
    }
}
