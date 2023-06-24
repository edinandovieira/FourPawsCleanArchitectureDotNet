using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FourPawsCleanArchitecture.Domain.Entities
{
    [Comment("Tabela referente aos serviços do estabelecimento")]
    public class Raca
    {
        [Key]
        [Comment("Código do Serviço")]
        public Guid Codigo { get; set; }
        [Comment("Nome do serviço")]
        public string Nome { get; set; }
        [Comment("Caminho do arquivo da raça")]
        public string Avatar { get; set; }
        [Comment("Status do serviço: A;Ativo;I;Inativo;D;Deletado")]
        public string Status { get; set; } = "Ativo";
    }
}
