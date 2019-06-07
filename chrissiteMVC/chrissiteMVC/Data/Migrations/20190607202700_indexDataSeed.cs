using Microsoft.EntityFrameworkCore.Migrations;

namespace chrissiteMVC.Data.Migrations
{
    public partial class indexDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e804557-5de8-4b4a-99ec-997f1f04e88e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "15ed68ef-8d11-493d-9940-e496165d65ac", "ee5b90e3-3013-4c6f-8d7f-f690b4c2415e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "IndexDataModel",
                columns: new[] { "Id", "Cv", "Description", "Email", "Name", "Occupation", "PhoneNo", "Picture" },
                values: new object[] { "1", "cv", "Description", "youremail@email.com", "Name", "Occupation", "(phone number)", "pic" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15ed68ef-8d11-493d-9940-e496165d65ac");

            migrationBuilder.DeleteData(
                table: "IndexDataModel",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3e804557-5de8-4b4a-99ec-997f1f04e88e", "6b15b085-d6aa-4850-b996-ed6c63824f4d", "Admin", "ADMIN" });
        }
    }
}
