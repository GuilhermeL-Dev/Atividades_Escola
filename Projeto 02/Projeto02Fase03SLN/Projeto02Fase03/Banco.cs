using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto02
{
    internal class Banco
    {
        private string _nome;
        public string Nome
        {
            get { return _nome.ToUpper(); }
            set { _nome = value; }
        }


        private string _codigoBACEN;
        public string CodigoBACEN
        {
            get { return _codigoBACEN; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _codigoBACEN = value;
                else
                    Console.WriteLine("Erro: O Código BACEN não pode ser vazio.");
            }
        }
    }
}