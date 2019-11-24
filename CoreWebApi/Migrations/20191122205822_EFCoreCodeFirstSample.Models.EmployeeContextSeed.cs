using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreWebApi.Migrations
{
    public partial class EFCoreCodeFirstSampleModelsEmployeeContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "RestaurantId", "Name" },
                values: new object[] { 1L, "Can can" });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "RestaurantId", "Name" },
                values: new object[] { 2L, "Katpedele" });

            migrationBuilder.InsertData(
                table: "Evaluation",
                columns: new[] { "EvaluationId", "Experience", "MoodRating", "Price", "RestaurantId", "UserId" },
                values: new object[] { 1L, 3.3m, 4.2m, 1.5m, 1L, 1L });

            migrationBuilder.InsertData(
                table: "Evaluation",
                columns: new[] { "EvaluationId", "Experience", "MoodRating", "Price", "RestaurantId", "UserId" },
                values: new object[] { 2L, 4.23m, 1.55m, 6.23m, 2L, 2L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Evaluation",
                keyColumn: "EvaluationId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 2L);
        }
    }
}
