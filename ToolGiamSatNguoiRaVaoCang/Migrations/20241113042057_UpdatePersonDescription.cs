using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToolGiamSatNguoiRaVaoCang.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePersonDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Person");
        }
    }
}
