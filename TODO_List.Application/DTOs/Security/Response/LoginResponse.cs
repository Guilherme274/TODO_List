
namespace TODO_List.Application.DTOs.Security.Response
{
    public record LoginResponse
    (
        string Id,
        string Nome,
        string UserName,
        string Email,
        DateTime DataNascimento,
        string Token        
    );
}