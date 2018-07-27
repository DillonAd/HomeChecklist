using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeChecklist.Persistence.Migrations
{
    public partial class Restructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Residents_Homes_HomeId",
                table: "Residents");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Homes_HomeId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Rooms_RoomId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_RoomId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_HomeId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Residents_HomeId",
                table: "Residents");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Tasks",
                newName: "ResidentId");

            migrationBuilder.AddColumn<int>(
                name: "HomeId",
                table: "Tasks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "HomeId",
                table: "Rooms",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HomeId",
                table: "Residents",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HomeId",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "ResidentId",
                table: "Tasks",
                newName: "RoomId");

            migrationBuilder.AlterColumn<int>(
                name: "HomeId",
                table: "Rooms",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "HomeId",
                table: "Residents",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_RoomId",
                table: "Tasks",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HomeId",
                table: "Rooms",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Residents_HomeId",
                table: "Residents",
                column: "HomeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Residents_Homes_HomeId",
                table: "Residents",
                column: "HomeId",
                principalTable: "Homes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Homes_HomeId",
                table: "Rooms",
                column: "HomeId",
                principalTable: "Homes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Rooms_RoomId",
                table: "Tasks",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
