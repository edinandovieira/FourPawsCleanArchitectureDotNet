namespace FourPawsCleanArchitecture.Application.DTOs
{
    public class ProdutoDTO
    {
        public Guid Codigo { get; set; }
        public string Nome { get; set; }
        public Guid CodigoCategoria { get; set; }
        public string Unidade { get; set; }
        public int Estoque { get; set; }
        public decimal Preco { get; set; }
        public string Arquivo { get; set; }
        public string Status { get; set; }
    }
}
