
using System.ComponentModel.DataAnnotations.Schema;

namespace TODO_List.Domain.Entities
{
    class Tarefa
    {
        [Column("cd_id", TypeName = "int")]
        public int Id { get; set; }
        [Column("ds_task")]
        public string Descricao { get; set; }
    }    
}