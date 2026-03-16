using Atividade;

internal class Program
{
    private static void Main(string[] args)
    {
        var calculadora = new CalculadoraViagem();

        calculadora.DefinirEstrategia(new BicicletaStrategy());
        calculadora.Calcular();

        calculadora.DefinirEstrategia(new CarroStrategy());
        calculadora.Calcular();

        calculadora.DefinirEstrategia(new AviaoStrategy());
        calculadora.Calcular();
    }
}