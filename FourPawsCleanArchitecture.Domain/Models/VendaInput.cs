namespace FourPawsCleanArchitecture.Domain.Models
{
    public record VendaInput(Guid codigocliente, Guid codigoproduto, decimal preco, int quantidade);
}
