using PocPostgress.Repository.Repositorios.Interfaces;
using PocPostgress.Request;
using PocPostgress.Services.Mapper;
using PocPostgress.Services.Service.Interfaces;
using PocPostgress.Services.Services.Domain.Interfaces;

namespace PocPostgress.Services.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoDomainService _alunoDomainService;
        private readonly IAdicionarAlunosRepository _adicionarAlunosRepository;

        public AlunoService(IAlunoDomainService alunoDomainService, 
            IAdicionarAlunosRepository adicionarAlunosRepository)
        {
            _alunoDomainService = alunoDomainService;
            _adicionarAlunosRepository = adicionarAlunosRepository;
        }

        public Task<bool> AdicionarAlunosAsync(AlunoRequest alunoRequest)
        {
            try
            {
                var aluno = alunoRequest.MapAluno();

                _alunoDomainService.ValidarRegras(aluno);

                return _adicionarAlunosRepository.AdicionarAlunosAsync(aluno);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
