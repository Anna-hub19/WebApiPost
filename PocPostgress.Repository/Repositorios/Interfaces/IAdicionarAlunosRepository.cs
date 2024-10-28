using PocPostegress.Domain.Domain;


namespace PocPostgress.Repository.Repositorios.Interfaces
{
    public interface IAdicionarAlunosRepository
    {
        public Task<bool> AdicionarAlunosAsync(Aluno aluno);
    }
}
