using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Infraestructure.Persistence;

namespace FourPawsCleanArchitecture.Infraestructure.Repositories
{
    public class ServicoRepository : IServicoRepository
    {
        private readonly SqlServeDbContext _db;

        public ServicoRepository(SqlServeDbContext db)
        {
            _db = db;
        }

        public Servico CreateServico(Servico servico)
        {
            _db.Servicos.Add(servico);
            _db.SaveChanges();

            return servico;
        }

        public List<Servico> GetAllServico()
        {
            return _db.Servicos.ToList();
        }

        public Servico GetServico(Guid codigo)
        {
            return _db.Servicos.FirstOrDefault(c => c.Codigo == codigo);
        }

        public Servico RemoveServico(Servico servico)
        {
            _db.Servicos.Remove(servico);
            _db.SaveChanges();

            return servico;
        }

        public Servico UpdateServico(Servico servico)
        {
            _db.Servicos.Update(servico);
            _db.SaveChanges();

            return servico;
        }
    }
}
