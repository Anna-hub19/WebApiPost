using PocPostegress.Domain.Domain;
using PocPostgress.Excecoes.Exececoes.Aluno;
using PocPostgress.Services.Services.Domain.Interfaces;

namespace PocPostgress.Services.Services.Domain
{
    public class AlunoDomainService : IAlunoDomainService
    {
        public AlunoDomainService()
        {
        }


        public void ValidarRegras(Aluno aluno)
        {
            if (!aluno.MaiorDeDezeseisAnos())
            {
                throw new AlunoIdadeInvalidaException("Aluno com idade minima não permitida");
            }
        }
    }
}
