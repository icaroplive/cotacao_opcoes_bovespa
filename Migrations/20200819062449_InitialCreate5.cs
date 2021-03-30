using Microsoft.EntityFrameworkCore.Migrations;

namespace carteiraAcoes.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "exerceu",
                table: "movimentoOpcao",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "finalizado",
                table: "movimentoOpcao",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "exerceu",
                table: "movimentoOpcao");

            migrationBuilder.DropColumn(
                name: "finalizado",
                table: "movimentoOpcao");
        }
    }
}
