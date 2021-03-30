using Microsoft.EntityFrameworkCore.Migrations;

namespace carteiraAcoes.Migrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovimentoAcaoId",
                table: "movimentoOpcao",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovimentoAcaoId",
                table: "movimentoOpcao");
        }
    }
}
