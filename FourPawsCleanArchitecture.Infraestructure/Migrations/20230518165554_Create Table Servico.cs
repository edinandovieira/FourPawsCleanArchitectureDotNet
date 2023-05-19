using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FourPawsCleanArchitecture.Infraestructure.Migrations
{
    public partial class CreateTableServico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    Codigo = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Código do Serviço"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Nome do serviço"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "'A'", comment: "Status do serviço: A;Ativo;I;Inativo;D;Deletado")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.Codigo);
                },
                comment: "Tabela referente aos serviços do estabelecimento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Servicos");
        }
    }
}
