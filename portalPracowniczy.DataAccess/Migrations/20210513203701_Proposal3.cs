using Microsoft.EntityFrameworkCore.Migrations;

namespace portalPracowniczy.DataAccess.Migrations
{
    public partial class Proposal3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Proposals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Proposals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Proposals_UserId",
                table: "Proposals",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proposals_Users_UserId",
                table: "Proposals",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proposals_Users_UserId",
                table: "Proposals");

            migrationBuilder.DropIndex(
                name: "IX_Proposals_UserId",
                table: "Proposals");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Proposals");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Proposals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
