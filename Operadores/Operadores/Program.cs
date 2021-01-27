using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operações Matemáticas
            /*
            int num1 = 15;
            int num2 = 2;
            //int resultado = num1 + num2;

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2);*/
            #endregion

            #region Precedência de valores aritméticos
            /*int num1 = 100;
            int num2 = 10;
            int num3 = 5;
            int resp = (num1 + num2) * (num3/2);*/
            #endregion

            #region Encremento e Decremento
            /*int num1 = 10;
            //num1 = num1 + 1;
            //num1++;
            //++num1;
            //num1--;
            //--num1;

            Console.WriteLine(num1--);
            Console.WriteLine(num1);*/
            #endregion

            #region Concatenação
            /*
            string nome = "Arcenio ";
            string sobrenome = "Corteis ";
            string nomeCompleto = nome + sobrenome + 1999;
            Console.WriteLine(nomeCompleto);
            */
            #endregion

            #region Operadores de atribuição;
            //int num1 = 10;

            //num1 = num1 + 20;
            //num1 += 20;
            //num1 -= 2;
            //num1 *= 3;
            //num1 /= 2;
            //num1 %= 2;

            //string nome = "Corteis";
            //nome += " Junior";
            #endregion

            #region Operadores de comparação
            /*
            bool res = 100 == 50 * 2;
            bool res2 = (200 / 2) != (100 + 100);

            string nome = "Corteis";
            bool res3 = nome != "Lucas";*/
            #endregion

            #region Operadores Relacionais
            //bool res = 100 < 50*3;
            //bool res = 100 + 25 > 50*2;
            //bool res = 45 + 25 <= 50*2;
            //bool res = 75 >= 50;
            #endregion

            #region Operadores Logicos
            bool res1 = 100 == 50;
            bool res2 = 60 == 50;

            bool final = res1 && res2;
            bool final2 = res1 || res2;

            Console.WriteLine(final2);
            #endregion
            Console.ReadKey();
        }
    }
}
