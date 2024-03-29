﻿// <auto-generated />
using System;
using FourPawsCleanArchitecture.Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FourPawsCleanArchitecture.Infraestructure.Migrations
{
    [DbContext(typeof(SqlServeDbContext))]
    [Migration("20230518165554_Create Table Servico")]
    partial class CreateTableServico
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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
#pragma warning restore 612, 618
        }
    }
}
