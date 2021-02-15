using Microsoft.EntityFrameworkCore.Migrations;

namespace Yawp.Migrations
{
    public partial class RenameOwnedByToOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OwnedBy",
                table: "Contacts",
                newName: "Owner");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Owner",
                table: "Contacts",
                newName: "OwnedBy");
        }
    }
}
