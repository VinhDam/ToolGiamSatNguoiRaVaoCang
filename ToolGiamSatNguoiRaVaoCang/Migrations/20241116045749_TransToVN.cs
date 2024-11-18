using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToolGiamSatNguoiRaVaoCang.Migrations
{
    /// <inheritdoc />
    public partial class TransToVN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "IssuePriority",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Cao");

            migrationBuilder.UpdateData(
                table: "IssuePriority",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Trung bình");

            migrationBuilder.UpdateData(
                table: "IssuePriority",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Thấp");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "IssuePriority",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "High");

            migrationBuilder.UpdateData(
                table: "IssuePriority",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Medium");

            migrationBuilder.UpdateData(
                table: "IssuePriority",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Low");
        }
    }
}
