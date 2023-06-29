namespace FourPawsCleanArchitecture.Domain.Models
{
    public record ClientInput(string nome, string rg, string cpf, string endereco, string email, string bairro, string telefone, string? celular = null);
}
