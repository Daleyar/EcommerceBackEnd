using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class modelMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d4d2417-6a1d-4a0b-88be-41562b3b9e33");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa8040a4-db7c-4455-9e01-e0beda9ff156");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe16aa0f-7935-4b47-9148-e9a2b7df1feb", "5e6febac-ff39-4f81-8f2b-5297186688a4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9046802b-a308-4a66-b8d8-cf00af94c4cb", "6b56ba62-683d-4287-8cae-b1d9e5202c78", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9046802b-a308-4a66-b8d8-cf00af94c4cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe16aa0f-7935-4b47-9148-e9a2b7df1feb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aa8040a4-db7c-4455-9e01-e0beda9ff156", "95a32154-a669-429a-b9d3-f2a8f7ea6abd", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0d4d2417-6a1d-4a0b-88be-41562b3b9e33", "33bd7459-2fd2-4f56-a239-50c2729039f0", "Admin", "ADMIN" });
        }
    }
}
