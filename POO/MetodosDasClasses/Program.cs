using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Metodos m = new Metodos();
            #region Metodos simples

            //m.Cumprimentar();
            #endregion

            #region Metodos com parametros

            //m.Somar(5, 10);
            //m.Apresentar("ARcenio", 22);
            #endregion

            #region Metodos com parametros por Ref e valor

            //int valor1 = 100;
            //int valor2 = 100;

            //m.AumentarValor(valor1);

            //m.AumentarRef(ref valor2);

            //Console.WriteLine("Valor 1: " + valor1);
            //Console.WriteLine("Valor 2 : " + valor2);
            #endregion

            #region Netodos com retorno de valores
            /*
            string nomeCompleto = m.MontaNome("Arcenio", "Corteis");
            int codigoChar = m.CodigoChar('a');
            double pi = m.ValorPi();

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(codigoChar);
            Console.WriteLine(pi);*/

            #endregion

            m.Cumprimentar();
            m.Cumprimentar("Corteis");
            m.Cumprimentar("Arcenio", 07);

            bool res1 = m.Comparar(10, 50 * 2);
            
            Console.WriteLine(res1);

            Console.ReadKey();
        }

    }
}
