using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FourPawsCleanArchitecture.Infraestructure.Persistence
{
    public class SqlServeDbContext : DbContext, ISqlServeDbContext
    {
        public SqlServeDbContext(DbContextOptions<SqlServeDbContext> options)
            : base(options) 
        { 
        }
        public DbSet<Categoria> Categorias { get; set; }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Categoria>()
                .HasKey(e => e.Codigo);
        }
    }
}
