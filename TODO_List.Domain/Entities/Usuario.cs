
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace TODO_List.Domain.Entities
{
    public class Usuario : IdentityUser
    {
        [Column("nm_usuario", TypeName = "varchar(60)")]
        public string Nome { get; set; }
        [Column("dt_nascimento", TypeName = "date")]
        public string DataNascimento { get; set; }
    }
}