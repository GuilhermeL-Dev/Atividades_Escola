using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02
{
    public abstract class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }

        public abstract void ExibirDocumento();
    }
}
