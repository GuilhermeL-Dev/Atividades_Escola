using Projeto02;
using System;

class Program
{
    static void Main(string[] args)
    {
        Banco meuBanco = new Banco();

        // Teste da Tarefa 03
        meuBanco.Nome = "banco do brasil";

        // Teste da Tarefa 01
        meuBanco.CodigoBACEN = "";


        Transacao minhaTransacao = new Transacao();

        // Teste da Tarefa 02
        minhaTransacao.Valor = -50.00m;


        //valores corretos para exibição
        meuBanco.CodigoBACEN = "001";
        minhaTransacao.Valor = 250.00m;
        minhaTransacao.Data = DateTime.Now;
        minhaTransacao.Tipo = "PIX";


        Console.WriteLine("--- REGISTRO BACEN ---");
        Console.WriteLine("Banco: " + meuBanco.Nome);
        Console.WriteLine("Código: " + meuBanco.CodigoBACEN);

        Console.WriteLine("-----------------------");

        Console.WriteLine("Tipo: " + minhaTransacao.Tipo);
        Console.WriteLine("Valor: R$ " + minhaTransacao.Valor);
        Console.WriteLine("Data: " + minhaTransacao.Data);

        Console.ReadKey();
    }
}