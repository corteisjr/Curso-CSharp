using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    class Conta
    {
        public string _cliente;
        public double _saldo;
        private double _taxa = 10;

        public string Cliente
        {
            get { return _cliente; }
            set
            {
                if (value != "Arcenio" && value != "Corteis")
                {
                    _cliente = "Visitante";
                    Saldo = 0;
                }
                else
                {
                    _cliente = value;
                    Saldo = 100;
                }
            }

        }

        public double Saldo
        {
            get
            {
                return _saldo;

            }
            private set
            {
                _saldo = value;
                
            }
        }

        public void Sacar(double valor)
        {
            valor += _taxa; //Encapsulamento, facilita manutenção do código
            _saldo -= valor;
        }
        
        public void Depositar(double valor)
        {
            _saldo += valor;
        }
    }
}
