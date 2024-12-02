using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReactApp1.Server.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Wachtwoord = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 21, nullable: false),
                    bedrijfId = table.Column<int>(type: "INTEGER", nullable: true),
                    bedrijfsNaam = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    bedrijfAdres = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    kvkNummer = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Naam = table.Column<string>(type: "TEXT", nullable: true),
                    EmailAdres = table.Column<string>(type: "TEXT", nullable: true),
                    Adres = table.Column<string>(type: "TEXT", nullable: true),
                    Telefoonnummer = table.Column<string>(type: "TEXT", nullable: true),
                    rol = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "Autos",
                columns: table => new
                {
                    voertuigId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    aantalDeuren = table.Column<int>(type: "INTEGER", nullable: false),
                    merk = table.Column<string>(type: "TEXT", nullable: false),
                    type = table.Column<string>(type: "TEXT", nullable: false),
                    status = table.Column<string>(type: "TEXT", nullable: false),
                    aanschafJaar = table.Column<int>(type: "INTEGER", nullable: false),
                    kleur = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autos", x => x.voertuigId);
                });

            migrationBuilder.CreateTable(
                name: "Campers",
                columns: table => new
                {
                    voertuigId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    heeftToilet = table.Column<bool>(type: "INTEGER", nullable: false),
                    merk = table.Column<string>(type: "TEXT", nullable: false),
                    type = table.Column<string>(type: "TEXT", nullable: false),
                    status = table.Column<string>(type: "TEXT", nullable: false),
                    aanschafJaar = table.Column<int>(type: "INTEGER", nullable: false),
                    kleur = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campers", x => x.voertuigId);
                });

            migrationBuilder.CreateTable(
                name: "Caravans",
                columns: table => new
                {
                    voertuigId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    aantalBedden = table.Column<int>(type: "INTEGER", nullable: false),
                    merk = table.Column<string>(type: "TEXT", nullable: false),
                    type = table.Column<string>(type: "TEXT", nullable: false),
                    status = table.Column<string>(type: "TEXT", nullable: false),
                    aanschafJaar = table.Column<int>(type: "INTEGER", nullable: false),
                    kleur = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caravans", x => x.voertuigId);
                });

            migrationBuilder.CreateTable(
                name: "HuurAanvragen",
                columns: table => new
                {
                    huurAanvraagId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    postcode = table.Column<string>(type: "TEXT", nullable: false),
                    huisnummer = table.Column<int>(type: "INTEGER", nullable: false),
                    straatnaam = table.Column<string>(type: "TEXT", nullable: false),
                    rijbewijsnummer = table.Column<int>(type: "INTEGER", nullable: false),
                    huurreden = table.Column<string>(type: "TEXT", nullable: false),
                    eindbestemming = table.Column<string>(type: "TEXT", nullable: false),
                    verwachtingreisafstand = table.Column<int>(type: "INTEGER", nullable: false),
                    accountid = table.Column<int>(type: "INTEGER", nullable: false),
                    BedrijfsAccountAccountId = table.Column<int>(type: "INTEGER", nullable: true),
                    HuurdersAccountAccountId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HuurAanvragen", x => x.huurAanvraagId);
                    table.ForeignKey(
                        name: "FK_HuurAanvragen_Account_BedrijfsAccountAccountId",
                        column: x => x.BedrijfsAccountAccountId,
                        principalTable: "Account",
                        principalColumn: "AccountId");
                    table.ForeignKey(
                        name: "FK_HuurAanvragen_Account_HuurdersAccountAccountId",
                        column: x => x.HuurdersAccountAccountId,
                        principalTable: "Account",
                        principalColumn: "AccountId");
                    table.ForeignKey(
                        name: "FK_HuurAanvragen_Account_accountid",
                        column: x => x.accountid,
                        principalTable: "Account",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HuurAanvragen_accountid",
                table: "HuurAanvragen",
                column: "accountid");

            migrationBuilder.CreateIndex(
                name: "IX_HuurAanvragen_BedrijfsAccountAccountId",
                table: "HuurAanvragen",
                column: "BedrijfsAccountAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_HuurAanvragen_HuurdersAccountAccountId",
                table: "HuurAanvragen",
                column: "HuurdersAccountAccountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autos");

            migrationBuilder.DropTable(
                name: "Campers");

            migrationBuilder.DropTable(
                name: "Caravans");

            migrationBuilder.DropTable(
                name: "HuurAanvragen");

            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}
