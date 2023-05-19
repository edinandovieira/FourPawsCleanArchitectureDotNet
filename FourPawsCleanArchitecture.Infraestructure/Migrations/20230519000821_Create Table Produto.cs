using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FourPawsCleanArchitecture.Infraestructure.Migrations
{
    public partial class CreateTableProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Codigo = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Código do produto"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Nome do produto"),
                    CodigoCategoria = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Categoria do produto"),
                    Unidade = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Unidade do produto"),
                    Estoque = table.Column<int>(type: "int", nullable: false, comment: "Estoque do produto"),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Preço do produto"),
                    Arquivo = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Arquivo do produto"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "'A'", comment: "Status do produto: A;Ativo;I;Inativo;D;Deletado")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_CodigoCategoria",
                        column: x => x.CodigoCategoria,
                        principalTable: "Categorias",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Tabela referente aos produtos do estabelecimento");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CodigoCategoria",
                table: "Produtos",
                column: "CodigoCategoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
