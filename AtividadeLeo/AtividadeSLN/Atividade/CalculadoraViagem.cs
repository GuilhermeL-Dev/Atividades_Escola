using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class CalculadoraViagem
    {
        private ITransporteStrategy _transporteStrategy;

        public void DefinirEstrategia(ITransporteStrategy transporteStrategy)
        {
            _transporteStrategy = transporteStrategy;
        }

        public void Calcular()
        {
            if (_transporteStrategy != null)
            {
                Console.WriteLine("Por favor, selecione um transporte primeiro.");
                return;
            }
            _transporteStrategy.CalcularTempo();
        }
    }
}
