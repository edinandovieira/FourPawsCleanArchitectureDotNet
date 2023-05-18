using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FourPawsCleanArchitecture.Domain.Entities
{
    [Comment("Tabela de feriados")]
    public class Feriado
    {
        [Key]
        [Comment("Código do feriado")]
        public Guid Codigo { get; set; }

        [Comment("Nome do feriado")]
        public string Nome { get; set; }

        [Comment("Data do feriado")]
        public DateTime Data { get; set;}

        [Comment("Status do feriado: A;Ativo;I;Inativo;D;Deletado")]
        public string Status { get; set; }
    }
}
