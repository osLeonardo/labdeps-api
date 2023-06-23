using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortalTransparenciaDeps.Infrastructure.Migrations
{
    public partial class portalTransparenciaDB_migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_historico_consulta",
                table: "remuneracao",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_historico_consulta",
                table: "peti",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_historico_consulta",
                table: "pep",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_historico_consulta",
                table: "leniencia",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_historico_consulta",
                table: "cnep",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_historico_consulta",
                table: "cepim",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_historico_consulta",
                table: "bpc",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_historico_consulta",
                table: "bolsa_familia",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_remuneracao_id_historico_consulta",
                table: "remuneracao",
                column: "id_historico_consulta");

            migrationBuilder.CreateIndex(
                name: "IX_peti_id_historico_consulta",
                table: "peti",
                column: "id_historico_consulta");

            migrationBuilder.CreateIndex(
                name: "IX_pep_id_historico_consulta",
                table: "pep",
                column: "id_historico_consulta");

            migrationBuilder.CreateIndex(
                name: "IX_leniencia_id_historico_consulta",
                table: "leniencia",
                column: "id_historico_consulta");

            migrationBuilder.CreateIndex(
                name: "IX_cnep_id_historico_consulta",
                table: "cnep",
                column: "id_historico_consulta");

            migrationBuilder.CreateIndex(
                name: "IX_cepim_id_historico_consulta",
                table: "cepim",
                column: "id_historico_consulta");

            migrationBuilder.CreateIndex(
                name: "IX_bpc_id_historico_consulta",
                table: "bpc",
                column: "id_historico_consulta");

            migrationBuilder.CreateIndex(
                name: "IX_bolsa_familia_id_historico_consulta",
                table: "bolsa_familia",
                column: "id_historico_consulta");

            migrationBuilder.AddForeignKey(
                name: "fk_bolsa_familia_historico_consulta_id_historico_consulta",
                table: "bolsa_familia",
                column: "id_historico_consulta",
                principalTable: "historico_consulta",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_bpc_historico_consulta_id_historico_consulta",
                table: "bpc",
                column: "id_historico_consulta",
                principalTable: "historico_consulta",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_cepim_historico_consulta_id_historico_consulta",
                table: "cepim",
                column: "id_historico_consulta",
                principalTable: "historico_consulta",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_cnep_historico_consulta_id_historico_consulta",
                table: "cnep",
                column: "id_historico_consulta",
                principalTable: "historico_consulta",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_leniencia_historico_consulta_id_historico_consulta",
                table: "leniencia",
                column: "id_historico_consulta",
                principalTable: "historico_consulta",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_pep_historico_consulta_id_historico_consulta",
                table: "pep",
                column: "id_historico_consulta",
                principalTable: "historico_consulta",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_peti_historico_consulta_id_historico_consulta",
                table: "peti",
                column: "id_historico_consulta",
                principalTable: "historico_consulta",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_remuneracao_historico_consulta_id_historico_consulta",
                table: "remuneracao",
                column: "id_historico_consulta",
                principalTable: "historico_consulta",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_bolsa_familia_historico_consulta_id_historico_consulta",
                table: "bolsa_familia");

            migrationBuilder.DropForeignKey(
                name: "fk_bpc_historico_consulta_id_historico_consulta",
                table: "bpc");

            migrationBuilder.DropForeignKey(
                name: "fk_cepim_historico_consulta_id_historico_consulta",
                table: "cepim");

            migrationBuilder.DropForeignKey(
                name: "fk_cnep_historico_consulta_id_historico_consulta",
                table: "cnep");

            migrationBuilder.DropForeignKey(
                name: "fk_leniencia_historico_consulta_id_historico_consulta",
                table: "leniencia");

            migrationBuilder.DropForeignKey(
                name: "fk_pep_historico_consulta_id_historico_consulta",
                table: "pep");

            migrationBuilder.DropForeignKey(
                name: "fk_peti_historico_consulta_id_historico_consulta",
                table: "peti");

            migrationBuilder.DropForeignKey(
                name: "fk_remuneracao_historico_consulta_id_historico_consulta",
                table: "remuneracao");

            migrationBuilder.DropIndex(
                name: "IX_remuneracao_id_historico_consulta",
                table: "remuneracao");

            migrationBuilder.DropIndex(
                name: "IX_peti_id_historico_consulta",
                table: "peti");

            migrationBuilder.DropIndex(
                name: "IX_pep_id_historico_consulta",
                table: "pep");

            migrationBuilder.DropIndex(
                name: "IX_leniencia_id_historico_consulta",
                table: "leniencia");

            migrationBuilder.DropIndex(
                name: "IX_cnep_id_historico_consulta",
                table: "cnep");

            migrationBuilder.DropIndex(
                name: "IX_cepim_id_historico_consulta",
                table: "cepim");

            migrationBuilder.DropIndex(
                name: "IX_bpc_id_historico_consulta",
                table: "bpc");

            migrationBuilder.DropIndex(
                name: "IX_bolsa_familia_id_historico_consulta",
                table: "bolsa_familia");

            migrationBuilder.DropColumn(
                name: "id_historico_consulta",
                table: "remuneracao");

            migrationBuilder.DropColumn(
                name: "id_historico_consulta",
                table: "peti");

            migrationBuilder.DropColumn(
                name: "id_historico_consulta",
                table: "pep");

            migrationBuilder.DropColumn(
                name: "id_historico_consulta",
                table: "leniencia");

            migrationBuilder.DropColumn(
                name: "id_historico_consulta",
                table: "cnep");

            migrationBuilder.DropColumn(
                name: "id_historico_consulta",
                table: "cepim");

            migrationBuilder.DropColumn(
                name: "id_historico_consulta",
                table: "bpc");

            migrationBuilder.DropColumn(
                name: "id_historico_consulta",
                table: "bolsa_familia");
        }
    }
}
