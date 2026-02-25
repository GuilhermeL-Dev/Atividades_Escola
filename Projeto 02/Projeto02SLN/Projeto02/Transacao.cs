

public abstract class Transacao
{
    protected decimal _valor;

    public decimal Valor
    {
        get { return _valor; }
        set
        {
            if (value > 0)
                _valor = value;
            else
                Console.WriteLine("Erro: O valor da transação deve ser positivo.");
        }
    }

    public DateTime Data { get; set; } = DateTime.Now;
    public string ContaOrigem { get; set; }
    public string ContaDestino { get; set; }

    public virtual bool Validar()
    {
        return _valor > 0;
    }
}
