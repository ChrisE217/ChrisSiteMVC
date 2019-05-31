using Microsoft.EntityFrameworkCore.Migrations;

namespace chrissiteMVC.Data.Migrations
{
    public partial class whatisthisbug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bfe743a-7d3c-4f4f-afc7-46f11db209d8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3e804557-5de8-4b4a-99ec-997f1f04e88e", "6b15b085-d6aa-4850-b996-ed6c63824f4d", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e804557-5de8-4b4a-99ec-997f1f04e88e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6bfe743a-7d3c-4f4f-afc7-46f11db209d8", "a70436d6-d4b2-4a3a-aa94-da487cf0f256", "Admin", "ADMIN" });
        }
    }
}
