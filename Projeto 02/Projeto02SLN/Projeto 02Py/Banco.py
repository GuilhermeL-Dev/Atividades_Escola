class Banco:
    def __init__(self):
        self._nome = ""
        self._codigo_bacen = ""

    @property
    def nome(self):
        # Retorna o nome sempre em maiúsculas
        return self._nome.upper()

    @nome.setter
    def nome(self, value):
        self._nome = value

    @property
    def codigo_bacen(self):
        return self._codigo_bacen

    @codigo_bacen.setter
    def codigo_bacen(self, value):
        # Valida se não é nulo ou vazio
        if value and value.strip():
            self._codigo_bacen = value
        else:
            print("Erro: O Código BACEN não pode ser vazio.")