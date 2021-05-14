using Microsoft.EntityFrameworkCore.Migrations;

namespace portalPracowniczy.DataAccess.Migrations
{
    public partial class Encje2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Holiday_Users_UserId",
                table: "Holiday");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Holiday",
                table: "Holiday");

            migrationBuilder.RenameTable(
                name: "Holiday",
                newName: "Holidays");

            migrationBuilder.RenameIndex(
                name: "IX_Holiday_UserId",
                table: "Holidays",
                newName: "IX_Holidays_UserId");

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HolidayTypeId",
                table: "Proposals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Proposals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HolidayTypeId",
                table: "Holidays",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Holidays",
                table: "Holidays",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdSuperior = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HolidayTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdRCP = table.Column<int>(type: "int", nullable: false),
                    IdERP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HolidayTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_BranchId",
                table: "Users",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PositionId",
                table: "Users",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Proposals_HolidayTypeId",
                table: "Proposals",
                column: "HolidayTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Proposals_StatusId",
                table: "Proposals",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_HolidayTypeId",
                table: "Holidays",
                column: "HolidayTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Holidays_HolidayTypes_HolidayTypeId",
                table: "Holidays",
                column: "HolidayTypeId",
                principalTable: "HolidayTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Holidays_Users_UserId",
                table: "Holidays",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proposals_HolidayTypes_HolidayTypeId",
                table: "Proposals",
                column: "HolidayTypeId",
                principalTable: "HolidayTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proposals_Status_StatusId",
                table: "Proposals",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Branch_BranchId",
                table: "Users",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Positions_PositionId",
                table: "Users",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Holidays_HolidayTypes_HolidayTypeId",
                table: "Holidays");

            migrationBuilder.DropForeignKey(
                name: "FK_Holidays_Users_UserId",
                table: "Holidays");

            migrationBuilder.DropForeignKey(
                name: "FK_Proposals_HolidayTypes_HolidayTypeId",
                table: "Proposals");

            migrationBuilder.DropForeignKey(
                name: "FK_Proposals_Status_StatusId",
                table: "Proposals");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Branch_BranchId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Positions_PositionId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "HolidayTypes");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Users_BranchId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PositionId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Proposals_HolidayTypeId",
                table: "Proposals");

            migrationBuilder.DropIndex(
                name: "IX_Proposals_StatusId",
                table: "Proposals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Holidays",
                table: "Holidays");

            migrationBuilder.DropIndex(
                name: "IX_Holidays_HolidayTypeId",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "HolidayTypeId",
                table: "Proposals");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Proposals");

            migrationBuilder.DropColumn(
                name: "HolidayTypeId",
                table: "Holidays");

            migrationBuilder.RenameTable(
                name: "Holidays",
                newName: "Holiday");

            migrationBuilder.RenameIndex(
                name: "IX_Holidays_UserId",
                table: "Holiday",
                newName: "IX_Holiday_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Holiday",
                table: "Holiday",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Holiday_Users_UserId",
                table: "Holiday",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
