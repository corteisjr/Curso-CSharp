using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    class Teste
    {
        private string nome; // PArticular das classe
        public string sobreNome; // Para todas as classes

        private void Metodo1() { }

        public void Executar() { }
    }

    class Humano
    {
       protected string nome;
       private string sobreNome;
       internal int idade; // somente eh visivel dentro do projecto!!
    }

    class Homem : Humano
    {
        public void Metodo()
        {
            nome = "";
            idade = 0;
        }
    }
}
