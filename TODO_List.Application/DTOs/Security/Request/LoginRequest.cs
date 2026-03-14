
using System.ComponentModel.DataAnnotations;

namespace TODO_List.Application.DTOs.Security.Request
{
    public record LoginRequest
    (
        [Required] string Email,
        [Required] [DataType(DataType.Password)] string Senha
    );
}