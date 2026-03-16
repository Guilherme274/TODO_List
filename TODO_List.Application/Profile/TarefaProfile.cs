
using AutoMapper;
using TODO_List.Application.DTOs.Request;
using TODO_List.Application.DTOs.Response;
using TODO_List.Domain.Entities;

namespace TODO_List.Application.Profiles
{
    public class TarefaProfile : Profile
    {
        public TarefaProfile()
        {
            CreateMap<TarefaRequest, Tarefa>();
            CreateMap<Tarefa, TarefaResponse>();
        }
    } 
}