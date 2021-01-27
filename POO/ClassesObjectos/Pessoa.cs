using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjectos
{
    class Pessoa
    {
        //Atributos ou Campos
        public string nome;
        public string sobrenome;
        public int anoNascimento;

        //Metodos simples
        public void Cumprimentar()
        {
            Console.WriteLine("Ola eu sou " + nome + " " + sobrenome);
        }
    }
}
