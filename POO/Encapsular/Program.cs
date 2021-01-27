using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            c.Cliente = "Arcenio";
            //c.Saldo = 100;

            //====== Operação de Deposito =========

            double valor = 100;
            c.Depositar(valor);

            //======== Operação de Saque «««««++++++++

            double valor2 = 50;
            c.Sacar(valor2);

            //============ Resultado Saldo ==========
            Console.WriteLine("Cliente: " + c._cliente);
            Console.WriteLine("Saldo: " + c.Saldo);

            Console.ReadKey();


        }
    }
}
