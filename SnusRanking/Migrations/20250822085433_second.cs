using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SnusRanking.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Taste",
                table: "Snus",
                newName: "Flavor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Flavor",
                table: "Snus",
                newName: "Taste");
        }
    }
}
