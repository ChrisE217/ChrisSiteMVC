using Microsoft.EntityFrameworkCore.Migrations;

namespace chrissiteMVC.Data.Migrations
{
    public partial class id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IndexDataModel",
                table: "IndexDataModel");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfec1c58-dd36-4fd4-a67d-17ba1bb687af");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "IndexDataModel",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IndexDataModel",
                table: "IndexDataModel",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b8225bc0-5bfe-4b91-b787-f8110d4130f2", "c0c12e69-c7d9-46fa-b802-28ff2263c4dd", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IndexDataModel",
                table: "IndexDataModel");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8225bc0-5bfe-4b91-b787-f8110d4130f2");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "IndexDataModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IndexDataModel",
                table: "IndexDataModel",
                column: "Name");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bfec1c58-dd36-4fd4-a67d-17ba1bb687af", "4d5d4973-b615-4855-9e4c-f5a4a0fc1cc5", "Admin", "ADMIN" });
        }
    }
}
