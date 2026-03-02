using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02
{
    public class ConversorBilhoes : IConversorGrandeza
    {
        public decimal Converter(decimal valor) => valor / 1000000000m;
        public string ObterSimbolo() => "Bi";
    }
}
