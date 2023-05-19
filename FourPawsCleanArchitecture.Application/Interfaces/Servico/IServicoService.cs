using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Records;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface IServicoService
    {
        public Servico CreateServico(RServicoPrincipal rServicoPrincipal);
        public Servico GetServico(Guid codigo);
        public List<Servico> GetAllServico();
        public Servico UpdateServico(Servico servico);
        public Servico RemoveServico(Servico servico);
    }
}
