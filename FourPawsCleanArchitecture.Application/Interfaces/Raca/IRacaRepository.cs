using FourPawsCleanArchitecture.Domain.Entities;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface IRacaRepository
    {
        public Raca CreateRaca(Raca raca, FileStream file);
        public Raca GetRaca(Guid codigo);
        public List<Raca> GetAllRacas();
        public Raca UpdateRaca(Raca raca);
        public Raca RemoveRaca(Raca raca);
    }
}
