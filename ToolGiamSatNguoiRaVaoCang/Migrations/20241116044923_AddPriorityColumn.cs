using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToolGiamSatNguoiRaVaoCang.Migrations
{
    /// <inheritdoc />
    public partial class AddPriorityColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PriorityId",
                table: "ZoneType",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PriorityId",
                table: "Zone",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PriorityId",
                table: "Shift",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PriorityId",
                table: "Person",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PriorityId",
                table: "Company",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ZoneType_PriorityId",
                table: "ZoneType",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Zone_PriorityId",
                table: "Zone",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Shift_PriorityId",
                table: "Shift",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_PriorityId",
                table: "Person",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_PriorityId",
                table: "Company",
                column: "PriorityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_IssuePriority_PriorityId",
                table: "Company",
                column: "PriorityId",
                principalTable: "IssuePriority",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_IssuePriority_PriorityId",
                table: "Person",
                column: "PriorityId",
                principalTable: "IssuePriority",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shift_IssuePriority_PriorityId",
                table: "Shift",
                column: "PriorityId",
                principalTable: "IssuePriority",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Zone_IssuePriority_PriorityId",
                table: "Zone",
                column: "PriorityId",
                principalTable: "IssuePriority",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ZoneType_IssuePriority_PriorityId",
                table: "ZoneType",
                column: "PriorityId",
                principalTable: "IssuePriority",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_IssuePriority_PriorityId",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_IssuePriority_PriorityId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Shift_IssuePriority_PriorityId",
                table: "Shift");

            migrationBuilder.DropForeignKey(
                name: "FK_Zone_IssuePriority_PriorityId",
                table: "Zone");

            migrationBuilder.DropForeignKey(
                name: "FK_ZoneType_IssuePriority_PriorityId",
                table: "ZoneType");

            migrationBuilder.DropIndex(
                name: "IX_ZoneType_PriorityId",
                table: "ZoneType");

            migrationBuilder.DropIndex(
                name: "IX_Zone_PriorityId",
                table: "Zone");

            migrationBuilder.DropIndex(
                name: "IX_Shift_PriorityId",
                table: "Shift");

            migrationBuilder.DropIndex(
                name: "IX_Person_PriorityId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Company_PriorityId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "PriorityId",
                table: "ZoneType");

            migrationBuilder.DropColumn(
                name: "PriorityId",
                table: "Zone");

            migrationBuilder.DropColumn(
                name: "PriorityId",
                table: "Shift");

            migrationBuilder.DropColumn(
                name: "PriorityId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "PriorityId",
                table: "Company");
        }
    }
}
