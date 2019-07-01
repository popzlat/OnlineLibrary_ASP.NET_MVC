using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBookLibrary.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Role_Users_LibrarianId",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Role_LibrarianId",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "LibrarianId",
                table: "Role");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Role",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Role");

            migrationBuilder.AddColumn<int>(
                name: "LibrarianId",
                table: "Role",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Role_LibrarianId",
                table: "Role",
                column: "LibrarianId");

            migrationBuilder.AddForeignKey(
                name: "FK_Role_Users_LibrarianId",
                table: "Role",
                column: "LibrarianId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
