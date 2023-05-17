using System.ComponentModel.DataAnnotations;

namespace FourPawsCleanArchitecture.Domain.Entities
{
    public class Categoria
    {
        public Guid Codigo { get; set; }

        public string Nome { get; set; }
    }
}
