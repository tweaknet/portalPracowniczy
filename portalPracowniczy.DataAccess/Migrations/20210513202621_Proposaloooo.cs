using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace portalPracowniczy.DataAccess.Migrations
{
    public partial class Proposaloooo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Proposal_ProposalId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Proposal");

            migrationBuilder.DropIndex(
                name: "IX_Users_ProposalId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProposalId",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProposalId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Proposal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdHolidayType = table.Column<int>(type: "int", nullable: false),
                    IdStatus = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    curentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proposal", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProposalId",
                table: "Users",
                column: "ProposalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Proposal_ProposalId",
                table: "Users",
                column: "ProposalId",
                principalTable: "Proposal",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
