using Microsoft.EntityFrameworkCore.Migrations;

namespace carteiraAcoes.Migrations
{
    public partial class vendidoAcao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Vendido",
                table: "movimentoAcao",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vendido",
                table: "movimentoAcao");
        }
    }
}
