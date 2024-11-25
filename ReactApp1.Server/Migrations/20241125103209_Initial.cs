using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReactApp1.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    accountId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    gebruikersNaam = table.Column<string>(type: "TEXT", nullable: false),
                    wachtwoord = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 21, nullable: false),
                    bedrijfId = table.Column<int>(type: "INTEGER", nullable: true),
                    bedrijfsNaam = table.Column<string>(type: "TEXT", nullable: true),
                    adres = table.Column<string>(type: "TEXT", nullable: true),
                    kvkNummer = table.Column<string>(type: "TEXT", nullable: true),
                    naam = table.Column<string>(type: "TEXT", nullable: true),
                    emailAdres = table.Column<string>(type: "TEXT", nullable: true),
                    HuurdersAccount_adres = table.Column<string>(type: "TEXT", nullable: true),
                    telefoonnummer = table.Column<string>(type: "TEXT", nullable: true),
                    rol = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.accountId);
                });

            migrationBuilder.CreateTable(
                name: "Autos",
                columns: table => new
                {
                    voertuigId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    dueren = table.Column<int>(type: "INTEGER", nullable: false),
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
                    gewicht = table.Column<int>(type: "INTEGER", nullable: false),
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
                name: "HuurAanvraags",
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
                    accountid = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HuurAanvraags", x => x.huurAanvraagId);
                    table.ForeignKey(
                        name: "FK_HuurAanvraags_Account_accountid",
                        column: x => x.accountid,
                        principalTable: "Account",
                        principalColumn: "accountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HuurAanvraags_accountid",
                table: "HuurAanvraags",
                column: "accountid");
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
                name: "HuurAanvraags");

            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}
