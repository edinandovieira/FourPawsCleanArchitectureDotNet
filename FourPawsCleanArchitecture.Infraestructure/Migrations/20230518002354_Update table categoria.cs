using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FourPawsCleanArchitecture.Infraestructure.Migrations
{
    public partial class Updatetablecategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Categorias",
                comment: "Tabela das categoria dos produtos");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Categorias",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Nome da categoria",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Codigo",
                table: "Categorias",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Código da categoria",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Categorias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValueSql: "'A'",
                comment: "Status da categoria: A;Ativo;I;Inativo;D;Deletado");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Categorias");

            migrationBuilder.AlterTable(
                name: "Categorias",
                oldComment: "Tabela das categoria dos produtos");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Categorias",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Nome da categoria");

            migrationBuilder.AlterColumn<Guid>(
                name: "Codigo",
                table: "Categorias",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Código da categoria");
        }
    }
}
