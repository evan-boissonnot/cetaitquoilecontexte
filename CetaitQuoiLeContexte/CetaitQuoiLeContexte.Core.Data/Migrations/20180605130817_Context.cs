using Microsoft.EntityFrameworkCore.Migrations;

namespace CetaitQuoiLeContexte.Core.Data.Migrations
{
    public partial class Context : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>("From", "Context", maxLength: 255);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("From", "Context");
        }
    }
}
