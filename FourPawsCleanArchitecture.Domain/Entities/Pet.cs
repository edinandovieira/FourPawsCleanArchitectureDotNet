using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FourPawsCleanArchitecture.Domain.Entities
{
    [Comment("Tabela referente aos pets dos clientes")]
    public class Pet
    {
        [Key]
        [Comment("Código do pet")]
        public Guid Codigo { get; set; }
        [Comment("Nome do pet")]
        public string Nome { get; set; }
        [Comment("Código da raça")]
        public Guid CodigoRaca { get; set; }
        [Comment("Código do cliente")]
        public Guid CodigoCliente { get; set; }
        [Comment("Idade do pet")]
        public int Idade { get; set; }
        [Comment("Status do pet: A;Ativo;I;Inativo;D;Deletado")]
        public string Status { get; set; }

        [ForeignKey("CodigoRaca")]
        public Raca Racas { get; set; }

        [ForeignKey("CodigoCliente")]
        public Cliente Clientes { get; set; }
    }
}
