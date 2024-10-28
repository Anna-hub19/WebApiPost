namespace PocPostgress.Excecoes.Exececoes.Aluno
{
    public class AlunoIdadeInvalidaException: Exception
    {
        public AlunoIdadeInvalidaException() { }

        public AlunoIdadeInvalidaException(string message) : base(message) { }  
    }
}
