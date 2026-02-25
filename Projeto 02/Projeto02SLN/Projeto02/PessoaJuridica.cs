using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02
{
    internal class PessoaJuridica : Cliente
    {
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }

        public override void ExibirDocumento()
        {
            Console.WriteLine($"CNPJ: {CNPJ}");
        }
    }
}
