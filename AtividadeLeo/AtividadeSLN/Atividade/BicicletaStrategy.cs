using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    public class BicicletaStrategy : ITransporteStrategy
    {
        public void CalcularTempo() => Console.WriteLine("Tempo de viagem de bicicleta: 3 horas");
    }
}
