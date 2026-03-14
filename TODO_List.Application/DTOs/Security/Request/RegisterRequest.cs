
using System.ComponentModel.DataAnnotations;

namespace TODO_List.Application.DTOs.Security.Request
{
    public record RegisterRequest
    (
        [Required] string Nome, 
        [Required] string Username,
        [Required] DateTime DataNascimento,
        [Required] [DataType(DataType.Password)] string Senha,
        [Required] [property:Compare("Senha")] string ConfirmarSenha
    );
    
}