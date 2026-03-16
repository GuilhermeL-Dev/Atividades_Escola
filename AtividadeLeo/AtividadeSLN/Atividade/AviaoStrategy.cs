using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    public class AviaoStrategy : ITransporteStrategy
    {
        public void CalcularTempo() => Console.WriteLine("Tempo de viagem de avião: 30 min");
    }
}
