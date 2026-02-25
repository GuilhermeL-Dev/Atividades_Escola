public class TransacaoTed : Transacao
{
    public override bool Validar()
    {
        return _valor > 5000;
    }
}