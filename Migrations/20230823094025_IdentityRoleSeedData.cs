using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.Migrations
{
    public partial class IdentityRoleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "070cd706-76ae-4243-92a5-96bc6f3be7d1", "03acd635-239f-4910-868b-54c624547a58", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b93aedef-1a46-460e-b468-0bedcef954b1", "a2e29a03-64e8-4aa2-bb7e-ae09e4b998dd", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d901fed7-cdf6-41fd-88ba-eda8a51e2a2d", "b821a160-f17e-425c-b598-c4a32ba02031", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "070cd706-76ae-4243-92a5-96bc6f3be7d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b93aedef-1a46-460e-b468-0bedcef954b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d901fed7-cdf6-41fd-88ba-eda8a51e2a2d");
        }
    }
}
