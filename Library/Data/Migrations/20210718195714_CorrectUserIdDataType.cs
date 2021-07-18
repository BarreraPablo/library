using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Data.Migrations
{
    public partial class CorrectUserIdDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrowings_AspNetUsers_UserId1",
                table: "Borrowings");

            migrationBuilder.DropIndex(
                name: "IX_Borrowings_UserId1",
                table: "Borrowings");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Borrowings");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Borrowings",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Borrowings_UserId",
                table: "Borrowings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowings_AspNetUsers_UserId",
                table: "Borrowings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrowings_AspNetUsers_UserId",
                table: "Borrowings");

            migrationBuilder.DropIndex(
                name: "IX_Borrowings_UserId",
                table: "Borrowings");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "Borrowings",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Borrowings",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Borrowings_UserId1",
                table: "Borrowings",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowings_AspNetUsers_UserId1",
                table: "Borrowings",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
