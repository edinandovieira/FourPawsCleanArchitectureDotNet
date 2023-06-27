using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Infraestructure.Persistence;

namespace FourPawsCleanArchitecture.Infraestructure.Repositories
{
    public class ClientRepository : IClienteRepository
    {
        private readonly SqlServeDbContext _db;

        public ClientRepository(SqlServeDbContext db)
        {
            _db = db;
        }

        public Cliente CreateClient(Cliente cliente)
        {
            _db.Clientes.Add(cliente);
            _db.SaveChanges();

            return cliente;
        }

        public List<Cliente> GetAllClient()
        {
            return _db.Clientes
                .OrderBy(x => x.Nome)
                .ToList();
        }

        public Cliente GetClient(Guid codigo)
        {
            return _db.Clientes.FirstOrDefault(x => x.Codigo == codigo);
        }

        public Cliente RemoveClient(Cliente cliente)
        {
            _db.Clientes.Remove(cliente);
            _db.SaveChanges();

            return cliente;
        }

        public Cliente UpdateClient(Cliente cliente)
        {
            _db.Clientes.Update(cliente);
            _db.SaveChanges();

            return cliente;
        }
    }
}
