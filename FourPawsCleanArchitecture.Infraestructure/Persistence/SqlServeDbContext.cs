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
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Feriado> Feriados { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Raca> Racas { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Categoria>()
                .HasKey(e => e.Codigo);

            modelBuilder.Entity<Categoria>()
                .Property(e => e.Status)
                .HasDefaultValueSql("'A'");

            modelBuilder.Entity<Usuario>()
                .HasKey(e => e.Codigo);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Tipo)
                .HasDefaultValueSql("'A'");

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Status)
                .HasDefaultValueSql("'A'");

            //modelBuilder.Entity<Feriado>()
            //    .HasKey(e => e.Codigo);

            modelBuilder.Entity<Feriado>()
                .Property(e => e.Status)
                .HasDefaultValueSql("'A'");

            modelBuilder.Entity<Servico>()
                .Property(e => e.Status)
                .HasDefaultValueSql("'A'");

            modelBuilder.Entity<Raca>()
                .Property(e => e.Status)
                .HasDefaultValueSql("'A'");

            modelBuilder.Entity<Produto>()
                .Property(e => e.Status)
                .HasDefaultValueSql("'A'");
        }
    }
}
