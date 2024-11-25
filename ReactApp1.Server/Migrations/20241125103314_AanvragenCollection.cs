using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReactApp1.Server.Migrations
{
    /// <inheritdoc />
    public partial class AanvragenCollection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BedrijfsAccountaccountId",
                table: "HuurAanvraags",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HuurdersAccountaccountId",
                table: "HuurAanvraags",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HuurAanvraags_BedrijfsAccountaccountId",
                table: "HuurAanvraags",
                column: "BedrijfsAccountaccountId");

            migrationBuilder.CreateIndex(
                name: "IX_HuurAanvraags_HuurdersAccountaccountId",
                table: "HuurAanvraags",
                column: "HuurdersAccountaccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_HuurAanvraags_Account_BedrijfsAccountaccountId",
                table: "HuurAanvraags",
                column: "BedrijfsAccountaccountId",
                principalTable: "Account",
                principalColumn: "accountId");

            migrationBuilder.AddForeignKey(
                name: "FK_HuurAanvraags_Account_HuurdersAccountaccountId",
                table: "HuurAanvraags",
                column: "HuurdersAccountaccountId",
                principalTable: "Account",
                principalColumn: "accountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HuurAanvraags_Account_BedrijfsAccountaccountId",
                table: "HuurAanvraags");

            migrationBuilder.DropForeignKey(
                name: "FK_HuurAanvraags_Account_HuurdersAccountaccountId",
                table: "HuurAanvraags");

            migrationBuilder.DropIndex(
                name: "IX_HuurAanvraags_BedrijfsAccountaccountId",
                table: "HuurAanvraags");

            migrationBuilder.DropIndex(
                name: "IX_HuurAanvraags_HuurdersAccountaccountId",
                table: "HuurAanvraags");

            migrationBuilder.DropColumn(
                name: "BedrijfsAccountaccountId",
                table: "HuurAanvraags");

            migrationBuilder.DropColumn(
                name: "HuurdersAccountaccountId",
                table: "HuurAanvraags");
        }
    }
}
