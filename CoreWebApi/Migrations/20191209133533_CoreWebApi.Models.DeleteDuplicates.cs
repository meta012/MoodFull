using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreWebApi.Migrations
{
    public partial class CoreWebApiModelsDeleteDuplicates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 955L);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 716L,
                columns: new[] { "Latitude", "Longitude", "Name", "SpecifyStreet", "Street", "Type", "Url" },
                values: new object[] { 54.686109799999997, 25.285978499999999, "KFC", "In front of Cathedral", "Gedimino pr. 1", "Quick Bites, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10342313-Reviews-KFC-Vilnius_Vilnius_County.html" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 716L,
                columns: new[] { "Latitude", "Longitude", "Name", "SpecifyStreet", "Street", "Type", "Url" },
                values: new object[] { 54.677889899999997, 25.282481900000001, "Snekutis", null, "Sv. Mikalojaus g. 15", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7651726-Reviews-Snekutis-Vilnius_Vilnius_County.html" });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "RestaurantId", "City", "Country", "Latitude", "Longitude", "Name", "SpecifyStreet", "Street", "Type", "Url" },
                values: new object[] { 955L, "Vilnius", "Lithuania", 54.686109799999997, 25.285978499999999, "KFC", "In front of Cathedral", "Gedimino pr. 1", "Quick Bites, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10342313-Reviews-KFC-Vilnius_Vilnius_County.html" });
        }
    }
}
