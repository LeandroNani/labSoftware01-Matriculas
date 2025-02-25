using Backend.src.models;
using Backend.src.services.interfaces;
using Backend.src.Data;
using Backend.src.DTOs;
using Backend.src.Middleware.Exceptions;

namespace Backend.src.services
{
    public class AlunoService(AppDbContext context) : IAlunoService
    {
        private readonly AppDbContext _context = context;

        // TODO: Tratamento de possivel `NumeroDePessoa` existente na base de dados
        public async Task AdicionarAluno(AlunoModel aluno)
        {
            await _context.Alunos.AddAsync(aluno);
            await _context.SaveChangesAsync(); 
        }

        public async Task AtualizarAluno(string id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            if (aluno != null)
            {
                _context.Alunos.Update(aluno);
            }
            else
            {
                throw new NotFoundException($"Aluno com id {id} não encontrado");
            }
        }

        public Task CancelarMatricula()
        {
            throw new NotImplementedException();
        }

        public Task EfetuarMatricula()
        {
            throw new NotImplementedException();
        }

        public List<AlunoModel> ListarAlunos()
        {
            throw new NotImplementedException();
        }

        public async Task<AlunoModel> Login(LoginRequest loginRequest)
        {
            AlunoModel? aluno = await _context.Alunos.FindAsync(loginRequest.NumeroDePessoa);
            return aluno ?? throw new NotFoundException($"Aluno com Numero de Pessoa {loginRequest.NumeroDePessoa} não encontrado");
        }

        public Task RemoverAluno()
        {
            throw new NotImplementedException();
        }
    }
}