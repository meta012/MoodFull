using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreWebApi.Migrations
{
    public partial class CoreWebApiModelsRestaurantInfoUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Restaurant",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Restaurant",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Restaurant",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Restaurant",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Restaurant",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "SpecifyStreet",
                table: "Restaurant",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Restaurant",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Restaurant",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Restaurant",
                maxLength: 400,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "SpecifyStreet",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Restaurant");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Restaurant",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150);
        }
    }
}
