using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parte1
            //Carro c = new Carro();
            //Bicicleta b = new Bicicleta();
            ////Veiculo v = new Veiculo(); //--> Somente serve de base para outras classes 

            //c.Acelerar();
            //b.Acelerar();
            #endregion

            Humano a = new Humano();
            Pessoa b = new Pessoa();
            Homem c = new Homem();


            Console.WriteLine("Humano");
            a.Olhos();
            a.Cabelos();
            Console.WriteLine("\nPessoa");
            b.Olhos();
            b.Cabelos();
            Console.WriteLine("\nHomem");
            c.Olhos();
            c.Cabelos();

            Console.ReadKey();


        }
    }
}
