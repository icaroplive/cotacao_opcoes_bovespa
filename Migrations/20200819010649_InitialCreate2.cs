using Microsoft.EntityFrameworkCore.Migrations;

namespace carteiraAcoes.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movimentoAcao_acao_AcaoId",
                table: "movimentoAcao");

            migrationBuilder.DropForeignKey(
                name: "FK_movimentoOpcao_opcao_OpcaoId",
                table: "movimentoOpcao");

            migrationBuilder.AlterColumn<int>(
                name: "OpcaoId",
                table: "movimentoOpcao",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AcaoId",
                table: "movimentoAcao",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_opcao_AcaoId",
                table: "opcao",
                column: "AcaoId");

            migrationBuilder.CreateIndex(
                name: "IX_opcao_SerieId",
                table: "opcao",
                column: "SerieId");

            migrationBuilder.AddForeignKey(
                name: "FK_movimentoAcao_acao_AcaoId",
                table: "movimentoAcao",
                column: "AcaoId",
                principalTable: "acao",
                principalColumn: "AcaoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_movimentoOpcao_opcao_OpcaoId",
                table: "movimentoOpcao",
                column: "OpcaoId",
                principalTable: "opcao",
                principalColumn: "OpcaoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_opcao_acao_AcaoId",
                table: "opcao",
                column: "AcaoId",
                principalTable: "acao",
                principalColumn: "AcaoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_opcao_serie_SerieId",
                table: "opcao",
                column: "SerieId",
                principalTable: "serie",
                principalColumn: "SerieId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_movimentoAcao_acao_AcaoId",
                table: "movimentoAcao");

            migrationBuilder.DropForeignKey(
                name: "FK_movimentoOpcao_opcao_OpcaoId",
                table: "movimentoOpcao");

            migrationBuilder.DropForeignKey(
                name: "FK_opcao_acao_AcaoId",
                table: "opcao");

            migrationBuilder.DropForeignKey(
                name: "FK_opcao_serie_SerieId",
                table: "opcao");

            migrationBuilder.DropIndex(
                name: "IX_opcao_AcaoId",
                table: "opcao");

            migrationBuilder.DropIndex(
                name: "IX_opcao_SerieId",
                table: "opcao");

            migrationBuilder.AlterColumn<int>(
                name: "OpcaoId",
                table: "movimentoOpcao",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AcaoId",
                table: "movimentoAcao",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_movimentoAcao_acao_AcaoId",
                table: "movimentoAcao",
                column: "AcaoId",
                principalTable: "acao",
                principalColumn: "AcaoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_movimentoOpcao_opcao_OpcaoId",
                table: "movimentoOpcao",
                column: "OpcaoId",
                principalTable: "opcao",
                principalColumn: "OpcaoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
