using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReactApp1.Server.Migrations
{
    /// <inheritdoc />
    public partial class Beginvalidatie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HuurAanvraags_Account_BedrijfsAccountAccountId",
                table: "HuurAanvraags");

            migrationBuilder.DropForeignKey(
                name: "FK_HuurAanvraags_Account_HuurdersAccountAccountId",
                table: "HuurAanvraags");

            migrationBuilder.DropForeignKey(
                name: "FK_HuurAanvraags_Account_accountid",
                table: "HuurAanvraags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HuurAanvraags",
                table: "HuurAanvraags");

            migrationBuilder.RenameTable(
                name: "HuurAanvraags",
                newName: "HuurAanvragen");

            migrationBuilder.RenameIndex(
                name: "IX_HuurAanvraags_HuurdersAccountAccountId",
                table: "HuurAanvragen",
                newName: "IX_HuurAanvragen_HuurdersAccountAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_HuurAanvraags_BedrijfsAccountAccountId",
                table: "HuurAanvragen",
                newName: "IX_HuurAanvragen_BedrijfsAccountAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_HuurAanvraags_accountid",
                table: "HuurAanvragen",
                newName: "IX_HuurAanvragen_accountid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HuurAanvragen",
                table: "HuurAanvragen",
                column: "huurAanvraagId");

            migrationBuilder.AddForeignKey(
                name: "FK_HuurAanvragen_Account_BedrijfsAccountAccountId",
                table: "HuurAanvragen",
                column: "BedrijfsAccountAccountId",
                principalTable: "Account",
                principalColumn: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_HuurAanvragen_Account_HuurdersAccountAccountId",
                table: "HuurAanvragen",
                column: "HuurdersAccountAccountId",
                principalTable: "Account",
                principalColumn: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_HuurAanvragen_Account_accountid",
                table: "HuurAanvragen",
                column: "accountid",
                principalTable: "Account",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HuurAanvragen_Account_BedrijfsAccountAccountId",
                table: "HuurAanvragen");

            migrationBuilder.DropForeignKey(
                name: "FK_HuurAanvragen_Account_HuurdersAccountAccountId",
                table: "HuurAanvragen");

            migrationBuilder.DropForeignKey(
                name: "FK_HuurAanvragen_Account_accountid",
                table: "HuurAanvragen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HuurAanvragen",
                table: "HuurAanvragen");

            migrationBuilder.RenameTable(
                name: "HuurAanvragen",
                newName: "HuurAanvraags");

            migrationBuilder.RenameIndex(
                name: "IX_HuurAanvragen_HuurdersAccountAccountId",
                table: "HuurAanvraags",
                newName: "IX_HuurAanvraags_HuurdersAccountAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_HuurAanvragen_BedrijfsAccountAccountId",
                table: "HuurAanvraags",
                newName: "IX_HuurAanvraags_BedrijfsAccountAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_HuurAanvragen_accountid",
                table: "HuurAanvraags",
                newName: "IX_HuurAanvraags_accountid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HuurAanvraags",
                table: "HuurAanvraags",
                column: "huurAanvraagId");

            migrationBuilder.AddForeignKey(
                name: "FK_HuurAanvraags_Account_BedrijfsAccountAccountId",
                table: "HuurAanvraags",
                column: "BedrijfsAccountAccountId",
                principalTable: "Account",
                principalColumn: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_HuurAanvraags_Account_HuurdersAccountAccountId",
                table: "HuurAanvraags",
                column: "HuurdersAccountAccountId",
                principalTable: "Account",
                principalColumn: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_HuurAanvraags_Account_accountid",
                table: "HuurAanvraags",
                column: "accountid",
                principalTable: "Account",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
