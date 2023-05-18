using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FourPawsCleanArchitecture.Domain.Entities
{
    [Comment("Tabela referentes ao usuários do sistema")]
    public class Usuario
    {
        [Key]
        [Comment("Código do usuário")]
        public Guid Codigo { get; set; }

        [Required]
        [Comment("Nome do usuário")]
        public string Nome { get; set; }

        [Required]
        [Comment("Senha do usuário")]
        public string Senha { get; set; }

        [Required]
        [Comment("Tipo do usuário; A = Administrador; C = Cliente")]
        public string Tipo { get; set; }

        [Required]
        [Comment("Status da categoria: A;Ativo;I;Inativo;D;Deletado")]
        public string Status { get; set; }
    }
}
