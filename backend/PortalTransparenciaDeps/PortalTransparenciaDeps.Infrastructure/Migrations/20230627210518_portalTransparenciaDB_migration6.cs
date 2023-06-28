using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortalTransparenciaDeps.Infrastructure.Migrations
{
    public partial class portalTransparenciaDB_migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_municipios_uf_id_uf",
                table: "municipio");

            migrationBuilder.DropPrimaryKey(
                name: "pk_uf",
                table: "uf");

            migrationBuilder.AddPrimaryKey(
                name: "pk_ufs",
                table: "uf",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_municipios_ufs_id_uf",
                table: "municipio",
                column: "id_uf",
                principalTable: "uf",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_municipios_ufs_id_uf",
                table: "municipio");

            migrationBuilder.DropPrimaryKey(
                name: "pk_ufs",
                table: "uf");

            migrationBuilder.AddPrimaryKey(
                name: "pk_uf",
                table: "uf",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_municipios_uf_id_uf",
                table: "municipio",
                column: "id_uf",
                principalTable: "uf",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
