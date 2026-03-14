
using TODO_List.Domain.Entities;

namespace TODO_List.Application.Service
{
    public interface ITokenService
    {
        public string GerarToken(Usuario usuario);
    }
}