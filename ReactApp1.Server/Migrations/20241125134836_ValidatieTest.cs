using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReactApp1.Server.Migrations
{
    /// <inheritdoc />
    public partial class ValidatieTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "deuren",
                table: "Autos",
                newName: "aantalDeuren");

            migrationBuilder.RenameColumn(
                name: "gewicht",
                table: "Caravans",
                newName: "aantalBedden");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "aantalDeuren",
                table: "Autos",
                newName: "deuren");

            migrationBuilder.RenameColumn(
                name: "aantalBedden",
                table: "Caravans",
                newName: "gewicht");
        }
    }
}
