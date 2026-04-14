using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kias_Kar_Kompany.Migrations
{
    /// <inheritdoc />
    public partial class commit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "manId",
                table: "Vehicle",
                newName: "ManId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ManId",
                table: "Vehicle",
                newName: "manId");
        }
    }
}
