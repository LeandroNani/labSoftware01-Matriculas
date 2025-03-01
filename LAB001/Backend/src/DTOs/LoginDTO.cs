using System.ComponentModel.DataAnnotations;

namespace Backend.src.DTOs
{
    public class LoginRequest
    {
        [Required]
        public required int NumeroDePessoa { get; set; }

        [Required]
        public required string Senha { get; set; }
    }
}
