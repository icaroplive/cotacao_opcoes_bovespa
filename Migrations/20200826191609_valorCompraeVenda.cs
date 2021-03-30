using Microsoft.EntityFrameworkCore.Migrations;

namespace carteiraAcoes.Migrations
{
    public partial class valorCompraeVenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ValorCompra",
                table: "opcao",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorVenda",
                table: "opcao",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorCompra",
                table: "acao",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorVenda",
                table: "acao",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorCompra",
                table: "opcao");

            migrationBuilder.DropColumn(
                name: "ValorVenda",
                table: "opcao");

            migrationBuilder.DropColumn(
                name: "ValorCompra",
                table: "acao");

            migrationBuilder.DropColumn(
                name: "ValorVenda",
                table: "acao");
        }
    }
}
