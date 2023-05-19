using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FourPawsCleanArchitecture.Domain.Entities
{
    [Comment("Tabela das categoria dos produtos")]
    public class Categoria
    {
        [Key]
        [Comment("Código da categoria")]
        public Guid Codigo { get; set; }

        [Required]
        [Comment("Nome da categoria")]
        public string Nome { get; set; }

        [Required]
        [Comment("Status da categoria: A;Ativo;I;Inativo;D;Deletado")]
        public string Status { get; set; }

        public ICollection<Produto> Produtos { get; set; }
    }
}
