using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreWebApi.Migrations
{
    public partial class CoreWebApiModelsVilniusQuickSnackSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 1L,
                columns: new[] { "City", "Country", "Latitude", "Longitude", "Name", "Street", "Type", "Url" },
                values: new object[] { "Vilnius", "Lithuania", 54.6724131, 25.272993499999998, "TESTER Algirdo", "Algirdo g. 53", "TESTER", "TESTER.com" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 2L,
                columns: new[] { "City", "Country", "Latitude", "Longitude", "Name", "Street", "Type", "Url" },
                values: new object[] { "Vilnius", "Lithuania", 54.729648500000003, 25.264011499999999, "TESTER Didlaukio", "Didlaukio g. 47", "TESTER", "TESTER.com" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 104L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713812500000003, 25.2959304 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 191L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713812500000003, 25.2959304 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 194L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713812500000003, 25.2959304 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 250L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713812500000003, 25.2959304 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 274L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713812500000003, 25.2959304 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 388L,
                columns: new[] { "Latitude", "Longitude", "Name", "SpecifyStreet", "Street", "Type", "Url" },
                values: new object[] { 54.680495100000002, 25.295552900000001, "Coffee1", null, "Uzupio str. 9", "Coffee & Tea, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8735568-Reviews-Coffee1-Vilnius_Vilnius_County.html" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 503L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713812500000003, 25.2959304 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 524L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713812500000003, 25.2959304 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 566L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713812500000003, 25.2959304 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 598L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713812500000003, 25.2959304 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 601L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713812500000003, 25.2959304 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 656L,
                columns: new[] { "Latitude", "Longitude", "Name", "Street", "Type", "Url" },
                values: new object[] { 54.685272099999999, 25.281969199999999, "Chaika", "Totoriu g. 7", "Coffee & Tea, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4737785-Reviews-Chaika-Vilnius_Vilnius_County.html" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 716L,
                columns: new[] { "Latitude", "Longitude", "Name", "SpecifyStreet", "Street", "Type", "Url" },
                values: new object[] { 54.677889899999997, 25.282481900000001, "Snekutis", null, "Sv. Mikalojaus g. 15", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7651726-Reviews-Snekutis-Vilnius_Vilnius_County.html" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 723L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.690502700000003, 25.280230299999999 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 792L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713812500000003, 25.2959304 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 844L,
                columns: new[] { "Latitude", "Longitude", "Name", "Street", "Type", "Url" },
                values: new object[] { 54.679189399999998, 25.284500999999999, "No Forks Mexican Grill", "Vokieciu g. 9", "Quick Bites, Mexican", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10459560-Reviews-No_Forks_Mexican_Grill-Vilnius_Vilnius_County.html" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 849L,
                columns: new[] { "Latitude", "Longitude", "Name", "Street", "Type", "Url" },
                values: new object[] { 54.679189399999998, 25.284500999999999, "Zatar", "Vokieciu g. 9", "Quick Bites, Mediterranean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8649271-Reviews-Zatar-Vilnius_Vilnius_County.html" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 897L,
                columns: new[] { "Latitude", "Longitude", "Name", "SpecifyStreet", "Street", "Type", "Url" },
                values: new object[] { 54.6822272, 25.290280500000001, "Beigelistai", "Hale market", "Literatu g. 7", "Quick Bites, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10468462-Reviews-Beigelistai-Vilnius_Vilnius_County.html" });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "RestaurantId", "City", "Country", "Latitude", "Longitude", "Name", "SpecifyStreet", "Street", "Type", "Url" },
                values: new object[,]
                {
                    { 955L, "Vilnius", "Lithuania", 54.686109799999997, 25.285978499999999, "KFC", "In front of Cathedral", "Gedimino pr. 1", "Quick Bites, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10342313-Reviews-KFC-Vilnius_Vilnius_County.html" },
                    { 954L, "Vilnius", "Lithuania", 54.687374900000002, 25.276888899999999, "Hesburger", null, "Gedimino pr. 24", "Quick Bites, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4728737-Reviews-Hesburger-Vilnius_Vilnius_County.html" },
                    { 953L, "Vilnius", "Lithuania", 54.672056499999997, 25.274210499999999, "Time4Pizza", null, "Kauno g. 16", "Quick Bites, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13414179-Reviews-Time4Pizza-Vilnius_Vilnius_County.html" },
                    { 952L, "Vilnius", "Lithuania", 54.713966900000003, 25.272621399999998, "KFC Ozas", "PPC Ozas", "Ozo g. 18", "Quick Bites, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3445962-Reviews-KFC_Ozas-Vilnius_Vilnius_County.html" },
                    { 951L, "Vilnius", "Lithuania", 54.688125999999997, 25.279601400000001, "Sushi Express", null, "Vilniaus g. 9", "Quick Bites, Japanese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10608119-Reviews-Sushi_Express-Vilnius_Vilnius_County.html" },
                    { 949L, "Vilnius", "Lithuania", 54.687499899999999, 25.2785689, "McDonald's", null, "Gedimino pr. 15", "Quick Bites, American", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10543393-Reviews-McDonald_s-Vilnius_Vilnius_County.html" },
                    { 929L, "Vilnius", "Lithuania", 54.684364500000001, 25.289748599999999, "Crustum Bakery & Cafe Pilies 4", null, "Pilies Street 4", "Coffee & Tea, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12169517-Reviews-Crustum_Bakery_Cafe_Pilies_4-Vilnius_Vilnius_County.html" },
                    { 930L, "Vilnius", "Lithuania", 54.682254899999997, 25.2658083, "Taste Map", null, "M. K. Ciurlionio 8", "Coffee & Tea, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7724682-Reviews-Taste_Map-Vilnius_Vilnius_County.html" },
                    { 931L, "Vilnius", "Lithuania", 54.684828500000002, 25.276965499999999, "Elska Coffee", "Located at the Pamenkalnis Art Gallery", "Pamenkalnio str. 1", "Coffee & Tea, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12431477-Reviews-Elska_Coffee-Vilnius_Vilnius_County.html" },
                    { 932L, "Vilnius", "Lithuania", 54.680449299999999, 25.283349900000001, "Huracan Coffee", "Vilnius, Lithuania", "Vokieciu g. 15", "Coffee & Tea, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7225990-Reviews-Huracan_Coffee-Vilnius_Vilnius_County.html" },
                    { 933L, "Vilnius", "Lithuania", 54.683882400000002, 25.2897161, "Caffeine", null, "Pilies g. 10", "Coffee & Tea, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1478355-Reviews-Caffeine-Vilnius_Vilnius_County.html" },
                    { 934L, "Vilnius", "Lithuania", 54.678435299999997, 25.286378299999999, "Italala Caffe", null, "Vokieciu g. 1", "Coffee & Tea, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13373025-Reviews-Italala_Caffe-Vilnius_Vilnius_County.html" },
                    { 935L, "Vilnius", "Lithuania", 54.704600900000003, 25.310794999999999, "Dodo Pizza Antakalnio", null, "Antakalnio g. 41", "Quick Bites, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17593336-Reviews-Dodo_Pizza_Antakalnio-Vilnius_Vilnius_County.html" },
                    { 936L, "Vilnius", "Lithuania", 54.678890000000003, 25.277615399999998, "Kavos virejai", null, "Pylimo g. 19", "Coffee & Tea, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8778806-Reviews-Kavos_virejai-Vilnius_Vilnius_County.html" },
                    { 937L, "Vilnius", "Lithuania", 54.672105100000003, 25.287405400000001, "Keule Ruke", null, "Pylimo 66", "Quick Bites, American", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7596242-Reviews-Keule_Ruke-Vilnius_Vilnius_County.html" },
                    { 950L, "Vilnius", "Lithuania", 54.672056499999997, 25.274210499999999, "Burger Kiosk", null, "Kauno Gatve 16", "Quick Bites, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13124197-Reviews-Burger_Kiosk-Vilnius_Vilnius_County.html" },
                    { 938L, "Vilnius", "Lithuania", 54.686032599999997, 25.279165599999999, "Wok to Walk", null, "Vilniaus g. 19", "Quick Bites, Thai", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6131633-Reviews-Wok_to_Walk-Vilnius_Vilnius_County.html" },
                    { 940L, "Vilnius", "Lithuania", 54.675222499999997, 25.284034200000001, "Caif Cafe", null, "50 Pylimo gatve", "Coffee & Tea, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12330794-Reviews-Caif_Cafe-Vilnius_Vilnius_County.html" },
                    { 941L, "Vilnius", "Lithuania", 54.687240699999997, 25.2818468, "Plus Plus Plus", null, "Gedimino pr. 9", "Quick Bites, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13125673-Reviews-Plus_Plus_Plus-Vilnius_Vilnius_County.html" },
                    { 942L, "Vilnius", "Lithuania", 54.680663299999999, 25.285385999999999, "Bookafe", null, "Stikliu g. 16", "Coffee & Tea, Healthy", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10299412-Reviews-Bookafe-Vilnius_Vilnius_County.html" },
                    { 943L, "Vilnius", "Lithuania", 54.6803217, 25.288816600000001, "Caffeine", null, "Didzioji g. 6", "Coffee & Tea, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12830549-Reviews-Caffeine-Vilnius_Vilnius_County.html" },
                    { 944L, "Vilnius", "Lithuania", 54.671515300000003, 25.2665574, "Meatbusters", null, "Kauno gatve 35", "Quick Bites, American", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12389273-Reviews-Meatbusters-Vilnius_Vilnius_County.html" },
                    { 945L, "Vilnius", "Lithuania", 54.678504199999999, 25.284778299999999, "Drama Burger Go", null, "Vokieciu g. 8", "Quick Bites, American", "https://www.tripadvisor.com/Restaurant_Review-g274951-d16945625-Reviews-Drama_Burger_Go-Vilnius_Vilnius_County.html" },
                    { 946L, "Vilnius", "Lithuania", 54.686378300000001, 25.276071999999999, "Downtown Food Hall & Lounge", null, "A. Smetonos g 5", "Quick Bites, Italian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15676239-Reviews-Downtown_Food_Hall_Lounge-Vilnius_Vilnius_County.html" },
                    { 947L, "Vilnius", "Lithuania", 54.687002999999997, 25.284551, "Tie kepejai", null, "Tilto g. 6", "Quick Bites", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3953023-Reviews-Tie_kepejai-Vilnius_Vilnius_County.html" },
                    { 948L, "Vilnius", "Lithuania", 54.681660000000001, 25.2657989, "Feju Kepyklele", null, "J. Basanaviciaus g. 37", "Dessert, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6495877-Reviews-Feju_Kepyklele-Vilnius_Vilnius_County.html" },
                    { 939L, "Vilnius", "Lithuania", 54.698905699999997, 25.270710399999999, "Thierry kepykla", "Quadrum Business City", "Konstitucijos 21c", "Bakeries, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12205064-Reviews-Thierry_kepykla-Vilnius_Vilnius_County.html" },
                    { 928L, "Vilnius", "Lithuania", 54.679292699999998, 25.283606200000001, "Crustum", null, "Vokieciu g. 18a", "Coffee & Tea, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10763509-Reviews-Crustum-Vilnius_Vilnius_County.html" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 928L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 929L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 930L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 931L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 932L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 933L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 934L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 935L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 936L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 937L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 938L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 939L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 940L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 941L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 942L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 943L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 944L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 945L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 946L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 947L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 948L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 949L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 950L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 951L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 952L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 953L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 954L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 955L);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 1L,
                columns: new[] { "City", "Country", "Latitude", "Longitude", "Name", "Street", "Type", "Url" },
                values: new object[] { null, null, 0.0, 0.0, "Can can", null, null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 2L,
                columns: new[] { "City", "Country", "Latitude", "Longitude", "Name", "Street", "Type", "Url" },
                values: new object[] { null, null, 0.0, 0.0, "Katpedele", null, null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 104L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713816899999998, 25.2939282 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 191L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713816899999998, 25.2939282 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 194L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713816899999998, 25.2939282 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 250L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713816899999998, 25.2939282 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 274L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713816899999998, 25.2939282 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 388L,
                columns: new[] { "Latitude", "Longitude", "Name", "SpecifyStreet", "Street", "Type", "Url" },
                values: new object[] { 54.706927499999999, 25.285181300000001, "Pizza Verde", "Suite 101 A", "Kalvariju g. 101A", "Pizza, Italian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10793017-Reviews-Pizza_Verde-Vilnius_Vilnius_County.html" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 503L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713816899999998, 25.2939282 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 524L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713816899999998, 25.2939282 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 566L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713816899999998, 25.2939282 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 598L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713816899999998, 25.2939282 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 601L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713816899999998, 25.2939282 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 656L,
                columns: new[] { "Latitude", "Longitude", "Name", "Street", "Type", "Url" },
                values: new object[] { 54.674812199999998, 25.284234900000001, "MOSS cafe", "Pylimo g. 47", "International, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17755163-Reviews-MOSS_cafe-Vilnius_Vilnius_County.html" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 716L,
                columns: new[] { "Latitude", "Longitude", "Name", "SpecifyStreet", "Street", "Type", "Url" },
                values: new object[] { 54.687240699999997, 25.2818468, "The Juice Room", "PC Ozas, 1 Aukstas", "Gedimino pr. 9", "Healthy", "https://www.tripadvisor.com/Restaurant_Review-g274951-d18995305-Reviews-The_Juice_Room-Vilnius_Vilnius_County.html" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 723L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.778562299999997, 25.091982099999999 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 792L,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 54.713816899999998, 25.2939282 });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 844L,
                columns: new[] { "Latitude", "Longitude", "Name", "Street", "Type", "Url" },
                values: new object[] { 54.6819585, 25.279805100000001, "Room", "Vilniaus g. 39", "Caribbean, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9593357-Reviews-Rhum_Room-Vilnius_Vilnius_County.html" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 849L,
                columns: new[] { "Latitude", "Longitude", "Name", "Street", "Type", "Url" },
                values: new object[] { 54.710690499999998, 25.303124199999999, "Sushi City", "S. Zukausko g. 49", "Sushi", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17756768-Reviews-Sushi_City-Vilnius_Vilnius_County.html" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 897L,
                columns: new[] { "Latitude", "Longitude", "Name", "SpecifyStreet", "Street", "Type", "Url" },
                values: new object[] { 54.681194699999999, 25.294645599999999, "Zalia Zasis", null, "Malunu g. 3", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14106298-Reviews-Zalia_Zasis-Vilnius_Vilnius_County.html" });
        }
    }
}
