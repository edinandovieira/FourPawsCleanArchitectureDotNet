﻿// <auto-generated />
using System;
using FourPawsCleanArchitecture.Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FourPawsCleanArchitecture.Infraestructure.Migrations
{
    [DbContext(typeof(SqlServeDbContext))]
    partial class SqlServeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FourPawsCleanArchitecture.Domain.Entities.Agendamento", b =>
                {
                    b.Property<Guid>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Código do agendamento");

                    b.Property<Guid>("CodigoPet")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Código do pet");

                    b.Property<Guid>("CodigoServico")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Código do serviço");

                    b.Property<DateTime>("Data")
                        .HasColumnType("date")
                        .HasComment("Data do agendamento");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Preço do serviço agendado na data");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("'A'")
                        .HasComment("Status do agendamento: A;Ativo;I;Inativo;D;Deletado");

                    b.HasKey("Codigo");

                    b.HasIndex("CodigoPet");

                    b.HasIndex("CodigoServico");

                    b.ToTable("Agendamentos");

                    b.HasComment("Tabela referente aos agendamentos do sistema");
                });

            modelBuilder.Entity("FourPawsCleanArchitecture.Domain.Entities.Categoria", b =>
                {
                    b.Property<Guid>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Código da categoria");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Nome da categoria");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("'A'")
                        .HasComment("Status da categoria: A;Ativo;I;Inativo;D;Deletado");

                    b.HasKey("Codigo");

                    b.ToTable("Categorias");

                    b.HasComment("Tabela das categoria dos produtos");
                });

            modelBuilder.Entity("FourPawsCleanArchitecture.Domain.Entities.Cliente", b =>
                {
                    b.Property<Guid>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Código do cliente");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Bairro do cliente");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Cpf do cliente");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Celular do cliente");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("E-mail principal do cliente");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Endereço do cliente");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Nome do cliente");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Identidade do Cliente");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("'A'")
                        .HasComment("Status do cliente: A;Ativo;I;Inativo;D;Deletado");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Telefone do cliente");

                    b.HasKey("Codigo");

                    b.ToTable("Clientes");

                    b.HasComment("Tabela referente a clientes do sistema");
                });

            modelBuilder.Entity("FourPawsCleanArchitecture.Domain.Entities.Feriado", b =>
                {
                    b.Property<Guid>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Código do feriado");

                    b.Property<DateTime>("Data")
                        .HasColumnType("date")
                        .HasComment("Data do feriado");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Nome do feriado");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("'A'")
                        .HasComment("Status do feriado: A;Ativo;I;Inativo;D;Deletado");

                    b.HasKey("Codigo");

                    b.ToTable("Feriados");

                    b.HasComment("Tabela de feriados");
                });

            modelBuilder.Entity("FourPawsCleanArchitecture.Domain.Entities.Pet", b =>
                {
                    b.Property<Guid>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Código do pet");

                    b.Property<Guid>("CodigoCliente")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Código do cliente");

                    b.Property<Guid>("CodigoRaca")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Código da raça");

                    b.Property<int>("Idade")
                        .HasColumnType("int")
                        .HasComment("Idade do pet");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Nome do pet");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("'A'")
                        .HasComment("Status do pet: A;Ativo;I;Inativo;D;Deletado");

                    b.HasKey("Codigo");

                    b.HasIndex("CodigoCliente");

                    b.HasIndex("CodigoRaca");

                    b.ToTable("Pets");

                    b.HasComment("Tabela referente aos pets dos clientes");
                });

            modelBuilder.Entity("FourPawsCleanArchitecture.Domain.Entities.Produto", b =>
                {
                    b.Property<Guid>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Código do produto");

                    b.Property<string>("Arquivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Arquivo do produto");

                    b.Property<Guid>("CodigoCategoria")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Categoria do produto");

                    b.Property<int>("Estoque")
                        .HasColumnType("int")
                        .HasComment("Estoque do produto");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Nome do produto");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Preço do produto");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("'A'")
                        .HasComment("Status do produto: A;Ativo;I;Inativo;D;Deletado");

                    b.Property<string>("Unidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Unidade do produto");

                    b.HasKey("Codigo");

                    b.HasIndex("CodigoCategoria");

                    b.ToTable("Produtos");

                    b.HasComment("Tabela referente aos produtos do estabelecimento");
                });

            modelBuilder.Entity("FourPawsCleanArchitecture.Domain.Entities.Raca", b =>
                {
                    b.Property<Guid>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Código do Serviço");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Caminho do arquivo da raça");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Nome do serviço");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("'A'")
                        .HasComment("Status do serviço: A;Ativo;I;Inativo;D;Deletado");

                    b.HasKey("Codigo");

                    b.ToTable("Racas");

                    b.HasComment("Tabela referente aos serviços do estabelecimento");
                });

            modelBuilder.Entity("FourPawsCleanArchitecture.Domain.Entities.Servico", b =>
                {
                    b.Property<Guid>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Código do Serviço");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Nome do serviço");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("'A'")
                        .HasComment("Status do serviço: A;Ativo;I;Inativo;D;Deletado");

                    b.HasKey("Codigo");

                    b.ToTable("Servicos");

                    b.HasComment("Tabela referente aos serviços do estabelecimento");
                });

            modelBuilder.Entity("FourPawsCleanArchitecture.Domain.Entities.Usuario", b =>
                {
                    b.Property<Guid>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Código do usuário");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Nome do usuário");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Senha do usuário");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("'A'")
                        .HasComment("Status da categoria: A;Ativo;I;Inativo;D;Deletado");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("'A'")
                        .HasComment("Tipo do usuário; A = Administrador; C = Cliente");

                    b.HasKey("Codigo");

                    b.ToTable("Usuarios");

                    b.HasComment("Tabela referentes ao usuários do sistema");
                });

            modelBuilder.Entity("FourPawsCleanArchitecture.Domain.Entities.Venda", b =>
                {
                    b.Property<Guid>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Código da venda");

                    b.Property<Guid>("CodigoCliente")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Código do cliente na venda");

                    b.Property<Guid>("CodigoProduto")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Código do produto da venda");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Preço do produto na venda");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int")
                        .HasComment("Quantidade do produto na venda");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("'A'")
                        .HasComment("Status da venda: A;Ativo;I;Inativo;D;Deletado");

                    b.HasKey("Codigo");

                    b.HasIndex("CodigoCliente");

                    b.HasIndex("CodigoProduto");

                    b.ToTable("Vendas");

                    b.HasComment("Tabela referente as vendas");
                });

            modelBuilder.Entity("FourPawsCleanArchitecture.Domain.Entities.Agendamento", b =>
                {
                    b.HasOne("FourPawsCleanArchitecture.Domain.Entities.Pet", "Pets")
                        .WithMany("Agendamentos")
                        .HasForeignKey("CodigoPet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FourPawsCleanArchitecture.Domain.Entities.Servico", "Servicos")
                        .WithMany("Agendamentos")
                        .HasForeignKey("CodigoServico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pets");

                    b.Navigation("Servicos");
                });

            modelBuilder.Entity("FourPawsCleanArchitecture.Domain.Entities.Pet", b =>
                {
                    b.HasOne("FourPawsCleanArchitecture.Domain.Entities.Cliente", "Clientes")
                        .WithMany("Pets")
                        .HasForeignKey("CodigoCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FourPawsCleanArchitecture.Domain.Entities.Raca", "Racas")
                        .WithMany()
                        .HasForeignKey("CodigoRaca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clientes");

                    b.Navigation("Racas");
                });

            modelBuilder.Entity("FourPawsCleanArchitecture.Domain.Entities.Produto", b =>
                {
                    b.HasOne("FourPawsCleanArchitecture.Domain.Entities.Categoria", "Categorias")
                        .WithMany("Produtos")
                        .HasForeignKey("CodigoCategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorias");
                });

            modelBuilder.Entity("FourPawsCleanArchitecture.Domain.Entities.Venda", b =>
                {
                    b.HasOne("FourPawsCleanArchitecture.Domain.Entities.Cliente", "Clientes")
                        .WithMany()
                        .HasForeignKey("CodigoCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FourPawsCleanArchitecture.Domain.Entities.Produto", "Produtos")
                        .WithMany()
                        .HasForeignKey("CodigoProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clientes");

                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("FourPawsCleanArchitecture.Domain.Entities.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("FourPawsCleanArchitecture.Domain.Entities.Cliente", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("FourPawsCleanArchitecture.Domain.Entities.Pet", b =>
                {
                    b.Navigation("Agendamentos");
                });

            modelBuilder.Entity("FourPawsCleanArchitecture.Domain.Entities.Servico", b =>
                {
                    b.Navigation("Agendamentos");
                });
#pragma warning restore 612, 618
        }
    }
}
