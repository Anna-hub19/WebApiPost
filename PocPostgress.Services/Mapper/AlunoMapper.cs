using PocPostegress.Domain.Domain;
using PocPostgress.Request;

namespace PocPostgress.Services.Mapper
{
    public static class AlunoMapper
    {
        public static Aluno MapAluno(this AlunoRequest alunoRequest)
        {
            return new Aluno
            {
                Nome = alunoRequest.Nome,
                Idade = alunoRequest.Idade
            };
        }
    }
}
