using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjeFiles.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    guid = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    category = table.Column<string>(nullable: true),
                    prize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.guid);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    guid = table.Column<Guid>(nullable: false),
                    userName = table.Column<string>(nullable: true),
                    userPass = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.guid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
