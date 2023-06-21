using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortalTransparenciaDeps.Infrastructure.Migrations
{
    public partial class userUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_user_logins_perfis_id_perfil",
                table: "user_login");

            migrationBuilder.DropIndex(
                name: "IX_user_login_id_perfil",
                table: "user_login");

            migrationBuilder.DropColumn(
                name: "id_perfil",
                table: "user_login");

            migrationBuilder.AddColumn<bool>(
                name: "ativo",
                table: "user_login",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "nome",
                table: "user_login",
                type: "character varying(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "sobrenome",
                table: "user_login",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ativo",
                table: "user_login");

            migrationBuilder.DropColumn(
                name: "nome",
                table: "user_login");

            migrationBuilder.DropColumn(
                name: "sobrenome",
                table: "user_login");

            migrationBuilder.AddColumn<int>(
                name: "id_perfil",
                table: "user_login",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_user_login_id_perfil",
                table: "user_login",
                column: "id_perfil");

            migrationBuilder.AddForeignKey(
                name: "fk_user_logins_perfis_id_perfil",
                table: "user_login",
                column: "id_perfil",
                principalTable: "perfil",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
