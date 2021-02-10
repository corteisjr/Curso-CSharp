using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    //Sealed não pode ser herdada!
    sealed class Bicicleta : Veiculo //Quer dizer que vai herdar de outra classe
    {
        public void Pedalar()
        {
            
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerou a bicicleta");
        }

        public override void Parar()
        {
            Console.WriteLine("Parou a bicicleta");
        }
    }
}
