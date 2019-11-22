using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreWebApi.Migrations
{
    public partial class EFCoreCodeFirstSampleModelsEmployeeContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    RestaurantId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.RestaurantId);
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
        }
    }
}
