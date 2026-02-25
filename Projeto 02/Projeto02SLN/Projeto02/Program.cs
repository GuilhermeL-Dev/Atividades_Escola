using Projeto02;

class Program
{
    static void Main(string[] args)
    {
        Banco meuBanco = new Banco();

        meuBanco.Nome = "banco do brasil";

        meuBanco.CodigoBACEN = "";


        Transacao minhaTransacao = new Transacao();

        minhaTransacao.Valor = -50.00m;

        meuBanco.CodigoBACEN = "001";
        minhaTransacao.Valor = 250.00m;
        minhaTransacao.Data = DateTime.Now;


        Console.WriteLine("--- REGISTRO BACEN ---");
        Console.WriteLine("Banco: " + meuBanco.Nome);
        Console.WriteLine("Código: " + meuBanco.CodigoBACEN + "\n");

        Console.WriteLine("-----------------------\n");

        Console.WriteLine("Valor: R$ " + minhaTransacao.Valor);
        Console.WriteLine("Data: " + minhaTransacao.Data + "\n\n");


        TransacaoPix meuPix = new TransacaoPix();
        meuPix.Valor = 15000;
        meuPix.ChavePix = "contato@emini.com";

        TransacaoTed meuTed = new TransacaoTed();
        meuTed.Valor = 6000;

        Console.WriteLine($"PIX de R$ {meuPix.Valor} é válido? {meuPix.Validar()}");
        Console.WriteLine($"TED de R$ {meuTed.Valor} é válido? {meuTed.Validar()}");

        Console.ReadKey();
    }
}