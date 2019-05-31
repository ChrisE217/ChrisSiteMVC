using Microsoft.EntityFrameworkCore.Migrations;

namespace chrissiteMVC.Data.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af31359e-3e76-4705-b13c-18b9bc5f49ea");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6bfe743a-7d3c-4f4f-afc7-46f11db209d8", "a70436d6-d4b2-4a3a-aa94-da487cf0f256", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bfe743a-7d3c-4f4f-afc7-46f11db209d8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "af31359e-3e76-4705-b13c-18b9bc5f49ea", "b3f907e6-7d60-4ce5-ad99-c2d54c407ddd", "Admin", "ADMIN" });
        }
    }
}
