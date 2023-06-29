using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FourPawsCleanArchitecture.Domain.Entities
{
    [Comment("Tabela referente aos produtos do estabelecimento")]
    public class Produto
    {
        [Key]
        [Comment("Código do produto")]
        public Guid Codigo { get; set; }

        [Comment("Nome do produto")]
        public string Nome { get; set; }

        [Comment("Categoria do produto")]
        public Guid CodigoCategoria { get; set; }

        [Comment("Unidade do produto")]
        public string Unidade { get; set; }

        [Comment("Estoque do produto")]
        public int Estoque { get; set; }

        [Comment("Preço do produto")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        [Comment("Arquivo do produto")]
        public string Arquivo { get; set; }

        [Comment("Status do produto: A;Ativo;I;Inativo;D;Deletado")]
        public string Status { get; set; } = "Ativo";

        [ForeignKey("CodigoCategoria")]
        public Categoria Categorias { get; set; }

        [JsonIgnore]
        public ICollection<Venda> Vendas { get; set; }
    }
}
