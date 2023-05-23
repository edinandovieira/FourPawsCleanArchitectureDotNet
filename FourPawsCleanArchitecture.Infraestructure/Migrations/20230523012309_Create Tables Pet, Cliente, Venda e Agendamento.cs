using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FourPawsCleanArchitecture.Infraestructure.Migrations
{
    public partial class CreateTablesPetClienteVendaeAgendamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Codigo = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Código do cliente"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Nome do cliente"),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Identidade do Cliente"),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Cpf do cliente"),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Endereço do cliente"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "E-mail principal do cliente"),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Bairro do cliente"),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Telefone do cliente"),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Celular do cliente"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "'A'", comment: "Status do cliente: A;Ativo;I;Inativo;D;Deletado")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Codigo);
                },
                comment: "Tabela referente a clientes do sistema");

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Codigo = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Código do pet"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Nome do pet"),
                    CodigoRaca = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Código da raça"),
                    CodigoCliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Código do cliente"),
                    Idade = table.Column<int>(type: "int", nullable: false, comment: "Idade do pet"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "'A'", comment: "Status do pet: A;Ativo;I;Inativo;D;Deletado")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Pets_Clientes_CodigoCliente",
                        column: x => x.CodigoCliente,
                        principalTable: "Clientes",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pets_Racas_CodigoRaca",
                        column: x => x.CodigoRaca,
                        principalTable: "Racas",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Tabela referente aos pets dos clientes");

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    Codigo = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Código da venda"),
                    CodigoCliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Código do cliente na venda"),
                    CodigoProduto = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Código do produto da venda"),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Preço do produto na venda"),
                    Quantidade = table.Column<int>(type: "int", nullable: false, comment: "Quantidade do produto na venda"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "'A'", comment: "Status da venda: A;Ativo;I;Inativo;D;Deletado")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Vendas_Clientes_CodigoCliente",
                        column: x => x.CodigoCliente,
                        principalTable: "Clientes",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vendas_Produtos_CodigoProduto",
                        column: x => x.CodigoProduto,
                        principalTable: "Produtos",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Tabela referente as vendas");

            migrationBuilder.CreateTable(
                name: "Agendamentos",
                columns: table => new
                {
                    Codigo = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Código do agendamento"),
                    CodigoServico = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Código do serviço"),
                    CodigoCliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Código do cliente na data do agendamento"),
                    CodigoPet = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Código do pet"),
                    Data = table.Column<DateTime>(type: "date", nullable: false, comment: "Data do agendamento"),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Preço do serviço agendado na data"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "'A'", comment: "Status do agendamento: A;Ativo;I;Inativo;D;Deletado")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamentos", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Agendamentos_Clientes_CodigoCliente",
                        column: x => x.CodigoCliente,
                        principalTable: "Clientes",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_Agendamentos_CodigoCliente",
                table: "Agendamentos",
                column: "CodigoCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_CodigoPet",
                table: "Agendamentos",
                column: "CodigoPet");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_CodigoServico",
                table: "Agendamentos",
                column: "CodigoServico");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_CodigoCliente",
                table: "Pets",
                column: "CodigoCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_CodigoRaca",
                table: "Pets",
                column: "CodigoRaca");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_CodigoCliente",
                table: "Vendas",
                column: "CodigoCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_CodigoProduto",
                table: "Vendas",
                column: "CodigoProduto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamentos");

            migrationBuilder.DropTable(
                name: "Vendas");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
