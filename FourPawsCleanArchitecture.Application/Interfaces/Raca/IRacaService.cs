using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Records;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface IRacaService
    {
        public Raca CreateRaca(string nome, string fileName, FileStream file);
        public Raca GetRaca(Guid codigo);
        public List<Raca> GetAllRacas();
        public Raca UpdateRaca(Guid codigo, string nome, string status, string? filename, FileStream? file);
        public Raca RemoveRaca(Guid codigo);
    }
}
