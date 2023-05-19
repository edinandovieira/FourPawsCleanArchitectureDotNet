using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Infraestructure.Persistence;

namespace FourPawsCleanArchitecture.Infraestructure.Repositories
{
    public class RacaRepository : IRacaRepository
    {
        private readonly SqlServeDbContext _db;

        public RacaRepository(SqlServeDbContext db)
        {
            _db = db;
        }

        public Raca CreateRaca(Raca raca)
        {
            _db.Racas.Add(raca);
            _db.SaveChanges();
            return raca;
        }

        public List<Raca> GetAllRacas()
        {
            return _db.Racas.ToList();
        }

        public Raca GetRaca(Guid codigo)
        {
            return _db.Racas.FirstOrDefault(c => c.Codigo == codigo);
        }

        public Raca RemoveRaca(Raca raca)
        {
            _db.Racas.Remove(raca);
            _db.SaveChanges();
            return raca;
        }

        public Raca UpdateRaca(Raca raca)
        {
            _db.Racas.Update(raca);
            _db.SaveChanges();
            return raca;
        }
    }
}
