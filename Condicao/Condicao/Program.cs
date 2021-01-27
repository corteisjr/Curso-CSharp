using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Condição simples e encadiadas
            /*int valor = 25;

            if (valor  < 5)
            {
                Console.WriteLine("Condição Verdadeira");
               
            }
            else if (valor >= 5 && valor < 10)
            {
                Console.WriteLine("Condição alternativa 1");
            }
            else if (valor >= 10 && valor < 20)
            {
                Console.WriteLine("Condição alternativa 2");
            }
            else
            {
                Console.WriteLine("Condição alternativa final");
            }*/
            #endregion

            #region Condição Aninhada
            /*
            int numero = 13;

            if (numero > 5)
            {
                Console.WriteLine("O numero eh maior que 5");

                if (numero % 2 == 0)
                {
                    Console.WriteLine(" e tambem eh par.");
                }
                else
                {
                    Console.WriteLine(" mas nao eh par.");
                }
            }
            */
            #endregion


            #region Condição Ternária
            int numero = 10;
            string mensagem = "";

            //Condicao ? true : false;

            mensagem = numero > 5 ? "Maior que 5" : "Menor que 5";



            //if (numero > 5)
            //{
              //  mensagem = "Maior que 5";

            //}
            //else
            //{
              //  mensagem = "Menor que 5";
            //}

            Console.WriteLine(mensagem);
            #endregion
            Console.ReadKey();
        }
    }
}
