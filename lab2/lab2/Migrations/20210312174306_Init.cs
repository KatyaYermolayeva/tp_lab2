using Microsoft.EntityFrameworkCore.Migrations;

namespace lab2.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "customer");

            migrationBuilder.RenameColumn(
                name: "Weight",
                table: "customer",
                newName: "weight");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "customer",
                newName: "surname");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "customer",
                newName: "street");

            migrationBuilder.RenameColumn(
                name: "Region",
                table: "customer",
                newName: "region");

            migrationBuilder.RenameColumn(
                name: "Postcode",
                table: "customer",
                newName: "postcode");

            migrationBuilder.RenameColumn(
                name: "Nationality",
                table: "customer",
                newName: "nationality");

            migrationBuilder.RenameColumn(
                name: "House",
                table: "customer",
                newName: "house");

            migrationBuilder.RenameColumn(
                name: "Height",
                table: "customer",
                newName: "height");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "customer",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "Flat",
                table: "customer",
                newName: "flat");

            migrationBuilder.RenameColumn(
                name: "District",
                table: "customer",
                newName: "district");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "customer",
                newName: "country");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "customer",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "customer",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SecondName",
                table: "customer",
                newName: "second_name");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "customer",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "customer",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "CreditCardNumber",
                table: "customer",
                newName: "credit_card_number");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "customer",
                newName: "birth_date");

            migrationBuilder.RenameColumn(
                name: "BankAccountNumber",
                table: "customer",
                newName: "bank_account_number");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customer",
                table: "customer",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_customer",
                table: "customer");

            migrationBuilder.RenameTable(
                name: "customer",
                newName: "Customers");

            migrationBuilder.RenameColumn(
                name: "weight",
                table: "Customers",
                newName: "Weight");

            migrationBuilder.RenameColumn(
                name: "surname",
                table: "Customers",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "street",
                table: "Customers",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "region",
                table: "Customers",
                newName: "Region");

            migrationBuilder.RenameColumn(
                name: "postcode",
                table: "Customers",
                newName: "Postcode");

            migrationBuilder.RenameColumn(
                name: "nationality",
                table: "Customers",
                newName: "Nationality");

            migrationBuilder.RenameColumn(
                name: "house",
                table: "Customers",
                newName: "House");

            migrationBuilder.RenameColumn(
                name: "height",
                table: "Customers",
                newName: "Height");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "Customers",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "flat",
                table: "Customers",
                newName: "Flat");

            migrationBuilder.RenameColumn(
                name: "district",
                table: "Customers",
                newName: "District");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "Customers",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Customers",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Customers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "second_name",
                table: "Customers",
                newName: "SecondName");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "Customers",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "Customers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "credit_card_number",
                table: "Customers",
                newName: "CreditCardNumber");

            migrationBuilder.RenameColumn(
                name: "birth_date",
                table: "Customers",
                newName: "BirthDate");

            migrationBuilder.RenameColumn(
                name: "bank_account_number",
                table: "Customers",
                newName: "BankAccountNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");
        }
    }
}
