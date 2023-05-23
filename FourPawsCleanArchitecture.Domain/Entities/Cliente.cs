using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FourPawsCleanArchitecture.Domain.Entities
{
    [Comment("Tabela referente a clientes do sistema")]
    public class Cliente
    {
        [Key]
        [Comment("Código do cliente")]
        public Guid Codigo { get; set; }
        [Comment("Nome do cliente")]
        public string Nome { get; set; }
        [Comment("Identidade do Cliente")]
        public string RG { get; set; }
        [Comment("Cpf do cliente")]
        public string CPF { get; set; }
        [Comment("Endereço do cliente")]
        public string Endereco { get; set; }
        [Comment("E-mail principal do cliente")]
        public string Email { get; set; }
        [Comment("Bairro do cliente")]
        public string Bairro { get; set; }
        [Comment("Telefone do cliente")]
        public string Telefone { get; set; }
        [Comment("Celular do cliente")]
        public string? Celular { get; set; }
        [Comment("Status do cliente: A;Ativo;I;Inativo;D;Deletado")]
        public string Status { get; set; }

        public ICollection<Pet> Pets { get; set; }
    }
}
