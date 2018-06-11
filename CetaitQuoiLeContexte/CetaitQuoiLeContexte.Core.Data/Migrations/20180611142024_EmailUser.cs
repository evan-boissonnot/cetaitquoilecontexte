using Microsoft.EntityFrameworkCore.Migrations;

namespace CetaitQuoiLeContexte.Core.Data.Migrations
{
    public partial class EmailUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
               name: "Email",
               table: "Person",
               defaultValue: string.Empty,
               nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Person");
        }
    }
}
