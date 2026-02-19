from banco import Banco
from transacao import Transacao

meu_banco = Banco()
minha_transacao = Transacao()

meu_banco.nome = "banco do brasil"
meu_banco.codigo_bacen = "001"
minha_transacao.valor = 250.00
minha_transacao.tipo = "PIX"

print(f"Banco: {meu_banco.nome}")
print(f"Valor: R$ {minha_transacao.valor}")