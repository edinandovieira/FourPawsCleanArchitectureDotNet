using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Records;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface IRacaService
    {
        public Raca CreateRaca(string nome, string fileName, FileStream file);
        public Raca GetRaca(Guid codigo);
        public List<Raca> GetAllRacas();
        public Raca UpdateRaca(Guid codigo, RRacaRequest rRacaRequest);
        public Raca RemoveRaca(Raca raca);
    }
}
