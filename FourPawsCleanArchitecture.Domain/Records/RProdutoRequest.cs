using FourPawsCleanArchitecture.Domain.Entities;

namespace FourPawsCleanArchitecture.Domain.Records
{
    public record RProdutoRequest
    (
        string Nome,
        Guid CodigoCategoria,
        string Unidade,
        int Estoque,
        decimal Preco,
        string Arquivo,
        string Status
    );
}
