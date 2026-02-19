using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto02
{
    internal class Transacao
    {
        public DateTime Data { get; set; }

        public string Tipo { get; set; }

        private decimal _valor;

        public decimal Valor
        {
            get { return _valor; }
            set
            {
                if (value > 0)
                    _valor = value;
                else
                    Console.WriteLine("Erro: O valor da transação deve ser positivo.");
            }
        }
    }
}
