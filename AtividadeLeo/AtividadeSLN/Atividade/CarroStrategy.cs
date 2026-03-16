using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    public class CarroStrategy : ITransporteStrategy
    {
        public void CalcularTempo() => Console.WriteLine("Tempo de viagem de carro: 1 horas");
    }
}
