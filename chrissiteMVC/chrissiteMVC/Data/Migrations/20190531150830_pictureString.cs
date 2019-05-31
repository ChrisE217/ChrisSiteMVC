using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace chrissiteMVC.Data.Migrations
{
    public partial class pictureString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce999ab2-2482-484b-8a0f-acf2bb2c3016");

            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "IndexDataModel",
                nullable: false,
                oldClrType: typeof(byte[]));

            migrationBuilder.AlterColumn<string>(
                name: "Cv",
                table: "IndexDataModel",
                nullable: false,
                oldClrType: typeof(byte[]));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bfec1c58-dd36-4fd4-a67d-17ba1bb687af", "4d5d4973-b615-4855-9e4c-f5a4a0fc1cc5", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfec1c58-dd36-4fd4-a67d-17ba1bb687af");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Picture",
                table: "IndexDataModel",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<byte[]>(
                name: "Cv",
                table: "IndexDataModel",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce999ab2-2482-484b-8a0f-acf2bb2c3016", "a3e620f3-6756-4f8c-8e1f-b83b0d4da329", "Admin", "ADMIN" });
        }
    }
}
