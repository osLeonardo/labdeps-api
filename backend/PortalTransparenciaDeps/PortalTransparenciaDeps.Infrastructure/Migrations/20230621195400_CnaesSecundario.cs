using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PortalTransparenciaDeps.Infrastructure.Migrations
{
    public partial class CnaesSecundario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cnaes_secundario",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cnaes_secundarios = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    id_dado = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cnaes_secundarios", x => x.id);
                    table.ForeignKey(
                        name: "fk_cnaes_secundarios_dados_id_dado",
                        column: x => x.id_dado,
                        principalTable: "dados",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cnaes_secundario_id_dado",
                table: "cnaes_secundario",
                column: "id_dado");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cnaes_secundario");
        }
    }
}
