using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FourPawsCleanArchitecture.Domain.Entities
{
    [Comment("Tabela referente aos serviços do estabelecimento")]
    public class Servico
    {
        public Servico()
        {
            Codigo = new Guid();
        }

        [Key]
        [Comment("Código do Serviço")]
        public Guid Codigo { get; set; }
        [Comment("Nome do serviço")]
        public string Nome { get; set; }
        [Comment("Status do serviço: A;Ativo;I;Inativo;D;Deletado")]
        public string Status { get; set; }

        public ICollection<Agendamento> Agendamentos { get; set; }
    }
}
