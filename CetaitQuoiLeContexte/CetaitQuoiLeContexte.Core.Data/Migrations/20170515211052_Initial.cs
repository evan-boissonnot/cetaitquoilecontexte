using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CetaitQuoiLeContexte.Core.Data.Migrations
{
    // 1. Il fallait d'abord installer le package : Install-Package Microsoft.EntityFrameworkCore.Tools
    // 2. Et après, on peut lancer dans le PMC : Add-Migration Initial
    // 3. Pour mettre à jour : Update-Database. Sinon par cmd, il faut : http://benjii.me/2016/05/dotnet-ef-migrations-for-asp-net-core/
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Context",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuthorId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Message = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Context", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Context_Person_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Context_AuthorId",
                table: "Context",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Context");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
