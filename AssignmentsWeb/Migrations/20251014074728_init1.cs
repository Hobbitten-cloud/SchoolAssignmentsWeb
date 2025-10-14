using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentsWeb.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Du skal lære om enums", "Opgave 1" });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Subjects", "Title" },
                values: new object[] { "Du skal nu lære om hvad en systemudviklings metode er", 2, "Opgave 2" });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Subjects", "Title" },
                values: new object[] { "Vi skal lære om binare tal", 1, "Opgave 3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "dubdubdub yes yes yes", "Skibidi" });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Subjects", "Title" },
                values: new object[] { "dubdubdub yes yes yes squared", 0, "Skibidi2" });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Subjects", "Title" },
                values: new object[] { "dubdubdub yes yes yes cubed", 0, "Skibidi3" });
        }
    }
}
