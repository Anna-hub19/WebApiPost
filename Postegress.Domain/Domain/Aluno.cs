namespace PocPostegress.Domain.Domain
{
    public class Aluno
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; } 

        public bool MaiorDeDezeseisAnos()
        {
            var VerificarIdade = Idade;
            if (VerificarIdade >= 16)
            {
                return true;
            } 
            else 
            {
                return false; 
            }
        }

    }
}
