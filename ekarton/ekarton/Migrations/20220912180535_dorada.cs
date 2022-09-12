using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ekarton.Migrations
{
    public partial class dorada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DodjeljenDoktors",
                keyColumn: "DodjeljenDoktorId",
                keyValue: 4,
                column: "DatumOd",
                value: new DateTime(2022, 9, 12, 20, 5, 32, 436, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "DodjeljenDoktors",
                keyColumn: "DodjeljenDoktorId",
                keyValue: 5,
                column: "DatumOd",
                value: new DateTime(2022, 9, 12, 20, 5, 32, 436, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "DodjeljenDoktors",
                keyColumn: "DodjeljenDoktorId",
                keyValue: 6,
                column: "DatumOd",
                value: new DateTime(2022, 9, 12, 20, 5, 32, 436, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "DodjeljeniDoktor",
                keyColumns: new[] { "DoktorId", "PacijentId" },
                keyValues: new object[] { 3001, 5001 },
                column: "DatumOd",
                value: new DateTime(2022, 9, 12, 20, 5, 32, 432, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "DodjeljeniDoktor",
                keyColumns: new[] { "DoktorId", "PacijentId" },
                keyValues: new object[] { 3007, 5002 },
                column: "DatumOd",
                value: new DateTime(2022, 9, 12, 20, 5, 32, 432, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "DodjeljeniDoktor",
                keyColumns: new[] { "DoktorId", "PacijentId" },
                keyValues: new object[] { 3008, 5003 },
                column: "DatumOd",
                value: new DateTime(2022, 9, 12, 20, 5, 32, 432, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 1001,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "lM1Gpj1rdHyDhF7Fxq5fcuqlmIQ=", "Kpqvb9o0sZxn+Kos2k/YhA==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 1002,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "5F7/CZvqDNcPhi8ssgKB0vQ+wak=", "4v/cnQsvUOET6CoZH9uGHg==" });

            migrationBuilder.UpdateData(
                table: "KorisnikUloga",
                keyColumn: "KorisnikUlogeId",
                keyValue: 1,
                column: "DatumIzmjenje",
                value: new DateTime(2022, 9, 12, 20, 5, 32, 415, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "KorisnikUloga",
                keyColumn: "KorisnikUlogeId",
                keyValue: 2,
                column: "DatumIzmjenje",
                value: new DateTime(2022, 9, 12, 20, 5, 32, 424, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Pacijent",
                keyColumn: "PacijentId",
                keyValue: 5001,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "GtsX3j7C/tANg4EhCznbQacEL5A=", "3tm+GFvVLAQgjGAm3EInFA==" });

            migrationBuilder.UpdateData(
                table: "Pacijent",
                keyColumn: "PacijentId",
                keyValue: 5002,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "Cxzdjx+qEMmDW36fFmmiZrsKd1o=", "3tm+GFvVLAQgjGAm3EInFA==" });

            migrationBuilder.UpdateData(
                table: "Pacijent",
                keyColumn: "PacijentId",
                keyValue: 5003,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "zmbTmlw/06F0GhpfAaM2boGyRfM=", "3tm+GFvVLAQgjGAm3EInFA==" });

            migrationBuilder.UpdateData(
                table: "PacijentOsiguranje",
                keyColumn: "PacijentOsiguranjeId",
                keyValue: 3,
                column: "DatumOsiguranja",
                value: new DateTime(2022, 9, 12, 20, 5, 32, 432, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "PacijentOsiguranje",
                keyColumn: "PacijentOsiguranjeId",
                keyValue: 4,
                column: "DatumOsiguranja",
                value: new DateTime(2022, 9, 12, 20, 5, 32, 432, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "PacijentOsiguranje",
                keyColumn: "PacijentOsiguranjeId",
                keyValue: 5,
                column: "DatumOsiguranja",
                value: new DateTime(2022, 9, 12, 20, 5, 32, 432, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Pregled",
                keyColumn: "PregledId",
                keyValue: 6110,
                column: "Datum",
                value: new DateTime(2022, 9, 12, 20, 5, 32, 433, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Terapija",
                keyColumn: "TerapijaId",
                keyValue: 6001,
                columns: new[] { "DO", "OD" },
                values: new object[] { new DateTime(2022, 9, 19, 20, 5, 32, 433, DateTimeKind.Local).AddTicks(1241), new DateTime(2022, 9, 12, 20, 5, 32, 433, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 7110,
                column: "Datum",
                value: new DateTime(2022, 9, 12, 20, 5, 32, 434, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Uputnica",
                keyColumn: "UputnicaId",
                keyValue: 6100,
                column: "Datum",
                value: new DateTime(2022, 9, 14, 20, 5, 32, 433, DateTimeKind.Local).AddTicks(4423));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DodjeljenDoktors",
                keyColumn: "DodjeljenDoktorId",
                keyValue: 4,
                column: "DatumOd",
                value: new DateTime(2022, 9, 11, 19, 13, 39, 955, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "DodjeljenDoktors",
                keyColumn: "DodjeljenDoktorId",
                keyValue: 5,
                column: "DatumOd",
                value: new DateTime(2022, 9, 11, 19, 13, 39, 955, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "DodjeljenDoktors",
                keyColumn: "DodjeljenDoktorId",
                keyValue: 6,
                column: "DatumOd",
                value: new DateTime(2022, 9, 11, 19, 13, 39, 955, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "DodjeljeniDoktor",
                keyColumns: new[] { "DoktorId", "PacijentId" },
                keyValues: new object[] { 3001, 5001 },
                column: "DatumOd",
                value: new DateTime(2022, 9, 11, 19, 13, 39, 947, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "DodjeljeniDoktor",
                keyColumns: new[] { "DoktorId", "PacijentId" },
                keyValues: new object[] { 3007, 5002 },
                column: "DatumOd",
                value: new DateTime(2022, 9, 11, 19, 13, 39, 947, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "DodjeljeniDoktor",
                keyColumns: new[] { "DoktorId", "PacijentId" },
                keyValues: new object[] { 3008, 5003 },
                column: "DatumOd",
                value: new DateTime(2022, 9, 11, 19, 13, 39, 947, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 1001,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "PMrjcrYtuedM8P3LbG24ooLB7aY=", "9fj9KknDkxyydNu/jPz+pQ==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 1002,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "yLYuAOt4Di8zitr6VSIw4AE2CbE=", "wUcZwkU9yTQTATwSKR70nA==" });

            migrationBuilder.UpdateData(
                table: "KorisnikUloga",
                keyColumn: "KorisnikUlogeId",
                keyValue: 1,
                column: "DatumIzmjenje",
                value: new DateTime(2022, 9, 11, 19, 13, 39, 926, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "KorisnikUloga",
                keyColumn: "KorisnikUlogeId",
                keyValue: 2,
                column: "DatumIzmjenje",
                value: new DateTime(2022, 9, 11, 19, 13, 39, 936, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Pacijent",
                keyColumn: "PacijentId",
                keyValue: 5001,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "8x/qobY6Ga+Oq8KGWQJB/I+ccxo=", "aFxdJv9B48K7/LtOFe6a7A==" });

            migrationBuilder.UpdateData(
                table: "Pacijent",
                keyColumn: "PacijentId",
                keyValue: 5002,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "yoampmSNnBaQ6HZhYhI+Pzsn/vA=", "aFxdJv9B48K7/LtOFe6a7A==" });

            migrationBuilder.UpdateData(
                table: "Pacijent",
                keyColumn: "PacijentId",
                keyValue: 5003,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "eyAthJOWVRbilkKlzwTk/A4aduQ=", "aFxdJv9B48K7/LtOFe6a7A==" });

            migrationBuilder.UpdateData(
                table: "PacijentOsiguranje",
                keyColumn: "PacijentOsiguranjeId",
                keyValue: 3,
                column: "DatumOsiguranja",
                value: new DateTime(2022, 9, 11, 19, 13, 39, 948, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "PacijentOsiguranje",
                keyColumn: "PacijentOsiguranjeId",
                keyValue: 4,
                column: "DatumOsiguranja",
                value: new DateTime(2022, 9, 11, 19, 13, 39, 948, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "PacijentOsiguranje",
                keyColumn: "PacijentOsiguranjeId",
                keyValue: 5,
                column: "DatumOsiguranja",
                value: new DateTime(2022, 9, 11, 19, 13, 39, 948, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Pregled",
                keyColumn: "PregledId",
                keyValue: 6110,
                column: "Datum",
                value: new DateTime(2022, 9, 11, 19, 13, 39, 950, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "Terapija",
                keyColumn: "TerapijaId",
                keyValue: 6001,
                columns: new[] { "DO", "OD" },
                values: new object[] { new DateTime(2022, 9, 18, 19, 13, 39, 949, DateTimeKind.Local).AddTicks(1980), new DateTime(2022, 9, 11, 19, 13, 39, 949, DateTimeKind.Local).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 7110,
                column: "Datum",
                value: new DateTime(2022, 9, 11, 19, 13, 39, 951, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Uputnica",
                keyColumn: "UputnicaId",
                keyValue: 6100,
                column: "Datum",
                value: new DateTime(2022, 9, 13, 19, 13, 39, 949, DateTimeKind.Local).AddTicks(7177));
        }
    }
}
