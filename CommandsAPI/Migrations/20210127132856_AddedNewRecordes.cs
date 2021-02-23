using Microsoft.EntityFrameworkCore.Migrations;

namespace CommandsAPI.Migrations
{
    public partial class AddedNewRecordes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GetCommands",
                columns: new[] { "Id", "CommandLine", "HowTo", "Plateform" },
                values: new object[] { 2, "rmdir FILENAME", "Remove a dircetory", "All Operating Systems" });

            migrationBuilder.InsertData(
                table: "GetCommands",
                columns: new[] { "Id", "CommandLine", "HowTo", "Plateform" },
                values: new object[] { 3, "echo SOMETHINGTOPRINTE", "Print something in Console", "All Operating Systems" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GetCommands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GetCommands",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
