using FourPawsCleanArchitecture.Domain.Converts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FourPawsCleanArchitecture.Domain.Entities
{
    [Comment("Tabela referente aos agendamentos do sistema")]
    public class Agendamento
    {
        [Key]
        [Comment("Código do agendamento")]
        public Guid Codigo { get; set; }
        [Comment("Código do serviço")]
        public Guid CodigoServico { get; set; }
        [Comment("Código do cliente na data do agendamento")]
        public Guid CodigoCliente { get; set; }
        [Comment("Código do pet")]
        public Guid CodigoPet { get; set; }
        [Comment("Data do agendamento")]
        [Column(TypeName = "date")]
        [JsonConverter(typeof(DateOnlyConverter))]
        public DateTime Data { get; set; }
        [Comment("Preço do serviço agendado na data")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }
        [Comment("Status do agendamento: A;Ativo;I;Inativo;D;Deletado")]
        public string Status { get; set; }

        [ForeignKey("CodigoServico")]
        public Servico Servicos { get; set; }

        [ForeignKey("CodigoCliente")]
        public Cliente Clientes { get; set; }

        [ForeignKey("CodigoPet")]
        public Pet Pets { get; set; }
    }
}
