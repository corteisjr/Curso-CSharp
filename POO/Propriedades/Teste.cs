using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    class Teste
    {
        // Definição de um campo

        private  string _nome;
        public string sobrenome { get; } = "Corteis"; //Quando nao trabalha com nenhum campo


        private  int _idade;

        // Definição de uma propriedade
        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }

        }


        public int Idade
        {
            get
            {
                return _idade;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Idade não pode ser maior que 18 anos");
                }
                else
                {
                    _idade = value;
                }
            }

        }
        public void Apresentar()
        {
            if (_nome != "")
            {

            }
        }
    }
}
