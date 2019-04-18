using Microsoft.EntityFrameworkCore.Migrations;

namespace LikeableThings.Migrations
{
    public partial class thing_updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Things_AspNetUsers_ApplicationUserId",
                table: "Things");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Things",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Things_ApplicationUserId",
                table: "Things",
                newName: "IX_Things_UserId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Things",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Things_AspNetUsers_UserId",
                table: "Things",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Things_AspNetUsers_UserId",
                table: "Things");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Things");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Things",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Things_UserId",
                table: "Things",
                newName: "IX_Things_ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Things_AspNetUsers_ApplicationUserId",
                table: "Things",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
