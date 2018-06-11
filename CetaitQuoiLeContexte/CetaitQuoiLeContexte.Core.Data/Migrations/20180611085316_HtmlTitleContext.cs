using Microsoft.EntityFrameworkCore.Migrations;

namespace CetaitQuoiLeContexte.Core.Data.Migrations
{
    public partial class HtmlTitleContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HtmlTitle",
                table: "Context",
                defaultValue: string.Empty,
                nullable: false);
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HtmlTitle",
                table: "Context");
        }
    }
}
