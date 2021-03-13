using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace lab2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Surname = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    SecondName = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<bool>(type: "boolean", nullable: false),
                    Nationality = table.Column<string>(type: "text", nullable: true),
                    Height = table.Column<double>(type: "double precision", nullable: false),
                    Weight = table.Column<double>(type: "double precision", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    Postcode = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    Region = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    Street = table.Column<string>(type: "text", nullable: true),
                    House = table.Column<int>(type: "integer", nullable: false),
                    Flat = table.Column<int>(type: "integer", nullable: true),
                    CreditCardNumber = table.Column<string>(type: "text", nullable: true),
                    BankAccountNumber = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BankAccountNumber", "BirthDate", "City", "Country", "CreditCardNumber", "District", "FirstName", "Flat", "Gender", "Height", "House", "Nationality", "PhoneNumber", "Postcode", "Region", "SecondName", "Street", "Surname", "Weight" },
                values: new object[,]
                {
                    { 1, "32784872371", new DateTime(1990, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minsk", "Belarus", "byt23473hfw73", "Minsky", "Ivan", 117, true, 1.8, 23, "Belarusian", "375291234567", "220076", "Minsky", "Ivanovich", "Slobodskaya", "Ivanov", 79.5 },
                    { 2, "12874981209", new DateTime(1987, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brest", "Belarus", "zdr69365ysl15", "Brestsky", "Petr", 2, true, 1.6699999999999999, 15, "Belarusian", "375447851287", "220076", "Brestsky", "Petrovich", "Pushkina", "Petrov", 65.299999999999997 },
                    { 3, "41409212945", new DateTime(2003, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minsk", "Belarus", "top63398orp16", "Minsky", "Anna", 213, false, 1.6499999999999999, 7, "Belarusian", "375298365509", "220076", "Minsky", "Ivanovna", "Pobedy square", "Ivanova", 89.099999999999994 },
                    { 4, "22973076899", new DateTime(1997, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gomel", "Belarus", "iiu89017zzk22", "Gomelsky", "Miron", 23, true, 1.8, 4, "Belarusian", "375338175098", "220076", "Gomelsky", "Semenovich", "Dzerzhinskogo", "Smirnov", 89.219999999999999 },
                    { 5, "16329993456", new DateTime(1995, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soligorsk", "Belarus", "wer46709odk92", "Soligorsky", "Vladimir", 55, true, 1.8899999999999999, 81, "Belarusian", "375292340987", "220076", "Minsky", "Igorevich", "Lenina", "Kotov", 100.3 },
                    { 6, "27382991203", new DateTime(2000, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brest", "Belarus", "byi32784lao63", "Brestsky", "Maria", 64, false, 1.6499999999999999, 17, "Belarusian", "375445679876", "220076", "Brestsky", "Mihailovna", "Volodarskogo", "Petrova", 59.0 },
                    { 7, "34729502493", new DateTime(1984, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brest", "Belarus", "off11874oqi81", "Brestsky", "Svetlana", 87, false, 1.71, 22, "Belarusian", "375291718190", "220076", "Brestsky", "Stepanovna", "Morozova", "Smirnova", 71.299999999999997 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
