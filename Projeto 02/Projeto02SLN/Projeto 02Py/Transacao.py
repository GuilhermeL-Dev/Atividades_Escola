from datetime import datetime

class Transacao:
    def __init__(self):
        self._valor = 0.0
        self.data = datetime.now()
        self.tipo = ""

    @property
    def valor(self):
        return self._valor

    @valor.setter
    def valor(self, value):
        # O valor deve ser obrigatoriamente maior que zero
        if value > 0:
            self._valor = value
        else:
            print("Erro: O valor da transação deve ser positivo.")