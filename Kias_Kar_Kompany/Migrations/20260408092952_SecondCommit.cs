using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kias_Kar_Kompany.Migrations
{
    /// <inheritdoc />
    public partial class SecondCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Manufacturer_ManufacturerId",
                table: "Vehicle");

            migrationBuilder.RenameColumn(
                name: "ManufacturerId",
                table: "Vehicle",
                newName: "ownerId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_ManufacturerId",
                table: "Vehicle",
                newName: "IX_Vehicle_ownerId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Manufacturer",
                newName: "ManId");

            migrationBuilder.AddColumn<int>(
                name: "ManufacturerManId",
                table: "Vehicle",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "manId",
                table: "Vehicle",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    ownerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ownerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ownerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ownerNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.ownerId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_ManufacturerManId",
                table: "Vehicle",
                column: "ManufacturerManId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Manufacturer_ManufacturerManId",
                table: "Vehicle",
                column: "ManufacturerManId",
                principalTable: "Manufacturer",
                principalColumn: "ManId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Owner_ownerId",
                table: "Vehicle",
                column: "ownerId",
                principalTable: "Owner",
                principalColumn: "ownerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Manufacturer_ManufacturerManId",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Owner_ownerId",
                table: "Vehicle");

            migrationBuilder.DropTable(
                name: "Owner");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_ManufacturerManId",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "ManufacturerManId",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "manId",
                table: "Vehicle");

            migrationBuilder.RenameColumn(
                name: "ownerId",
                table: "Vehicle",
                newName: "ManufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_ownerId",
                table: "Vehicle",
                newName: "IX_Vehicle_ManufacturerId");

            migrationBuilder.RenameColumn(
                name: "ManId",
                table: "Manufacturer",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Manufacturer_ManufacturerId",
                table: "Vehicle",
                column: "ManufacturerId",
                principalTable: "Manufacturer",
                principalColumn: "Id");
        }
    }
}
