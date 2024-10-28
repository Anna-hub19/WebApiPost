using PocPostgress.Request;


namespace PocPostgress.Services.Service.Interfaces
{
    public interface IAlunoService
    {
        public Task<bool> AdicionarAlunosAsync(AlunoRequest alunoRequest);

    }
}
