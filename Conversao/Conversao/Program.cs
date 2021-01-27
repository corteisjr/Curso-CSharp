using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Conversao Implicita
            /*byte num1 = 100;
            ushort num2;

            float num3 = 1250.45f;
            double num4;
            num4 = num3;

            num2 = num1;*/
            #endregion

            #region Conversao Explicita
            /*
            ushort num1 = 500;
            byte num2 = (byte)num1;

            float num3 = 2500f;
            int num4 = (int)num3;

            char letra = (char)97;
            */
            #endregion

            #region Metodo Parse
            /*
            string txtnumero = "1999";
            int numero = int.Parse(txtnumero);

            byte num1 = byte.Parse("120");

            double num2 = double.Parse("12812,67");

            float num3 = float.Parse("457,75");*/
            #endregion 

            string texto = Convert.ToString(2500);

            double num1 = Convert.ToDouble(false);

            int num2 = Convert.ToInt32('c');

            Console.WriteLine(num2);
            Console.ReadKey();
        }
    }
}
