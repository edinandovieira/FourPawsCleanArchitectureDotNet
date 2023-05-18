using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Infraestructure.Persistence;

namespace FourPawsCleanArchitecture.Infraestructure.Repositories
{
    public class FeriadoRepository : IFeriadoRepository
    {
        private readonly SqlServeDbContext _db;

        public FeriadoRepository(SqlServeDbContext db)
        {
            _db = db;
        }

        public Feriado CreateHolyday(Feriado feriado)
        {
            _db.Feriados.Add(feriado);
            _db.SaveChanges();

            return feriado;
        }

        public List<Feriado> GetAllHolyday()
        {
            return _db.Feriados.ToList();
        }

        public Feriado GetHolyday(Guid codigo)
        {
            return _db.Feriados.FirstOrDefault(c => c.Codigo == codigo);
        }

        public Feriado RemoveHolyday(Feriado feriado)
        {
            _db.Feriados.Remove(feriado);

            return feriado;
        }

        public Feriado UpdateHolyday(Feriado feriado)
        {
            _db.Feriados.Update(feriado);

            return feriado;
        }
    }
}
