using Microsoft.EntityFrameworkCore.Migrations;

namespace CommandsAPI.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GetCommands",
                columns: new[] { "Id", "CommandLine", "HowTo", "Plateform" },
                values: new object[] { 1, "midir FILENAME", "Make a dircetory", "All Operating Systems" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GetCommands",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
