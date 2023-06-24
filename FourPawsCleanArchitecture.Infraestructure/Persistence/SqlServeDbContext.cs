using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

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
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Venda> Vendas { get; set; }

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
                .HasConversion(
                    value => ConvertStatusToStr(value),
                    value => ConvertStatusToDb(value)
                )
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
                .HasConversion(
                    value => ConvertStatusToStr(value),
                    value => ConvertStatusToDb(value)
                )
                .HasDefaultValueSql("'A'");

            modelBuilder.Entity<Produto>()
                .Property(e => e.Status)
                .HasConversion(
                    value => ConvertStatusToStr(value),
                    value => ConvertStatusToDb(value)
                )
                .HasDefaultValueSql("'A'");

            modelBuilder.Entity<Produto>()
                .Property(e => e.Preco)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Pet>()
                .Property(e => e.Status)
                .HasDefaultValueSql("'A'");

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Status)
                .HasDefaultValueSql("'A'");

            modelBuilder.Entity<Venda>()
                .Property(e => e.Status)
                .HasDefaultValueSql("'A'");

            modelBuilder.Entity<Agendamento>()
                .Property(e => e.Status)
                .HasDefaultValueSql("'A'");
        }

        private string ConvertStatusToStr(string value)
        {
            switch (value)
            {
                case "Ativo":
                    return "A";
                case "Inativo":
                    return "I";
                default:
                    throw new NotSupportedException($"Valor inválido: {value}");
            }
        }

        private string ConvertStatusToDb(string value)
        {
            switch (value)
            {
                case "A":
                    return "Ativo";
                case "I":
                    return "Inativo";
                default:
                    throw new NotSupportedException($"Valor inválido: {value}");
            }
        }
    }
}
