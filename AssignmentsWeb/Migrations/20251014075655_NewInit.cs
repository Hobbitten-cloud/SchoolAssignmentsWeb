using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentsWeb.Migrations
{
    /// <inheritdoc />
    public partial class NewInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "Description", "Subjects", "Title" },
                values: new object[] { 4, "Vi skal nu snakke sammen med APIer", 0, "Opgave 4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
