using Microsoft.EntityFrameworkCore.Migrations;

namespace chrissiteMVC.Data.Migrations
{
    public partial class stringValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8225bc0-5bfe-4b91-b787-f8110d4130f2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "af31359e-3e76-4705-b13c-18b9bc5f49ea", "b3f907e6-7d60-4ce5-ad99-c2d54c407ddd", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af31359e-3e76-4705-b13c-18b9bc5f49ea");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b8225bc0-5bfe-4b91-b787-f8110d4130f2", "c0c12e69-c7d9-46fa-b802-28ff2263c4dd", "Admin", "ADMIN" });
        }
    }
}
