using TODO_List.Domain.Entities;
using AutoMapper;
using TODO_List.Application.DTOs.Security.Request;
using TODO_List.Application.DTOs.Security.Response;

namespace TODO_List.Application.Security.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<RegisterRequest, Usuario>();
            CreateMap<LoginRequest, Usuario>();
            CreateMap<Usuario, LoginResponse>();
        }
    }
}