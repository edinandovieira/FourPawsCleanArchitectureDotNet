using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FourPawsCleanArchitecture.Infraestructure.Migrations
{
    public partial class UpdateVendaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Codigo",
                table: "Vendas",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Código da registro",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Código da venda");

            migrationBuilder.AddColumn<Guid>(
                name: "CodigoVenda",
                table: "Vendas",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                comment: "Código da venda");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoVenda",
                table: "Vendas");

            migrationBuilder.AlterColumn<Guid>(
                name: "Codigo",
                table: "Vendas",
                type: "uniqueidentifier",
                nullable: false,
                comment: "Código da venda",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "Código da registro");
        }
    }
}
