namespace FourPawsCleanArchitecture.Domain.Models
{
    public record UserResponse
    (
        Guid Codigo,
        string Nome,
        string Tipo,
        string Status
    );
}
