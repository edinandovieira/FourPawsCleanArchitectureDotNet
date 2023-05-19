using FourPawsCleanArchitecture.Domain.Converts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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

        [Column(TypeName = "date")]
        [Comment("Data do feriado")]
        [JsonConverter(typeof(DateOnlyConverter))]
        public DateTime Data { get; set; }

        [Comment("Status do feriado: A;Ativo;I;Inativo;D;Deletado")]
        public string Status { get; set; }
    }
}
