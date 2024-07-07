//Uma classe que não pode ser herdada. usada em classe aonde temos métodos e propriedades
//muito sensiveis, aonde não poder sofrer modificação.
sealed class Aluno
{
    public string Nome { get; set; }
}

class Pessoa// : Aluno
{
    //Herdar de Aluno Resultaria em erro de compilação
}
