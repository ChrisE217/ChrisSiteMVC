using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace chrissiteMVC.Data.Migrations
{
    public partial class projectANDindex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndexDataModel",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Occupation = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    Picture = table.Column<byte[]>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNo = table.Column<string>(maxLength: 15, nullable: false),
                    Cv = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndexDataModel", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "ProjectDataModel",
                columns: table => new
                {
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Link = table.Column<string>(maxLength: 255, nullable: false),
                    Image = table.Column<byte[]>(nullable: false),
                    GithubLink = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDataModel", x => x.Title);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndexDataModel");

            migrationBuilder.DropTable(
                name: "ProjectDataModel");
        }
    }
}
