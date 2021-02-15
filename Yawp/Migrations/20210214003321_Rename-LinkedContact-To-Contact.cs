using Microsoft.EntityFrameworkCore.Migrations;

namespace Yawp.Migrations
{
    public partial class RenameLinkedContactToContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LinkedContact",
                table: "Users",
                newName: "Contact");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contact",
                table: "Users",
                newName: "LinkedContact");
        }
    }
}
