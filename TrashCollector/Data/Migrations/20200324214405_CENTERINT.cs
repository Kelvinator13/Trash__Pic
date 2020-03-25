using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class CENTERINT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55b9f9ff-977a-42cd-b982-042b9ee82ce8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5bc42f3a-aea8-47b7-8c55-8dca61db4549");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6476950-a01e-4bb5-b5db-e2523faa265d", "57615777-d8de-473e-b22b-610b1a8df209", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ded2ffd0-0eb5-4998-ba5e-695ed35123aa", "f06a801a-8161-4594-818a-0ac5c00b344b", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6476950-a01e-4bb5-b5db-e2523faa265d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ded2ffd0-0eb5-4998-ba5e-695ed35123aa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5bc42f3a-aea8-47b7-8c55-8dca61db4549", "b9edf0c3-664c-4a30-9b16-64d37371cc77", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "55b9f9ff-977a-42cd-b982-042b9ee82ce8", "f1cb4640-922e-4521-81be-a3df8083f817", "Employee", "EMPLOYEE" });
        }
    }
}
