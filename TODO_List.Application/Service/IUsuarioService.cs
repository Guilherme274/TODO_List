
using TODO_List.Application.DTOs.Security.Request;
using TODO_List.Application.DTOs.Security.Response;

namespace TODO_List.Application.Service
{
    public interface IUsuarioService
    {
        public Task<string> RegistrarUsuario(RegisterRequest request);
        public Task<LoginResponse> LogarUsuario(LoginRequest request);
    }
}