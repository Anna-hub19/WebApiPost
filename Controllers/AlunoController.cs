using Microsoft.AspNetCore.Mvc;
using PocPostgress.Request;
using PocPostgress.Services.Service.Interfaces;



namespace PocPostgress.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;
        private readonly ILogger<AlunoController> _logger;

        public AlunoController(ILogger<AlunoController> logger,
            IAlunoService alunoService)
        {
            _logger = logger;
            _alunoService = alunoService;
        }


        [HttpPost(Name = "alunos/adicionar")]
        public IActionResult Adicionar(AlunoRequest alunoRequest)
        {
            try
            {
                _alunoService.AdicionarAlunosAsync(alunoRequest);

                return Ok("Aluno adicionado com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
