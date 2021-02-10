using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Forma
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Altura { get; private set; }
        public int Largura { get; private set; }
        public int Raio { get; private set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando-se para desenhar");
        }

        public virtual void Area()
        {

        }

    }

    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um circulo");
        }

    }


}
