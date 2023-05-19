using Microsoft.VisualBasic;

namespace FourPawsCleanArchitecture.Domain.Records
{
    public record RUpdateFeriado
    (
        string Nome,
        DateTime Data,
        string Status
    );
}
