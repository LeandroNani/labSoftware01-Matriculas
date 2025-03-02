using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.src.models
{
    [Table("professor")]
    public class ProfessorModel : PessoaModel
    {
        public required List<DisciplinaModel> Disciplinas { get; set; }
        public required string NivelEscolar { get; set; }

        public ProfessorModel()
            : base() { }
    }
}
