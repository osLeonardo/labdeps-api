using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortalTransparenciaDeps.Infrastructure.Migrations
{
    public partial class updateLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ativo",
                table: "user_login",
                type: "boolean",
                nullable: false,
                defaultValue: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ativo",
                table: "user_login");
        }
    }
}
