using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreWebApi.Migrations
{
    public partial class CoreWebApiModelsAddTesterSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    RestaurantId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Url = table.Column<string>(maxLength: 400, nullable: true),
                    Type = table.Column<string>(maxLength: 100, nullable: true),
                    Street = table.Column<string>(maxLength: 200, nullable: true),
                    SpecifyStreet = table.Column<string>(maxLength: 200, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.RestaurantId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    UserType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Evaluation",
                columns: table => new
                {
                    EvaluationId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MoodRating = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    Experience = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    RestaurantId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluation", x => x.EvaluationId);
                    table.ForeignKey(
                        name: "FK_Evaluation_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evaluation_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "RestaurantId", "City", "Country", "Latitude", "Longitude", "Name", "SpecifyStreet", "Street", "Type", "Url" },
                values: new object[,]
                {
                    { 1L, "Vilnius", "Lithuania", 54.6724131, 25.272993499999998, "TESTER Algirdo", null, "Algirdo g. 53", "TESTER", "TESTER.com" },
                    { 2L, "Vilnius", "Lithuania", 54.729648500000003, 25.264011499999999, "TESTER Didlaukio", null, "Didlaukio g. 47", "TESTER", "TESTER.com" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "UserType", "Username" },
                values: new object[,]
                {
                    { 1L, "admin", "admin", "admin", 1, "admin" },
                    { 2L, "labas", "lab", "labaslabas", 2, "labas" }
                });

            migrationBuilder.InsertData(
                table: "Evaluation",
                columns: new[] { "EvaluationId", "Experience", "MoodRating", "Price", "RestaurantId", "UserId" },
                values: new object[] { 1L, 3.3m, 4.2m, 1.5m, 1L, 1L });

            migrationBuilder.InsertData(
                table: "Evaluation",
                columns: new[] { "EvaluationId", "Experience", "MoodRating", "Price", "RestaurantId", "UserId" },
                values: new object[] { 2L, 4.23m, 1.55m, 6.23m, 2L, 2L });

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_RestaurantId",
                table: "Evaluation",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_UserId",
                table: "Evaluation",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluation");

            migrationBuilder.DropTable(
                name: "Restaurant");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
