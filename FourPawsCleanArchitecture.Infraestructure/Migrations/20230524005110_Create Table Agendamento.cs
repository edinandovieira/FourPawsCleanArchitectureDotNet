using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FourPawsCleanArchitecture.Infraestructure.Migrations
{
    public partial class CreateTableAgendamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agendamentos",
                columns: table => new
                {
                    Codigo = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Código do agendamento"),
                    CodigoServico = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Código do serviço"),
                    CodigoPet = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Código do pet"),
                    Data = table.Column<DateTime>(type: "date", nullable: false, comment: "Data do agendamento"),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Preço do serviço agendado na data"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "'A'", comment: "Status do agendamento: A;Ativo;I;Inativo;D;Deletado")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamentos", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Agendamentos_Pets_CodigoPet",
                        column: x => x.CodigoPet,
                        principalTable: "Pets",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendamentos_Servicos_CodigoServico",
                        column: x => x.CodigoServico,
                        principalTable: "Servicos",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Tabela referente aos agendamentos do sistema");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_CodigoPet",
                table: "Agendamentos",
                column: "CodigoPet");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_CodigoServico",
                table: "Agendamentos",
                column: "CodigoServico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamentos");
        }
    }
}
