using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FourPawsCleanArchitecture.Domain.Entities
{
    [Comment("Tabela referente as vendas")]
    public class Venda
    {
        [Key]
        [Comment("Código da registro")]
        public Guid Codigo { get; set; }
        [Comment("Código da venda")]
        public Guid CodigoVenda { get; set; }
        [Comment("Código do cliente na venda")]
        public Guid CodigoCliente { get; set; }
        [Comment("Código do produto da venda")]
        public Guid CodigoProduto { get; set; }
        [Comment("Preço do produto na venda")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }
        [Comment("Quantidade do produto na venda")]
        public int Quantidade { get; set; }
        [Comment("Status da venda: A;Ativo;I;Inativo;D;Deletado")]
        public string Status { get; set; } = "A";

        [ForeignKey("CodigoCliente")]
        public Cliente Clientes { get; set; }

        [ForeignKey("CodigoProduto")]
        public  Produto Produtos { get; set; }
    }
}
