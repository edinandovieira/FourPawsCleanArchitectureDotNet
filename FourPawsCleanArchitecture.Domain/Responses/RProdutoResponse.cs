namespace FourPawsCleanArchitecture.Domain.Responses
{
    public record RProdutoResponse(Guid codigo, string nome, Guid codigoCategoria, string unidade, int estoque, decimal preco, string arquivo, string status);
}
