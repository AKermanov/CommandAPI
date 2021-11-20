using Microsoft.EntityFrameworkCore.Migrations;

namespace CommandAPISolution.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CommandItems",
                columns: new[] { "Id", "CommandLine", "HowTo", "Platform" },
                values: new object[] { 1, "dotnet ef migrations add <Name of Migration>", "How to generete migration", ".Net Core Ef" });

            migrationBuilder.InsertData(
                table: "CommandItems",
                columns: new[] { "Id", "CommandLine", "HowTo", "Platform" },
                values: new object[] { 2, "dotnet ef database update", "Run Migrations", ".Net Core Ef" });

            migrationBuilder.InsertData(
                table: "CommandItems",
                columns: new[] { "Id", "CommandLine", "HowTo", "Platform" },
                values: new object[] { 3, "dotnet ef migrations list", "List active migrations", ".Net Core Ef" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CommandItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CommandItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CommandItems",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
