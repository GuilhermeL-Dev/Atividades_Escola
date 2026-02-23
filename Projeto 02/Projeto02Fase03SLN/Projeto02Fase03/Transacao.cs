public class Transacao
{
    protected decimal _valor;

    public decimal Valor
    {
        get { return _valor; }
        set { if (value > 0) _valor = value; }
    }

    public DateTime Data { get; set; } = DateTime.Now;
    public string ContaOrigem { get; set; }
    public string ContaDestino { get; set; }

    public virtual bool Validar()
    {
        return _valor > 0;
    }
}
