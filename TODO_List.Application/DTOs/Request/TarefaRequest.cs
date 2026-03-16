using System.ComponentModel.DataAnnotations;

namespace TODO_List.Application.DTOs.Request
{
    public record TarefaRequest([Required] string Descricao);
}