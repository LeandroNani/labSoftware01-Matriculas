using Backend.src.models;
using Microsoft.AspNetCore.Mvc;
using Backend.src.services;
using System.Threading.Tasks;
using Backend.src.Data;
using Backend.src.DTOs;
namespace Backend.src.controllers
{
    [ApiController]
    [Route("[controller]")] // Define a rota como /aluno
    public class AlunoController : ControllerBase {
        private readonly AppDbContext _context;
        private readonly AlunoService _alunoService;

        public AlunoController(AppDbContext context) {
            _context = context;
            _alunoService = new AlunoService(_context);
        }

        [HttpPost("adicionar")]
        public async Task<IActionResult> AdicionarAluno(AlunoModel aluno)
        {
            await _alunoService.AdicionarAluno(aluno);
            return Ok(aluno);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest loginRequest)
        {
            return Ok(loginRequest);
        }
    }
}
