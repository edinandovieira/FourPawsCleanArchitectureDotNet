namespace FourPawsCleanArchitecture.Domain.Models
{
    public class ProductInput
    {
        public string nome { get; set;}

        public Guid codigoCategoria { get; set; }
        public string unidade { get; set; }
        public int estoque { get; set; }
        public decimal preco { get; set; }

    }
}
