using FourPawsCleanArchitecture.Domain.Entities;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface IServicoRepository
    {
        public Servico CreateServico(Servico servico);
        public Servico GetServico(Guid codigo);
        public List<Servico> GetAllServico();
        public Servico UpdateServico(Servico servico);
        public Servico RemoveServico(Servico servico);
    }
}
