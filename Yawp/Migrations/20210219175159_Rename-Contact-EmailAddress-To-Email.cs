using Microsoft.EntityFrameworkCore.Migrations;

namespace Yawp.Migrations
{
    public partial class RenameContactEmailAddressToEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Contacts",
                newName: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Contacts",
                newName: "EmailAddress");
        }
    }
}
