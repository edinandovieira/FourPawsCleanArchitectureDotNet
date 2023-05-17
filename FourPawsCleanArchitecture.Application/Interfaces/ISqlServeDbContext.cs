using FourPawsCleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface ISqlServeDbContext
    {
        DbSet<Categoria> Categorias { get; set; }
        Task<int> SaveChangesAsync();
    }
}
