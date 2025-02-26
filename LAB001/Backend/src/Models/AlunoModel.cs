using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.src.models
{
    [Table("aluno")]
    public class AlunoModel : PessoaModel
    {
        public CursoModel? Curso { get; set; }
        public required string Matricula { get; set; }
        public List<DisciplinaModel>? DisciplinasCursadas { get; set; }
        public List<DisciplinaModel>? PlanoDeEnsino { get; set; } // Disciplinas que o aluno está cursando atualmente
        public required string Email { get; set; }
        public required int Mensalidade { get; set; }

        public AlunoModel()
            : base() { }
    }
}
