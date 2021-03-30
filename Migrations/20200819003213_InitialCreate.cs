using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace carteiraAcoes.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "acao",
                columns: table => new
                {
                    AcaoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    Codigo = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_acao", x => x.AcaoId);
                });

            migrationBuilder.CreateTable(
                name: "opcao",
                columns: table => new
                {
                    OpcaoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    ValorStrike = table.Column<decimal>(nullable: false),
                    AcaoId = table.Column<int>(nullable: false),
                    SerieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_opcao", x => x.OpcaoId);
                });

            migrationBuilder.CreateTable(
                name: "serie",
                columns: table => new
                {
                    SerieId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    Mes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serie", x => x.SerieId);
                });

            migrationBuilder.CreateTable(
                name: "movimentoAcao",
                columns: table => new
                {
                    MovimentoAcaoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantidade = table.Column<int>(nullable: false),
                    DataCompra = table.Column<DateTime>(nullable: false),
                    DataVenda = table.Column<DateTime>(nullable: true),
                    ValorCompra = table.Column<decimal>(nullable: false),
                    ValorVenda = table.Column<decimal>(nullable: false),
                    AcaoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movimentoAcao", x => x.MovimentoAcaoId);
                    table.ForeignKey(
                        name: "FK_movimentoAcao_acao_AcaoId",
                        column: x => x.AcaoId,
                        principalTable: "acao",
                        principalColumn: "AcaoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "movimentoOpcao",
                columns: table => new
                {
                    MovimentoOpcaoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantidade = table.Column<int>(nullable: false),
                    ValorPremio = table.Column<decimal>(nullable: false),
                    DataVencimento = table.Column<DateTime>(nullable: true),
                    DataVenda = table.Column<DateTime>(nullable: false),
                    OpcaoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movimentoOpcao", x => x.MovimentoOpcaoId);
                    table.ForeignKey(
                        name: "FK_movimentoOpcao_opcao_OpcaoId",
                        column: x => x.OpcaoId,
                        principalTable: "opcao",
                        principalColumn: "OpcaoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_movimentoAcao_AcaoId",
                table: "movimentoAcao",
                column: "AcaoId");

            migrationBuilder.CreateIndex(
                name: "IX_movimentoOpcao_OpcaoId",
                table: "movimentoOpcao",
                column: "OpcaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movimentoAcao");

            migrationBuilder.DropTable(
                name: "movimentoOpcao");

            migrationBuilder.DropTable(
                name: "serie");

            migrationBuilder.DropTable(
                name: "acao");

            migrationBuilder.DropTable(
                name: "opcao");
        }
    }
}
