using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PortalTransparenciaDeps.Infrastructure.Migrations
{
    public partial class addHistorico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ativo",
                table: "user_login");

            migrationBuilder.CreateTable(
                name: "historico_consulta",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    data_consulta = table.Column<DateOnly>(type: "date", nullable: false),
                    tipo_consulta = table.Column<string>(type: "text", nullable: false),
                    codigo = table.Column<string>(type: "text", nullable: false),
                    data_referencia = table.Column<DateOnly>(type: "date", nullable: false),
                    intervalo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_historico_consultas", x => x.id);
                    table.ForeignKey(
                        name: "fk_historico_consultas_user_logins_user_id",
                        column: x => x.user_id,
                        principalTable: "user_login",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_historico_consulta_user_id",
                table: "historico_consulta",
                column: "user_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "historico_consulta");

            migrationBuilder.AddColumn<bool>(
                name: "ativo",
                table: "user_login",
                type: "boolean",
                nullable: false,
                defaultValue: true);
        }
    }
}
