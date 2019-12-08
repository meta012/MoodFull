using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreWebApi.Migrations
{
    public partial class CoreWebApiModelsRestaurantSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "RestaurantId", "City", "Country", "Latitude", "Longitude", "Name", "SpecifyStreet", "Street", "Type", "Url" },
                values: new object[,]
                {
                    { 100L, "Vilnius", "Lithuania", 54.681864099999999, 25.2892604, "Amandus", "At Hotel Artagonist", "Pilies str. 34", "European, Central European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12578836-Reviews-Amandus-Vilnius_Vilnius_County.html" },
                    { 646L, "Vilnius", "Lithuania", 54.689301499999999, 25.275857899999998, "Mr. Pub", null, "A. Jaksto g 9", "British", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19272039-Reviews-Mr_Pub-Vilnius_Vilnius_County.html" },
                    { 647L, "Vilnius", "Lithuania", 54.679419600000003, 25.288235100000001, "SOMA cafe", null, "Saviciaus g. 2", "Indian, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19416117-Reviews-SOMA_cafe-Vilnius_Vilnius_County.html" },
                    { 648L, "Vilnius", "Lithuania", 54.672056499999997, 25.274210499999999, "Hot Wings", "Uptown Bazaar", "Kauno g. 16", "Mexican, American", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13284285-Reviews-Hot_Wings-Vilnius_Vilnius_County.html" },
                    { 649L, "Vilnius", "Lithuania", 54.693901500000003, 25.2889351, "Baltas dobilas", null, "Rinktines str. 5", "Wine Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19368748-Reviews-Baltas_dobilas-Vilnius_Vilnius_County.html" },
                    { 650L, "Vilnius", "Lithuania", 54.676506400000001, 25.289740399999999, "Apuokas", null, "Subaciaus g. 6", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19003697-Reviews-Apuokas-Vilnius_Vilnius_County.html" },
                    { 651L, "Vilnius", "Lithuania", 54.684878900000001, 25.292781000000002, "La Kavine Pas Erlicka", null, "Maironio g. 1", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d7217171-Reviews-La_Kavine_Pas_Erlicka-Vilnius_Vilnius_County.html" },
                    { 652L, "Vilnius", "Lithuania", 54.688955200000002, 25.275873900000001, "UAB \"Akivaras\"", null, "A. Jaksto g 5", "European, Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10458759-Reviews-UAB_Akivaras-Vilnius_Vilnius_County.html" },
                    { 653L, "Vilnius", "Lithuania", 54.740131099999999, 25.2746067, "Sushi Out Jeruzale", null, "Jeruzales g. 4", "Japanese, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19319280-Reviews-Sushi_Out_Jeruzale-Vilnius_Vilnius_County.html" },
                    { 654L, "Vilnius", "Lithuania", 54.720227999999999, 25.244045700000001, "Hesburger Vilnius Ukmerges", null, "Ukmerges str. 238", "American, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13835228-Reviews-Hesburger_Vilnius_Ukmerges-Vilnius_Vilnius_County.html" },
                    { 655L, "Vilnius", "Lithuania", 54.690783000000003, 25.2769899, "Skalvijos Bufetas", null, "A. Gostauto g 2", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19210771-Reviews-Skalvijos_Bufetas-Vilnius_Vilnius_County.html" },
                    { 656L, "Vilnius", "Lithuania", 54.674812199999998, 25.284234900000001, "MOSS cafe", null, "Pylimo g. 47", "International, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17755163-Reviews-MOSS_cafe-Vilnius_Vilnius_County.html" },
                    { 657L, "Vilnius", "Lithuania", 54.681183500000003, 25.272274800000002, "B15 Gastrobaras", null, "J. Basanaviciaus g. 15", "Italian, French", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13834116-Reviews-B15_Gastrobaras-Vilnius_Vilnius_County.html" },
                    { 658L, "Vilnius", "Lithuania", 54.715215800000003, 25.296279299999998, "Can Can Pizza", "Outlet Parkas", "Lakunu g. 14B", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d19117427-Reviews-Can_Can_Pizza-Vilnius_Vilnius_County.html" },
                    { 659L, "Vilnius", "Lithuania", 54.686568200000004, 25.281063100000001, "Room 12 Lounge Restaurant", "Congress Avenue Hotel", "Gedimino pr. 12", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19241016-Reviews-Room_12_Lounge_Restaurant-Vilnius_Vilnius_County.html" },
                    { 660L, "Vilnius", "Lithuania", 54.675823899999997, 25.2721059, "Pekinas", null, "Algirdo 28", "Chinese, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1913856-Reviews-Pekinas-Vilnius_Vilnius_County.html" },
                    { 661L, "Vilnius", "Lithuania", 54.674317899999998, 25.283996999999999, "Cafe Pizzeria Bellissimo", null, "Geliu g. 4", "Pizza, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8084306-Reviews-Cafe_Pizzeria_Bellissimo-Vilnius_Vilnius_County.html" },
                    { 662L, "Vilnius", "Lithuania", 54.739916899999997, 25.220011, "Viva Pizza & Viva Sushi & Viva Wok", null, "Perkunkiemio gatve 13", "Italian, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15660655-Reviews-Viva_Pizza_Viva_Sushi_Viva_Wok-Vilnius_Vilnius_County.html" },
                    { 663L, "Vilnius", "Lithuania", 54.750630399999999, 25.264888200000001, "Skonio Slenis", "BOD building", "Mokslininku g. 6A", "French, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7330799-Reviews-Skonio_Slenis-Vilnius_Vilnius_County.html" },
                    { 664L, "Vilnius", "Lithuania", 54.710690499999998, 25.303124199999999, "Sushi City", null, "S. Zukausko str. 49", "Japanese, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17756729-Reviews-Sushi_City-Vilnius_Vilnius_County.html" },
                    { 665L, "Vilnius", "Lithuania", 54.698293999999997, 25.3108732, "Taste Map Coffee Park", "Vilnius Tech Park, Sapiegų Rūmų Parke", "Antakalnio g. 17", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14925291-Reviews-Taste_Map_Coffee_Park-Vilnius_Vilnius_County.html" },
                    { 666L, "Vilnius", "Lithuania", 54.700393900000002, 25.257780100000002, "Steaksupply", "SC Panorama Gourmet", "Saltoniskiu St 9", "American, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15094376-Reviews-Steaksupply-Vilnius_Vilnius_County.html" },
                    { 645L, "Vilnius", "Lithuania", 54.689130900000002, 25.266751899999999, "InContro Hot Pot", null, "Gedimino pr. 46", "International", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10626886-Reviews-InContro_Hot_Pot-Vilnius_Vilnius_County.html" },
                    { 644L, "Vilnius", "Lithuania", 54.687240699999997, 25.2818468, "Sriubos namai", "Gediminas 9, Second floor", "Gedimino pr. 9", "Cafe, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3436669-Reviews-Sriubos_namai-Vilnius_Vilnius_County.html" },
                    { 643L, "Vilnius", "Lithuania", 54.6731081, 25.2736673, "Dou Asia", null, "Kauno gatve 13", "Asian, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15285643-Reviews-Dou_Asia-Vilnius_Vilnius_County.html" },
                    { 642L, "Vilnius", "Lithuania", 54.6955867, 25.281877900000001, "Cavallino Cafe", "#5", "Kalvariju g. 23", "European, Central European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13372926-Reviews-Cavallino_Cafe-Vilnius_Vilnius_County.html" },
                    { 620L, "Vilnius", "Lithuania", 54.679993199999998, 25.278229499999998, "Izgara", null, "Traku g. 2", "Mediterranean, Barbecue", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15212025-Reviews-Izgara-Vilnius_Vilnius_County.html" },
                    { 621L, "Vilnius", "Lithuania", 54.686914999999999, 25.2827509, "Pylimelis", null, "Gedimino pr. 7", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d7004290-Reviews-Pylimelis-Vilnius_Vilnius_County.html" },
                    { 622L, "Vilnius", "Lithuania", 54.713966900000003, 25.272621399999998, "2Bistro + Grill", null, "Ozo g. 18", "European, Grill", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6691511-Reviews-2Bistro_Grill-Vilnius_Vilnius_County.html" },
                    { 623L, "Vilnius", "Lithuania", 54.680880999999999, 25.270154999999999, "Pekino Antis", null, "Algirdo g. 2", "Chinese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7727928-Reviews-Pekino_Antis-Vilnius_Vilnius_County.html" },
                    { 624L, "Vilnius", "Lithuania", 54.693894999999998, 25.276167999999998, "CanCan Pizza", "Vcup", "Upes g. 9", "Pizza, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10832932-Reviews-CanCan_Pizza-Vilnius_Vilnius_County.html" },
                    { 625L, "Vilnius", "Lithuania", 54.680619800000002, 25.296227500000001, "Pane e Vino", null, "Uzupio g. 13", "Italian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12254450-Reviews-Pane_e_Vino-Vilnius_Vilnius_County.html" },
                    { 626L, "Vilnius", "Lithuania", 54.700393900000002, 25.257780100000002, "Ali sokoladine", null, "Saltoniskiu g. 9", "French, Belgian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12668357-Reviews-Ali_sokoladine-Vilnius_Vilnius_County.html" },
                    { 627L, "Vilnius", "Lithuania", 54.681194699999999, 25.294645599999999, "Zalia Zasis", null, "Malunu g. 3", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14107717-Reviews-Zalia_Zasis-Vilnius_Vilnius_County.html" },
                    { 628L, "Vilnius", "Lithuania", 54.687155500000003, 25.279651399999999, "Baras Senas Radijas", "Ausros Vartu 27", null, "Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8723802-Reviews-Baras_Senas_Radijas-Vilnius_Vilnius_County.html" },
                    { 629L, "Vilnius", "Lithuania", 54.6818484, 25.2669493, "Intriga Cafe-Bar", null, "J. Basanaviciaus g. 31", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d6876204-Reviews-Intriga_Cafe_Bar-Vilnius_Vilnius_County.html" },
                    { 667L, "Vilnius", "Lithuania", 54.724448700000003, 25.321181500000002, "Stories Cafe", null, "Nemencines pl. 4C", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15513806-Reviews-Stories_Cafe-Vilnius_Vilnius_County.html" },
                    { 630L, "Vilnius", "Lithuania", 54.677646000000003, 25.284275000000001, "Rhapsody GastroPub", null, "Mesiniu g. 3", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17351580-Reviews-Rhapsody_GastroPub-Vilnius_Vilnius_County.html" },
                    { 632L, "Vilnius", "Lithuania", 54.743764300000002, 25.277014300000001, "Medziotoju restoranas", null, "Jeruzales g. 16", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d12255497-Reviews-Medziotoju_restoranas-Vilnius_Vilnius_County.html" },
                    { 633L, "Vilnius", "Lithuania", 54.676273000000002, 25.266401699999999, "Inn 555", null, "T. Sevcenkos g. 16F", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1155432-Reviews-Inn_555-Vilnius_Vilnius_County.html" },
                    { 634L, "Vilnius", "Lithuania", 54.686047000000002, 25.2797363, "Faksas Under Vilnius", null, "Vilniaus g. 12", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d12197677-Reviews-Faksas_Under_Vilnius-Vilnius_Vilnius_County.html" },
                    { 635L, "Vilnius", "Lithuania", 54.7254887, 25.232714300000001, "Simo Baras", null, "Zemynos 26", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12502906-Reviews-Simo_Baras-Vilnius_Vilnius_County.html" },
                    { 636L, "Vilnius", "Lithuania", 54.673070099999997, 25.2838876, "Station 24", null, "Sodu g. 8", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11896510-Reviews-Station_24-Vilnius_Vilnius_County.html" },
                    { 637L, "Vilnius", "Lithuania", 54.7250759, 25.342369000000001, "PAS TA, restoranas-picerija", null, "Sauletekio al. 43", "Italian, American", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7316600-Reviews-PAS_TA_restoranas_picerija-Vilnius_Vilnius_County.html" },
                    { 638L, "Vilnius", "Lithuania", 54.692930099999998, 25.277095899999999, "BAR'za", null, "Upes g. 5", "Seafood, Grill", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4830853-Reviews-BAR_za-Vilnius_Vilnius_County.html" },
                    { 639L, "Vilnius", "Lithuania", 54.7197891, 25.299649299999999, "Fokus Pizza", null, "Kareiviu g. 14", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7359703-Reviews-Fokus_Pizza-Vilnius_Vilnius_County.html" },
                    { 640L, "Vilnius", "Lithuania", 54.674885099999997, 25.2834246, "Charpentier", null, "Geliu g. 3", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d12592978-Reviews-Charpentier-Vilnius_Vilnius_County.html" },
                    { 641L, "Vilnius", "Lithuania", 54.678324799999999, 25.2772507, "Tabera", null, "Pylimo g. 23", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11671408-Reviews-Tabera-Vilnius_Vilnius_County.html" },
                    { 631L, "Vilnius", "Lithuania", 54.683084000000001, 25.235931799999999, "Vingio Istorijos", "Vingio Parkas", "M. K. Ciurlionio g. 100", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8797829-Reviews-Vingio_Istorijos-Vilnius_Vilnius_County.html" },
                    { 668L, "Vilnius", "Lithuania", 54.693925100000001, 25.276128400000001, "Hesburger", null, "Konstitucijos pr. 16", "American", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14784928-Reviews-Hesburger-Vilnius_Vilnius_County.html" },
                    { 669L, "Vilnius", "Lithuania", 54.717767100000003, 25.299606399999998, "Steak for Break", null, "Kareiviu g. 11B", "Italian, Steakhouse", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15744102-Reviews-Steak_for_Break-Vilnius_Vilnius_County.html" },
                    { 670L, "Vilnius", "Lithuania", 54.686205999999999, 25.275113000000001, "White House", null, "A. Stulginskio g. 8", "Mediterranean, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6877642-Reviews-White_House-Vilnius_Vilnius_County.html" },
                    { 697L, "Vilnius", "Lithuania", 54.686700999999999, 25.283262000000001, "Cafe Kaciu Kavine", null, "Gedimino pr. 5", "Cafe, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7288639-Reviews-Cat_Cafe_KaciU_Kavine-Vilnius_Vilnius_County.html" },
                    { 698L, "Vilnius", "Lithuania", 54.666699299999998, 25.255718900000002, "Klivija", null, "Paneriu, 51", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d12009427-Reviews-Klivija-Vilnius_Vilnius_County.html" },
                    { 699L, "Vilnius", "Lithuania", 54.680116300000002, 25.277155100000002, "Mama food - take away", "J. Basanaviciaus Str.3", "J.Basanaviciaus Str.3", "European, Grill", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11912208-Reviews-Mama_food_take_away-Vilnius_Vilnius_County.html" },
                    { 700L, "Vilnius", "Lithuania", 54.727717699999999, 25.236215300000001, "Wraperia Suppa Kebs", null, "Laisves pr. 125", "Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12806019-Reviews-Wraperia_Suppa_Kebs-Vilnius_Vilnius_County.html" },
                    { 701L, "Vilnius", "Lithuania", 54.675206299999999, 25.309715499999999, "Tres Baracudos Pub", null, "Subaciaus g. 15", "Grill, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9568155-Reviews-Tres_Baracudos_Pub-Vilnius_Vilnius_County.html" },
                    { 702L, "Vilnius", "Lithuania", 54.694402599999997, 25.226134600000002, "Elguva gurmanams", null, "I. Simulionio g. 5", "Japanese, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10458908-Reviews-Elguva_gurmanams-Vilnius_Vilnius_County.html" },
                    { 703L, "Vilnius", "Lithuania", 54.678896299999998, 25.2839761, "Senolui Kepyklele", null, "Vokieciu g. 14", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d11674386-Reviews-Senolui_Kepyklele-Vilnius_Vilnius_County.html" },
                    { 704L, "Vilnius", "Lithuania", 54.689608900000003, 25.266162999999999, "Laiko virtuve", null, "Gedimino pr. 43", "Sushi", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10498569-Reviews-Laiko_virtuve-Vilnius_Vilnius_County.html" },
                    { 705L, "Vilnius", "Lithuania", 54.686032599999997, 25.279165599999999, "Sushi City", null, "Vilniaus g. 19", "Japanese, Sushi", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12728469-Reviews-Sushi_City-Vilnius_Vilnius_County.html" },
                    { 706L, "Vilnius", "Lithuania", 54.687038600000001, 25.259474999999998, "Trikampis pub & bowling", null, "16A Gostauto street", "Mexican, American", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12905241-Reviews-Trikampis_pub_bowling-Vilnius_Vilnius_County.html" },
                    { 696L, "Vilnius", "Lithuania", 54.685544800000002, 25.279676500000001, "Sports Pub", null, "Vilniaus g. 16", "American, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17639638-Reviews-Sports_Pub-Vilnius_Vilnius_County.html" },
                    { 707L, "Vilnius", "Lithuania", 54.681784999999998, 25.278115799999998, "4/20 Restaurant Lounge Bar", null, "Klaipedos g. 1", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9993474-Reviews-4_20_Restaurant_Lounge_Bar-Vilnius_Vilnius_County.html" },
                    { 709L, "Vilnius", "Lithuania", 54.678896399999999, 25.2782442, "Appetit Us", null, "Pylimo g. 21", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8633508-Reviews-Appetit_Us-Vilnius_Vilnius_County.html" },
                    { 710L, "Vilnius", "Lithuania", 54.697377299999999, 25.2989158, "Cue Club", null, "Zirmunu g. 2", "Japanese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1007103-Reviews-Cue_Club-Vilnius_Vilnius_County.html" },
                    { 711L, "Vilnius", "Lithuania", 54.731649699999998, 25.245696800000001, "Cili Pizza", "Prekybos centras Mandarinas", "Ateities g. 91", "Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10468509-Reviews-Cili_Pizza-Vilnius_Vilnius_County.html" },
                    { 712L, "Vilnius", "Lithuania", 54.702448099999998, 25.210996000000002, "The Sandwich", null, "Virsuliskiu Skg. 34", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7394588-Reviews-The_Sandwich-Vilnius_Vilnius_County.html" },
                    { 713L, "Vilnius", "Lithuania", 54.680900700000002, 25.289787799999999, "Skrajojantis Olandas", null, "Boksto g. 3", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1409774-Reviews-Skrajojantis_Olandas-Vilnius_Vilnius_County.html" },
                    { 714L, "Vilnius", "Lithuania", 54.684193800000003, 25.290067400000002, "Vero Cafe", null, "Pilies G. 6", "Italian, French", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19126571-Reviews-Vero_Cafe-Vilnius_Vilnius_County.html" },
                    { 715L, "Vilnius", "Lithuania", 54.694266800000001, 25.394125800000001, "Baltria", "Naujoji Vilnia", "Skardzio g. 10", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12842337-Reviews-Baltria-Vilnius_Vilnius_County.html" },
                    { 716L, "Vilnius", "Lithuania", 54.687240699999997, 25.2818468, "The Juice Room", "PC Ozas, 1 Aukstas", "Gedimino pr. 9", "Healthy", "https://www.tripadvisor.com/Restaurant_Review-g274951-d18995305-Reviews-The_Juice_Room-Vilnius_Vilnius_County.html" },
                    { 717L, "Vilnius", "Lithuania", 54.684220699999997, 25.2732156, "Jammi Kebabai", null, "Tauro g. 3", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d17532714-Reviews-Jammi_Kebabai-Vilnius_Vilnius_County.html" },
                    { 718L, "Vilnius", "Lithuania", 54.678600899999999, 25.264174499999999, "Jinmei Chinese Restaurants", null, "Vytenio g. 8", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d16669479-Reviews-Jinmei_Chinese_Restaurants-Vilnius_Vilnius_County.html" },
                    { 708L, "Vilnius", "Lithuania", 54.680993000000001, 25.262628899999999, "Conditus", null, "J. Basanaviciaus g. 53", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7264989-Reviews-Conditus-Vilnius_Vilnius_County.html" },
                    { 619L, "Vilnius", "Lithuania", 54.708103700000002, 25.227777100000001, "Plus Plus Plus", null, "Virsuliskiu g. 42", "Fast Food, Mediterranean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d16904437-Reviews-Plus_Plus_Plus-Vilnius_Vilnius_County.html" },
                    { 695L, "Vilnius", "Lithuania", 54.708103700000002, 25.227777100000001, "Naujieji Rytai", null, "Virsuliskiu g. 42", "Chinese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12184328-Reviews-Naujieji_Rytai-Vilnius_Vilnius_County.html" },
                    { 693L, "Vilnius", "Lithuania", 54.6885689, 25.272467800000001, "Ad Astrum", null, "Gedimino pr. 33", "European, Russian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12919771-Reviews-Ad_Astrum-Vilnius_Vilnius_County.html" },
                    { 671L, "Vilnius", "Lithuania", 54.692783900000002, 25.303659, "Boho Cafe", null, "T. Kosciuskos G. 21-2A", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14107462-Reviews-Boho_Cafe-Vilnius_Vilnius_County.html" },
                    { 672L, "Vilnius", "Lithuania", 54.681553399999999, 25.288159499999999, "LA buffet", null, "Pilies g. 25a", "European, Fusion", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8099815-Reviews-LA_buffet-Vilnius_Vilnius_County.html" },
                    { 673L, "Vilnius", "Lithuania", 54.688238900000002, 25.265066900000001, "Tauradvaris cafe bakery", null, "J. Jasinskio g 7-2", "French, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12581415-Reviews-Tauradvaris_cafe_bakery-Vilnius_Vilnius_County.html" },
                    { 674L, "Vilnius", "Lithuania", 54.679409999999997, 25.257871099999999, "Kinu Roze", null, "Savanoriu pr. 1", "Chinese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3190007-Reviews-Kinu_Roze-Vilnius_Vilnius_County.html" },
                    { 675L, "Vilnius", "Lithuania", 54.678600899999999, 25.264174499999999, "Jinmei", null, "Vytenio g.8", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d16669250-Reviews-Jinmei-Vilnius_Vilnius_County.html" },
                    { 676L, "Vilnius", "Lithuania", 54.724171599999998, 25.319729899999999, "Sushi Express", null, "Nemencines pl. 2", "Japanese, Sushi", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12830198-Reviews-Sushi_Express-Vilnius_Vilnius_County.html" },
                    { 677L, "Vilnius", "Lithuania", 54.673406999999997, 25.266571299999999, "Tahini Maistas Nuo Iesmo", null, "Naugarduko g. 50", "Lebanese, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15144163-Reviews-Tahini_Maistas_Nuo_Iesmo-Vilnius_Vilnius_County.html" },
                    { 678L, "Vilnius", "Lithuania", 54.676963299999997, 25.276474799999999, "Restaurant Tbilisi", null, "Naugarduko g. 12", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d15290909-Reviews-Restaurant_Tbilisi-Vilnius_Vilnius_County.html" },
                    { 679L, "Vilnius", "Lithuania", 54.680972099999998, 25.299444399999999, "Zenoteca", null, "Uzupio g. 25", "Italian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12106097-Reviews-Zenoteca-Vilnius_Vilnius_County.html" },
                    { 680L, "Vilnius", "Lithuania", 54.6949325, 25.283254100000001, "Honkongas", null, "Lvovo g. 13", "$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11882430-Reviews-Honkongas-Vilnius_Vilnius_County.html" },
                    { 694L, "Vilnius", "Lithuania", 54.709511200000001, 25.2221312, "Can Can Pizza", null, "Virsuliskiu g. 30", "Pizza, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10825901-Reviews-Can_Can_Pizza-Vilnius_Vilnius_County.html" },
                    { 681L, "Vilnius", "Lithuania", 54.6670406, 25.272815699999999, "Burger Street Grill house", null, "Svitrigailos g. 14", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d15100261-Reviews-Burger_Street_Grill_house-Vilnius_Vilnius_County.html" },
                    { 683L, "Vilnius", "Lithuania", 54.675512099999999, 25.257311399999999, "Pizza Jazz", null, "Savanoriu pr. 16", "Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d811751-Reviews-Pizza_Jazz-Vilnius_Vilnius_County.html" },
                    { 684L, "Vilnius", "Lithuania", 54.8131865, 25.350697700000001, "Restaurante Europos Parkas", null, "Europos parko g. 300", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d11632882-Reviews-Restaurante_Europos_Parkas-Vilnius_Vilnius_County.html" },
                    { 685L, "Vilnius", "Lithuania", 54.687240699999997, 25.2818468, "Mon Ami Boulangerie", "GO9, level -1", "Gedimino pr. 9", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12716208-Reviews-Mon_Ami_Boulangerie-Vilnius_Vilnius_County.html" },
                    { 686L, "Vilnius", "Lithuania", 54.685272099999999, 25.281969199999999, "Kaukazo Kebabai", null, "Totoriu gatve 7", "American, Turkish", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13532604-Reviews-Kaukazo_Kebabai-Vilnius_Vilnius_County.html" },
                    { 687L, "Vilnius", "Lithuania", 54.675802300000001, 25.286292199999998, "MAma's", null, "Arkliu g. 18", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7188101-Reviews-MAma_s-Vilnius_Vilnius_County.html" },
                    { 688L, "Vilnius", "Lithuania", 54.68788, 25.267590899999998, "Antalija Kebabine", null, "J. Jasinskio g. 1", "$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7682778-Reviews-Antalija_Kebabine-Vilnius_Vilnius_County.html" },
                    { 689L, "Vilnius", "Lithuania", 54.677635000000002, 25.286655, "Siuolaikinio Meno Centro Kavine", null, "Rudninku Gatve 2", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10453968-Reviews-Siuolaikinio_Meno_Centro_Kavine-Vilnius_Vilnius_County.html" },
                    { 690L, "Vilnius", "Lithuania", 54.717965999999997, 25.3031978, "Super Sushi", "ZirmUnU g. 68 A, Vilniaus g. 24 B", "Zirmunu g. 68 A", "Japanese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12847373-Reviews-Super_Sushi-Vilnius_Vilnius_County.html" },
                    { 691L, "Vilnius", "Lithuania", 54.715215800000003, 25.296279299999998, "Tortine", null, "Lakunu g. 14b", "Italian, French", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13157273-Reviews-Tortine-Vilnius_Vilnius_County.html" },
                    { 692L, "Vilnius", "Lithuania", 54.681864099999999, 25.2892604, "Terrano restoranas & vynine", null, "Pilies g. 34", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3941741-Reviews-Terrano_restoranas_vynine-Vilnius_Vilnius_County.html" },
                    { 682L, "Vilnius", "Lithuania", 54.679993199999998, 25.278229499999998, "CanCan Pizza", null, "Traku g. 2", "Pizza, Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3813763-Reviews-CanCan_Pizza-Vilnius_Vilnius_County.html" },
                    { 618L, "Vilnius", "Lithuania", 54.688247400000002, 25.267575600000001, "FenerFalafel", null, "Dainavos g. 6", "Fast Food, Healthy", "https://www.tripadvisor.com/Restaurant_Review-g274951-d16929139-Reviews-FenerFalafel-Vilnius_Vilnius_County.html" },
                    { 617L, "Vilnius", "Lithuania", 54.6763379, 25.282938999999999, "Club Italia", null, "Ligonines g. 7", "Wine Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10696273-Reviews-Club_Italia-Vilnius_Vilnius_County.html" },
                    { 616L, "Vilnius", "Lithuania", 54.679407699999999, 25.283484399999999, "Razmarin", null, "Vokieciu g. 20", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15610366-Reviews-Razmarin-Vilnius_Vilnius_County.html" },
                    { 542L, "Vilnius", "Lithuania", 54.710310399999997, 25.262674499999999, "Crustum Akropolis Vilnius", null, "Ozo 25", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8335198-Reviews-Crustum_Akropolis_Vilnius-Vilnius_Vilnius_County.html" },
                    { 543L, "Vilnius", "Lithuania", 54.710310399999997, 25.262674499999999, "Freedom Terrace", null, "Ozo g. 25", "Pizza, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10818332-Reviews-Freedom_Terrace-Vilnius_Vilnius_County.html" },
                    { 544L, "Vilnius", "Lithuania", 54.679705400000003, 25.283171100000001, "PJazz", null, "Vokieciu g. 24", "Pizza, Italian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7256973-Reviews-PJazz-Vilnius_Vilnius_County.html" },
                    { 545L, "Vilnius", "Lithuania", 54.689948899999997, 25.264092900000001, "Rytai", null, "Gyneju g. 2", "Chinese, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7281413-Reviews-Rytai-Vilnius_Vilnius_County.html" },
                    { 546L, "Vilnius", "Lithuania", 54.703604900000002, 25.279492900000001, "Brandevino", null, "Zalgirio g. 88", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2491909-Reviews-Brandevino-Vilnius_Vilnius_County.html" },
                    { 547L, "Vilnius", "Lithuania", 54.717965999999997, 25.3031978, "Laimos Smukle", null, "Zirmunu g. 68A", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d5494249-Reviews-Laimos_Smukle-Vilnius_Vilnius_County.html" },
                    { 548L, "Vilnius", "Lithuania", 54.694619400000001, 25.286451199999998, "Pavalgom Bistro", null, "Seimyniskiu g. 20", "Fast Food, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15091446-Reviews-Pavalgom_Bistro-Vilnius_Vilnius_County.html" },
                    { 549L, "Vilnius", "Lithuania", 54.715904899999998, 25.316747899999999, "Wraperia Suppa Kebs Antakalnis", null, "Antakalnio g. 77", "Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13142578-Reviews-Wraperia_Suppa_Kebs_Antakalnis-Vilnius_Vilnius_County.html" },
                    { 550L, "Vilnius", "Lithuania", 54.678896399999999, 25.2782442, "Birzu Duona", null, "Pylimo g. 21", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17691709-Reviews-Birzu_Duona-Vilnius_Vilnius_County.html" },
                    { 551L, "Vilnius", "Lithuania", 54.694403899999998, 25.305353, "Bacchus", null, "Antakalnio g. 4a", "Grill", "https://www.tripadvisor.com/Restaurant_Review-g274951-d16619219-Reviews-Bacchus-Vilnius_Vilnius_County.html" },
                    { 541L, "Vilnius", "Lithuania", 54.694914300000001, 25.2773413, "7 Elephants", null, "Konstitucijos pr. 12", "Steakhouse, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7986141-Reviews-7_Elephants-Vilnius_Vilnius_County.html" },
                    { 552L, "Vilnius", "Lithuania", 54.700393900000002, 25.257780100000002, "Rojaus Maistas", "Gourmet Pc Panorama", "Saltoniskiu g. 9", "Seafood, Mediterranean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13403439-Reviews-Rojaus_Maistas-Vilnius_Vilnius_County.html" },
                    { 554L, "Vilnius", "Lithuania", 54.680731000000002, 25.293157799999999, "Po Seiva - Uzupio Terasa", null, "Uzupio g. 2", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d10778412-Reviews-Po_Seiva_Uzupio_Terasa-Vilnius_Vilnius_County.html" },
                    { 555L, "Vilnius", "Lithuania", 54.828134800000001, 25.130812500000001, "The V Steak House", null, "Ezeraiciu G.2, Ezeraiciu K., Avizieniu Sen", "European, Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12908219-Reviews-The_V_Steak_House-Vilnius_Vilnius_County.html" },
                    { 556L, "Vilnius", "Lithuania", 54.681183500000003, 25.272274800000002, "Tapas Gastrobar", null, "J. Basanaviciaus g. 15", "Mediterranean, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10432346-Reviews-Tapas_Gastrobar-Vilnius_Vilnius_County.html" },
                    { 557L, "Vilnius", "Lithuania", 54.710615199999999, 25.286581999999999, "PUBLiC", null, "Kalvariju g. 125", "Italian, American", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14068396-Reviews-PUBLiC-Vilnius_Vilnius_County.html" },
                    { 558L, "Vilnius", "Lithuania", 54.739772299999998, 25.273539299999999, "PizzaPub", null, "Ateities g. 1F", "Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d5999020-Reviews-PizzaPub-Vilnius_Vilnius_County.html" },
                    { 559L, "Vilnius", "Lithuania", 54.675480899999997, 25.2568381, "PJazz", null, "Kedru g. 4", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11799050-Reviews-PJazz-Vilnius_Vilnius_County.html" },
                    { 560L, "Vilnius", "Lithuania", 54.681660000000001, 25.2657989, "Sinano Kebabai", null, "J. Basanaviciaus Gatve 37", "Middle Eastern", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12404583-Reviews-Sinano_Kebabai-Vilnius_Vilnius_County.html" },
                    { 561L, "Vilnius", "Lithuania", 54.686047000000002, 25.2797363, "Fidel Bar", null, "Vilniaus g. 12", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9720349-Reviews-Fidel_Bar-Vilnius_Vilnius_County.html" },
                    { 562L, "Vilnius", "Lithuania", 54.698298700000002, 25.2587473, "Ajurvedine Virtuve Saltoniskiu", null, "Saltoniskiu g. 34A", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d4088250-Reviews-Ajurvedine_Virtuve-Vilnius_Vilnius_County.html" },
                    { 563L, "Vilnius", "Lithuania", 54.695079800000002, 25.253224800000002, "Ajurvedine Virtuve Latviu", null, "Latviu g. 7a", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d4088250-Reviews-Ajurvedine_Virtuve-Vilnius_Vilnius_County.html" },
                    { 553L, "Vilnius", "Lithuania", 54.624231600000002, 25.110008100000002, "Senoji Kibinine Traku Vokeje", "Supermarket MAXIMA XX", "J. Tiskeviciaus g 22", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7693403-Reviews-Senoji_Kibinine_Traku_Vokeje-Vilnius_Vilnius_County.html" },
                    { 564L, "Vilnius", "Lithuania", 54.692703899999998, 25.303395999999999, "Bistro PAN", null, "T. Kosciuskos g 17", "Pizza, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d16831169-Reviews-Bistro_PAN-Vilnius_Vilnius_County.html" },
                    { 540L, "Vilnius", "Lithuania", 54.679409999999997, 25.257871099999999, "Blasercafe DIM KAVI", "PC Helios City", "Savanoriu pr. 1", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d10525989-Reviews-Blasercafe_DIM_KAVI-Vilnius_Vilnius_County.html" },
                    { 538L, "Vilnius", "Lithuania", 54.684474199999997, 25.282306899999998, "Sulcius", null, "Totoriu g. 15", "$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1022595-Reviews-Sulcius-Vilnius_Vilnius_County.html" },
                    { 516L, "Vilnius", "Lithuania", 54.678324799999999, 25.2772507, "Hundred Wine Bar", null, "Pylimo g. 23", "French, Grill", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19229034-Reviews-Hundred_Wine_Bar-Vilnius_Vilnius_County.html" },
                    { 517L, "Vilnius", "Lithuania", 54.675222499999997, 25.284034200000001, "take eat easy", null, "50 Pylimo street", "Street Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12476691-Reviews-Take_eat_easy-Vilnius_Vilnius_County.html" },
                    { 518L, "Vilnius", "Lithuania", 54.672677399999998, 25.283582500000001, "Panorama Hotel Restaurant", null, "Sodu g. 14", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12986570-Reviews-Panorama_Hotel_Restaurant-Vilnius_Vilnius_County.html" },
                    { 519L, "Vilnius", "Lithuania", 54.679705400000003, 25.283171100000001, "Miyako", "Old Town", "Vokieciu g. 24", "Japanese, Sushi", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13184155-Reviews-Miyako-Vilnius_Vilnius_County.html" },
                    { 520L, "Vilnius", "Lithuania", 54.678504199999999, 25.284778299999999, "Tappo D'oro Baras", null, "Vokieciu g. 8", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d10626788-Reviews-Tappo_D_oro_Baras-Vilnius_Vilnius_County.html" },
                    { 521L, "Vilnius", "Lithuania", 54.676335999999999, 25.265773100000001, "Gastronomika", null, "T. Sevcenkos g. 16i", "European, French", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8809238-Reviews-Gastronomika-Vilnius_Vilnius_County.html" },
                    { 522L, "Vilnius", "Lithuania", 54.6754976, 25.288881, "Uogiene cafe", null, "Ausros Vartu 11", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12357842-Reviews-Uogiene_cafe-Vilnius_Vilnius_County.html" },
                    { 523L, "Vilnius", "Lithuania", 54.674191899999997, 25.2870463, "Restaurant Cafe Budulia", null, "Bazilijonu str.6", "Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12229425-Reviews-Restaurant_Cafe_Budulia-Vilnius_Vilnius_County.html" },
                    { 524L, "Vilnius", "Lithuania", 54.713816899999998, 25.2939282, "SENOJI KIBININE Ogmios miestas", "Šeimos aikštė 5", "Verkiu 29", "European, Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14519195-Reviews-SENOJI_KIBININE_Ogmios_miestas-Vilnius_Vilnius_County.html" },
                    { 525L, "Vilnius", "Lithuania", 54.6956609, 25.181318399999999, "Salotes Uzeiga", "Prie Salotes Ezero Papludimio", "Salotes K. Papludimio G. 4", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8868561-Reviews-Salotes_Uzeiga-Vilnius_Vilnius_County.html" },
                    { 539L, "Vilnius", "Lithuania", 54.679926100000003, 25.277010199999999, "QPolo", null, "J. Basanaviciaus g. 4", "American, Fusion", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4979417-Reviews-QPolo-Vilnius_Vilnius_County.html" },
                    { 526L, "Vilnius", "Lithuania", 54.711221999999999, 25.291834900000001, "Pank'olis", null, "Verkiu g. 25-C", "Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8721091-Reviews-Pank_olis-Vilnius_Vilnius_County.html" },
                    { 528L, "Vilnius", "Lithuania", 54.6765422, 25.288965099999999, "California GOURMET", null, "Subaciaus str. 2", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3210556-Reviews-California_GOURMET-Vilnius_Vilnius_County.html" },
                    { 529L, "Vilnius", "Lithuania", 54.677036100000002, 25.264610300000001, "Sofra Kavine", null, "T. Sevcenkos g. 16a", "Cafe, Turkish", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10081113-Reviews-Sofra_Kavine-Vilnius_Vilnius_County.html" },
                    { 530L, "Vilnius", "Lithuania", 54.686630899999997, 25.259621299999999, "Termeh", null, "J. Jasinskio g. 16A", "Middle Eastern, Persian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17667970-Reviews-Termeh-Vilnius_Vilnius_County.html" },
                    { 531L, "Vilnius", "Lithuania", 54.693894999999998, 25.276167999999998, "Crustum", "Pc Cup", "Upes g. 9", "European, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12910464-Reviews-Crustum-Vilnius_Vilnius_County.html" },
                    { 532L, "Vilnius", "Lithuania", 54.684515900000001, 25.284464400000001, "Capo Pizza Bar", null, "L. Stuokos-Guceviciaus g. 7", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10097839-Reviews-Capo_Pizza_Bar-Vilnius_Vilnius_County.html" },
                    { 533L, "Vilnius", "Lithuania", 54.6911779, 25.397590900000001, "Lab 180", "Savanoriu 180", "Liepto g. 3", "Spanish", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9453700-Reviews-Lab_180-Vilnius_Vilnius_County.html" },
                    { 534L, "Vilnius", "Lithuania", 54.679885900000002, 25.296285000000001, "Uzupis Republic presidential Cafe \"Suske\"", null, "Paupio street 5", "European, Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12996367-Reviews-Uzupis_Republic_presidential_Cafe_Suske-Vilnius_Vilnius_County.html" },
                    { 535L, "Vilnius", "Lithuania", 54.707233600000002, 25.1896378, "Daily", null, "Vyduno Gatve 2", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10081076-Reviews-Daily-Vilnius_Vilnius_County.html" },
                    { 536L, "Vilnius", "Lithuania", 54.6789542, 25.258936899999998, "British Cafe", null, "Savanoriu Prospektas 6A-1004", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d11896566-Reviews-British_Cafe-Vilnius_Vilnius_County.html" },
                    { 537L, "Vilnius", "Lithuania", 54.683470100000001, 25.279014199999999, "Lokstauk Speakeasy", null, "Vilniaus g. 33", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11938353-Reviews-Lokstauk_Speakeasy-Vilnius_Vilnius_County.html" },
                    { 527L, "Vilnius", "Lithuania", 54.687240699999997, 25.2818468, "Rosehip Vegan Bistro (G9)", null, "Gedimino pr. 9", "$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d18190413-Reviews-Rosehip_Vegan_Bistro_G9-Vilnius_Vilnius_County.html" },
                    { 719L, "Vilnius", "Lithuania", 54.689171100000003, 25.2100738, "Fokus Pizza", null, "L. Asanaviciutes g. 15", "Italian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8322332-Reviews-Fokus_Pizza-Vilnius_Vilnius_County.html" },
                    { 565L, "Vilnius", "Lithuania", 54.683084000000001, 25.235931799999999, "Raw Spot", null, "M.K. Ciurlionio g. 100", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7019450-Reviews-Raw_Spot-Vilnius_Vilnius_County.html" },
                    { 567L, "Vilnius", "Lithuania", 54.677796999999998, 25.286201999999999, "SMC cafe", null, "Vokieciu g. 2", "European, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7391560-Reviews-SMC_cafe-Vilnius_Vilnius_County.html" },
                    { 594L, "Vilnius", "Lithuania", 54.684652, 25.285744000000001, "Le Salon Bar & Lounge", "Kempinski Hotel Cathedral Square", "Universiteto g. 14", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12207570-Reviews-Le_Salon_Bar_Lounge-Vilnius_Vilnius_County.html" },
                    { 595L, "Vilnius", "Lithuania", 54.713966900000003, 25.272621399999998, "9 Drakonai", null, "Ozo street 18", "Chinese, Fusion", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14533895-Reviews-9_Drakonai-Vilnius_Vilnius_County.html" },
                    { 596L, "Vilnius", "Lithuania", 54.673670000000001, 25.286079900000001, "Wingis", "Halės Market", "Pylimo St 58", "Caribbean, International", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15139768-Reviews-Wingis-Vilnius_Vilnius_County.html" },
                    { 597L, "Vilnius", "Lithuania", 54.6843279, 25.2642399, "Laiko Ratas", null, "Sierakausko 15", "Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13171354-Reviews-Laiko_Ratas-Vilnius_Vilnius_County.html" },
                    { 598L, "Vilnius", "Lithuania", 54.713816899999998, 25.2939282, "Sushi Express", null, "Verkiu g. 29", "Japanese, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10607763-Reviews-Sushi_Express-Vilnius_Vilnius_County.html" },
                    { 599L, "Vilnius", "Lithuania", 54.684652, 25.285744000000001, "Le Cafe", null, "Universiteto g. 14", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15639813-Reviews-Le_Cafe-Vilnius_Vilnius_County.html" },
                    { 600L, "Vilnius", "Lithuania", 54.694914300000001, 25.2773413, "MERCI Restaurant & Hookah Lounge", null, "Konstitucijos pr. 12", "European, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10173919-Reviews-MERCI_Restaurant_Hookah_Lounge-Vilnius_Vilnius_County.html" },
                    { 601L, "Vilnius", "Lithuania", 54.713816899999998, 25.2939282, "La Pasta Makaronu Namai", "Ogmios Miestas, Seimos Aikste 3", "Verkiu g. 29", "Italian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11873515-Reviews-La_Pasta_Makaronu_Namai-Vilnius_Vilnius_County.html" },
                    { 602L, "Vilnius", "Lithuania", 54.693014400000003, 25.268068700000001, "Bistrolita", null, "Lukiskiu g. 5", "Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10093105-Reviews-Bistrolita-Vilnius_Vilnius_County.html" },
                    { 603L, "Vilnius", "Lithuania", 54.681306499999998, 25.289365799999999, "Storytellers", null, "Pilies g. 42", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14910663-Reviews-Stroytellers-Vilnius_Vilnius_County.html" },
                    { 593L, "Vilnius", "Lithuania", 54.6754976, 25.288881, "Uogenie kavine cafe", null, "11 Ausros Vartu", "Cafe, Deli", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12281201-Reviews-Uogenie_kavine_cafe-Vilnius_Vilnius_County.html" },
                    { 604L, "Vilnius", "Lithuania", 54.710310399999997, 25.262674499999999, "Yogoland", "shopping center Akropolis", "Ozo gatve 25", "American, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12611203-Reviews-Yogoland-Vilnius_Vilnius_County.html" },
                    { 606L, "Vilnius", "Lithuania", 54.697377299999999, 25.2989158, "Sushi Express", null, "Zirmunu g. 2", "Japanese, Sushi", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12842222-Reviews-Sushi_Express-Vilnius_Vilnius_County.html" },
                    { 607L, "Vilnius", "Lithuania", 54.672308299999997, 25.279317299999999, "Bulkine", null, "Kauno g. 2", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10758151-Reviews-Bulkine-Vilnius_Vilnius_County.html" },
                    { 608L, "Vilnius", "Lithuania", 54.675639400000001, 25.283271899999999, "Paradis Belge +32", null, "Rudninku g. 15", "Belgian, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1021680-Reviews-Paradis_Belge_32-Vilnius_Vilnius_County.html" },
                    { 609L, "Vilnius", "Lithuania", 54.675304300000001, 25.267927100000001, "Vilnius City Cafe & Retaurant", null, "Svitrigailos g. 11D", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12920331-Reviews-Vilnius_City_Cafe_Retaurant-Vilnius_Vilnius_County.html" },
                    { 610L, "Vilnius", "Lithuania", 54.679189399999998, 25.284500999999999, "Grill London", null, "Vokieciu Str. 9", "American, British", "https://www.tripadvisor.com/Restaurant_Review-g274951-d18754684-Reviews-Grill_London-Vilnius_Vilnius_County.html" },
                    { 611L, "Vilnius", "Lithuania", 54.675465000000003, 25.282343900000001, "Nieko Ypatingo", "5", "Raugyklos g. 5", "Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13293819-Reviews-Nieko_Ypatingo-Vilnius_Vilnius_County.html" },
                    { 612L, "Vilnius", "Lithuania", 54.813032200000002, 25.237663999999999, "Mama Grill", null, "Zirgu g. 2", "European, Barbecue", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10588012-Reviews-Mama_Grill-Vilnius_Vilnius_County.html" },
                    { 613L, "Vilnius", "Lithuania", 54.685094100000001, 25.281200599999998, "Switch Bar", "Entrance from main street", "Labdariu g. 8", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10793830-Reviews-Switch_Bar-Vilnius_Vilnius_County.html" },
                    { 614L, "Vilnius", "Lithuania", 54.643045899999997, 25.279819, "Heineken Bar", "Vilnius Airport", "Rodunios kelias 2", "Bar, International", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7715073-Reviews-Heineken_Bar-Vilnius_Vilnius_County.html" },
                    { 615L, "Vilnius", "Lithuania", 54.697367, 25.266847899999998, "Skonis", "Entrance from river side", "Konstitucijos pr. 26", "International, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17571577-Reviews-Skonis-Vilnius_Vilnius_County.html" },
                    { 605L, "Vilnius", "Lithuania", 54.683876300000001, 25.279057900000002, "Mimoza", null, "Islandijos g. 1", "Contemporary", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2429175-Reviews-Mimoza-Vilnius_Vilnius_County.html" },
                    { 566L, "Vilnius", "Lithuania", 54.713816899999998, 25.2939282, "BBQ House", null, "Verkiu g. 29", "Barbecue", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12592515-Reviews-BBQ_House-Vilnius_Vilnius_County.html" },
                    { 592L, "Vilnius", "Lithuania", 54.680985900000003, 25.283743000000001, "Grill Inn", null, "Dominikonu g. 6", "International, Grill", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4722542-Reviews-Grill_Inn-Vilnius_Vilnius_County.html" },
                    { 590L, "Vilnius", "Lithuania", 54.686094900000001, 25.279101900000001, "Sultiniai", null, "Jogailos g. 6", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d11660717-Reviews-Sultiniai-Vilnius_Vilnius_County.html" },
                    { 568L, "Vilnius", "Lithuania", 54.687240699999997, 25.2818468, "The Juice Room", "Go 9 1", "Gedimino pr. 9", "Healthy", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10397149-Reviews-The_Juice_Room-Vilnius_Vilnius_County.html" },
                    { 569L, "Vilnius", "Lithuania", 54.683882400000002, 25.2897161, "Kaukazo gerybes (Caucasian goodies)", null, "Pilies 10", "European, Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15867048-Reviews-Kaukazo_gerybes_Caucasian_goodies-Vilnius_Vilnius_County.html" },
                    { 570L, "Vilnius", "Lithuania", 54.713966900000003, 25.272621399999998, "Etno Dvaras", null, "Ozo g. 18", "Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15115411-Reviews-Etno_Dvaras-Vilnius_Vilnius_County.html" },
                    { 571L, "Vilnius", "Lithuania", 54.692654500000003, 25.256467099999998, "Mindaugo kepykla", null, "Vytauto g. 39", "Italian, French", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12688577-Reviews-Mindaugo_kepykla-Vilnius_Vilnius_County.html" },
                    { 572L, "Vilnius", "Lithuania", 54.7168578, 25.245300100000001, "Agotos grycia", "59a", "Seskines g. 59a", "Eastern European, Central European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1058146-Reviews-Agotos_grycia-Vilnius_Vilnius_County.html" },
                    { 573L, "Vilnius", "Lithuania", 54.6816824, 25.268590199999998, "NORD Restaurant", null, "J. Basanaviciaus g. 26", "European, Swedish", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12998666-Reviews-NORD_Restaurant-Vilnius_Vilnius_County.html" },
                    { 574L, "Vilnius", "Lithuania", 54.688118199999998, 25.261523, "Boulingo Klubas", "16a Gostauto street", "J. Jasinskio g. 16", "French, American", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8633660-Reviews-Boulingo_Klubas-Vilnius_Vilnius_County.html" },
                    { 575L, "Vilnius", "Lithuania", 54.685544800000002, 25.279676500000001, "Hooters", null, "Vilniaus g. 16", "American, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12793609-Reviews-Hooters-Vilnius_Vilnius_County.html" },
                    { 576L, "Vilnius", "Lithuania", 54.687746300000001, 25.284182000000001, "RnB Grill Cafe", null, "Tilto g. 13", "Grill", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8662730-Reviews-RnB_Grill_Cafe-Vilnius_Vilnius_County.html" },
                    { 577L, "Vilnius", "Lithuania", 54.6819585, 25.279805100000001, "Pienas ne vienas", null, "Vilniaus g. 39", "American, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12364704-Reviews-Pienas_ne_vienas-Vilnius_Vilnius_County.html" },
                    { 591L, "Vilnius", "Lithuania", 54.679502499999998, 25.283383799999999, "Alus Restoranas Zemaiciai Budas Zemaicuiir Leituval", null, "Vokieciu g. 22", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4894342-Reviews-Alus_Restoranas_Zemaiciai_Budas_Zemaicuiir_Leituval-Vilnius_Vilnius_County.html" },
                    { 578L, "Vilnius", "Lithuania", 54.683196700000003, 25.289500700000001, "Trys Klevai", null, "Pilies g. 16", "Chinese, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6678376-Reviews-Trys_Klevai-Vilnius_Vilnius_County.html" },
                    { 580L, "Vilnius", "Lithuania", 54.687240699999997, 25.2818468, "Gan Bei City", null, "Gedimino pr. 9", "Japanese, Indian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15297358-Reviews-Gan_Bei_City-Vilnius_Vilnius_County.html" },
                    { 581L, "Vilnius", "Lithuania", 54.679178899999997, 25.281133799999999, "Bobutes Virtuve", null, "Pranciskonu g. 1", "European, Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13953014-Reviews-Bobutes_Virtuve-Vilnius_Vilnius_County.html" },
                    { 582L, "Vilnius", "Lithuania", 54.681553399999999, 25.288159499999999, "Spice", "K. Sirvydo squere", "Pilies str. 25A", "Chinese, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12284105-Reviews-Spice-Vilnius_Vilnius_County.html" },
                    { 583L, "Vilnius", "Lithuania", 54.676335999999999, 25.265773100000001, "16i Kava", null, "T. Sevcenkos g. 16i", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12879153-Reviews-16i_Kava-Vilnius_Vilnius_County.html" },
                    { 584L, "Vilnius", "Lithuania", 54.736098699999999, 25.2197566, "Awokado Noodle Bar", null, "Pavilnioniu g. 33", "Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17837047-Reviews-Awokado_Noodle_Bar-Vilnius_Vilnius_County.html" },
                    { 585L, "Vilnius", "Lithuania", 54.689130900000002, 25.266751899999999, "Niam Niam Sushi", null, "Gedimino prospektas 46", "Sushi", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10695038-Reviews-Niam_Niam_Sushi-Vilnius_Vilnius_County.html" },
                    { 586L, "Vilnius", "Lithuania", 54.700393900000002, 25.257780100000002, "SELFISH Panorama", "PC Panorama", "Saltoniskiu g. 9", "Seafood, Wine Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15027543-Reviews-SELFISH_Panorama-Vilnius_Vilnius_County.html" },
                    { 587L, "Vilnius", "Lithuania", 54.678476699999997, 25.287901099999999, "Botanist Kiemelis", null, "Didzioji 24", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17513486-Reviews-Botanist_Kiemelis-Vilnius_Vilnius_County.html" },
                    { 588L, "Vilnius", "Lithuania", 54.696131899999997, 25.249624900000001, "Fresh Friendly Family", null, "Kestucio g. 38", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8119160-Reviews-Fresh_Friendly_Family-Vilnius_Vilnius_County.html" },
                    { 589L, "Vilnius", "Lithuania", 54.679833299999999, 25.277749199999999, "Moon Gastrobar Vilnius", null, "J. Basanaviciaus g 2", "European, Central European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17380816-Reviews-Moon_Gastrobar_Vilnius-Vilnius_Vilnius_County.html" },
                    { 579L, "Vilnius", "Lithuania", 54.674316699999999, 25.268873599999999, "Zilva", null, "Svitrigailos g. 26", "Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10247987-Reviews-Zilva-Vilnius_Vilnius_County.html" },
                    { 515L, "Vilnius", "Lithuania", 54.703704899999998, 25.278146799999998, "Untold Grill Stories", null, "Zalgirio g. 90", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11789187-Reviews-Untold_Grill_Stories-Vilnius_Vilnius_County.html" },
                    { 720L, "Vilnius", "Lithuania", 54.648752399999999, 25.2745058, "Cafe Wings", null, "Dariaus Ir Gireno Gatve 42", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d16865395-Reviews-Cafe_Wings-Vilnius_Vilnius_County.html" },
                    { 722L, "Vilnius", "Lithuania", 54.700393900000002, 25.257780100000002, "Sriubos Diena", "PLC Panorama", "Saltoniskiu g. 9", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14213070-Reviews-Sriubos_Diena-Vilnius_Vilnius_County.html" },
                    { 853L, "Vilnius", "Lithuania", 54.700393900000002, 25.257780100000002, "Thierry", "Gourmet by Panorama", "Saltoniskiu g. 9", "French", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19268402-Reviews-Thierry-Vilnius_Vilnius_County.html" }
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "RestaurantId", "City", "Country", "Latitude", "Longitude", "Name", "SpecifyStreet", "Street", "Type", "Url" },
                values: new object[,]
                {
                    { 854L, "Vilnius", "Lithuania", 54.724381999999999, 25.244357000000001, "Burgerine", null, "Fabijoniskiu str. 2", "American, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13007788-Reviews-Burgerine-Vilnius_Vilnius_County.html" },
                    { 855L, "Vilnius", "Lithuania", 54.684193800000003, 25.290067400000002, "Toranj", null, "Pilies G. 6", "European, Middle Eastern", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19342068-Reviews-Toranj-Vilnius_Vilnius_County.html" },
                    { 856L, "Vilnius", "Lithuania", 54.683470100000001, 25.279014199999999, "Sushi Masters", null, "Vilniaus G. 33", "Japanese, Sushi", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19614774-Reviews-Sushi_Masters-Vilnius_Vilnius_County.html" },
                    { 857L, "Vilnius", "Lithuania", 54.679993199999998, 25.278229499999998, "Brandy Lounge Bar", null, "Traku g. 2", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11716795-Reviews-Brandy_Lounge_Bar-Vilnius_Vilnius_County.html" },
                    { 858L, "Vilnius", "Lithuania", 54.693901500000003, 25.2889351, "Please", null, "Rinktines g. 5", "Japanese, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d18848270-Reviews-Please-Vilnius_Vilnius_County.html" },
                    { 859L, "Vilnius", "Lithuania", 54.680776199999997, 25.295363999999999, "Kanapine Krautuve", null, "Uzupio Gatve 14", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d12384550-Reviews-Kanapine_Krautuve-Vilnius_Vilnius_County.html" },
                    { 860L, "Vilnius", "Lithuania", 54.722467799999997, 25.337668799999999, "Coffee Hill VGTU", "Boulevard", "Sauletekio al. 11", "European, Central European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12705574-Reviews-Coffee_Hill_VGTU-Vilnius_Vilnius_County.html" },
                    { 861L, "Vilnius", "Lithuania", 54.681958799999997, 25.311500500000001, "Uzupio Kiemelis", "53 A", "Polocko g. 53A", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14021711-Reviews-Uzupio_Kiemelis-Vilnius_Vilnius_County.html" },
                    { 862L, "Vilnius", "Lithuania", 54.724171599999998, 25.319729899999999, "Restoranas Kino Studija", null, "Nemencines Plentas 2", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12615452-Reviews-Restoranas_Kino_Studija-Vilnius_Vilnius_County.html" },
                    { 863L, "Vilnius", "Lithuania", 54.692130900000002, 25.2642393, "Al Dente", null, "Gyneju g. 14", "$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8563768-Reviews-Al_Dente-Vilnius_Vilnius_County.html" },
                    { 864L, "Vilnius", "Lithuania", 54.713049099999999, 25.287658700000001, "Kavine - Baras \"Minutele\"", null, "P. Luksio g 2", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17912677-Reviews-Kavine_Baras_Minutele-Vilnius_Vilnius_County.html" },
                    { 865L, "Vilnius", "Lithuania", 54.718958899999997, 25.302484100000001, "Ipek Trade", null, "Zirmunu 70", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6898628-Reviews-Ipek_Trade-Vilnius_Vilnius_County.html" },
                    { 866L, "Vilnius", "Lithuania", 54.777944099999999, 25.341885300000001, "Restoranas-picerija Pas Ta", null, "Visalaukio g. 1", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d18849592-Reviews-Restoranas_picerija_Pas_Ta-Vilnius_Vilnius_County.html" },
                    { 867L, "Vilnius", "Lithuania", 54.726692200000002, 25.235115100000002, "Viking The Chef", null, "Laisvės pr. 115A", "Barbecue, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15099693-Reviews-Viking_The_Chef-Vilnius_Vilnius_County.html" },
                    { 868L, "Vilnius", "Lithuania", 54.718828299999998, 25.2151289, "teStyle", null, "Rygos g. 43", "Cafe, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19112706-Reviews-TeStyle-Vilnius_Vilnius_County.html" },
                    { 869L, "Vilnius", "Lithuania", 54.681307699999998, 25.304681299999999, "Macarons Art", null, "Polocko g. 17", "$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d16756172-Reviews-Macarons_Art-Vilnius_Vilnius_County.html" },
                    { 870L, "Vilnius", "Lithuania", 54.6818484, 25.2669493, "Endorfin", null, "Jono Basanaviciaus g. 31", "Mexican, American", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14861954-Reviews-Endorfin-Vilnius_Vilnius_County.html" },
                    { 871L, "Vilnius", "Lithuania", 54.686532999999997, 25.282013899999999, "Barbados Tropical Tar", null, "Totoriu g. 1", "Latin, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15780076-Reviews-Barbados_Tropical_Tar-Vilnius_Vilnius_County.html" },
                    { 872L, "Vilnius", "Lithuania", 54.728009, 25.241247099999999, "Sushi Out", null, "Ukmerges g. 259A", "Japanese, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14791185-Reviews-Sushi_Out-Vilnius_Vilnius_County.html" },
                    { 873L, "Vilnius", "Lithuania", 54.728868599999998, 25.2692911, "Restaurant - Pizzeria Pas Ta", null, "Didlaukio g. 80A", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d18849583-Reviews-Restaurant_Pizzeria_Pas_Ta-Vilnius_Vilnius_County.html" },
                    { 852L, "Vilnius", "Lithuania", 54.717965999999997, 25.3031978, "Ajomama", null, "Zirmunu g. 68A", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19114347-Reviews-Ajomama-Vilnius_Vilnius_County.html" },
                    { 851L, "Vilnius", "Lithuania", 54.6776099, 25.262399899999998, "Andriaus Pica", null, "T. Sevcenkos g. 16", "Diner", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15666285-Reviews-Andriaus_Pica-Vilnius_Vilnius_County.html" },
                    { 850L, "Vilnius", "Lithuania", 54.672056499999997, 25.274210499999999, "Paradice", null, "Kauno g. 16", "Thai, Deli", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12995156-Reviews-Paradice-Vilnius_Vilnius_County.html" },
                    { 849L, "Vilnius", "Lithuania", 54.710690499999998, 25.303124199999999, "Sushi City", null, "S. Zukausko g. 49", "Sushi", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17756768-Reviews-Sushi_City-Vilnius_Vilnius_County.html" },
                    { 827L, "Vilnius", "Lithuania", 54.671302799999999, 25.267844199999999, "Smoke Brothers", null, "Kauno g. 30", "American, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10470763-Reviews-Smoke_Brothers-Vilnius_Vilnius_County.html" },
                    { 828L, "Vilnius", "Lithuania", 54.688410900000001, 25.276493800000001, "Baras Juoda Raudona", null, "A. Vienuolio g. 4", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4758007-Reviews-Baras_Juoda_Raudona-Vilnius_Vilnius_County.html" },
                    { 829L, "Vilnius", "Lithuania", 54.678234199999999, 25.2549326, "Cili Pizza", "KT Forum Cinemas Vingis", "Savanoriu pr. 7", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12239170-Reviews-Cili_Pizza-Vilnius_Vilnius_County.html" },
                    { 830L, "Vilnius", "Lithuania", 54.671906700000001, 25.2883645, "Berlin'o Bistro", null, "Gelezinkelio g. 3-14", "German, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10746708-Reviews-Berlin_o_Bistro-Vilnius_Vilnius_County.html" },
                    { 831L, "Vilnius", "Lithuania", 54.698293999999997, 25.3108732, "SAKMES", null, "Antakalnio g. 17", "Fusion", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14113571-Reviews-SAKMES-Vilnius_Vilnius_County.html" },
                    { 832L, "Vilnius", "Lithuania", 54.688410900000001, 25.276493800000001, "\"G spot\" snack bar", null, "A. Vienuolio g 4", "American, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d16701938-Reviews-G_spot_snack_bar-Vilnius_Vilnius_County.html" },
                    { 833L, "Vilnius", "Lithuania", 54.674889, 25.283939100000001, "Country Heroes", null, "Geliu g. 2", "American, Irish", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17709415-Reviews-Country_Heroes-Vilnius_Vilnius_County.html" },
                    { 834L, "Vilnius", "Lithuania", 54.700393900000002, 25.257780100000002, "Sushi Boutique", null, "Saltoniskiu g. 9", "Japanese, Seafood", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17756015-Reviews-Sushi_Boutique-Vilnius_Vilnius_County.html" },
                    { 835L, "Vilnius", "Lithuania", 54.687240699999997, 25.2818468, "Wafflatte", null, "Gedimino pr. 9", "Belgian, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d18344194-Reviews-Wafflatte-Vilnius_Vilnius_County.html" },
                    { 836L, "Vilnius", "Lithuania", 54.700393900000002, 25.257780100000002, "The Meat Point", "Islandijos pl. 32", "Saltoniskiu g. 9", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17759734-Reviews-The_Meat_Point-Vilnius_Vilnius_County.html" },
                    { 874L, "Vilnius", "Lithuania", 54.6821682, 25.302649800000001, "Kiskio asarele", null, "Baltasis skg. 9", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17821722-Reviews-Kiskio_asarele-Vilnius_Vilnius_County.html" },
                    { 837L, "Vilnius", "Lithuania", 54.672056499999997, 25.274210499999999, "Ruci", null, "Kauno str. 16", "Indian, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13279551-Reviews-Ruci-Vilnius_Vilnius_County.html" },
                    { 839L, "Vilnius", "Lithuania", 54.734828, 25.339807, "PineWood Bar Lounge", null, "Nemencines Pl. 37", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19468349-Reviews-PineWood_Bar_Lounge-Vilnius_Vilnius_County.html" },
                    { 840L, "Vilnius", "Lithuania", 54.6765969, 25.287959000000001, "Dziuga Namai", null, "Ausros Vartu g. 3", "Cafe, International", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17336568-Reviews-Dziuga_Namai-Vilnius_Vilnius_County.html" },
                    { 841L, "Vilnius", "Lithuania", 54.681183500000003, 25.272274800000002, "Genys Taproom Vilnius", null, "15 Jono Basanaviciaus str.", "Brew Pub, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19333490-Reviews-Genys_Taproom_Vilnius-Vilnius_Vilnius_County.html" },
                    { 842L, "Vilnius", "Lithuania", 54.670243999999997, 25.282919499999998, "Miltai ir dziaugsmai", "With Peronas bar", "Gelezinkelio g. 6", "Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17766698-Reviews-Miltai_ir_dziaugsmai-Vilnius_Vilnius_County.html" },
                    { 843L, "Vilnius", "Lithuania", 54.692130900000002, 25.2642393, "Maurizio's Pizzeria", null, "Gyneju g. 14", "Italian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19545232-Reviews-Maurizio_s_Pizzeria-Vilnius_Vilnius_County.html" },
                    { 844L, "Vilnius", "Lithuania", 54.6819585, 25.279805100000001, "Room", null, "Vilniaus g. 39", "Caribbean, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9593357-Reviews-Rhum_Room-Vilnius_Vilnius_County.html" },
                    { 845L, "Vilnius", "Lithuania", 54.689033199999997, 25.2656277, "Maison N", null, "3 A. Rotundo Gatve", "French", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14138737-Reviews-Maison_N-Vilnius_Vilnius_County.html" },
                    { 846L, "Vilnius", "Lithuania", 54.728009, 25.241247099999999, "Maukas", null, "Ukmerges g. 259A", "American, Belgian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13509456-Reviews-Maukas-Vilnius_Vilnius_County.html" },
                    { 847L, "Vilnius", "Lithuania", 54.682212200000002, 25.289341, "Sumara kavine", null, "Pilies g. 28", "Turkish", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13836811-Reviews-Sumara_kavine-Vilnius_Vilnius_County.html" },
                    { 848L, "Vilnius", "Lithuania", 54.676366999999999, 25.285785000000001, "Karmelitai", null, "Karmelitu g. 3", "Cafe, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7742843-Reviews-Karmelitai-Vilnius_Vilnius_County.html" },
                    { 838L, "Vilnius", "Lithuania", 54.680960900000002, 25.289764399999999, "D'oro Kavinuke", null, "Boksto gatve 1", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12212677-Reviews-D_oro_Kavinuke-Vilnius_Vilnius_County.html" },
                    { 875L, "Vilnius", "Lithuania", 54.684220699999997, 25.2732156, "Tauro 3", null, "Tauro g. 3", "Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11150259-Reviews-Tauro_3-Vilnius_Vilnius_County.html" },
                    { 876L, "Vilnius", "Lithuania", 54.6797453, 25.283892300000002, "UAB Mesyte", null, "Vokieciu 11", "American, Steakhouse", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11805146-Reviews-UAB_Mesyte-Vilnius_Vilnius_County.html" },
                    { 877L, "Vilnius", "Lithuania", 54.689985399999998, 25.287670599999998, "Kitas Krantas", "River Bank", "Zveju 14a", "Fast Food, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14142267-Reviews-Kitas_Krantas-Vilnius_Vilnius_County.html" },
                    { 904L, "Vilnius", "Lithuania", 54.688487899999998, 25.273155899999999, "Trip", null, "Gedimino pr. 31", "International", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2665975-Reviews-Trip-Vilnius_Vilnius_County.html" },
                    { 905L, "Vilnius", "Lithuania", 54.681120999999997, 25.27411, "Kulinarijos Studija", null, "Teatro g. 7-7", "$$$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9728988-Reviews-Kulinarijos_Studija-Vilnius_Vilnius_County.html" },
                    { 906L, "Vilnius", "Lithuania", 54.739481599999998, 25.218815299999999, "Pizza Rock", null, "Eitminu g. 18-120", "Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d16870307-Reviews-Pizza_Rock-Vilnius_Vilnius_County.html" },
                    { 907L, "Vilnius", "Lithuania", 54.6816824, 25.268590199999998, "MB Japoniskas maistas", null, "J. Basanaviciaus g. 26", "Japanese, Peruvian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19527305-Reviews-MB_Japoniskas_maistas-Vilnius_Vilnius_County.html" },
                    { 908L, "Vilnius", "Lithuania", 54.687155500000003, 25.279651399999999, "Sushi Express", "Molas", "K. Barsausko str. 66A", "Japanese, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14783828-Reviews-Sushi_Express-Vilnius_Vilnius_County.html" },
                    { 909L, "Vilnius", "Lithuania", 54.703361600000001, 25.283194600000002, "Sushi Out", null, "Kalvariju g. 88", "Japanese, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19112465-Reviews-Sushi_Out-Vilnius_Vilnius_County.html" },
                    { 910L, "Vilnius", "Lithuania", 54.6940466, 25.428156999999999, "Selavy", null, "Pramones g. 97", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d17820483-Reviews-Selavy-Vilnius_Vilnius_County.html" },
                    { 911L, "Vilnius", "Lithuania", 54.6890669, 25.278177100000001, "Saj", null, "A. Vienuolio g 1", "Fast Food, Mediterranean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19257428-Reviews-Saj-Vilnius_Vilnius_County.html" },
                    { 912L, "Vilnius", "Lithuania", 54.682636899999999, 25.276373700000001, "Darzas", null, "K. Kalinausko g. 2B", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d16708198-Reviews-Darzas-Vilnius_Vilnius_County.html" },
                    { 913L, "Vilnius", "Lithuania", 54.713966900000003, 25.272621399999998, "Labuki", null, "Ozo g. 18", "Japanese, Sushi", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14184680-Reviews-Labuki-Vilnius_Vilnius_County.html" },
                    { 903L, "Vilnius", "Lithuania", 54.672308299999997, 25.279317299999999, "Mua Xuan Viet & Asia. Vietnamo Virtuve", "Near Bus Stop", "Kauno g. 2", "Vietnamese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d18187950-Reviews-Mua_Xuan_Viet_Asia_Vietnamo_Virtuve-Vilnius_Vilnius_County.html" },
                    { 914L, "Vilnius", "Lithuania", 54.672056499999997, 25.274210499999999, "Kavos Era", null, "Kauno g. 16", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d18785714-Reviews-Kavos_Era-Vilnius_Vilnius_County.html" },
                    { 916L, "Vilnius", "Lithuania", 54.691961999999997, 25.2650519, "Raudonas Autobusiukas", "Prie Valstybes Zinios", "Lentpjuviu skg. 8", "American, Caribbean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12219712-Reviews-Raudonas_Autobusiukas-Vilnius_Vilnius_County.html" },
                    { 917L, "Vilnius", "Lithuania", 54.713966900000003, 25.272621399999998, "Pizza Hut Express", "Ozas Shopping & Entertainment Centre", "Ozo g. 18", "Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d18981110-Reviews-Pizza_Hut_Express-Vilnius_Vilnius_County.html" },
                    { 918L, "Vilnius", "Lithuania", 54.663567100000002, 25.237667600000002, "Chata Bbq", null, "Vilkpedes g. 20C", "Barbecue, Grill", "https://www.tripadvisor.com/Restaurant_Review-g274951-d16754292-Reviews-Chata_Bbq-Vilnius_Vilnius_County.html" },
                    { 919L, "Vilnius", "Lithuania", 54.735346, 25.220607000000001, "Hachik Kebab", null, "Gabijos g. 30", "Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19117059-Reviews-Hachik_Kebab-Vilnius_Vilnius_County.html" },
                    { 920L, "Vilnius", "Lithuania", 54.670198300000003, 25.284258300000001, "Baristokrat Specialty Coffee", "Main waiting hall", "Gelezinkelio g. 16", "Italian, French", "https://www.tripadvisor.com/Restaurant_Review-g274951-d18968024-Reviews-Baristokrat_Specialty_Coffee-Vilnius_Vilnius_County.html" },
                    { 921L, "Vilnius", "Lithuania", 54.676963299999997, 25.276474799999999, "Geri Laikai", null, "Naugarduko g. 12,", "International", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19492969-Reviews-Geri_Laikai-Vilnius_Vilnius_County.html" },
                    { 922L, "Vilnius", "Lithuania", 54.670123199999999, 25.261340199999999, "Moldova Wines Baltic States", "Smolenskio 7", "Kauno g. 36", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12823075-Reviews-Moldova_Wines_Baltic_States-Vilnius_Vilnius_County.html" },
                    { 923L, "Vilnius", "Lithuania", 54.693514100000002, 25.2883046, "Viva Pizza & Sushi & Wok", null, "Rinktines g. 16", "Italian, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19603432-Reviews-Viva_Pizza_Sushi_Wok-Vilnius_Vilnius_County.html" },
                    { 924L, "Vilnius", "Lithuania", 54.728038300000001, 25.240948700000001, "Kalimera", null, "Ukmerges G. 259", "Greek", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15564734-Reviews-Kalimera-Vilnius_Vilnius_County.html" },
                    { 925L, "Vilnius", "Lithuania", 54.742810400000003, 25.294954499999999, "The Owls", null, "Vaidilutes g. 79", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15839527-Reviews-The_Owls-Vilnius_Vilnius_County.html" },
                    { 915L, "Vilnius", "Lithuania", 54.683084000000001, 25.235931799999999, "Soko Riesutai", null, "M. K. Ciurlionio 100", "Italian, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10165007-Reviews-Soko_Riesutai-Vilnius_Vilnius_County.html" },
                    { 826L, "Vilnius", "Lithuania", 54.640650200000003, 25.2776359, "OnLine Cafe", "Vilnius International Airport (VNO)", "Rodunios Kelias 10A", "Cafe, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12321721-Reviews-OnLine_Cafe-Vilnius_Vilnius_County.html" },
                    { 902L, "Vilnius", "Lithuania", 54.688118199999998, 25.261523, "Kaljano Meistrai", "Entrance through the bowling bar", "Jasinskio Gatve 16", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d11995882-Reviews-Kaljano_Meistrai-Vilnius_Vilnius_County.html" },
                    { 900L, "Vilnius", "Lithuania", 54.679269599999998, 25.2705558, "Cheng Long", null, "Algirdo 8-2", "Chinese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15582118-Reviews-Cheng_Long-Vilnius_Vilnius_County.html" },
                    { 878L, "Vilnius", "Lithuania", 54.728868599999998, 25.2692911, "Mexican kitchen cuisine", null, "Didlaukio g. 80 A", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d10822472-Reviews-Mexican_kitchen_cuisine-Vilnius_Vilnius_County.html" },
                    { 879L, "Vilnius", "Lithuania", 54.670692000000003, 25.2817829, "Krido Bistro", null, "Sodu g. 22", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d17532369-Reviews-Krido_Bistro-Vilnius_Vilnius_County.html" },
                    { 880L, "Vilnius", "Lithuania", 54.676199599999997, 25.254980199999999, "Gero Alaus Parduotuve", null, "Savanoriu pr. 22", "$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10687572-Reviews-Gero_Alaus_Parduotuve-Vilnius_Vilnius_County.html" },
                    { 881L, "Vilnius", "Lithuania", 54.7210301, 25.2823581, "Busy Beet", null, "Balcikonio str. 9", "French, American", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12921963-Reviews-Busy_Beet-Vilnius_Vilnius_County.html" },
                    { 882L, "Vilnius", "Lithuania", 54.686378300000001, 25.276071999999999, "Paikis", null, "A. Smetonos g 5", "Fast Food, British", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17622129-Reviews-Paikis-Vilnius_Vilnius_County.html" },
                    { 883L, "Vilnius", "Lithuania", 54.732297799999998, 25.298228000000002, "Armenian Grill", null, "Vaidilutes g. 9", "Eastern European, Armenian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19516293-Reviews-Armenian_Grill-Vilnius_Vilnius_County.html" },
                    { 884L, "Vilnius", "Lithuania", 54.6719504, 25.1574727, "JCS Kiauliu Valdovai", null, "Titnago g. 78", "$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9884780-Reviews-JCS_Kiauliu_Valdovai-Vilnius_Vilnius_County.html" },
                    { 885L, "Vilnius", "Lithuania", 54.726921699999998, 25.232931000000001, "P&B Baras", null, "Zemynos g. 18", "American, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11435136-Reviews-P_B_Baras-Vilnius_Vilnius_County.html" },
                    { 886L, "Vilnius", "Lithuania", 54.689940999999997, 25.280230100000001, "Jusmira", null, "Vilniaus g. 1", "European, Central European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17853451-Reviews-Jusmira-Vilnius_Vilnius_County.html" },
                    { 887L, "Vilnius", "Lithuania", 54.687374900000002, 25.276888899999999, "Baras Gastronomas", "Inside Gastronomas Food Hall", "Gedimino pr. 24", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19451986-Reviews-Baras_Gastronomas-Vilnius_Vilnius_County.html" },
                    { 901L, "Vilnius", "Lithuania", 54.676471999999997, 25.291771099999998, "Leaf Cafe", null, "Subaciaus 16", "$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8560725-Reviews-Leaf_Cafe-Vilnius_Vilnius_County.html" },
                    { 888L, "Vilnius", "Lithuania", 54.700915899999998, 25.2853058, "Sushi Express", null, "H. Manto 90-1", "Japanese, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14783845-Reviews-Sushi_Express-Vilnius_Vilnius_County.html" },
                    { 890L, "Vilnius", "Lithuania", 54.710310399999997, 25.262674499999999, "Hanabi Fusion", null, "Ozo g. 25", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d10057697-Reviews-Hanabi_Fusion-Vilnius_Vilnius_County.html" },
                    { 891L, "Vilnius", "Lithuania", 54.689130900000002, 25.266751899999999, "LeBonjour", null, "Gedimino pr. 46", "French", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13078751-Reviews-LeBonjour-Vilnius_Vilnius_County.html" },
                    { 892L, "Vilnius", "Lithuania", 54.737034000000001, 25.229869999999998, "Broliu pizza", null, "Ukmerges g. 298", "Italian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13140371-Reviews-BroliU_pizza-Vilnius_Vilnius_County.html" },
                    { 893L, "Vilnius", "Lithuania", 54.6804737, 25.274585800000001, "Skonio Vejas", null, "J. Basanaviciaus g. 11", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13397000-Reviews-Skonio_Vejas-Vilnius_Vilnius_County.html" },
                    { 894L, "Vilnius", "Lithuania", 54.679993199999998, 25.278229499999998, "Arte Cafe", null, "Traku g. 2", "European, Turkish", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15033712-Reviews-Arte_Cafe-Vilnius_Vilnius_County.html" },
                    { 895L, "Vilnius", "Lithuania", 54.726921699999998, 25.232931000000001, "Alibaba Kinu Restoranas", null, "Zemynos g. 18", "Chinese, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12998201-Reviews-Alibaba_KinU_Restoranas-Vilnius_Vilnius_County.html" },
                    { 896L, "Vilnius", "Lithuania", 54.6967225, 25.2812397, "Zako Food Truck", null, "Kalvariju gatve 24A", "Fast Food, Street Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14080809-Reviews-Zako_Food_Truck-Vilnius_Vilnius_County.html" },
                    { 897L, "Vilnius", "Lithuania", 54.681194699999999, 25.294645599999999, "Zalia Zasis", null, "Malunu g. 3", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14106298-Reviews-Zalia_Zasis-Vilnius_Vilnius_County.html" },
                    { 898L, "Vilnius", "Lithuania", 54.679409999999997, 25.257871099999999, "Sushi City", null, "Savanoriu pr. 1", "Japanese, Seafood", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17756040-Reviews-Sushi_City-Vilnius_Vilnius_County.html" },
                    { 899L, "Vilnius", "Lithuania", 54.717894000000001, 25.2997671, "Pizza King", null, "Kareiviu G. 11A", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d16831390-Reviews-Pizza_King-Vilnius_Vilnius_County.html" },
                    { 889L, "Vilnius", "Lithuania", 54.674180700000001, 25.306534200000002, "Pieva", null, "P. Visinskio g. 10", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d18340908-Reviews-Pieva-Vilnius_Vilnius_County.html" },
                    { 825L, "Vilnius", "Lithuania", 54.688410900000001, 25.276493800000001, "Soya", null, "A. Vienuolio g 4", "Sushi, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10995085-Reviews-Soya-Vilnius_Vilnius_County.html" },
                    { 824L, "Vilnius", "Lithuania", 54.673531599999997, 25.254428399999998, "Magma", null, "Zemaites g. 8", "$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12237164-Reviews-Magma-Vilnius_Vilnius_County.html" },
                    { 823L, "Vilnius", "Lithuania", 54.689590199999998, 25.210557399999999, "Buga", null, "L. Asanaviciutes g. 17", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17567314-Reviews-Buga-Vilnius_Vilnius_County.html" },
                    { 749L, "Vilnius", "Lithuania", 54.6811036, 25.289904799999999, "Tower Gate Uab Manu Forti Restoranas", "Boksto g. 2", "Latako g. 1", "Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4641718-Reviews-Tower_Gate_Uab_Manu_Forti_Restoranas-Vilnius_Vilnius_County.html" },
                    { 750L, "Vilnius", "Lithuania", 54.784672999999998, 25.333939000000001, "Sernas", null, "Zaliuju ezeru g. 148", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d5486658-Reviews-Sernas-Vilnius_Vilnius_County.html" },
                    { 751L, "Vilnius", "Lithuania", 54.713966900000003, 25.272621399999998, "Mao", null, "Ozo g. 18", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d8058204-Reviews-Mao-Vilnius_Vilnius_County.html" },
                    { 752L, "Vilnius", "Lithuania", 54.713966900000003, 25.272621399999998, "Shimao", "OZAS Shopping centre", "Ozo Street 18", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13337200-Reviews-Shimao-Vilnius_Vilnius_County.html" },
                    { 753L, "Vilnius", "Lithuania", 54.682625000000002, 25.2801419, "Wall Street Avenue", null, "Vilniaus street 28", "American, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12108362-Reviews-Wall_Street_Avenue-Vilnius_Vilnius_County.html" },
                    { 754L, "Vilnius", "Lithuania", 54.682446800000001, 25.289344, "Kristupo Kavine", null, "Pilies g. 24", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d12868281-Reviews-Kristupo_Kavine-Vilnius_Vilnius_County.html" },
                    { 755L, "Vilnius", "Lithuania", 54.6819585, 25.279805100000001, "Room", null, "Vilniaus g. 39", "Caribbean, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9593357-Reviews-Rhum_Room-Vilnius_Vilnius_County.html" },
                    { 756L, "Vilnius", "Lithuania", 54.680407000000002, 25.2666009, "FOKUS Pizza", null, "Svitrigailos g. 4", "Italian, Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d928998-Reviews-FOKUS_Pizza-Vilnius_Vilnius_County.html" },
                    { 757L, "Vilnius", "Lithuania", 54.680302300000001, 25.292985099999999, "Kavine Boras", null, "Uzupio g. 1", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d5262628-Reviews-Kavine_Boras-Vilnius_Vilnius_County.html" },
                    { 758L, "Vilnius", "Lithuania", 54.689977900000002, 25.262150599999998, "Auksinis feniksas", null, "Gedimino pr. 64", "Chinese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1063376-Reviews-Auksinis_feniksas-Vilnius_Vilnius_County.html" },
                    { 748L, "Vilnius", "Lithuania", 54.697367, 25.266847899999998, "Azzurro Restoranas", null, "Konstitucijos pr. 26", "Mediterranean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13350863-Reviews-Azzurro_Restoranas-Vilnius_Vilnius_County.html" },
                    { 759L, "Vilnius", "Lithuania", 54.684396999999997, 25.295446999999999, "La Crepe Terrasse", null, "Bernardinu Sodas", "French, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8625016-Reviews-La_Crepe_Terrasse-Vilnius_Vilnius_County.html" },
                    { 761L, "Vilnius", "Lithuania", 54.677578699999998, 25.300212800000001, "Kava Tau UAB", "Subaciaus panorama", "Subaciaus apzvalgos aikstele", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12272611-Reviews-Kava_Tau_UAB-Vilnius_Vilnius_County.html" },
                    { 762L, "Vilnius", "Lithuania", 54.688875899999999, 25.268090300000001, "Pink&Yellow", null, "Gediminas avenue 44A", "Mexican, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19315679-Reviews-Pink_Yellow-Vilnius_Vilnius_County.html" },
                    { 763L, "Vilnius", "Lithuania", 54.676677900000001, 25.287860899999998, "KingWinn", null, "Etmonų g. 2", "Belgian, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15072509-Reviews-KingWinn-Vilnius_Vilnius_County.html" },
                    { 764L, "Vilnius", "Lithuania", 54.658052400000003, 25.142752900000001, "Krims kebab", "Motorway Vilnius-Kaunas", "Savanoriu pr. 247A", "Fast Food, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10459392-Reviews-Krims_kebab-Vilnius_Vilnius_County.html" },
                    { 765L, "Vilnius", "Lithuania", 54.726217400000003, 25.294590199999998, "Gedimino Smukle", null, "Zirmunu g. 139", "Seafood", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10247451-Reviews-Gedimino_Smukle-Vilnius_Vilnius_County.html" },
                    { 766L, "Vilnius", "Lithuania", 54.683295000000001, 25.282261999999999, "Adelia", null, "Totoriu g. 23", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13958378-Reviews-Adelia-Vilnius_Vilnius_County.html" },
                    { 767L, "Vilnius", "Lithuania", 54.713966900000003, 25.272621399999998, "No Forks Mexican Grill at OZAS", "Shopping Center OZAS", "Ozo g. 18", "Mexican, South American", "https://www.tripadvisor.com/Restaurant_Review-g274951-d16866847-Reviews-No_Forks_Mexican_Grill_at_OZAS-Vilnius_Vilnius_County.html" },
                    { 768L, "Vilnius", "Lithuania", 54.700393900000002, 25.257780100000002, "Pizza 360 Autentica", null, "Saltoniskiu g. 9", "Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17380475-Reviews-Pizza_360_Autentica-Vilnius_Vilnius_County.html" },
                    { 769L, "Vilnius", "Lithuania", 54.689085200000001, 25.275818600000001, "UAB Fudis", null, "A. Jaksto g. 7", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d10253153-Reviews-UAB_Fudis-Vilnius_Vilnius_County.html" },
                    { 770L, "Vilnius", "Lithuania", 54.679855400000001, 25.279341500000001, "Desi", null, "Traku g. 5", "Fast Food, Middle Eastern", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8435595-Reviews-Desi-Vilnius_Vilnius_County.html" },
                    { 760L, "Vilnius", "Lithuania", 54.698614999999997, 25.269275100000002, "Narauti", null, "Konstitucijos pr. 23", "$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9868457-Reviews-Narauti-Vilnius_Vilnius_County.html" },
                    { 771L, "Vilnius", "Lithuania", 54.676203000000001, 25.251797, "Kinu Broliai", null, "Savanoriu pr. 15", "Chinese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7368805-Reviews-Kinu_Broliai-Vilnius_Vilnius_County.html" },
                    { 747L, "Vilnius", "Lithuania", 54.679189399999998, 25.284500999999999, "Rice & Dough", null, "Vokieciu g. 9", "Italian, Japanese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10625366-Reviews-Rice_Dough-Vilnius_Vilnius_County.html" },
                    { 745L, "Vilnius", "Lithuania", 54.690890699999997, 25.264290299999999, "Dangiski Migdolai", null, "Gyneju g. 4", "International, Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7316574-Reviews-Dangiski_Migdolai-Vilnius_Vilnius_County.html" },
                    { 723L, "Vilnius", "Lithuania", 54.778562299999997, 25.091982099999999, "Zvejo Sapnas", "Suderves village", "Vilniaus g, 2a Suderve", "Seafood, Healthy", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12585708-Reviews-Zvejo_Sapnas-Vilnius_Vilnius_County.html" },
                    { 724L, "Vilnius", "Lithuania", 54.686047000000002, 25.2797363, "Selfiecide Bar", null, "Vilniaus g. 12-1", "Cafe, International", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14918642-Reviews-Selfiecide_Bar-Vilnius_Vilnius_County.html" },
                    { 725L, "Vilnius", "Lithuania", 54.733849499999998, 25.258997999999998, "KuroNeko Cafe", "Lower Level, next to Library", "Ateities g. 20", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d14810040-Reviews-KuroNeko_Cafe-Vilnius_Vilnius_County.html" },
                    { 726L, "Vilnius", "Lithuania", 54.686378300000001, 25.276071999999999, "Zatar falafel & hummus Kiosque", null, "A. Smetonos g 5", "Fast Food, Middle Eastern", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15814240-Reviews-Zatar_falafel_hummus_Kiosque-Vilnius_Vilnius_County.html" },
                    { 727L, "Vilnius", "Lithuania", 54.679201999999997, 25.288806900000001, "L'Elysee Restaurant", null, "Saviciaus g. 5", "French", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14125749-Reviews-L_Elysee_Restaurant-Vilnius_Vilnius_County.html" },
                    { 728L, "Vilnius", "Lithuania", 54.694914300000001, 25.2773413, "Didzioji Kinija", null, "Konstitucijos pr. 12", "Chinese, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7261901-Reviews-Didzioji_Kinija-Vilnius_Vilnius_County.html" },
                    { 729L, "Vilnius", "Lithuania", 54.685094100000001, 25.281200599999998, "Pablo Pub", null, "Labdariu g. 8", "German, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13343418-Reviews-Pablo_Pub-Vilnius_Vilnius_County.html" },
                    { 730L, "Vilnius", "Lithuania", 54.724171599999998, 25.319729899999999, "Kino Studija", null, "Nemencines Pl 2", "Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14480456-Reviews-Kino_Studija-Vilnius_Vilnius_County.html" },
                    { 731L, "Vilnius", "Lithuania", 54.698293999999997, 25.3108732, "BarKodas", "Vilnius Tech Park", "Antakalnio g. 17", "European, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12916051-Reviews-BarKodas-Vilnius_Vilnius_County.html" },
                    { 732L, "Vilnius", "Lithuania", 54.816332500000001, 24.9186817, "Pusynelis", "Verksionys", "108, Verkšionys", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d11872195-Reviews-Pusynelis-Vilnius_Vilnius_County.html" },
                    { 746L, "Vilnius", "Lithuania", 54.6804737, 25.274585800000001, "Smiki Smaki - bakery & cafe", null, "J. Basanaviciaus g. 11", "French, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12266378-Reviews-Smiki_Smaki_bakery_cafe-Vilnius_Vilnius_County.html" },
                    { 733L, "Vilnius", "Lithuania", 54.713966900000003, 25.272621399999998, "Subway", null, "Ozo g. 18", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d12439627-Reviews-Subway-Vilnius_Vilnius_County.html" },
                    { 735L, "Vilnius", "Lithuania", 54.676335399999999, 25.271190300000001, "Kavine 31", null, "31 Algirdo str.", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d10663073-Reviews-Kavine_31-Vilnius_Vilnius_County.html" },
                    { 736L, "Vilnius", "Lithuania", 54.674113300000002, 25.25385, "Geras maistas", null, "Zemaites g. 6", "International", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10235291-Reviews-Geras_maistas-Vilnius_Vilnius_County.html" },
                    { 737L, "Vilnius", "Lithuania", 54.681079099999998, 25.285259199999999, "MaD Dog", null, "Dominikonu g. 9", "$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9808461-Reviews-MaD_Dog-Vilnius_Vilnius_County.html" },
                    { 738L, "Vilnius", "Lithuania", 54.686032599999997, 25.279165599999999, "Crow Bar V19", null, "Vilniaus g. 19", "$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8408150-Reviews-Crow_Bar_V19-Vilnius_Vilnius_County.html" },
                    { 739L, "Vilnius", "Lithuania", 54.693916299999998, 25.2648999, "Pank'Uojantis Restoranas", null, "Gyneju g. 16", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d9871781-Reviews-Pank_Uojantis_Restoranas-Vilnius_Vilnius_County.html" },
                    { 740L, "Vilnius", "Lithuania", 54.693250999999997, 25.273554900000001, "Wine Box", null, "Upes g. 6", "Cafe, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10456601-Reviews-Wine_Box-Vilnius_Vilnius_County.html" },
                    { 741L, "Vilnius", "Lithuania", 54.694266800000001, 25.394125800000001, "Skardis", null, "Skardzio g. 10", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d5485675-Reviews-Skardis-Vilnius_Vilnius_County.html" },
                    { 742L, "Vilnius", "Lithuania", 54.686630899999997, 25.259621299999999, "Sushi Express", null, "J. Jasinskio g. 16A", "Japanese, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10607751-Reviews-Sushi_Express-Vilnius_Vilnius_County.html" },
                    { 743L, "Vilnius", "Lithuania", 54.670608999999999, 25.2787948, "Ajurvedine Virtuve - Stepono", null, "Sv. Stepono g. 31", "Indian, Healthy", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8433861-Reviews-Ajurvedine_Virtuve_Stepono-Vilnius_Vilnius_County.html" },
                    { 744L, "Vilnius", "Lithuania", 54.688410900000001, 25.276493800000001, "Tokyo / Thai Gourmet", null, "A. Vienuolio g 4", "Japanese, Thai", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1133795-Reviews-Tokyo_Thai_Gourmet-Vilnius_Vilnius_County.html" },
                    { 734L, "Vilnius", "Lithuania", 54.685646200000001, 25.324158300000001, "Restaurant Batoras", null, "Sroves G. 21", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8858536-Reviews-Restaurant_Batoras-Vilnius_Vilnius_County.html" },
                    { 721L, "Vilnius", "Lithuania", 54.713966900000003, 25.272621399999998, "Seklycia-Euro Pub", "PC Ozas-Shoping Center 3 Flor", "Ozo g. 18", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8514176-Reviews-Seklycia_Euro_Pub-Vilnius_Vilnius_County.html" },
                    { 772L, "Vilnius", "Lithuania", 54.713966900000003, 25.272621399999998, "Asaki", null, "Ozo G. 18", "Japanese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17785679-Reviews-Asaki-Vilnius_Vilnius_County.html" },
                    { 774L, "Vilnius", "Lithuania", 54.713966900000003, 25.272621399999998, "Can Can Pizza", null, "Ozo g. 18", "Pizza, Italian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10825844-Reviews-Can_Can_Pizza-Vilnius_Vilnius_County.html" },
                    { 801L, "Vilnius", "Lithuania", 54.681335900000001, 25.285154500000001, "Cosy", null, "Dominikonu Gatve 10", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d18460187-Reviews-Cosy-Vilnius_Vilnius_County.html" },
                    { 802L, "Vilnius", "Lithuania", 54.680370600000003, 25.2881833, "Cili Pica", null, "Didzioji g. 5", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4453229-Reviews-Cili_Pica-Vilnius_Vilnius_County.html" },
                    { 803L, "Vilnius", "Lithuania", 54.686185799999997, 25.2843999, "Il Mulino", null, "Gedimino pr. 2A", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9558112-Reviews-Il_Mulino-Vilnius_Vilnius_County.html" },
                    { 804L, "Vilnius", "Lithuania", 54.710310399999997, 25.262674499999999, "Dinner Map", null, "Ozo g. 25", "$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d18895607-Reviews-Dinner_Map-Vilnius_Vilnius_County.html" },
                    { 805L, "Vilnius", "Lithuania", 54.678504199999999, 25.284778299999999, "SOYA Asian Fusion", null, "Vokieciu g. 8", "Sushi, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d5602848-Reviews-SOYA_Asian_Fusion-Vilnius_Vilnius_County.html" },
                    { 806L, "Vilnius", "Lithuania", 54.700393900000002, 25.257780100000002, "La Crepe", "Panorama", "Saltoniskiu g. 9", "European, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2557516-Reviews-La_Crepe-Vilnius_Vilnius_County.html" },
                    { 807L, "Vilnius", "Lithuania", 54.703361600000001, 25.283194600000002, "Eat More Chicken", null, "Kalvariju g. 88", "Street Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12061849-Reviews-Eat_More_Chicken-Vilnius_Vilnius_County.html" },
                    { 808L, "Vilnius", "Lithuania", 54.680900700000002, 25.289787799999999, "Ararijo", null, "Boksto g. 3", "Korean, Chinese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17605901-Reviews-Ararijo-Vilnius_Vilnius_County.html" },
                    { 809L, "Vilnius", "Lithuania", 54.684736000000001, 25.279214, "Vanille Lounge", null, "Vilniaus g. 29", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6364150-Reviews-Vanille_Lounge-Vilnius_Vilnius_County.html" },
                    { 810L, "Vilnius", "Lithuania", 54.684615000000001, 25.2906464, "Barboros Svetaine", null, "B. Radvilaites g. 3", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11719865-Reviews-Barboros_Svetaine-Vilnius_Vilnius_County.html" },
                    { 800L, "Vilnius", "Lithuania", 54.692400999999997, 25.2210255, "Ha Noi", null, "Sausio 13- Osios Gatve 2-110", "Vietnamese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12885399-Reviews-Ha_Noi-Vilnius_Vilnius_County.html" },
                    { 811L, "Vilnius", "Lithuania", 54.643045899999997, 25.279819, "Pank’olis Airport", null, "Rodunios kelias 2", "Italian, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15182437-Reviews-Pank_olis_Airport-Vilnius_Vilnius_County.html" },
                    { 813L, "Vilnius", "Lithuania", 54.678954500000003, 25.263361400000001, "Restaurant Capriccio", "Grata Hotel", "Vytenio g. 9", "International", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12841543-Reviews-Restaurant_Capriccio-Vilnius_Vilnius_County.html" },
                    { 814L, "Vilnius", "Lithuania", 54.689977900000002, 25.262150599999998, "Kinu Roze", null, "Gedimino pr. 64", "Chinese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8724058-Reviews-Kinu_Roze-Vilnius_Vilnius_County.html" },
                    { 815L, "Vilnius", "Lithuania", 54.6501369, 25.280534400000001, "Cili Pizza", "PC Nordika", "Vikingu g. 3A", "Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12689768-Reviews-Cili_Pizza-Vilnius_Vilnius_County.html" },
                    { 816L, "Vilnius", "Lithuania", 54.715215800000003, 25.296279299999998, "Ramenas Ir Pagaliukai", null, "Lakunu g. 14B", "Japanese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d18380791-Reviews-Ramenas_Ir_Pagaliukai-Vilnius_Vilnius_County.html" },
                    { 817L, "Vilnius", "Lithuania", 54.740110999999999, 25.228211900000002, "Soya, Big, Vilnius, Lithuania", "1st Floor", "Ukmerges g. 369", "Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9701260-Reviews-Soya_Big_Vilnius_Lithuania-Vilnius_Vilnius_County.html" },
                    { 818L, "Vilnius", "Lithuania", 54.688487899999998, 25.273155899999999, "White Rice Restaurant", null, "Gedimino pr. 31", "Vietnamese, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17479376-Reviews-White_Rice_Restaurant-Vilnius_Vilnius_County.html" },
                    { 819L, "Vilnius", "Lithuania", 54.672719299999997, 25.286611199999999, "Pastopoly", "Hales Turgus , Pylimo g.58", "Pylimo g. 60", "Italian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13150355-Reviews-Pastopoly-Vilnius_Vilnius_County.html" },
                    { 820L, "Vilnius", "Lithuania", 54.680407000000002, 25.2666009, "American pizza burger", null, "Svitrigailos g. 4", "Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10729648-Reviews-American_pizza_burger-Vilnius_Vilnius_County.html" },
                    { 821L, "Vilnius", "Lithuania", 54.710310399999997, 25.262674499999999, "Cili Pizza", null, "Ozo g. 25", "Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12594202-Reviews-Cili_Pizza-Vilnius_Vilnius_County.html" },
                    { 822L, "Vilnius", "Lithuania", 54.624624400000002, 25.1726791, "Kavine Pas Rimute", null, "Misko gatve 6, Naujuju Valkininku k.", "Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7291487-Reviews-Kavine_Pas_Rimute-Vilnius_Vilnius_County.html" },
                    { 812L, "Vilnius", "Lithuania", 54.698177700000002, 25.270939500000001, "Pank'olis Quadrum", null, "Konstitucijos pr. 21", "Mediterranean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15065909-Reviews-Pank_olis_Quadrum-Vilnius_Vilnius_County.html" },
                    { 773L, "Vilnius", "Lithuania", 54.672985300000001, 25.258961500000002, "Quala", null, "Smolensko g. 10B", "Chinese, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15583798-Reviews-Quala-Vilnius_Vilnius_County.html" },
                    { 799L, "Vilnius", "Lithuania", 54.680302900000001, 25.277835, "AUX CHAMPS ELYSEES", null, "Pylimo g. 22", "French", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2371646-Reviews-AUX_CHAMPS_ELYSEES-Vilnius_Vilnius_County.html" },
                    { 797L, "Vilnius", "Lithuania", 54.6819585, 25.279805100000001, "Foodwankers", null, "Vilniaus g. 39", "Chinese, American", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10240199-Reviews-Foodwankers-Vilnius_Vilnius_County.html" },
                    { 775L, "Vilnius", "Lithuania", 54.693925100000001, 25.276128400000001, "Laikinoji Sostine", null, "Konstitucijos pr. 16", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d795790-Reviews-Laikinoji_Sostine-Vilnius_Vilnius_County.html" },
                    { 776L, "Vilnius", "Lithuania", 54.6950936, 25.287865400000001, "Desrainis24.lt", null, "Rinktines g. 24", "Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6922192-Reviews-Desrainis24_lt-Vilnius_Vilnius_County.html" },
                    { 777L, "Vilnius", "Lithuania", 54.714004199999998, 25.3163591, "9 Drakonai", null, "Antakalnio street 71", "Chinese, Fusion", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14533897-Reviews-9_Drakonai-Vilnius_Vilnius_County.html" },
                    { 778L, "Vilnius", "Lithuania", 54.7279129, 25.238897000000001, "Can Can Pizza", null, "Ukmerges g. 282", "Pizza, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10825846-Reviews-Can_Can_Pizza-Vilnius_Vilnius_County.html" },
                    { 779L, "Vilnius", "Lithuania", 54.713966900000003, 25.272621399999998, "Sriubos Diena", "Pc Ozas", "Ozo g. 18", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14213248-Reviews-Sriubos_Diena-Vilnius_Vilnius_County.html" },
                    { 780L, "Vilnius", "Lithuania", 54.689418799999999, 25.266864900000002, "Publikas", "Senamiestis", "Gedimino prospektas 39", "European, Mediterranean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15910413-Reviews-Publikas-Vilnius_Vilnius_County.html" },
                    { 781L, "Vilnius", "Lithuania", 54.696671100000003, 25.279034899999999, "Munch Pizza & Sushi", null, "Lvovo g. 25", "Italian, Japanese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17195487-Reviews-Munch_Pizza_Sushi-Vilnius_Vilnius_County.html" },
                    { 782L, "Vilnius", "Lithuania", 54.731649699999998, 25.245696800000001, "Baltasis Lotosas", null, "Ateities G. 91", "Chinese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6420655-Reviews-Baltasis_Lotosas-Vilnius_Vilnius_County.html" },
                    { 783L, "Vilnius", "Lithuania", 54.710310399999997, 25.262674499999999, "CanCan", null, "Ozo Gatve 25", "Pizza, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10825902-Reviews-CanCan-Vilnius_Vilnius_County.html" },
                    { 784L, "Vilnius", "Lithuania", 54.687240699999997, 25.2818468, "Huracan Coffee", null, "Gedimino pr. 9", "$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14799744-Reviews-Huracan_Coffee-Vilnius_Vilnius_County.html" },
                    { 798L, "Vilnius", "Lithuania", 54.692400999999997, 25.2210255, "Kebab House", null, "Sausio 13-osios g. 2", "European, Turkish", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14152837-Reviews-Kebab_House-Vilnius_Vilnius_County.html" },
                    { 785L, "Vilnius", "Lithuania", 54.687240699999997, 25.2818468, "Formosa Bubble Tea", "-1 Floor", "Gedimino pr. 9", "Chinese, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13511381-Reviews-Formosa_Bubble_Tea-Vilnius_Vilnius_County.html" },
                    { 787L, "Vilnius", "Lithuania", 54.712061200000001, 25.2862543, "Bar Be Que Kepsnine", null, "Kalvariju g. 172A", "Barbecue, Grill", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8354143-Reviews-Bar_Be_Que_Kepsnine-Vilnius_Vilnius_County.html" },
                    { 788L, "Vilnius", "Lithuania", 54.676130899999997, 25.274889099999999, "Rytai", null, "Naugarduko g. 22", "Chinese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9609268-Reviews-Rytai-Vilnius_Vilnius_County.html" },
                    { 789L, "Vilnius", "Lithuania", 54.694982799999998, 25.274673499999999, "Sushi Express", null, "Konstitucijos pr. 20", "Japanese, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10607736-Reviews-Sushi_Express-Vilnius_Vilnius_County.html" },
                    { 790L, "Vilnius", "Lithuania", 54.656584000000002, 25.138779100000001, "CanCan Pizza", null, "Savanoriu pr. 247", "Pizza, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10832925-Reviews-CanCan_Pizza-Vilnius_Vilnius_County.html" },
                    { 791L, "Vilnius", "Lithuania", 54.679876800000002, 25.290310099999999, "Smukle", null, "Boksto g. 9", "Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12117748-Reviews-Smukle-Vilnius_Vilnius_County.html" },
                    { 792L, "Vilnius", "Lithuania", 54.713816899999998, 25.2939282, "Cuba Studija Pub&Club", null, "Verkiu g. 29", "American, Caribbean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10146632-Reviews-Cuba_Studija_Pub_Club-Vilnius_Vilnius_County.html" },
                    { 793L, "Vilnius", "Lithuania", 54.682575800000002, 25.235156799999999, "Picnic Bistro", "Vingio Parkas", "M. K. Ciurlionio g. 98", "International, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7965571-Reviews-Picnic_Bistro-Vilnius_Vilnius_County.html" },
                    { 794L, "Vilnius", "Lithuania", 54.698905699999997, 25.270710399999999, "Le Butcher", null, "Konstitucijos Prospektas 21C", "American, Steakhouse", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12012360-Reviews-Le_Butcher-Vilnius_Vilnius_County.html" },
                    { 795L, "Vilnius", "Lithuania", 54.678324799999999, 25.2772507, "La Cocina de Jose", null, "Pylimo g. 23", "European, Spanish", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11924264-Reviews-La_Cocina_de_Jose-Vilnius_Vilnius_County.html" },
                    { 796L, "Vilnius", "Lithuania", 54.695990000000002, 25.307587000000002, "Trys Puseles", null, "Antakalnio g. 12", "Fusion", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12726233-Reviews-Trys_Puseles-Vilnius_Vilnius_County.html" },
                    { 786L, "Vilnius", "Lithuania", 54.700540199999999, 25.270102399999999, "BARCELONA", null, "Linkmenu g. 5", "Mediterranean, Spanish", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1053704-Reviews-BARCELONA-Vilnius_Vilnius_County.html" },
                    { 514L, "Vilnius", "Lithuania", 54.694914300000001, 25.2773413, "Stars and Legends", "Konstitucijos ave.12", "Konstitucijos pr. 12", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4282814-Reviews-Stars_and_Legends-Vilnius_Vilnius_County.html" },
                    { 513L, "Vilnius", "Lithuania", 54.661499999999997, 25.337727900000001, "Tores Bravoras", null, "Guriu g. 10", "European, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6508999-Reviews-Tores_Bravoras-Vilnius_Vilnius_County.html" },
                    { 512L, "Vilnius", "Lithuania", 54.684891899999997, 25.281956999999998, "Mojitos Casa De Cuba", null, "Totoriu g. 11", "Cuban, Caribbean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9762667-Reviews-Mojitos_Casa_De_Cuba-Vilnius_Vilnius_County.html" },
                    { 231L, "Vilnius", "Lithuania", 54.686700999999999, 25.283262000000001, "Prie Katedros", null, "Gedimino pr. 5", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1593086-Reviews-Prie_Katedros-Vilnius_Vilnius_County.html" },
                    { 232L, "Vilnius", "Lithuania", 54.672865799999997, 25.278794399999999, "Ararat", null, "Kauno g. 3a", "Eastern European, Armenian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3923745-Reviews-Ararat-Vilnius_Vilnius_County.html" },
                    { 233L, "Vilnius", "Lithuania", 54.676408899999998, 25.288837000000001, "Etno Dvaras", null, "Ausros Vartu g. 2", "Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15574643-Reviews-Etno_Dvaras-Vilnius_Vilnius_County.html" }
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "RestaurantId", "City", "Country", "Latitude", "Longitude", "Name", "SpecifyStreet", "Street", "Type", "Url" },
                values: new object[,]
                {
                    { 234L, "Vilnius", "Lithuania", 54.681617000000003, 25.291853, "Steakhouse Hazienda", null, "Maironio g. 13", "European, Central European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1083976-Reviews-Steakhouse_Hazienda-Vilnius_Vilnius_County.html" },
                    { 235L, "Vilnius", "Lithuania", 54.676048000000002, 25.284486999999999, "Burbulio Vynine", null, "Rudninku g. 18", "Italian, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2277538-Reviews-Burbulio_Vynine-Vilnius_Vilnius_County.html" },
                    { 236L, "Vilnius", "Lithuania", 54.680731600000001, 25.2966193, "Maghrib Restaurant", "Uzupio Street 22-3", "Uzupis Str. 22", "Mediterranean, Moroccan", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4134331-Reviews-Maghrib_Restaurant-Vilnius_Vilnius_County.html" },
                    { 237L, "Vilnius", "Lithuania", 54.678638900000003, 25.285744699999999, "Charlie Pizza", null, "Vokieciu g. 3", "Pizza, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2555470-Reviews-Charlie_Pizza-Vilnius_Vilnius_County.html" },
                    { 238L, "Vilnius", "Lithuania", 54.696327400000001, 25.276653499999998, "Vapiano", "EUROPA Shopping Centre", "Konstitucijos pr. 7A", "Italian, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2241887-Reviews-Vapiano-Vilnius_Vilnius_County.html" },
                    { 239L, "Vilnius", "Lithuania", 54.673729000000002, 25.283965999999999, "Cup & Cake Kavine", null, "Sodu g. 5", "French, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17817201-Reviews-Cup_Cake_Kavine-Vilnius_Vilnius_County.html" },
                    { 240L, "Vilnius", "Lithuania", 54.68788, 25.267590899999998, "Local Pub", null, "J. Jasinskio g 1", "Bar, American", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12535440-Reviews-Local_Pub-Vilnius_Vilnius_County.html" },
                    { 241L, "Vilnius", "Lithuania", 54.670198300000003, 25.284258300000001, "Gusto Blynine", null, "Gelezinkelio g. 16", "Cafe, Russian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6437199-Reviews-Gusto_Blynine-Vilnius_Vilnius_County.html" },
                    { 242L, "Vilnius", "Lithuania", 54.676677900000001, 25.287860899999998, "Peri Peri Old Town", null, "Etmonu g. 2", "American, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13296967-Reviews-Peri_Peri_Old_Town-Vilnius_Vilnius_County.html" },
                    { 243L, "Vilnius", "Lithuania", 54.682446800000001, 25.289344, "Narutis Restaurant", null, "Pilies g. 24", "Eastern European, International", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1931622-Reviews-Narutis_Restaurant-Vilnius_Vilnius_County.html" },
                    { 244L, "Vilnius", "Lithuania", 54.679502499999998, 25.283383799999999, "La Provence", null, "Vokieciu g. 22", "French, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d812283-Reviews-La_Provence-Vilnius_Vilnius_County.html" },
                    { 245L, "Vilnius", "Lithuania", 54.684396999999997, 25.295446999999999, "Sugamour Summer Terrace", null, "Bernardinu sodas, B. Radvilaites g. 8A", "Cafe, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14161526-Reviews-Sugamour_Summer_Terrace-Vilnius_Vilnius_County.html" },
                    { 246L, "Vilnius", "Lithuania", 54.681480100000002, 25.289173099999999, "Marche de Provence", null, "Pilies gatve 27", "French, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2280936-Reviews-Marche_de_Provence-Vilnius_Vilnius_County.html" },
                    { 247L, "Vilnius", "Lithuania", 54.692130900000002, 25.2642393, "Stebuklai", null, "Gyneju g. 14", "European, International", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3531089-Reviews-Stebuklai-Vilnius_Vilnius_County.html" },
                    { 248L, "Vilnius", "Lithuania", 54.683470100000001, 25.279014199999999, "Piano Piano Vilnius", null, "Vilniaus g. 33", "Italian, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12723189-Reviews-Piano_Piano_Vilnius-Vilnius_Vilnius_County.html" },
                    { 249L, "Vilnius", "Lithuania", 54.676734000000003, 25.2674637, "Baltoji Kate VINO e PIZZA ITALIANA", null, "Svitrigailos g. 11A", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10784499-Reviews-Baltoji_Kate_VINO_e_PIZZA_ITALIANA-Vilnius_Vilnius_County.html" },
                    { 250L, "Vilnius", "Lithuania", 54.713816899999998, 25.2939282, "Buceris", null, "Verkiu g. 29", "Steakhouse, Deli", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9830922-Reviews-Buceris-Vilnius_Vilnius_County.html" },
                    { 251L, "Vilnius", "Lithuania", 54.676155100000003, 25.2883204, "Invino", null, "Ausros Vartu g. 7", "European, Wine Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1021509-Reviews-Invino-Vilnius_Vilnius_County.html" },
                    { 230L, "Vilnius", "Lithuania", 54.675639400000001, 25.283271899999999, "Belgai", null, "Rudninku 15", "Belgian, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3859559-Reviews-Belgai-Vilnius_Vilnius_County.html" },
                    { 229L, "Vilnius", "Lithuania", 54.680731000000002, 25.293157799999999, "Uzupio Kavine", null, "Uzupio g. 2", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d783315-Reviews-Uzupio_Kavine-Vilnius_Vilnius_County.html" },
                    { 228L, "Vilnius", "Lithuania", 54.678076699999998, 25.2869478, "Zuvine", "Town Hall", "Didzioji g. 31", "Seafood, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3335150-Reviews-Zuvine-Vilnius_Vilnius_County.html" },
                    { 227L, "Vilnius", "Lithuania", 54.6745442, 25.289279499999999, "Ugnies Smukle", null, "Ausros Vartu g. 19", "Barbecue, Grill", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15090652-Reviews-Ugnies_Smukle-Vilnius_Vilnius_County.html" },
                    { 205L, "Vilnius", "Lithuania", 54.688487899999998, 25.273155899999999, "Drama Burger", null, "Gedimino pr. 31", "American, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d5602852-Reviews-Drama_Burger-Vilnius_Vilnius_County.html" },
                    { 206L, "Vilnius", "Lithuania", 54.684081300000003, 25.2858242, "Klaipedos Senamiestis", null, "S. Daukanto a 2", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6579881-Reviews-Klaipedos_Senamiestis-Vilnius_Vilnius_County.html" },
                    { 207L, "Vilnius", "Lithuania", 54.676639000000002, 25.286730899999998, "Bix", null, "Etmonu g. 6", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1194012-Reviews-Bix-Vilnius_Vilnius_County.html" },
                    { 208L, "Vilnius", "Lithuania", 54.680541900000001, 25.285914900000002, "Stikliai Restaurant", "LT-01131", "Gaono g. 7", "International, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1656515-Reviews-Stikliai_Restaurant-Vilnius_Vilnius_County.html" },
                    { 209L, "Vilnius", "Lithuania", 54.680743, 25.298039800000002, "Le Travi", null, "Uzupio g. 19", "Italian, Mediterranean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14129979-Reviews-Le_Travi-Vilnius_Vilnius_County.html" },
                    { 210L, "Vilnius", "Lithuania", 54.687950899999997, 25.2743082, "Radharane Vegatarian Restaurant", "18 Ozo g., PC Ozas", "Gedimino pr. 32", "Indian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2388369-Reviews-Radharane_Vegatarian_Restaurant-Vilnius_Vilnius_County.html" },
                    { 211L, "Vilnius", "Lithuania", 54.680694699999997, 25.269565, "Borsch Restaurant", null, "Algirdo g. 5", "Ukrainian, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3838040-Reviews-Borsch_Restaurant-Vilnius_Vilnius_County.html" },
                    { 212L, "Vilnius", "Lithuania", 54.693894999999998, 25.276167999999998, "La Crepe", null, "Upes g. 9", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6579202-Reviews-La_Crepe-Vilnius_Vilnius_County.html" },
                    { 213L, "Vilnius", "Lithuania", 54.685552700000002, 25.284753899999998, "Zoe's Bar & Grill", null, "Odminiu g. 3", "Bar, International", "https://www.tripadvisor.com/Restaurant_Review-g274951-d886736-Reviews-Zoe_s_Bar_Grill-Vilnius_Vilnius_County.html" },
                    { 214L, "Vilnius", "Lithuania", 54.680999200000002, 25.297797299999999, "Uzupio Klasika", null, "Uzupio g. 28", "European, Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6404272-Reviews-Uzupio_Klasika-Vilnius_Vilnius_County.html" },
                    { 252L, "Vilnius", "Lithuania", 54.678890000000003, 25.277615399999998, "Sluoksniai", null, "Pylimo g. 19", "Cafe, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12678077-Reviews-Sluoksniai-Vilnius_Vilnius_County.html" },
                    { 215L, "Vilnius", "Lithuania", 54.687951900000002, 25.2761551, "Restaurant Neringa", null, "Gedimino pr. 23", "Eastern European, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1867444-Reviews-Restaurant_Neringa-Vilnius_Vilnius_County.html" },
                    { 217L, "Vilnius", "Lithuania", 54.684878900000001, 25.292781000000002, "Restaurant Upe", null, "Maironio g. 1", "European, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15679754-Reviews-Restaurant_Upe-Vilnius_Vilnius_County.html" },
                    { 218L, "Vilnius", "Lithuania", 54.679409999999997, 25.257871099999999, "Dodo pizza Helios City", null, "Savanoriu pr. 1", "Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17593584-Reviews-Dodo_pizza_Helios_City-Vilnius_Vilnius_County.html" },
                    { 219L, "Vilnius", "Lithuania", 54.686483899999999, 25.284301899999999, "Say Cheese", null, "Gedimino pr. 3a", "International, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12903121-Reviews-Say_Cheese-Vilnius_Vilnius_County.html" },
                    { 220L, "Vilnius", "Lithuania", 54.700393900000002, 25.257780100000002, "Manami", "Panorama", "Saltoniskiu g. 9", "Chinese, Japanese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7903257-Reviews-Manami-Vilnius_Vilnius_County.html" },
                    { 221L, "Vilnius", "Lithuania", 54.694514900000001, 25.287992899999999, "Pitarija \"Fire Place\"", null, "Seimyniskiu g. 17", "International, Vietnamese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8556500-Reviews-Pitarija_Fire_Place-Vilnius_Vilnius_County.html" },
                    { 222L, "Vilnius", "Lithuania", 54.686700999999999, 25.283262000000001, "CRAFT & DRAFT brewpub and whiskey", null, "5, Gedimino prospektas", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11904343-Reviews-CRAFT_DRAFT_brewpub_and_whiskey-Vilnius_Vilnius_County.html" },
                    { 223L, "Vilnius", "Lithuania", 54.676337199999999, 25.281587900000002, "Bizarre", null, "Pylimo g. 38", "Sushi, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12031936-Reviews-Bizarre-Vilnius_Vilnius_County.html" },
                    { 224L, "Vilnius", "Lithuania", 54.681660000000001, 25.2657989, "Vathaitau", null, "J. Basanaviciaus g. 37", "Asian, Thai", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9598031-Reviews-Vathaitau-Vilnius_Vilnius_County.html" },
                    { 225L, "Vilnius", "Lithuania", 54.679797800000003, 25.297446399999998, "Paupio 12", "Uzupis", "Paupio g. 12", "Pizza, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12148092-Reviews-Paupio_12-Vilnius_Vilnius_County.html" },
                    { 226L, "Vilnius", "Lithuania", 54.684193800000003, 25.290067400000002, "Decantus", null, "Pilies g. 6", "Wine Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9601613-Reviews-Decantus-Vilnius_Vilnius_County.html" },
                    { 216L, "Vilnius", "Lithuania", 54.687240699999997, 25.2818468, "Carre", null, "Gedimino pr. 9", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4453142-Reviews-Carre-Vilnius_Vilnius_County.html" },
                    { 253L, "Vilnius", "Lithuania", 54.680541900000001, 25.285914900000002, "Stikliai Tavern", null, "Gaono g. 7", "Eastern European, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3544149-Reviews-Stikliai_Tavern-Vilnius_Vilnius_County.html" },
                    { 254L, "Vilnius", "Lithuania", 54.677646000000003, 25.284275000000001, "Le Butcher", null, "Mesiniu g. 3", "American, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7231393-Reviews-Le_Butcher-Vilnius_Vilnius_County.html" },
                    { 255L, "Vilnius", "Lithuania", 54.713966900000003, 25.272621399999998, "Charlie Pizza", "Ozas", "Ozo g. 18", "Italian, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8603289-Reviews-Charlie_Pizza-Vilnius_Vilnius_County.html" },
                    { 282L, "Vilnius", "Lithuania", 54.735729900000003, 25.253136999999999, "Fabai", null, "Ateities g. 21A", "Barbecue, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3785613-Reviews-Fabai-Vilnius_Vilnius_County.html" },
                    { 283L, "Vilnius", "Lithuania", 54.6800377, 25.2787024, "Pizzaland", null, "Traku g. 4", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6631041-Reviews-Pizzaland-Vilnius_Vilnius_County.html" },
                    { 284L, "Vilnius", "Lithuania", 54.677335100000001, 25.287307200000001, "Astorija Brasserie", null, "Didzioji g. 35-2", "French", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6418613-Reviews-Astorija_Brasserie-Vilnius_Vilnius_County.html" },
                    { 285L, "Vilnius", "Lithuania", 54.6765422, 25.288965099999999, "California Tapas & Wine", null, "Subaciaus str. 2", "Seafood, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1870288-Reviews-California_Tapas_Wine-Vilnius_Vilnius_County.html" },
                    { 286L, "Vilnius", "Lithuania", 54.675465000000003, 25.282343900000001, "Baziliskas", null, "Raugyklos g. 5", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12269649-Reviews-Baziliskas-Vilnius_Vilnius_County.html" },
                    { 287L, "Vilnius", "Lithuania", 54.679432400000003, 25.288203899999999, "Queensberry", null, "Didzioji g. 18", "Wine Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15097236-Reviews-Queensberry-Vilnius_Vilnius_County.html" },
                    { 288L, "Vilnius", "Lithuania", 54.684785499999997, 25.357065899999998, "Belmontas", null, "Belmonto g. 17", "Barbecue, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2108362-Reviews-Belmontas-Vilnius_Vilnius_County.html" },
                    { 289L, "Vilnius", "Lithuania", 54.689085200000001, 25.275818600000001, "Saigon", null, "A. Jaksto g 7", "Asian, Vietnamese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12230160-Reviews-Saigon-Vilnius_Vilnius_County.html" },
                    { 290L, "Vilnius", "Lithuania", 54.682254899999997, 25.2658083, "Desertine Atostogos", null, "M. K. Ciurlionio g. 8", "Italian, French", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8765516-Reviews-Desertine_Atostogos-Vilnius_Vilnius_County.html" },
                    { 291L, "Vilnius", "Lithuania", 54.679409999999997, 25.257871099999999, "Carskoje selo", "Helios City", "Savanoriu pr. 1", "Russian, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6436887-Reviews-Carskoje_selo-Vilnius_Vilnius_County.html" },
                    { 281L, "Vilnius", "Lithuania", 54.686568200000004, 25.281063100000001, "PANK'olis Avenue", "City centre", "Gedimino Avenue 12", "International, Fusion", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12848828-Reviews-PANK_olis_Avenue-Vilnius_Vilnius_County.html" },
                    { 292L, "Vilnius", "Lithuania", 54.681527500000001, 25.285808100000001, "Flow Bar", null, "Dominikonu g. 14", "European, Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17701590-Reviews-Flow_Bar-Vilnius_Vilnius_County.html" },
                    { 294L, "Vilnius", "Lithuania", 54.6846715, 25.2905984, "Mian", null, "Barboros Radvilaites g. 5", "Chinese, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14142044-Reviews-Mian-Vilnius_Vilnius_County.html" },
                    { 295L, "Vilnius", "Lithuania", 54.680337999999999, 25.262222000000001, "Valgomasis", null, "J. Basanaviciaus g. 44", "European, Soups", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9748035-Reviews-Valgomasis-Vilnius_Vilnius_County.html" },
                    { 296L, "Vilnius", "Lithuania", 54.685855799999999, 25.281991699999999, "Veg Cafe Vegetarian Restaurant", null, "Totoriu g. 3", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6780522-Reviews-Veg_Cafe_Vegetarian_Restaurant-Vilnius_Vilnius_County.html" },
                    { 297L, "Vilnius", "Lithuania", 54.689359699999997, 25.265891400000001, "Fumosumo", null, "Rotundo 2", "Sushi, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13152538-Reviews-Fumosumo-Vilnius_Vilnius_County.html" },
                    { 298L, "Vilnius", "Lithuania", 54.828102100000002, 25.277181500000001, "Araks", null, "Raudondvaris, Araks", "Barbecue, Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1830379-Reviews-Araks-Vilnius_Vilnius_County.html" },
                    { 299L, "Vilnius", "Lithuania", 54.689355999999997, 25.267831900000001, "CanCan Pizza", null, "Gedimino pr. 37", "Pizza, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10832920-Reviews-CanCan_Pizza-Vilnius_Vilnius_County.html" },
                    { 300L, "Vilnius", "Lithuania", 54.680377700000001, 25.293534000000001, "Devinke", null, "Uzupio 4", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11777791-Reviews-Devinke-Vilnius_Vilnius_County.html" },
                    { 301L, "Vilnius", "Lithuania", 54.680058000000002, 25.277391999999999, "City Chef Barbecue", null, "J. Basanaviciaus g 1", "American, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13227735-Reviews-City_Chef_Barbecue-Vilnius_Vilnius_County.html" },
                    { 302L, "Vilnius", "Lithuania", 54.679292699999998, 25.283606200000001, "Osteria Pizzeria A' Roma", null, "Vokieciu g. 18A", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13134249-Reviews-Osteria_Pizzeria_A_Roma-Vilnius_Vilnius_County.html" },
                    { 303L, "Vilnius", "Lithuania", 54.693925100000001, 25.276128400000001, "Manami", "Vcup", "Konstitucijos pr. 16", "Chinese, Japanese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7158556-Reviews-Manami-Vilnius_Vilnius_County.html" },
                    { 293L, "Vilnius", "Lithuania", 54.686147900000002, 25.286151199999999, "Grill Terrace", null, "Sventaragio g. 3", "European, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8677806-Reviews-Grill_Terrace-Vilnius_Vilnius_County.html" },
                    { 204L, "Vilnius", "Lithuania", 54.680016999999999, 25.286184500000001, "Notre Vie", null, "Stikliu g. 10", "European, Wine Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3566621-Reviews-Notre_Vie-Vilnius_Vilnius_County.html" },
                    { 280L, "Vilnius", "Lithuania", 54.679346000000002, 25.289083000000002, "Gatves Kepejai", null, "Saviciaus g. 6", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11549311-Reviews-Gatves_Kepejai-Vilnius_Vilnius_County.html" },
                    { 278L, "Vilnius", "Lithuania", 54.676922300000001, 25.2848048, "Atmosphere - Gastro Cafe", "Ground Floor", "Rudninku Gatve 12", "International, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d16851819-Reviews-Atmosphere_Gastro_Cafe-Vilnius_Vilnius_County.html" },
                    { 256L, "Vilnius", "Lithuania", 54.672668600000002, 25.289757300000002, "Anayor", null, "Ausros Vartu g. 27", "Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13329842-Reviews-Anayor-Vilnius_Vilnius_County.html" },
                    { 257L, "Vilnius", "Lithuania", 54.675830900000001, 25.288549700000001, "12 Istoriju", null, "Ausros Vartu g. 9", "European, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8383275-Reviews-12_Istoriju-Vilnius_Vilnius_County.html" },
                    { 258L, "Vilnius", "Lithuania", 54.683876300000001, 25.279057900000002, "MADU", null, "Islandijos g. 1", "Bar, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15368222-Reviews-MADU-Vilnius_Vilnius_County.html" },
                    { 259L, "Vilnius", "Lithuania", 54.680084000000001, 25.285868000000001, "Cibulis Restaurant and Bar", "Located on the corner of the Stikliu and M. Antokolskio gatvė", "12, Stikliu Gatve", "International, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d16433311-Reviews-Cibulis_Restaurant_and_Bar-Vilnius_Vilnius_County.html" },
                    { 260L, "Vilnius", "Lithuania", 54.693357900000002, 25.2693157, "Alaus Namai", null, "A. Gostauto g. 8", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4424191-Reviews-Alaus_Namai-Vilnius_Vilnius_County.html" },
                    { 261L, "Vilnius", "Lithuania", 54.686094900000001, 25.279101900000001, "Alynas", null, "Jogailos g. 6", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6628576-Reviews-Alynas-Vilnius_Vilnius_County.html" },
                    { 262L, "Vilnius", "Lithuania", 54.679955800000002, 25.286706599999999, "Augustas ir Barbora", null, "Stikliu g. 7", "Cafe, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17380183-Reviews-Augustas_ir_Barbora-Vilnius_Vilnius_County.html" },
                    { 263L, "Vilnius", "Lithuania", 54.707946999999997, 25.295832900000001, "Alaus Studija", null, "S. Zukausko g. 20", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d5999536-Reviews-Alaus_Studija-Vilnius_Vilnius_County.html" },
                    { 264L, "Vilnius", "Lithuania", 54.685863900000001, 25.278717799999999, "Debut Cafe", null, "Jogailos g. 8", "European, Central European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3163718-Reviews-Debut_Cafe-Vilnius_Vilnius_County.html" },
                    { 265L, "Vilnius", "Lithuania", 54.685544800000002, 25.279676500000001, "Newton", null, "Vilniaus g. 16", "Steakhouse, Neapolitan", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17444680-Reviews-Newton-Vilnius_Vilnius_County.html" },
                    { 279L, "Vilnius", "Lithuania", 54.686525899999999, 25.279710900000001, "Manami", null, "Vilniaus g. 10", "Japanese, Sushi", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13418515-Reviews-Manami-Vilnius_Vilnius_County.html" },
                    { 266L, "Vilnius", "Lithuania", 54.680609500000003, 25.282302999999999, "St. Valentino", null, "Vilnius str. 47", "Italian, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2628831-Reviews-St_Valentino-Vilnius_Vilnius_County.html" },
                    { 268L, "Vilnius", "Lithuania", 54.680509999999998, 25.2882815, "El Mercado", null, "Didzioji g. 3", "Seafood, Mediterranean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13085668-Reviews-El_Mercado-Vilnius_Vilnius_County.html" },
                    { 269L, "Vilnius", "Lithuania", 54.683876300000001, 25.279057900000002, "Piano Man Story bar", null, "Islandijos g. 1", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7990729-Reviews-Piano_Man_Story_bar-Vilnius_Vilnius_County.html" },
                    { 270L, "Vilnius", "Lithuania", 54.693501099999999, 25.250709000000001, "Don Simon", null, "Kestucio g. 24a", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10729618-Reviews-Don_Simon-Vilnius_Vilnius_County.html" },
                    { 271L, "Vilnius", "Lithuania", 54.710310399999997, 25.262674499999999, "Delano", "PC Akropolis", "Ozo g. 25", "Fast Food, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2043967-Reviews-Delano-Vilnius_Vilnius_County.html" },
                    { 272L, "Vilnius", "Lithuania", 54.684162399999998, 25.2778615, "Briusly", null, "Islandijos g. 4", "Asian, Thai", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1010220-Reviews-Briusly-Vilnius_Vilnius_County.html" },
                    { 273L, "Vilnius", "Lithuania", 54.713332600000001, 25.295966, "Peri Peri", "Šeimos aikštė 3, Ogmios miestas", "Seimos aikste 3", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12120949-Reviews-Peri_Peri-Vilnius_Vilnius_County.html" },
                    { 274L, "Vilnius", "Lithuania", 54.713816899999998, 25.2939282, "Meze Restoranas", "Seimos Aikste 2", "Verkiu g. 29", "Mediterranean, Greek", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11829571-Reviews-Meze_Restoranas-Vilnius_Vilnius_County.html" },
                    { 275L, "Vilnius", "Lithuania", 54.694302999999998, 25.283591000000001, "Carskoje Selo", null, "Seimyniskiu g. 3", "Eastern European, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2558043-Reviews-Carskoje_Selo-Vilnius_Vilnius_County.html" },
                    { 276L, "Vilnius", "Lithuania", 54.679211899999999, 25.289162900000001, "Saviciaus sPUNKa", null, "Saviciaus g. 9", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13531465-Reviews-Saviciaus_sPUNKa-Vilnius_Vilnius_County.html" },
                    { 277L, "Vilnius", "Lithuania", 54.693501099999999, 25.250709000000001, "Sushi Stop", null, "Kestucio g. 24 a", "Japanese, Sushi", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8479369-Reviews-Sushi_Stop-Vilnius_Vilnius_County.html" },
                    { 267L, "Vilnius", "Lithuania", 54.686700999999999, 25.283262000000001, "Girta Bite", null, "Gedimino pr. 5", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15321886-Reviews-Girta_Bite-Vilnius_Vilnius_County.html" },
                    { 203L, "Vilnius", "Lithuania", 54.673992900000002, 25.284318299999999, "Deveti", null, "Sodu g. 3", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7219400-Reviews-Deveti-Vilnius_Vilnius_County.html" },
                    { 202L, "Vilnius", "Lithuania", 54.689366, 25.251540800000001, "Panama Food Garden", null, "Vykinto g. 17A", "Seafood, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7284214-Reviews-Panama_Food_Garden-Vilnius_Vilnius_County.html" },
                    { 201L, "Vilnius", "Lithuania", 54.6819585, 25.279805100000001, "Rhum Room", null, "Vilniaus g. 39", "Caribbean, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9593357-Reviews-Rhum_Room-Vilnius_Vilnius_County.html" },
                    { 127L, "Vilnius", "Lithuania", 54.678896399999999, 25.2782442, "Somm", null, "Pylimo g. 21", "Mediterranean, Wine Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11868909-Reviews-Somm-Vilnius_Vilnius_County.html" },
                    { 128L, "Vilnius", "Lithuania", 54.682153999999997, 25.2914019, "Saint Germain", null, "Literatu g. 9", "French, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d812279-Reviews-Saint_Germain-Vilnius_Vilnius_County.html" },
                    { 129L, "Vilnius", "Lithuania", 54.694314300000002, 25.282409900000001, "Rib Room", null, "Seimyniskiu g. 1", "Barbecue, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2520676-Reviews-Rib_Room-Vilnius_Vilnius_County.html" },
                    { 130L, "Vilnius", "Lithuania", 54.676734000000003, 25.2674637, "Varenyky", null, "Svitrigailos g. 11A", "Ukrainian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8478041-Reviews-Varenyky-Vilnius_Vilnius_County.html" },
                    { 131L, "Vilnius", "Lithuania", 54.674500000000002, 25.269435000000001, "Senoji Trobele", null, "Naugarduko g. 36", "European, Balti", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3169105-Reviews-Senoji_Trobele-Vilnius_Vilnius_County.html" },
                    { 132L, "Vilnius", "Lithuania", 54.684389400000001, 25.289909699999999, "Grey", null, "Pilies g. 2", "International, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8746678-Reviews-Grey-Vilnius_Vilnius_County.html" },
                    { 133L, "Vilnius", "Lithuania", 54.685855799999999, 25.281991699999999, "Vegafe", null, "Totoriu g. 3", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2692065-Reviews-Vegafe-Vilnius_Vilnius_County.html" },
                    { 134L, "Vilnius", "Lithuania", 54.674748299999997, 25.270196200000001, "Zemaiciu Asotis", null, "Naugarduko g. 32-1", "Latvian, Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8076894-Reviews-Zemaiciu_Asotis-Vilnius_Vilnius_County.html" },
                    { 135L, "Vilnius", "Lithuania", 54.680016999999999, 25.286184500000001, "Restaurant Lokys", null, "Stikliu str. 10", "European, Latvian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1173558-Reviews-Restaurant_Lokys-Vilnius_Vilnius_County.html" },
                    { 136L, "Vilnius", "Lithuania", 54.681497899999997, 25.2847641, "Meat Lovers Pub", null, "Sv. Ignoto 14", "American, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3208166-Reviews-Meat_Lovers_Pub-Vilnius_Vilnius_County.html" },
                    { 126L, "Vilnius", "Lithuania", 54.687520900000003, 25.2761499, "THE TOWN Steakhouse", null, "Gedimino pr. 26", "Steakhouse", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7243178-Reviews-THE_TOWN_Steakhouse-Vilnius_Vilnius_County.html" },
                    { 137L, "Vilnius", "Lithuania", 54.681189400000001, 25.301982599999999, "Snekutis", null, "Polocko g. 7A", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d799959-Reviews-Snekutis-Vilnius_Vilnius_County.html" },
                    { 139L, "Vilnius", "Lithuania", 54.686109799999997, 25.285978499999999, "Boom Burgers Lithuania", null, "Gedimino pr. 1", "Barbecue, American", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6761325-Reviews-Boom_Burgers_Lithuania-Vilnius_Vilnius_County.html" },
                    { 140L, "Vilnius", "Lithuania", 54.684634099999997, 25.282416300000001, "Busi Trecias", null, "Totoriu g. 18", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d801069-Reviews-Busi_Trecias-Vilnius_Vilnius_County.html" },
                    { 141L, "Vilnius", "Lithuania", 54.674774399999997, 25.2824913, "Snekutis", null, "Sv. Stepono 8", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d815001-Reviews-Snekutis-Vilnius_Vilnius_County.html" },
                    { 142L, "Vilnius", "Lithuania", 54.687494899999997, 25.279091999999999, "La Crepe", null, "Gedimino pr. 13", "French, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4293749-Reviews-La_Crepe-Vilnius_Vilnius_County.html" },
                    { 143L, "Vilnius", "Lithuania", 54.683506000000001, 25.291912, "Shakespeare Hotel Restaurant", null, "Bernardinu g. 8-8", "Central European, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3157815-Reviews-Shakespeare_Hotel_Restaurant-Vilnius_Vilnius_County.html" },
                    { 144L, "Vilnius", "Lithuania", 54.6754976, 25.288881, "Galo do Porto", null, "Ausros Vartu g. 11", "Seafood, Mediterranean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8630939-Reviews-Galo_do_Porto-Vilnius_Vilnius_County.html" },
                    { 145L, "Vilnius", "Lithuania", 54.684821999999997, 25.291877100000001, "RoseHip Vegan Bistro", null, "B. Radvilaites G. 7", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13707977-Reviews-RoseHip_Vegan_Bistro-Vilnius_Vilnius_County.html" },
                    { 146L, "Vilnius", "Lithuania", 54.700393900000002, 25.257780100000002, "Guacamole", "SLC Panorama", "Saltoniskiu g. 9", "Mexican, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12693049-Reviews-Guacamole-Vilnius_Vilnius_County.html" },
                    { 147L, "Vilnius", "Lithuania", 54.6782653, 25.2851824, "Georgian House", null, "Mesiniu Gatve 4-3", "Eastern European, Georgian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11890598-Reviews-Georgian_House-Vilnius_Vilnius_County.html" },
                    { 148L, "Vilnius", "Lithuania", 54.679600000000001, 25.2856655, "Rene", null, "M. Antokolskio g. 13", "Belgian, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1063316-Reviews-Rene-Vilnius_Vilnius_County.html" },
                    { 138L, "Vilnius", "Lithuania", 54.681224999999998, 25.298368, "Sturmu Svyturys", null, "Uzupio g. 30", "Seafood, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7894191-Reviews-Sturmu_Svyturys-Vilnius_Vilnius_County.html" },
                    { 149L, "Vilnius", "Lithuania", 54.685552700000002, 25.284753899999998, "Sue's Indian Raja", null, "Odminiu str. 3", "Indian, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d779192-Reviews-Sue_s_Indian_Raja-Vilnius_Vilnius_County.html" },
                    { 125L, "Vilnius", "Lithuania", 54.686700999999999, 25.283262000000001, "Cat Cafe Kaciu Kavine", null, "Gedimino pr. 5", "Cafe, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7288639-Reviews-Cat_Cafe_KaciU_Kavine-Vilnius_Vilnius_County.html" },
                    { 123L, "Vilnius", "Lithuania", 54.689986400000002, 25.289074299999999, "Boff", null, "Olimpieciu g. 1", "Steakhouse, Barbecue", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3699264-Reviews-Boff-Vilnius_Vilnius_County.html" },
                    { 101L, "Vilnius", "Lithuania", 54.680819200000002, 25.2971909, "Sweet Root", null, "Uzupio g. 22-1", "European, Central European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6857584-Reviews-Sweet_Root-Vilnius_Vilnius_County.html" },
                    { 102L, "Vilnius", "Lithuania", 54.681442500000003, 25.286437899999999, "D'eco Bar & Restaurant", null, "Dominikonu g. 15", "International, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11929746-Reviews-D_eco_Bar_Restaurant-Vilnius_Vilnius_County.html" },
                    { 103L, "Vilnius", "Lithuania", 54.682212200000002, 25.289341, "Jurgis ir Drakonas Pilies", null, "Pilies gatve 28", "Pizza, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15055888-Reviews-Jurgis_ir_Drakonas_Pilies-Vilnius_Vilnius_County.html" },
                    { 104L, "Vilnius", "Lithuania", 54.713816899999998, 25.2939282, "Jurgis ir Drakonas Ogmios", "Ogmios Miestas, Seimos Aikste 6", "Verkiu g. 29", "Pizza, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7285270-Reviews-Jurgis_ir_Drakonas_Ogmios-Vilnius_Vilnius_County.html" },
                    { 105L, "Vilnius", "Lithuania", 54.6800377, 25.2787024, "Alaus Biblioteka", null, "Traku g. 4", "International, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7740892-Reviews-Alaus_Biblioteka-Vilnius_Vilnius_County.html" },
                    { 106L, "Vilnius", "Lithuania", 54.684736000000001, 25.279214, "Selfish Bistro - wine and seafood", null, "Vilniaus g. 29", "European, Wine Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12187277-Reviews-Selfish_Bistro_wine_and_seafood-Vilnius_Vilnius_County.html" },
                    { 107L, "Vilnius", "Lithuania", 54.681840000000001, 25.280929, "Trinity", null, "Vilniaus g. 30", "French, Mediterranean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8508576-Reviews-Trinity-Vilnius_Vilnius_County.html" },
                    { 108L, "Vilnius", "Lithuania", 54.678324799999999, 25.2772507, "Gaspar's Restoranas", "Behind Iki store at Pylimo street", "Pylimo g. 23-3", "Indian, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8868503-Reviews-Gaspar_s_Restoranas-Vilnius_Vilnius_County.html" },
                    { 109L, "Vilnius", "Lithuania", 54.684652, 25.285744000000001, "Telegrafas at Kempinski", null, "Universiteto g. 14", "European, Central European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4586963-Reviews-Telegrafas_at_Kempinski-Vilnius_Vilnius_County.html" },
                    { 110L, "Vilnius", "Lithuania", 54.680421899999999, 25.277787100000001, "Jurgis ir Drakonas Pylimo", null, "Pylimo g. 22D", "Pizza, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7190965-Reviews-Jurgis_ir_Drakonas_Pylimo-Vilnius_Vilnius_County.html" },
                    { 124L, "Vilnius", "Lithuania", 54.683157199999997, 25.290089399999999, "Mykolo 4", null, "Sv. Mykolo g. 4", "Eastern European, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2314488-Reviews-Mykolo_4-Vilnius_Vilnius_County.html" },
                    { 111L, "Vilnius", "Lithuania", 54.6797453, 25.283892300000002, "Bon Chop", null, "Vokieciu g. 11", "Steakhouse, Barbecue", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11873412-Reviews-Bon_Chop-Vilnius_Vilnius_County.html" },
                    { 113L, "Vilnius", "Lithuania", 54.679993199999998, 25.278229499999998, "King & Mouse - Whisky Bar & Shop", null, "Traku g. 2", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4282485-Reviews-King_Mouse_Whisky_Bar_Shop-Vilnius_Vilnius_County.html" },
                    { 114L, "Vilnius", "Lithuania", 54.673055300000001, 25.283091899999999, "Chacapuri Sodu", null, "Sodu g. 9", "Soups, Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8456585-Reviews-Chacapuri_Sodu-Vilnius_Vilnius_County.html" },
                    { 115L, "Vilnius", "Lithuania", 54.6754976, 25.288881, "BUNTE GANS", null, "Ausros Vartu g. 11", "German, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1498860-Reviews-BUNTE_GANS-Vilnius_Vilnius_County.html" },
                    { 116L, "Vilnius", "Lithuania", 54.710310399999997, 25.262674499999999, "Jurgis ir Drakonas Akropolio", "2nd Floor", "Ozo g. 25", "Pizza, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7988553-Reviews-Jurgis_ir_Drakonas_Akropolio-Vilnius_Vilnius_County.html" },
                    { 117L, "Vilnius", "Lithuania", 54.681881699999998, 25.286359300000001, "Fiorentino", null, "Universiteto g. 4", "Italian, Mediterranean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2273916-Reviews-Fiorentino-Vilnius_Vilnius_County.html" },
                    { 118L, "Vilnius", "Lithuania", 54.680394800000002, 25.2809922, "14Horses Uptown", null, "Traku g. 14", "Scandinavian, International", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4888865-Reviews-14Horses_Uptown-Vilnius_Vilnius_County.html" },
                    { 119L, "Vilnius", "Lithuania", 54.6801374, 25.2809019, "Gyvas Baras", "2 Pranciškonų street", "11 Traku street", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7912906-Reviews-Gyvas_Baras-Vilnius_Vilnius_County.html" },
                    { 120L, "Vilnius", "Lithuania", 54.6855495, 25.279182599999999, "Da Antonio", null, "Vilniaus g. 23", "Italian, Mediterranean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d783178-Reviews-Da_Antonio-Vilnius_Vilnius_County.html" },
                    { 121L, "Vilnius", "Lithuania", 54.680838100000003, 25.285159799999999, "Bistro 18", null, "Stikliu g. 18", "European, Central European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1006749-Reviews-Bistro_18-Vilnius_Vilnius_County.html" },
                    { 122L, "Vilnius", "Lithuania", 54.685518299999998, 25.2750737, "Lauro lapas", null, "Pamenkalnio g. 24", "European, Central European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3187222-Reviews-Lauro_lapas-Vilnius_Vilnius_County.html" },
                    { 112L, "Vilnius", "Lithuania", 54.684314899999997, 25.2825208, "Trattoria da Flavio", null, "Totoriu g. 22", "Italian, Mediterranean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7254665-Reviews-Trattoria_da_Flavio-Vilnius_Vilnius_County.html" },
                    { 304L, "Vilnius", "Lithuania", 54.680662599999998, 25.2948092, "Health Restaurant", "Užupis", "Malunu g. 4", "European, Fusion", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12895670-Reviews-Health_Restaurant-Vilnius_Vilnius_County.html" },
                    { 150L, "Vilnius", "Lithuania", 54.676048000000002, 25.284486999999999, "Casa La Familia", null, "Rudninku g. 18", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11954280-Reviews-Casa_La_Familia-Vilnius_Vilnius_County.html" },
                    { 152L, "Vilnius", "Lithuania", 54.677340899999997, 25.267818999999999, "Pizza di Ascari", null, "Svitrigailos g. 16", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10326443-Reviews-Pizza_di_Ascari-Vilnius_Vilnius_County.html" },
                    { 179L, "Vilnius", "Lithuania", 54.678809600000001, 25.2703761, "Fortas", "Konstitucijos pr. 7A", "Algirdo g. 17", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2304285-Reviews-Fortas-Vilnius_Vilnius_County.html" },
                    { 180L, "Vilnius", "Lithuania", 54.683104399999998, 25.290231800000001, "Gabi Restaurant", null, "Sv. Mykolo 6", "European, Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1503440-Reviews-Gabi_Restaurant-Vilnius_Vilnius_County.html" },
                    { 181L, "Vilnius", "Lithuania", 54.675387899999997, 25.285093100000001, "Sofa de Pancho", null, "Visu Sventuju g. 5", "Mexican", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4061652-Reviews-Sofa_de_Pancho-Vilnius_Vilnius_County.html" },
                    { 182L, "Vilnius", "Lithuania", 54.684035000000002, 25.2897511, "Pilies Katpedele", null, "Pilies g. 8", "European, Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10202268-Reviews-Pilies_Katpedele-Vilnius_Vilnius_County.html" },
                    { 183L, "Vilnius", "Lithuania", 54.678896299999998, 25.2839761, "Gyoza Bar", null, "Vokieciu g. 14", "Japanese, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12167671-Reviews-Gyoza_Bar-Vilnius_Vilnius_County.html" },
                    { 184L, "Vilnius", "Lithuania", 54.706927499999999, 25.285181300000001, "Pizza Verde", null, "Kalvariju g. 101A", "Pizza, Italian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10836394-Reviews-Pizza_Verde-Vilnius_Vilnius_County.html" },
                    { 185L, "Vilnius", "Lithuania", 54.675638399999997, 25.289042899999998, "Medininkai", null, "Ausros Vartu str 8", "Grill", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1533411-Reviews-Medininkai-Vilnius_Vilnius_County.html" },
                    { 186L, "Vilnius", "Lithuania", 54.672438499999998, 25.280588099999999, "Kavine Ceburekine", null, "V. Sopeno g. 3", "Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8646584-Reviews-Kavine_Ceburekine-Vilnius_Vilnius_County.html" },
                    { 187L, "Vilnius", "Lithuania", 54.684735500000002, 25.2846826, "The Old Green House", null, "L. Stuokos Guceviciaus g. 5", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3365492-Reviews-The_Old_Green_House-Vilnius_Vilnius_County.html" },
                    { 188L, "Vilnius", "Lithuania", 54.671699099999998, 25.274847900000001, "Time", "Comfort Hotel LT", "Mindaugo g. 27", "European, Central European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3601227-Reviews-Time-Vilnius_Vilnius_County.html" },
                    { 178L, "Vilnius", "Lithuania", 54.679160799999998, 25.287042400000001, "Maurizio's Italian Food", null, "Didzioji G. 19 A", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11970412-Reviews-Maurizio_s_Italian_Food-Vilnius_Vilnius_County.html" },
                    { 189L, "Vilnius", "Lithuania", 54.679705400000003, 25.283171100000001, "Beer House & Craft Kitchen", null, "Vokieciu str. 24", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10307144-Reviews-Beer_House_Craft_Kitchen-Vilnius_Vilnius_County.html" },
                    { 191L, "Vilnius", "Lithuania", 54.713816899999998, 25.2939282, "Holigans", "Ogmios Miestas", "Verkiu g. 29", "International, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9798229-Reviews-Holigans-Vilnius_Vilnius_County.html" },
                    { 192L, "Vilnius", "Lithuania", 54.680182199999997, 25.2880368, "Nineteen18", null, "Didzioji gatve 7", "International", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15090777-Reviews-Nineteen18-Vilnius_Vilnius_County.html" },
                    { 193L, "Vilnius", "Lithuania", 54.689262999999997, 25.268439900000001, "Dine Restoranas", null, "Gedimino pr. 35", "International, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7319190-Reviews-Dine_Restoranas-Vilnius_Vilnius_County.html" },
                    { 194L, "Vilnius", "Lithuania", 54.713816899999998, 25.2939282, "Brooklyn Brothers", "Ogmios Miestas, Šeimos Aikštė 3", "Verkiu g. 29", "Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13206857-Reviews-Brooklyn_Brothers-Vilnius_Vilnius_County.html" },
                    { 195L, "Vilnius", "Lithuania", 54.681487699999998, 25.284701999999999, "Vieta", null, "Sv. Ignoto g. 12-1", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4550914-Reviews-Vieta-Vilnius_Vilnius_County.html" },
                    { 196L, "Vilnius", "Lithuania", 54.6839431, 25.279566200000001, "Mano guru", null, "Vilniaus g. 22-1", "Cafe, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1067489-Reviews-Mano_guru-Vilnius_Vilnius_County.html" },
                    { 197L, "Vilnius", "Lithuania", 54.676506400000001, 25.289740399999999, "Namai", null, "Subaciaus g. 6", "International, Fusion", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8435239-Reviews-Namai-Vilnius_Vilnius_County.html" },
                    { 198L, "Vilnius", "Lithuania", 54.679637499999998, 25.285561600000001, "Markus ir Ko", null, "M. Antokolskio Str. 11", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1052650-Reviews-Markus_ir_Ko-Vilnius_Vilnius_County.html" },
                    { 199L, "Vilnius", "Lithuania", 54.679346000000002, 25.289083000000002, "La Storia", null, "Saviciaus g. 6", "Italian, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6816792-Reviews-La_Storia-Vilnius_Vilnius_County.html" },
                    { 200L, "Vilnius", "Lithuania", 54.680509999999998, 25.2882815, "Ti'ana", null, "Didzioji g. 3", "Italian, Mediterranean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8479635-Reviews-Ti_ana-Vilnius_Vilnius_County.html" },
                    { 190L, "Vilnius", "Lithuania", 54.684789700000003, 25.2791152, "Republic Baras", null, "Vilniaus g. 27", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7282716-Reviews-Republic_Baras-Vilnius_Vilnius_County.html" },
                    { 151L, "Vilnius", "Lithuania", 54.681932400000001, 25.287611299999998, "Ertlio Namas", null, "Sv. Jono g. 7", "European, Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8553720-Reviews-Ertlio_Namas-Vilnius_Vilnius_County.html" },
                    { 177L, "Vilnius", "Lithuania", 54.679160799999998, 25.287042400000001, "Amatininku Uzeiga", null, "Didzioji g. 19", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2085513-Reviews-Amatininku_Uzeiga-Vilnius_Vilnius_County.html" },
                    { 175L, "Vilnius", "Lithuania", 54.67689, 25.276176400000001, "Kinza", null, "Naugarduko g. 14", "Asian, Middle Eastern", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6537010-Reviews-Kinza-Vilnius_Vilnius_County.html" },
                    { 153L, "Vilnius", "Lithuania", 54.679479299999997, 25.2868225, "Aline Leiciai", null, "Stikliu g. 4", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4044358-Reviews-Aline_Leiciai-Vilnius_Vilnius_County.html" },
                    { 154L, "Vilnius", "Lithuania", 54.679892100000004, 25.287637, "Kitchen", null, "Didzioji g. 11", "European, Central European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2295604-Reviews-Kitchen-Vilnius_Vilnius_County.html" },
                    { 155L, "Vilnius", "Lithuania", 54.688410900000001, 25.276493800000001, "Berneliu Uzeiga", null, "A. Vienuolio g 4a", "European, Latvian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2423995-Reviews-Berneliu_Uzeiga-Vilnius_Vilnius_County.html" },
                    { 156L, "Vilnius", "Lithuania", 54.683196700000003, 25.289500700000001, "Etno Dvaras", null, "Pilies g. 16", "European, Balti", "https://www.tripadvisor.com/Restaurant_Review-g274951-d941394-Reviews-Etno_Dvaras-Vilnius_Vilnius_County.html" },
                    { 157L, "Vilnius", "Lithuania", 54.684837299999998, 25.2823417, "Blue Lotus Indian & Thai Restaurant", null, "Totoriu g. 16", "Indian, Thai", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8438346-Reviews-Blue_Lotus_Indian_Thai_Restaurant-Vilnius_Vilnius_County.html" },
                    { 158L, "Vilnius", "Lithuania", 54.680536500000002, 25.294902499999999, "One For All", null, "Uzupio g. 10", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9859248-Reviews-One_For_All-Vilnius_Vilnius_County.html" },
                    { 159L, "Vilnius", "Lithuania", 54.680199600000002, 25.295323100000001, "Uzupio picerija", null, "Paupio g. 3", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1067492-Reviews-Uzupio_picerija-Vilnius_Vilnius_County.html" },
                    { 160L, "Vilnius", "Lithuania", 54.677889899999997, 25.282481900000001, "Snekutis", null, "Sv. Mikalojaus g. 15", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7651726-Reviews-Snekutis-Vilnius_Vilnius_County.html" },
                    { 161L, "Vilnius", "Lithuania", 54.6765422, 25.288965099999999, "Imperial", null, "Subaciaus Str. 2", "European, French", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6366869-Reviews-Imperial-Vilnius_Vilnius_County.html" },
                    { 162L, "Vilnius", "Lithuania", 54.676155100000003, 25.2883204, "The Portobello", null, "Ausros Vartu g. 7", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2485320-Reviews-The_Portobello-Vilnius_Vilnius_County.html" },
                    { 176L, "Vilnius", "Lithuania", 54.678327799999998, 25.287892200000002, "Saula", null, "Didzioji str. 26", "Central European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12114846-Reviews-Saula-Vilnius_Vilnius_County.html" },
                    { 163L, "Vilnius", "Lithuania", 54.676774999999999, 25.288309000000002, "Cafe Montmartre", null, "Didzioji g. 40", "French, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4400717-Reviews-Cafe_Montmartre-Vilnius_Vilnius_County.html" },
                    { 165L, "Vilnius", "Lithuania", 54.682947900000002, 25.281874800000001, "La Boheme", null, "Sv. Ignoto g. 4-3", "European, Wine Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1155513-Reviews-La_Boheme-Vilnius_Vilnius_County.html" },
                    { 166L, "Vilnius", "Lithuania", 54.680495100000002, 25.295552900000001, "Prie Angelo", null, "Uzupio g. 9", "European, Grill", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4168458-Reviews-Prie_Angelo-Vilnius_Vilnius_County.html" },
                    { 167L, "Vilnius", "Lithuania", 54.675934300000002, 25.2888986, "Gusto Blynine", null, "Ausros Vartu g. 6", "American, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d816220-Reviews-Gusto_Blynine-Vilnius_Vilnius_County.html" },
                    { 168L, "Vilnius", "Lithuania", 54.682625000000002, 25.2801419, "Distilerija", null, "Vilniaus g. 28", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10041823-Reviews-Distilerija-Vilnius_Vilnius_County.html" },
                    { 169L, "Vilnius", "Lithuania", 54.69388, 25.2510598, "VERANDA svetaine - baras", null, "Kestucio g. 39", "European, Central European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2319344-Reviews-VERANDA_svetaine_baras-Vilnius_Vilnius_County.html" },
                    { 170L, "Vilnius", "Lithuania", 54.681335900000001, 25.285154500000001, "Cozy", null, "Dominikonu street 10", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d982450-Reviews-Cozy-Vilnius_Vilnius_County.html" },
                    { 171L, "Vilnius", "Lithuania", 54.693565499999998, 25.278360599999999, "Pirmas Blynas", null, "Konstitucijos pr. 12A", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15142060-Reviews-Pirmas_Blynas-Vilnius_Vilnius_County.html" },
                    { 172L, "Vilnius", "Lithuania", 54.682625000000002, 25.2801419, "Dziaugsmas", null, "Vilniaus g. 28", "Contemporary", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12210617-Reviews-Dziaugsmas-Vilnius_Vilnius_County.html" },
                    { 173L, "Vilnius", "Lithuania", 54.683470100000001, 25.279014199999999, "Grill London", null, "Vilniaus g. 33", "Steakhouse, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10326420-Reviews-Grill_London-Vilnius_Vilnius_County.html" },
                    { 174L, "Vilnius", "Lithuania", 54.6752088, 25.289150899999999, "Ristorante Sorrentino", null, "Ausros Vartu g. 15", "Italian, Mediterranean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10636482-Reviews-Ristorante_Sorrentino-Vilnius_Vilnius_County.html" },
                    { 164L, "Vilnius", "Lithuania", 54.679201999999997, 25.288948999999999, "Balzac", null, "Saviciaus g. 7", "French, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1584318-Reviews-Balzac-Vilnius_Vilnius_County.html" },
                    { 305L, "Vilnius", "Lithuania", 54.689221500000002, 25.2661582, "Restaurant Esse", null, "Gedimino pr. 50-2", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1626456-Reviews-Restaurant_Esse-Vilnius_Vilnius_County.html" },
                    { 306L, "Vilnius", "Lithuania", 54.678257000000002, 25.287650500000002, "LABUKI", "2 Floor", "Didzioji g. 28", "Japanese, Sushi", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2016513-Reviews-LABUKI-Vilnius_Vilnius_County.html" },
                    { 307L, "Vilnius", "Lithuania", 54.699565900000003, 25.282959300000002, "Chacapuri Kalvariju street", "From Turgaus street side", "61 Kalvariju St", "Georgian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11894764-Reviews-Chacapuri_Kalvariju_street-Vilnius_Vilnius_County.html" },
                    { 438L, "Vilnius", "Lithuania", 54.676343000000003, 25.289360299999998, "Renaissance Restoranas", null, "Subaciaus g. 3", "Italian, Mediterranean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12506432-Reviews-Renaissance_Restoranas-Vilnius_Vilnius_County.html" },
                    { 439L, "Vilnius", "Lithuania", 54.653154200000003, 25.304198899999999, "Can Can Pizza", null, "Liepkalnio G 112", "Grill, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10825932-Reviews-Can_Can_Pizza-Vilnius_Vilnius_County.html" },
                    { 440L, "Vilnius", "Lithuania", 54.685628999999999, 25.259226999999999, "BASILICO, restoranas, UAB VAKANDRA", null, "A. Gostauto g. 40C", "Italian, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4591121-Reviews-BASILICO_restoranas_UAB_VAKANDRA-Vilnius_Vilnius_County.html" },
                    { 441L, "Vilnius", "Lithuania", 54.6813821, 25.280771699999999, "Balti Drambliai", null, "Vilniaus g. 41", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1048792-Reviews-Balti_Drambliai-Vilnius_Vilnius_County.html" },
                    { 442L, "Vilnius", "Lithuania", 54.673670000000001, 25.286079900000001, "Assorti Gourmet", null, "Pylimo g. 58", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d14130723-Reviews-Assorti_Gourmet-Vilnius_Vilnius_County.html" }
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "RestaurantId", "City", "Country", "Latitude", "Longitude", "Name", "SpecifyStreet", "Street", "Type", "Url" },
                values: new object[,]
                {
                    { 443L, "Vilnius", "Lithuania", 54.740110999999999, 25.228211900000002, "Etno Dvaras", "PC BIG Vilnius Shoppingcenter", "Ukmerges g. 369", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11689386-Reviews-Etno_Dvaras-Vilnius_Vilnius_County.html" },
                    { 444L, "Vilnius", "Lithuania", 54.6900999, 25.2802668, "Restaurant \"Draugai\"", null, "Vilniaus g. 4", "International, Caucasian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12992075-Reviews-Restaurant_Draugai-Vilnius_Vilnius_County.html" },
                    { 445L, "Vilnius", "Lithuania", 54.680619800000002, 25.296227500000001, "Pronto Pizza", null, "Uzupio g. 13", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17762871-Reviews-Pronto_Pizza-Vilnius_Vilnius_County.html" },
                    { 446L, "Vilnius", "Lithuania", 54.698614999999997, 25.269275100000002, "9 Drakonai", null, "Konstitucijos avenue 23", "Chinese, Fusion", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14533899-Reviews-9_Drakonai-Vilnius_Vilnius_County.html" },
                    { 447L, "Vilnius", "Lithuania", 54.700349500000002, 25.2692145, "Pizza & Nachos Pub", null, "Linkmenu g. 4", "Pizza, Italian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15071569-Reviews-Pizza_Nachos_Pub-Vilnius_Vilnius_County.html" },
                    { 437L, "Vilnius", "Lithuania", 54.676434999999998, 25.271662800000001, "Restoranas \"Prancuzai\"", null, "24 Algirdo str.", "French, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12721062-Reviews-Restoranas_Prancuzai-Vilnius_Vilnius_County.html" },
                    { 448L, "Vilnius", "Lithuania", 54.686378300000001, 25.276071999999999, "Kalimera", "Down town food hall", "A. Smetonos g 5", "Mediterranean, Greek", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15356039-Reviews-Kalimera-Vilnius_Vilnius_County.html" },
                    { 450L, "Vilnius", "Lithuania", 54.7122636, 25.295132299999999, "9 Drakonai", "Ogmios Mieste, Interjero Aleja", "P. Luksio g. 19", "Chinese, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8275029-Reviews-9_Drakonai-Vilnius_Vilnius_County.html" },
                    { 451L, "Vilnius", "Lithuania", 54.680377700000001, 25.293534000000001, "Bel Ami", null, "Uzupio g. 4", "European, Italian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6708881-Reviews-Bel_Ami-Vilnius_Vilnius_County.html" },
                    { 452L, "Vilnius", "Lithuania", 54.680663000000003, 25.288322900000001, "Cafe de Paris", null, "Didzioji g. 1", "French, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1067186-Reviews-Cafe_de_Paris-Vilnius_Vilnius_County.html" },
                    { 453L, "Vilnius", "Lithuania", 54.676343000000003, 25.289360299999998, "UAB Ida Basar Restaurant", null, "Subaciaus g. 3", null, "https://www.tripadvisor.com/Restaurant_Review-g274951-d6510899-Reviews-UAB_Ida_Basar_Restaurant-Vilnius_Vilnius_County.html" },
                    { 454L, "Vilnius", "Lithuania", 54.686568200000004, 25.281063100000001, "La Cave Bistro", null, "Gedimino pr. 12", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8723083-Reviews-La_Cave_Bistro-Vilnius_Vilnius_County.html" },
                    { 455L, "Vilnius", "Lithuania", 54.693925100000001, 25.276128400000001, "Charlie Pizza", "Pc Cup", "Konstitucijos pr. 16", "Pizza, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4589260-Reviews-Charlie_Pizza-Vilnius_Vilnius_County.html" },
                    { 456L, "Vilnius", "Lithuania", 54.679292699999998, 25.283606200000001, "Bbq & Brew House", null, "Vokieciu 18A", "Latin, Barbecue", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17461375-Reviews-Bbq_Brew_House-Vilnius_Vilnius_County.html" },
                    { 457L, "Vilnius", "Lithuania", 54.684314899999997, 25.2825208, "Totorino", null, "Totoriu g. 22", "European, Mediterranean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9597847-Reviews-Totorino-Vilnius_Vilnius_County.html" },
                    { 458L, "Vilnius", "Lithuania", 54.671475399999999, 25.285419300000001, "McDonald's", null, "Seinu g. 3", "American, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8651946-Reviews-McDonald_s-Vilnius_Vilnius_County.html" },
                    { 459L, "Vilnius", "Lithuania", 54.703656000000002, 25.316509, "Visa Pica", null, "Silo g. 13A", "Pizza, Soups", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7285873-Reviews-Visa_Pica-Vilnius_Vilnius_County.html" },
                    { 449L, "Vilnius", "Lithuania", 54.680252000000003, 25.276248899999999, "The Great Tit", null, "Jono Basanaviciaus 7", "European, Central European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11666919-Reviews-The_Great_Tit-Vilnius_Vilnius_County.html" },
                    { 460L, "Vilnius", "Lithuania", 54.6804737, 25.274585800000001, "Cagino restoranas", null, "J. Basanaviciaus g. 11", "Eastern European, Russian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1867309-Reviews-Cagino_restoranas-Vilnius_Vilnius_County.html" },
                    { 436L, "Vilnius", "Lithuania", 54.681349900000001, 25.285136099999999, "Nino", null, "Sv. Ignoto g. 16", "Bar, Spanish", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3170314-Reviews-Nino-Vilnius_Vilnius_County.html" },
                    { 434L, "Vilnius", "Lithuania", 54.674971999999997, 25.282804500000001, "Parduotuvele", null, "Sv. Stepono st. 6-1", "Cafe, Healthy", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15266463-Reviews-Parduotuvele-Vilnius_Vilnius_County.html" },
                    { 412L, "Vilnius", "Lithuania", 54.688609300000003, 25.267251399999999, "Beef Room", null, "Gediminas av. 44B", "Steakhouse, International", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17635487-Reviews-Beef_Room-Vilnius_Vilnius_County.html" },
                    { 413L, "Vilnius", "Lithuania", 54.684515900000001, 25.284464400000001, "Ramenas ir pagaliukai", null, "Stuokos-Guceviciaus str. 7", "Japanese, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10550715-Reviews-Ramenas_ir_pagaliukai-Vilnius_Vilnius_County.html" },
                    { 414L, "Vilnius", "Lithuania", 54.680086799999998, 25.277119200000001, "The Urban Garden", null, "Jono Basanaviciaus St. 3", "Fast Food, Healthy", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13791578-Reviews-The_Urban_Garden-Vilnius_Vilnius_County.html" },
                    { 415L, "Vilnius", "Lithuania", 54.713966900000003, 25.272621399999998, "Fortas Restoranas", "located in Ozas Mall", "Ozo g. 18", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12320024-Reviews-Fortas_Restoranas-Vilnius_Vilnius_County.html" },
                    { 416L, "Vilnius", "Lithuania", 54.672241900000003, 25.281673699999999, "Cili Pizza", null, "Sopeno G 1-17", "Pizza, Italian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7606846-Reviews-Cili_Pizza-Vilnius_Vilnius_County.html" },
                    { 417L, "Vilnius", "Lithuania", 54.674954399999997, 25.285329300000001, "Bar Bukowski", null, "Visu Sventuju g. 7", "Bar, Gastropub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10785884-Reviews-Bar_Bukowski-Vilnius_Vilnius_County.html" },
                    { 418L, "Vilnius", "Lithuania", 54.683072000000003, 25.277809999999999, "Shimai Sushi & Wine", "2 Palangos g.", "8 Pylimo g.", "Japanese, Sushi", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10293098-Reviews-Shimai_Sushi_Wine-Vilnius_Vilnius_County.html" },
                    { 419L, "Vilnius", "Lithuania", 54.672415000000001, 25.282542100000001, "Awokado Noodle Bar", null, "Sodu g. 15", "Thai, Fusion", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17449674-Reviews-Awokado_Noodle_Bar-Vilnius_Vilnius_County.html" },
                    { 420L, "Vilnius", "Lithuania", 54.650574300000002, 25.270505, "Fat Cloud Restaurant", null, "Dariaus ir Gireno g. 21", "Menu", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14013095-Reviews-Fat_Cloud_Restaurant-Vilnius_Vilnius_County.html" },
                    { 421L, "Vilnius", "Lithuania", 54.7038899, 25.309819000000001, "Charlie Pizza", null, "Antakalnio g. 44", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8603291-Reviews-Charlie_Pizza-Vilnius_Vilnius_County.html" },
                    { 435L, "Vilnius", "Lithuania", 54.686109799999997, 25.285978499999999, "'Baras Suo", null, "Gedimino pr. 1", "Pub, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7952030-Reviews-Baras_Suo-Vilnius_Vilnius_County.html" },
                    { 422L, "Vilnius", "Lithuania", 54.679670999999999, 25.278890000000001, "Pabo Latino", null, "Traku gatve 3", "Bar, Cuban", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2269089-Reviews-Pabo_Latino-Vilnius_Vilnius_County.html" },
                    { 424L, "Vilnius", "Lithuania", 54.680779999999999, 25.261680999999999, "Achtamar", null, "S. Konarskio Str. 1/2", "Eastern European, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7812178-Reviews-Achtamar-Vilnius_Vilnius_County.html" },
                    { 425L, "Vilnius", "Lithuania", 54.6790199, 25.284754400000001, "Sushi Express", null, "Vokieciu str. 7", "Japanese, Sushi", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11694324-Reviews-Sushi_Express-Vilnius_Vilnius_County.html" },
                    { 426L, "Vilnius", "Lithuania", 54.713320299999999, 25.2958794, "Chinkalnia Georgian Restaurant", "Ogmios Miestelis", "Verkiu g 29, Seimos Aikste 3", "Georgian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13978106-Reviews-Chinkalnia_Georgian_Restaurant-Vilnius_Vilnius_County.html" },
                    { 427L, "Vilnius", "Lithuania", 54.688355999999999, 25.2152122, "Pauksciu Takas", null, "Sausio 13-osios g. 10", "European, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7713626-Reviews-Pauksciu_Ttakas-Vilnius_Vilnius_County.html" },
                    { 428L, "Vilnius", "Lithuania", 54.679219000000003, 25.288611, "Mason Gastropub", null, "Saviciaus g. 3", "European, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12869749-Reviews-Mason_Gastropub-Vilnius_Vilnius_County.html" },
                    { 429L, "Vilnius", "Lithuania", 54.650960599999998, 25.280029899999999, "Ikea Restaurant", null, "Zirniu gatve, 56", "Fast Food, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7122278-Reviews-Ikea_Restaurant-Vilnius_Vilnius_County.html" },
                    { 430L, "Vilnius", "Lithuania", 54.6763379, 25.282938999999999, "La Pergola", null, "Ligonines g. 7", "European, Central European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1022637-Reviews-La_Pergola-Vilnius_Vilnius_County.html" },
                    { 431L, "Vilnius", "Lithuania", 54.685424900000001, 25.277629900000001, "Plum Bum Bar", null, "A. Smetonos g. 2", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3357185-Reviews-Plum_Bum_Bar-Vilnius_Vilnius_County.html" },
                    { 432L, "Vilnius", "Lithuania", 54.676408899999998, 25.288837000000001, "Brasserie After 5PM", null, "Subaciaus g. 1", "French, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d5859602-Reviews-Brasserie_After_5PM-Vilnius_Vilnius_County.html" },
                    { 433L, "Vilnius", "Lithuania", 54.684789700000003, 25.2791152, "10 Reasons Lounge", null, "Vilniaus Gatve 27", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15870300-Reviews-10_Reasons_Lounge-Vilnius_Vilnius_County.html" },
                    { 423L, "Vilnius", "Lithuania", 54.683882400000002, 25.2897161, "El Gaucho Sano", null, "Pilies g. 10", "Steakhouse, Latin", "https://www.tripadvisor.com/Restaurant_Review-g274951-d919299-Reviews-El_Gaucho_Sano-Vilnius_Vilnius_County.html" },
                    { 411L, "Vilnius", "Lithuania", 54.680900700000002, 25.289787799999999, "Popierinis Baras", null, "Boksto Gatve 3", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8863556-Reviews-Popierinis_Baras-Vilnius_Vilnius_County.html" },
                    { 461L, "Vilnius", "Lithuania", 54.745770999999998, 25.290900000000001, "Vandens malunas", null, "Verkiu g. 100", "European, Central European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1488882-Reviews-Vandens_malunas-Vilnius_Vilnius_County.html" },
                    { 463L, "Vilnius", "Lithuania", 54.680923, 25.281586000000001, "Pink Milkshake", null, "Vilniaus g. 45", "American", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10131304-Reviews-Pink_Milkshake-Vilnius_Vilnius_County.html" },
                    { 490L, "Vilnius", "Lithuania", 54.686606500000003, 25.285877599999999, "Senoji pasaga", "2 T. Vrublevskio street", "1 Tilto street", "Polish, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17804394-Reviews-Senoji_pasaga-Vilnius_Vilnius_County.html" },
                    { 491L, "Vilnius", "Lithuania", 54.674250299999997, 25.267509499999999, "Delta Mityba", "Inner Yard Ground Flour Big Widows", "Naugarduko g. 41", "Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13632369-Reviews-Delta_Mityba-Vilnius_Vilnius_County.html" },
                    { 492L, "Vilnius", "Lithuania", 54.678504199999999, 25.284778299999999, "Grill terrace", null, "Vokieciu g. 8", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11437139-Reviews-Grill_terrace-Vilnius_Vilnius_County.html" },
                    { 493L, "Vilnius", "Lithuania", 54.672719299999997, 25.286611199999999, "Narushi", null, "Pylimo g. 60", "Japanese, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17433214-Reviews-Narushi-Vilnius_Vilnius_County.html" },
                    { 494L, "Vilnius", "Lithuania", 54.685272099999999, 25.281969199999999, "Lasagna Mia", null, "Totoriu g. 7", "Italian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10553820-Reviews-Lasagna_Mia-Vilnius_Vilnius_County.html" },
                    { 495L, "Vilnius", "Lithuania", 54.685133999999998, 25.285020899999999, "Sventaragio sodas", "Amberton Vilnius Hotel", "L. Stuokos-Guceviciaus g 1", "European, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13203529-Reviews-Sventaragio_sodas-Vilnius_Vilnius_County.html" },
                    { 496L, "Vilnius", "Lithuania", 54.681183500000003, 25.272274800000002, "Aliumbas", null, "J. Basanaviciaus g. 15", "Bar, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d16774059-Reviews-Aliumbas-Vilnius_Vilnius_County.html" },
                    { 497L, "Vilnius", "Lithuania", 54.6819585, 25.279805100000001, "Plus Plus Plus", null, "Vilniaus g. 39", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11699670-Reviews-Plus_Plus_Plus-Vilnius_Vilnius_County.html" },
                    { 498L, "Vilnius", "Lithuania", 54.700393900000002, 25.257780100000002, "Grill Brazil", null, "Saltoniskiu 9", "Barbecue, Brazilian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2188007-Reviews-Grill_Brazil-Vilnius_Vilnius_County.html" },
                    { 499L, "Vilnius", "Lithuania", 54.689106500000001, 25.2654557, "Liberta", "Ratonda Centrum Hotels", "A. Rotundo g 1", "European, Grill", "https://www.tripadvisor.com/Restaurant_Review-g274951-d16649540-Reviews-Liberta-Vilnius_Vilnius_County.html" },
                    { 489L, "Vilnius", "Lithuania", 54.686719699999998, 25.2790043, "Dziugas", null, "Jogailos g. 4", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13834627-Reviews-Dziugas-Vilnius_Vilnius_County.html" },
                    { 500L, "Vilnius", "Lithuania", 54.6846715, 25.2905984, "Petrazoles", null, "Barboros Radvilaites g. 5", "Middle Eastern, Persian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15279355-Reviews-Petrazoles-Vilnius_Vilnius_County.html" },
                    { 502L, "Vilnius", "Lithuania", 54.685272099999999, 25.281969199999999, "Zirniukas ir Pupa", null, "Totoriu g. 7", "International, Soups", "https://www.tripadvisor.com/Restaurant_Review-g274951-d18930561-Reviews-Zirniukas_ir_Pupa-Vilnius_Vilnius_County.html" },
                    { 503L, "Vilnius", "Lithuania", 54.713816899999998, 25.2939282, "Vafliu namai", "Seimos aikste 3", "Verkiu g. 29", "American, Belgian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12272919-Reviews-Vafliu_namai-Vilnius_Vilnius_County.html" },
                    { 504L, "Vilnius", "Lithuania", 54.6819585, 25.279805100000001, "Katlerio", null, "Vilniaus g. 39", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15149724-Reviews-Katlerio-Vilnius_Vilnius_County.html" },
                    { 505L, "Vilnius", "Lithuania", 54.670243999999997, 25.282919499999998, "Peronas", null, "Gelezinkelio g. 6", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12548449-Reviews-Peronas-Vilnius_Vilnius_County.html" },
                    { 506L, "Vilnius", "Lithuania", 54.710310399999997, 25.262674499999999, "PJazz", null, "Ozo g. 25", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11785270-Reviews-PJazz-Vilnius_Vilnius_County.html" },
                    { 507L, "Vilnius", "Lithuania", 54.710310399999997, 25.262674499999999, "Vero Cafe", null, "Ozo Gatve 25", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12330746-Reviews-Vero_Cafe-Vilnius_Vilnius_County.html" },
                    { 508L, "Vilnius", "Lithuania", 54.669740699999998, 25.237104200000001, "Brooklyn Brothers", null, "2 Eiguliu Street", "$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d16673819-Reviews-Brooklyn_Brothers-Vilnius_Vilnius_County.html" },
                    { 509L, "Vilnius", "Lithuania", 54.697367, 25.266847899999998, "Terrazza", null, "Konstitucijos pr. 26", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8139048-Reviews-Terrazza-Vilnius_Vilnius_County.html" },
                    { 510L, "Vilnius", "Lithuania", 54.684193800000003, 25.290067400000002, "Cafe Toranj", null, "Pilies G. 6", "Middle Eastern, Persian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d19341942-Reviews-Cafe_Toranj-Vilnius_Vilnius_County.html" },
                    { 511L, "Vilnius", "Lithuania", 54.640650200000003, 25.2776359, "Charlie pizza VNO", null, "Rodunios str. 10a", "Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d16883916-Reviews-Charlie_pizza_VNO-Vilnius_Vilnius_County.html" },
                    { 501L, "Vilnius", "Lithuania", 54.6955393, 25.259858300000001, "Restaurant Green Hall", null, "Upes g. 21", "European, Contemporary", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7305479-Reviews-Restaurant_Green_Hall-Vilnius_Vilnius_County.html" },
                    { 462L, "Vilnius", "Lithuania", 54.696327400000001, 25.276653499999998, "Miyako", null, "Konstitucijos pr. 7A", "Japanese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1049335-Reviews-Miyako-Vilnius_Vilnius_County.html" },
                    { 488L, "Vilnius", "Lithuania", 54.696327400000001, 25.276653499999998, "Gan bei city - Europa", null, "Konstitucijos pr. 7A", "Japanese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15855944-Reviews-Gan_bei_city_Europa-Vilnius_Vilnius_County.html" },
                    { 486L, "Vilnius", "Lithuania", 54.676506400000001, 25.289740399999999, "Dejavu Sushi", null, "Subaciaus g. 6-46", "Sushi", "https://www.tripadvisor.com/Restaurant_Review-g274951-d18917455-Reviews-Dejavu_Sushi-Vilnius_Vilnius_County.html" },
                    { 464L, "Vilnius", "Lithuania", 54.680086799999998, 25.277119200000001, "Lunch Time Bistro", null, "J. Basanaviciaus g. 3", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13511447-Reviews-Lunch_Time_Bistro-Vilnius_Vilnius_County.html" },
                    { 465L, "Vilnius", "Lithuania", 54.674812199999998, 25.284234900000001, "Moss Cafe", null, "Pylimo g. 47", "European, Scandinavian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17756132-Reviews-Moss_Cafe-Vilnius_Vilnius_County.html" },
                    { 466L, "Vilnius", "Lithuania", 54.683470100000001, 25.279014199999999, "Mililitrai", null, "Vilniaus g. 33", "Japanese, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d18931420-Reviews-Mililitrai-Vilnius_Vilnius_County.html" },
                    { 467L, "Vilnius", "Lithuania", 54.677337299999998, 25.279274699999998, "Restaurant-bar VINGRIAI", "Vingriu g. 25, Vilnius", "Vingriu g. 25", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4077816-Reviews-Restaurant_bar_VINGRIAI-Vilnius_Vilnius_County.html" },
                    { 468L, "Vilnius", "Lithuania", 54.675222499999997, 25.284034200000001, "Mr. Kebab", null, "Pylimo g. 50", "Turkish", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17778833-Reviews-Mr_Kebab-Vilnius_Vilnius_County.html" },
                    { 469L, "Vilnius", "Lithuania", 54.677769400000003, 25.279392999999999, "Elite", null, "Pylimo g. 25", "Fast Food, Middle Eastern", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10308866-Reviews-Elite-Vilnius_Vilnius_County.html" },
                    { 470L, "Vilnius", "Lithuania", 54.687790399999997, 25.262727600000002, "Daily Poison", "14a-101", "J. Jasinskio g. 14a-101", "Cafe, American", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14933980-Reviews-Daily_Poison-Vilnius_Vilnius_County.html" },
                    { 471L, "Vilnius", "Lithuania", 54.696671100000003, 25.279034899999999, "Bure No1", null, "Lvovo g. 25", "Central European, Mediterranean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4035701-Reviews-Bure_No1-Vilnius_Vilnius_County.html" },
                    { 472L, "Vilnius", "Lithuania", 54.683035199999999, 25.289275499999999, "Trattoria di Ravello", null, "Pilies g. 18-20", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4454713-Reviews-Trattoria_di_Ravello-Vilnius_Vilnius_County.html" },
                    { 473L, "Vilnius", "Lithuania", 54.679816600000002, 25.290597600000002, "Smagus Raugas / Happy Brew", null, "Boksto g. 8", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9881534-Reviews-Smagus_Raugas_Happy_Brew-Vilnius_Vilnius_County.html" },
                    { 487L, "Vilnius", "Lithuania", 54.672668600000002, 25.289757300000002, "Kansas City Bar-B-Que", "Aušros Vartų g. 27, Vilnius 02100, Lithuania", "Ausros Vartu g. 27", "American", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17741703-Reviews-Kansas_City_Bar_B_Que-Vilnius_Vilnius_County.html" },
                    { 474L, "Vilnius", "Lithuania", 54.690890699999997, 25.264290299999999, "Tarbushi Bistro", null, "Gyneju g 4", "Lebanese, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12886160-Reviews-Tarbushi_Bistro-Vilnius_Vilnius_County.html" },
                    { 476L, "Vilnius", "Lithuania", 54.684735500000002, 25.2846826, "Suzana", null, "L. Stuokos- Guceviciaus g. 5", "Latvian, Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4979192-Reviews-Suzana-Vilnius_Vilnius_County.html" },
                    { 477L, "Vilnius", "Lithuania", 54.713966900000003, 25.272621399999998, "Bonocosi", "Ozas shopping center, ground floor", "Ozo street 18", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10339319-Reviews-Bonocosi-Vilnius_Vilnius_County.html" },
                    { 478L, "Vilnius", "Lithuania", 54.685552700000002, 25.284753899999998, "Art Cafe", null, "Odminiu g. 3", "Healthy, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13546143-Reviews-Art_Cafe-Vilnius_Vilnius_County.html" },
                    { 479L, "Vilnius", "Lithuania", 54.676540500000002, 25.2826415, "Enoteca San Michele", null, "Ligonines G. 5/C", "Italian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d5522543-Reviews-Enoteca_San_Michele-Vilnius_Vilnius_County.html" },
                    { 480L, "Vilnius", "Lithuania", 54.672487599999997, 25.272282700000002, "Kinu Roze", null, "Kauno g. 15", "Chinese, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1510851-Reviews-Kinu_Roze-Vilnius_Vilnius_County.html" },
                    { 481L, "Vilnius", "Lithuania", 54.68788, 25.267590899999998, "ANATOLIJA Grill Kebab", null, "J. Jasinskio g. 1", "Turkish, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8872768-Reviews-ANATOLIJA_Grill_Kebab-Vilnius_Vilnius_County.html" },
                    { 482L, "Vilnius", "Lithuania", 54.700393900000002, 25.257780100000002, "Drama Burger at PANORAMA", null, "Saltoniskiu g. 9", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12014549-Reviews-Drama_Burger_at_PANORAMA-Vilnius_Vilnius_County.html" },
                    { 483L, "Vilnius", "Lithuania", 54.6821682, 25.302649800000001, "Uzupyne", null, "Baltasis skg. 9", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8607690-Reviews-Uzupyne-Vilnius_Vilnius_County.html" },
                    { 484L, "Vilnius", "Lithuania", 54.680182199999997, 25.2880368, "Sofija Bar", null, "Didzioji g. 7", "Bar, Wine Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15043939-Reviews-Sofija_Bar-Vilnius_Vilnius_County.html" },
                    { 485L, "Vilnius", "Lithuania", 54.682867999999999, 25.279415, "Vynine Franki", null, "Vilniaus g. 35", "European, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3604805-Reviews-Vynine_Franki-Vilnius_Vilnius_County.html" },
                    { 475L, "Vilnius", "Lithuania", 54.688118199999998, 25.261523, "Pietausim lt", null, "J. Jasinskio g. 16", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10451996-Reviews-Pietausim_lt-Vilnius_Vilnius_County.html" },
                    { 926L, "Vilnius", "Lithuania", 54.691882399999997, 25.283950000000001, "Prie neries", null, "Zveju st. 2", "Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12861368-Reviews-Prie_neries-Vilnius_Vilnius_County.html" },
                    { 410L, "Vilnius", "Lithuania", 54.681973999999997, 25.250743, "Horizontas", null, "M. K. Ciurlionio g. 84", "European, Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d5014175-Reviews-Horizontas-Vilnius_Vilnius_County.html" },
                    { 408L, "Vilnius", "Lithuania", 54.686719699999998, 25.2790043, "Pomodoro", null, "Jogailos g. 4", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d968038-Reviews-Pomodoro-Vilnius_Vilnius_County.html" },
                    { 334L, "Vilnius", "Lithuania", 54.827014599999998, 25.276909700000001, "HBH Vilnius", "Raudondvario km. Rieses sen", "Zirgu 2, Raudondvario kaimas", "Fusion, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4816559-Reviews-HBH_Vilnius-Vilnius_Vilnius_County.html" },
                    { 335L, "Vilnius", "Lithuania", 54.6798395, 25.286835, "Leiciu Bravoras", null, "Stikliu g. 5", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15519744-Reviews-Leiciu_Bravoras-Vilnius_Vilnius_County.html" },
                    { 336L, "Vilnius", "Lithuania", 54.700393900000002, 25.257780100000002, "Gourmet Panorama", "Shopping mall Panorama | Gourmet Panorama", "Saltoniskiu g. 9", "Asian, Italian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17244486-Reviews-Gourmet_Panorama-Vilnius_Vilnius_County.html" },
                    { 337L, "Vilnius", "Lithuania", 54.680421899999999, 25.277787100000001, "Freunde", "Corner of Pylimo and Traku Street", "Pylimo g. 22D", "Mediterranean, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13948008-Reviews-Freunde-Vilnius_Vilnius_County.html" },
                    { 338L, "Vilnius", "Lithuania", 54.687240699999997, 25.2818468, "Pachamama Dinner Club", null, "9 Gedimino Prospektas", "Peruvian, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14900936-Reviews-Pachamama_Dinner_Club-Vilnius_Vilnius_County.html" },
                    { 339L, "Vilnius", "Lithuania", 54.673670000000001, 25.286079900000001, "Hales Deli", "8A, Hales market", "Pylimo g. 58", "Cafe, Grill", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10192215-Reviews-Hales_Deli-Vilnius_Vilnius_County.html" },
                    { 340L, "Vilnius", "Lithuania", 54.673670000000001, 25.286079900000001, "Spoon Out", null, "Pylimo g. 58", "Asian, Thai", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12998035-Reviews-Spoon_Out-Vilnius_Vilnius_County.html" },
                    { 341L, "Vilnius", "Lithuania", 54.682731199999999, 25.276305900000001, "Namaste India Restaurant", null, "Kalinausko g. 2", "Indian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8523065-Reviews-Namaste_India_Restaurant-Vilnius_Vilnius_County.html" },
                    { 342L, "Vilnius", "Lithuania", 54.687520900000003, 25.2761499, "CAN CAN Pizza", null, "Gedimino pr. 26", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7116622-Reviews-CAN_CAN_Pizza-Vilnius_Vilnius_County.html" },
                    { 343L, "Vilnius", "Lithuania", 54.688487899999998, 25.273155899999999, "Bonocosi", null, "Gedimino pr. 31", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12541036-Reviews-Bonocosi-Vilnius_Vilnius_County.html" },
                    { 333L, "Vilnius", "Lithuania", 54.684222300000002, 25.277489599999999, "Beigeliu Krautuvele", null, "Pylimo g. 2", "Middle Eastern, Israeli", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10509721-Reviews-Beigeliu_Krautuvele-Vilnius_Vilnius_County.html" },
                    { 344L, "Vilnius", "Lithuania", 54.679853799999997, 25.2864383, "Restaurant Lokys Steakhouse", null, "Stikliu g. 8-10", "Steakhouse, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14194001-Reviews-Restaurant_Lokys_Steakhouse-Vilnius_Vilnius_County.html" },
                    { 346L, "Vilnius", "Lithuania", 54.680912999999997, 25.2901481, "Lagaminas", null, "Boksto g. 2", "Polish, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15602405-Reviews-Lagaminas-Vilnius_Vilnius_County.html" },
                    { 347L, "Vilnius", "Lithuania", 54.709533200000003, 25.299937499999999, "Katpedele", "Banginis", "P. Luksio g. 34", "European, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8603308-Reviews-Katpedele-Vilnius_Vilnius_County.html" },
                    { 348L, "Vilnius", "Lithuania", 54.689608900000003, 25.266162999999999, "Rise", null, "Gedimino pr. 43", "Japanese, Sushi", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10716798-Reviews-Rise-Vilnius_Vilnius_County.html" },
                    { 349L, "Vilnius", "Lithuania", 54.696131899999997, 25.249624900000001, "RIEKE bistro", "Bebru g. 7", "Kestucio g. 38", "International, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12547569-Reviews-RIEKE_bistro-Vilnius_Vilnius_County.html" },
                    { 350L, "Vilnius", "Lithuania", 54.687240699999997, 25.2818468, "Studio 9", null, "Gedimino pr. 9", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3267209-Reviews-Studio_9-Vilnius_Vilnius_County.html" },
                    { 351L, "Vilnius", "Lithuania", 54.689301499999999, 25.275857899999998, "Variokas - Steampunk bar", null, "A. Jaksto g 9", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10791681-Reviews-Variokas_Steampunk_bar-Vilnius_Vilnius_County.html" },
                    { 352L, "Vilnius", "Lithuania", 54.676836000000002, 25.286764900000001, "Monstro", null, "Arkliu g. 6", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12296442-Reviews-Monstro-Vilnius_Vilnius_County.html" },
                    { 353L, "Vilnius", "Lithuania", 54.683876300000001, 25.279057900000002, "Uncle Sam American Pub", null, "Islandijos g. 1", "American, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12863942-Reviews-Uncle_Sam_American_Pub-Vilnius_Vilnius_County.html" },
                    { 354L, "Vilnius", "Lithuania", 54.694982799999998, 25.274673499999999, "Riverside Restaurant", null, "Konstitucijos pr. 20", "International, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2208604-Reviews-Riverside_Restaurant-Vilnius_Vilnius_County.html" },
                    { 355L, "Vilnius", "Lithuania", 54.7122818, 25.2986024, "Etno Dvaras", null, "J. Kubiliaus g. 16", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10450729-Reviews-Etno_Dvaras-Vilnius_Vilnius_County.html" },
                    { 345L, "Vilnius", "Lithuania", 54.740143799999998, 25.224593299999999, "Charlie Pizza", "Domus Pro", "Ukmerges g. 308", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7242847-Reviews-Charlie_Pizza-Vilnius_Vilnius_County.html" },
                    { 356L, "Vilnius", "Lithuania", 54.678522700000002, 25.2580566, "Kavos Era", null, "Savanoriu pr. 6", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12448965-Reviews-Kavos_Era-Vilnius_Vilnius_County.html" },
                    { 332L, "Vilnius", "Lithuania", 54.679278600000004, 25.289516200000001, "Bromas", null, "Saviciaus g. 11-26", "Grill, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11734059-Reviews-Bromas-Vilnius_Vilnius_County.html" },
                    { 330L, "Vilnius", "Lithuania", 54.680377700000001, 25.293534000000001, "Kitsch", null, "Uzupio Gatve 4", "International, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13087606-Reviews-Kitsch-Vilnius_Vilnius_County.html" },
                    { 308L, "Vilnius", "Lithuania", 54.686479200000001, 25.285742800000001, "Senatoriai Restaurant", null, "Tilto g. 2A", "International, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7704133-Reviews-Senatoriai_Restaurant-Vilnius_Vilnius_County.html" },
                    { 309L, "Vilnius", "Lithuania", 54.684652, 25.285744000000001, "Atelier Wine Boutique & Tasting Bar", "Kempinski Hotel Cathedral Square", "Universiteto g. 14", "International, Wine Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12499739-Reviews-Atelier_Wine_Boutique_Tasting_Bar-Vilnius_Vilnius_County.html" },
                    { 310L, "Vilnius", "Lithuania", 54.684515900000001, 25.284464400000001, "Ramenas ir pagaliukai I Ramen & Sticks", "Lakūnų g. 14b", "L. Stuokos Guceviciaus g. 7", "Japanese, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10548016-Reviews-Ramenas_ir_pagaliukai_I_Ramen_Sticks-Vilnius_Vilnius_County.html" },
                    { 311L, "Vilnius", "Lithuania", 54.677041799999998, 25.288914399999999, "Artistai", null, "Sv. Kazimiero g. 3", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4026199-Reviews-Artistai-Vilnius_Vilnius_County.html" },
                    { 312L, "Vilnius", "Lithuania", 54.679705400000003, 25.283171100000001, "LeBonjour", null, "Vokieciu g. 24", "French, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12623095-Reviews-LeBonjour-Vilnius_Vilnius_County.html" },
                    { 313L, "Vilnius", "Lithuania", 54.679407699999999, 25.283484399999999, "Buona Taverna", null, "Vokieciu g. 20", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6676968-Reviews-Buona_Taverna-Vilnius_Vilnius_County.html" },
                    { 314L, "Vilnius", "Lithuania", 54.676099000000001, 25.288638899999999, "Spiritus Bar", null, "Ausros Vartu g. 4", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7807371-Reviews-Spiritus_Bar-Vilnius_Vilnius_County.html" },
                    { 315L, "Vilnius", "Lithuania", 54.671228300000003, 25.269202700000001, "ELFA GastroBar", null, "Svitrigailos Strasse, 29", "Bar, Barbecue", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10174851-Reviews-ELFA_GastroBar-Vilnius_Vilnius_County.html" },
                    { 316L, "Vilnius", "Lithuania", 54.687399999999997, 25.283230100000001, "Salionas", null, "K. Sirvydo g. 6", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7284088-Reviews-Salionas-Vilnius_Vilnius_County.html" },
                    { 317L, "Vilnius", "Lithuania", 54.672415000000001, 25.282542100000001, "Continent Cafe Restaurant", null, "Sodu g. 15", "American, African", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15018119-Reviews-Continent_Cafe_Restaurant-Vilnius_Vilnius_County.html" },
                    { 331L, "Vilnius", "Lithuania", 54.393441000000003, 24.963920900000002, "Pirciupio Karcema", "Senųjų Pirčiupių g. 2, Pirčiupiai", "Senųjų Pirčiupių g. 2, Pirčiupių k.", "European, Eastern European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6394855-Reviews-Pirciupio_Karcema-Vilnius_Vilnius_County.html" },
                    { 318L, "Vilnius", "Lithuania", 54.674191899999997, 25.2870463, "Ice Dunes", null, "Bazilijonu 6", "Italian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14015976-Reviews-Ice_Dunes-Vilnius_Vilnius_County.html" },
                    { 320L, "Vilnius", "Lithuania", 54.702691000000002, 25.291360999999998, "Marceliukes kletis", null, "Tuskulenu g. 35", "Eastern European, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1898759-Reviews-Marceliukes_kletis-Vilnius_Vilnius_County.html" },
                    { 321L, "Vilnius", "Lithuania", 54.6905134, 25.264208100000001, "Leleko", null, "Gedimino pr. 49", "Eastern European, Central European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d4662509-Reviews-Leleko-Vilnius_Vilnius_County.html" },
                    { 322L, "Vilnius", "Lithuania", 54.713966900000003, 25.272621399999998, "Manami", "Ozas", "Ozo g. 18", "Chinese, Sushi", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11548957-Reviews-Manami-Vilnius_Vilnius_County.html" },
                    { 323L, "Vilnius", "Lithuania", 54.678677899999997, 25.281849999999999, "7 Fridays", null, "Pranciskonu St., 3", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8720289-Reviews-7_Fridays-Vilnius_Vilnius_County.html" },
                    { 324L, "Vilnius", "Lithuania", 54.684035000000002, 25.2897511, "La Crepe", null, "Pilies g. 8", "French, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7390943-Reviews-La_Crepe-Vilnius_Vilnius_County.html" },
                    { 325L, "Vilnius", "Lithuania", 54.681784999999998, 25.278115799999998, "Kamikadze Japonu Virtuve", null, "Klaipedos g. 1-1", "Japanese, Seafood", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7063652-Reviews-Kamikadze_Japonu_Virtuve-Vilnius_Vilnius_County.html" },
                    { 326L, "Vilnius", "Lithuania", 54.677796999999998, 25.286201999999999, "TASTE - JHK and DD's Place", null, "Vokieciu g. 2", "Asian, Korean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d5866128-Reviews-TASTE_JHK_and_DD_s_Place-Vilnius_Vilnius_County.html" },
                    { 327L, "Vilnius", "Lithuania", 54.696657600000002, 25.250277000000001, "sPUNKa Zverynas", null, "Kestucio g. 55", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7282228-Reviews-SPUNKa_Zverynas-Vilnius_Vilnius_County.html" },
                    { 328L, "Vilnius", "Lithuania", 54.681652300000003, 25.286152399999999, "Leaye", null, "Dominikonu street 16", "Chinese, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12501676-Reviews-Leaye-Vilnius_Vilnius_County.html" },
                    { 329L, "Vilnius", "Lithuania", 54.680880999999999, 25.270154999999999, "Restoranas Meksika", null, "Algirdo g. 2", "Mexican", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6656598-Reviews-Restoranas_Meksika-Vilnius_Vilnius_County.html" },
                    { 319L, "Vilnius", "Lithuania", 54.693894999999998, 25.276167999999998, "Grill Terrace", null, "Upes g. 9", "European, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8600511-Reviews-Grill_Terrace-Vilnius_Vilnius_County.html" },
                    { 409L, "Vilnius", "Lithuania", 54.679201999999997, 25.288806900000001, "Blusyne Lounge Bar", null, "Saviciaus g. 5", "Mexican, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3404103-Reviews-Blusyne_Lounge_Bar-Vilnius_Vilnius_County.html" },
                    { 357L, "Vilnius", "Lithuania", 54.677487200000002, 25.2794247, "Kavine Kisenele", "Junction with Pylmio g.", "Vingriu g. 14", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10887922-Reviews-Kavine_Kisenele-Vilnius_Vilnius_County.html" },
                    { 359L, "Vilnius", "Lithuania", 54.680912999999997, 25.2901481, "Lagmanas", null, "Boksto g. 2", "Bar, Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13413186-Reviews-Lagmanas-Vilnius_Vilnius_County.html" },
                    { 386L, "Vilnius", "Lithuania", 54.686914999999999, 25.2827509, "Post Skriptum", null, "Gedimino Prospektas 7", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8571058-Reviews-Post_Skriptum-Vilnius_Vilnius_County.html" },
                    { 387L, "Vilnius", "Lithuania", 54.675856000000003, 25.213817899999999, "Chinkali namai", null, "Architektu g. 11", "Georgian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12614828-Reviews-Chinkali_namai-Vilnius_Vilnius_County.html" },
                    { 388L, "Vilnius", "Lithuania", 54.706927499999999, 25.285181300000001, "Pizza Verde", "Suite 101 A", "Kalvariju g. 101A", "Pizza, Italian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10793017-Reviews-Pizza_Verde-Vilnius_Vilnius_County.html" },
                    { 389L, "Vilnius", "Lithuania", 54.740110999999999, 25.228211900000002, "Archie's Burger", "BIG Vilnius", "Ukmerges g. 369", "American", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11734419-Reviews-Archie_s_Burger-Vilnius_Vilnius_County.html" },
                    { 390L, "Vilnius", "Lithuania", 54.682867999999999, 25.279415, "Talutti - Bakes 'n' Shakes City", null, "Vilniaus g. 35", "Bar, International", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12805584-Reviews-Talutti_Bakes_n_Shakes_City-Vilnius_Vilnius_County.html" },
                    { 391L, "Vilnius", "Lithuania", 54.684162399999998, 25.2778615, "Kas Kas", null, "Islandijos g. 4", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d5031310-Reviews-Kas_Kas-Vilnius_Vilnius_County.html" },
                    { 392L, "Vilnius", "Lithuania", 54.6776099, 25.262399899999998, "Element", null, "T. Sevcenkos g. 16", "European, Central European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9853184-Reviews-Element-Vilnius_Vilnius_County.html" },
                    { 393L, "Vilnius", "Lithuania", 54.680824899999998, 25.296814999999999, "Liu Patty", null, "Uzupio g. 20", "Deli", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12512221-Reviews-Liu_Patty-Vilnius_Vilnius_County.html" },
                    { 394L, "Vilnius", "Lithuania", 54.688184900000003, 25.274743999999998, "Beatos Virtuve Studija", "5th Floor", "Gedimino pr. 27", "European, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9751054-Reviews-Beatos_Virtuve_Studija-Vilnius_Vilnius_County.html" },
                    { 395L, "Vilnius", "Lithuania", 54.677420900000001, 25.284286000000002, "Cigar House", null, "Dysnos g. 7-3", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3902689-Reviews-Cigar_House-Vilnius_Vilnius_County.html" },
                    { 385L, "Vilnius", "Lithuania", 54.691637100000001, 25.2874281, "MEAT Steak House", null, "A. Juozapaviciaus g. 13", "Steakhouse, Barbecue", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9600803-Reviews-MEAT_Steak_House-Vilnius_Vilnius_County.html" },
                    { 396L, "Vilnius", "Lithuania", 54.6825446, 25.279533499999999, "Drops Bar", null, "Vilniaus g. 37", "Bar, Gastropub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12656632-Reviews-Drops_Bar-Vilnius_Vilnius_County.html" },
                    { 398L, "Vilnius", "Lithuania", 54.728038300000001, 25.240948700000001, "Burger Street", null, "Ukmerges Gatve 259", "Fast Food, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11543747-Reviews-Burger_Street-Vilnius_Vilnius_County.html" },
                    { 399L, "Vilnius", "Lithuania", 54.678324799999999, 25.2772507, "Indie Bar", null, "Pylimo g. 23", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7719702-Reviews-Indie_Bar-Vilnius_Vilnius_County.html" },
                    { 400L, "Vilnius", "Lithuania", 54.672894599999999, 25.286056299999998, "Asia Viet", null, "Pylimo g. 61", "Asian, Vietnamese", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15212158-Reviews-Asia_Viet-Vilnius_Vilnius_County.html" },
                    { 401L, "Vilnius", "Lithuania", 54.685552700000002, 25.284753899999998, "Uff Cafe", null, "Odminiu g. 3", "Cafe", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7778319-Reviews-Uff_Cafe-Vilnius_Vilnius_County.html" },
                    { 402L, "Vilnius", "Lithuania", 54.6764911, 25.2898675, "Restaurant TerraVino", "Old Town", "Subaciaus g. 6A", "Steakhouse, Italian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d11865129-Reviews-Restaurant_TerraVino-Vilnius_Vilnius_County.html" },
                    { 403L, "Vilnius", "Lithuania", 54.687390899999997, 25.284075999999999, "Guinness bar", "Cathedral Square, Old Town", "Tilto g. 8", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d5042949-Reviews-Guinness_bar-Vilnius_Vilnius_County.html" },
                    { 404L, "Vilnius", "Lithuania", 54.682786399999998, 25.279752200000001, "Leyla Restaurat - Lebanese Cuisine", "Same building as distileria and Anna Mesha", "Liejyklos Gatve 1", "Lebanese, Mediterranean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12930033-Reviews-Leyla_Restaurat_Lebanese_Cuisine-Vilnius_Vilnius_County.html" },
                    { 405L, "Vilnius", "Lithuania", 54.689948899999997, 25.264092900000001, "Submarine", null, "Gyneju G. 2", "Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12378893-Reviews-Submarine-Vilnius_Vilnius_County.html" },
                    { 406L, "Vilnius", "Lithuania", 54.684099500000002, 25.289208599999998, "Spyros Metaxa", null, "Pilies g. 5", "Mediterranean, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1155431-Reviews-Spyros_Metaxa-Vilnius_Vilnius_County.html" },
                    { 407L, "Vilnius", "Lithuania", 54.679885900000002, 25.296285000000001, "Seimos Restoranelis", null, "Paupio g. 5", "Brew Pub, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15190679-Reviews-Seimos_Restoranelis-Vilnius_Vilnius_County.html" },
                    { 397L, "Vilnius", "Lithuania", 54.693010999999998, 25.305365999999999, "Sakwa", null, "M. K. Paco g. 1-2", "Polish, Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d5511047-Reviews-Sakwa-Vilnius_Vilnius_County.html" },
                    { 358L, "Vilnius", "Lithuania", 54.680912999999997, 25.2901481, "Boksto vartai", null, "Boksto g. 2", "American, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8423277-Reviews-Boksto_vartai-Vilnius_Vilnius_County.html" },
                    { 384L, "Vilnius", "Lithuania", 54.700393900000002, 25.257780100000002, "Gan Bei City", "08105 Vilnius", "Saltoniskiu g. 9", "Chinese, Sushi", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2607690-Reviews-Gan_Bei_City-Vilnius_Vilnius_County.html" },
                    { 382L, "Vilnius", "Lithuania", 54.680135900000003, 25.280905000000001, "Pranciskonai Bar&Bistro", null, "Pranciskonu g. 2", "European, Wine Bar", "https://www.tripadvisor.com/Restaurant_Review-g274951-d9702806-Reviews-Pranciskonai_Bar_Bistro-Vilnius_Vilnius_County.html" },
                    { 360L, "Vilnius", "Lithuania", 54.694914300000001, 25.2773413, "Vilnius Beer Museum", null, "Konstitucijos pr. 12-4", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d7650960-Reviews-Vilnius_Beer_Museum-Vilnius_Vilnius_County.html" },
                    { 361L, "Vilnius", "Lithuania", 54.708042900000002, 25.227629, "Katpedele", "Mada", "Virsuliskiu G. 40", "Bar, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8603311-Reviews-Katpedele-Vilnius_Vilnius_County.html" },
                    { 362L, "Vilnius", "Lithuania", 54.678358899999999, 25.27666, "Gold HongKong", null, "Vingriu G. 11", "Chinese, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10903291-Reviews-Gold_HongKong-Vilnius_Vilnius_County.html" },
                    { 363L, "Vilnius", "Lithuania", 54.680182199999997, 25.2880368, "14Horses", null, "Didzioji str. 7", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d14200582-Reviews-14Horses-Vilnius_Vilnius_County.html" },
                    { 364L, "Vilnius", "Lithuania", 54.685672199999999, 25.282039699999999, "Tesla Pub", "Oldtown", "Totoriu g. 5", "American", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10036063-Reviews-Tesla_Pub-Vilnius_Vilnius_County.html" },
                    { 365L, "Vilnius", "Lithuania", 54.677036100000002, 25.264610300000001, "Shark Tail Sushi", null, "T. Sevcenkos g. 16a", "Japanese, Sushi", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8827509-Reviews-Shark_Tail_Sushi-Vilnius_Vilnius_County.html" },
                    { 366L, "Vilnius", "Lithuania", 54.734662200000002, 25.338550600000001, "Plento Grill & Wine", null, "Nemencines pl. 33", "European, Armenian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10541666-Reviews-Plento_Grill_Wine-Vilnius_Vilnius_County.html" },
                    { 367L, "Vilnius", "Lithuania", 54.678094899999998, 25.272715999999999, "CanCan Pizza", null, "Mindaugo g. 11", "Italian, Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d3836905-Reviews-CanCan_Pizza-Vilnius_Vilnius_County.html" },
                    { 368L, "Vilnius", "Lithuania", 54.678280999999998, 25.285137899999999, "Casa No 4 Drinks & Grill", null, "Vokieciu g. 4", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10672212-Reviews-Casa_No_4_Drinks_Grill-Vilnius_Vilnius_County.html" },
                    { 369L, "Vilnius", "Lithuania", 54.6950936, 25.287865400000001, "Chopped Belgian Chips", null, "Rinktines g. 24", "Belgian, Fast Food", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12870104-Reviews-Chopped_Belgian_Chips-Vilnius_Vilnius_County.html" },
                    { 383L, "Vilnius", "Lithuania", 54.672105100000003, 25.287405400000001, "Vijokliai Beer Garden", "Pylimo st. 66", "Pylimo Gatve 66", "Bar, Pub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10051064-Reviews-Vijokliai_Beer_Garden-Vilnius_Vilnius_County.html" },
                    { 370L, "Vilnius", "Lithuania", 54.686630899999997, 25.259621299999999, "PJazz", null, "J. Jasinskio g. 16A", "Pizza", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1015894-Reviews-PJazz-Vilnius_Vilnius_County.html" },
                    { 372L, "Vilnius", "Lithuania", 54.6864499, 25.285890299999998, "Margarita's Casa Mexicana", null, "Tilto g. 2", "Mexican", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12301359-Reviews-Margarita_s_Casa_Mexicana-Vilnius_Vilnius_County.html" },
                    { 373L, "Vilnius", "Lithuania", 54.680253700000002, 25.281363299999999, "Keisti Zenklai", null, "Traku g. 13", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d6542430-Reviews-Keisti_Zenklai-Vilnius_Vilnius_County.html" },
                    { 374L, "Vilnius", "Lithuania", 54.679940600000002, 25.279525100000001, "Cheers Pub", null, "Traku g. 7", "Bar, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d8527839-Reviews-Cheers_Pub-Vilnius_Vilnius_County.html" },
                    { 375L, "Vilnius", "Lithuania", 54.687862000000003, 25.265469499999998, "Kinu Roze", null, "J. Jasinskio g 6", "Chinese, Asian", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1020396-Reviews-KinU_Roze-Vilnius_Vilnius_County.html" },
                    { 376L, "Vilnius", "Lithuania", 54.673670000000001, 25.286079900000001, "Sraige, Vynas ir Varle", "Halės Marketplace", "Pylimo str. 58", "French, Mediterranean", "https://www.tripadvisor.com/Restaurant_Review-g274951-d13378706-Reviews-Sraige_Vynas_ir_Varle-Vilnius_Vilnius_County.html" },
                    { 377L, "Vilnius", "Lithuania", 54.693901500000003, 25.2889351, "Brussels Mussels", null, "Rinktines street 5", "Belgian, Seafood", "https://www.tripadvisor.com/Restaurant_Review-g274951-d18968979-Reviews-Brussels_Mussels-Vilnius_Vilnius_County.html" },
                    { 378L, "Vilnius", "Lithuania", 54.676836000000002, 25.286764900000001, "Prohibicija", null, "Arkliu str. 6", "$$ - $$$", "https://www.tripadvisor.com/Restaurant_Review-g274951-d12173898-Reviews-Prohibicija-Vilnius_Vilnius_County.html" },
                    { 379L, "Vilnius", "Lithuania", 54.693436599999998, 25.289230499999999, "Solt Dining", null, "Rinktines g. 3", "International, European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d15191110-Reviews-Solt_Dining-Vilnius_Vilnius_County.html" },
                    { 380L, "Vilnius", "Lithuania", 54.7245007, 25.205005100000001, "Le Paysage Restaurant", "Vilnius Grand Resort", "Ežeraičio g. 2", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d2173891-Reviews-Le_Paysage_Restaurant-Vilnius_Vilnius_County.html" },
                    { 381L, "Vilnius", "Lithuania", 54.686525899999999, 25.279710900000001, "Novo2", null, "Gedimino pr. 16", "European, French", "https://www.tripadvisor.com/Restaurant_Review-g274951-d10100129-Reviews-Novo2-Vilnius_Vilnius_County.html" },
                    { 371L, "Vilnius", "Lithuania", 54.690502700000003, 25.280230299999999, "Congress Hotel Restaurant", null, "Vilniaus g. 2", "European", "https://www.tripadvisor.com/Restaurant_Review-g274951-d1136180-Reviews-Congress_Hotel_Restaurant-Vilnius_Vilnius_County.html" },
                    { 927L, "Vilnius", "Lithuania", 54.700393900000002, 25.257780100000002, "Wraperia Suppa kebs", null, "Saltoniskiskiu g. 9", "Pub, Gastropub", "https://www.tripadvisor.com/Restaurant_Review-g274951-d17792646-Reviews-Wraperia_Suppa_kebs-Vilnius_Vilnius_County.html" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 250L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 251L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 252L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 253L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 254L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 255L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 256L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 257L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 258L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 259L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 260L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 261L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 262L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 263L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 264L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 265L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 266L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 267L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 268L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 269L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 270L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 271L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 272L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 273L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 274L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 275L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 276L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 277L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 278L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 279L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 280L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 281L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 282L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 283L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 284L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 285L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 286L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 287L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 288L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 289L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 290L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 291L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 292L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 293L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 294L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 295L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 296L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 297L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 298L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 299L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 300L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 301L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 302L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 303L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 304L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 305L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 306L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 307L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 308L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 309L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 310L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 311L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 312L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 313L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 314L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 315L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 316L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 317L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 318L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 319L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 320L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 321L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 322L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 323L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 324L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 325L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 326L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 327L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 328L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 329L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 330L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 331L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 332L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 333L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 334L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 335L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 336L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 337L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 338L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 339L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 340L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 341L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 342L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 343L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 344L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 345L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 346L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 347L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 348L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 349L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 350L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 351L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 352L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 353L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 354L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 355L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 356L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 357L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 358L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 359L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 360L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 361L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 362L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 363L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 364L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 365L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 366L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 367L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 368L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 369L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 370L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 371L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 372L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 373L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 374L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 375L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 376L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 377L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 378L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 379L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 380L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 381L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 382L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 383L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 384L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 385L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 386L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 387L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 388L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 389L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 390L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 391L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 392L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 393L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 394L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 395L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 396L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 397L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 398L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 399L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 400L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 401L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 402L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 403L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 404L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 405L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 406L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 407L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 408L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 409L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 410L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 411L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 412L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 413L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 414L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 415L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 416L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 417L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 418L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 419L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 420L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 421L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 422L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 423L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 424L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 425L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 426L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 427L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 428L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 429L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 430L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 431L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 432L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 433L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 434L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 435L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 436L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 437L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 438L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 439L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 440L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 441L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 442L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 443L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 444L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 445L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 446L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 447L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 448L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 449L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 450L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 451L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 452L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 453L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 454L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 455L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 456L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 457L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 458L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 459L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 460L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 461L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 462L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 463L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 464L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 465L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 466L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 467L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 468L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 469L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 470L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 471L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 472L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 473L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 474L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 475L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 476L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 477L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 478L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 479L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 480L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 481L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 482L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 483L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 484L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 485L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 486L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 487L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 488L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 489L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 490L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 491L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 492L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 493L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 494L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 495L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 496L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 497L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 498L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 499L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 500L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 501L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 502L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 503L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 504L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 505L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 506L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 507L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 508L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 509L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 510L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 511L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 512L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 513L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 514L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 515L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 516L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 517L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 518L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 519L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 520L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 521L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 522L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 523L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 524L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 525L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 526L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 527L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 528L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 529L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 530L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 531L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 532L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 533L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 534L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 535L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 536L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 537L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 538L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 539L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 540L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 541L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 542L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 543L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 544L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 545L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 546L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 547L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 548L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 549L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 550L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 551L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 552L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 553L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 554L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 555L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 556L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 557L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 558L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 559L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 560L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 561L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 562L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 563L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 564L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 565L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 566L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 567L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 568L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 569L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 570L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 571L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 572L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 573L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 574L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 575L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 576L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 577L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 578L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 579L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 580L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 581L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 582L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 583L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 584L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 585L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 586L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 587L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 588L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 589L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 590L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 591L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 592L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 593L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 594L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 595L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 596L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 597L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 598L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 599L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 600L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 601L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 602L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 603L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 604L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 605L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 606L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 607L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 608L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 609L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 610L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 611L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 612L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 613L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 614L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 615L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 616L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 617L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 618L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 619L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 620L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 621L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 622L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 623L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 624L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 625L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 626L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 627L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 628L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 629L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 630L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 631L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 632L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 633L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 634L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 635L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 636L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 637L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 638L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 639L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 640L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 641L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 642L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 643L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 644L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 645L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 646L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 647L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 648L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 649L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 650L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 651L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 652L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 653L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 654L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 655L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 656L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 657L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 658L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 659L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 660L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 661L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 662L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 663L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 664L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 665L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 666L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 667L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 668L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 669L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 670L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 671L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 672L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 673L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 674L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 675L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 676L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 677L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 678L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 679L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 680L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 681L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 682L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 683L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 684L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 685L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 686L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 687L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 688L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 689L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 690L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 691L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 692L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 693L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 694L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 695L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 696L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 697L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 698L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 699L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 700L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 701L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 702L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 703L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 704L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 705L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 706L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 707L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 708L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 709L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 710L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 711L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 712L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 713L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 714L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 715L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 716L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 717L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 718L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 719L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 720L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 721L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 722L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 723L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 724L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 725L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 726L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 727L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 728L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 729L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 730L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 731L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 732L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 733L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 734L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 735L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 736L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 737L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 738L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 739L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 740L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 741L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 742L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 743L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 744L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 745L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 746L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 747L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 748L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 749L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 750L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 751L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 752L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 753L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 754L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 755L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 756L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 757L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 758L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 759L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 760L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 761L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 762L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 763L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 764L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 765L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 766L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 767L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 768L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 769L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 770L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 771L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 772L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 773L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 774L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 775L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 776L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 777L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 778L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 779L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 780L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 781L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 782L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 783L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 784L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 785L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 786L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 787L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 788L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 789L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 790L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 791L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 792L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 793L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 794L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 795L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 796L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 797L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 798L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 799L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 800L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 801L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 802L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 803L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 804L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 805L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 806L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 807L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 808L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 809L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 810L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 811L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 812L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 813L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 814L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 815L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 816L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 817L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 818L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 819L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 820L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 821L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 822L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 823L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 824L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 825L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 826L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 827L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 828L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 829L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 830L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 831L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 832L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 833L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 834L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 835L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 836L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 837L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 838L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 839L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 840L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 841L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 842L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 843L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 844L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 845L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 846L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 847L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 848L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 849L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 850L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 851L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 852L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 853L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 854L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 855L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 856L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 857L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 858L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 859L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 860L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 861L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 862L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 863L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 864L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 865L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 866L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 867L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 868L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 869L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 870L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 871L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 872L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 873L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 874L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 875L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 876L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 877L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 878L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 879L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 880L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 881L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 882L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 883L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 884L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 885L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 886L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 887L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 888L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 889L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 890L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 891L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 892L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 893L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 894L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 895L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 896L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 897L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 898L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 899L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 900L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 901L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 902L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 903L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 904L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 905L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 906L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 907L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 908L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 909L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 910L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 911L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 912L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 913L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 914L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 915L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 916L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 917L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 918L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 919L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 920L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 921L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 922L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 923L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 924L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 925L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 926L);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "RestaurantId",
                keyValue: 927L);
        }
    }
}
