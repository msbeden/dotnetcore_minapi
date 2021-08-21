using minimumApi.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

namespace minimumApi.Migrations
{
    [DbContext(typeof(minimumApiDbContext))]
    [Migration("2002-InsertCities_Data")]
    public class InsertCities : Migration
    {
        protected override void Up([NotNull] MigrationBuilder migrationBuilder)
        {
            string[] citiesColumns = new[] { "CityName", "PlateCode", "CountryId" };
            string[] citiesColumnTypes = new[] { "varchar(100)", "varchar(2)", "int" };

            object[,] citiesValues = new object[,]
            {
                { "Adana", "01", 1 },
                { "Adıyaman", "02", 1},
                { "Afyonkarahisar", "03", 1},
                { "Ağrı", "04", 1},
                { "Amasya", "05", 1},
                { "Ankara", "06", 1},
                { "Antalya", "07", 1},
                { "Artvin", "08", 1},
                { "Aydın", "09", 1},
                { "Balıkesir", "10", 1},
                { "Bilecik", "11", 1},
                { "Bingöl", "12", 1},
                { "Bitlis", "13", 1},
                { "Bolu", "14", 1},
                { "Burdur", "15", 1},
                { "Bursa", "16", 1},
                { "Çanakkale", "17", 1},
                { "Çankırı", "18", 1},
                { "Çorum", "19", 1},
                { "Denizli", "20", 1},
                { "Diyarbakır", "21", 1},
                { "Edirne", "22", 1},
                { "Elazığ", "23", 1},
                { "Erzincan", "24", 1},
                { "Erzurum", "25", 1},
                { "Eskişehir", "26", 1},
                { "Gaziantep", "27", 1},
                { "Giresun", "28", 1},
                { "Gümüşhane", "29", 1},
                { "Hakkari", "30", 1},
                { "Hatay", "31", 1},
                { "Isparta", "32", 1},
                { "Mersin", "33", 1},
                { "İstanbul", "34", 1},
                { "İzmir", "35", 1},
                { "Kars", "36", 1},
                { "Kastamonu", "37", 1},
                { "Kayseri", "38", 1},
                { "Kırklareli", "39", 1},
                { "Kırşehir", "40", 1},
                { "Kocaeli", "41", 1},
                { "Konya", "42", 1},
                { "Kütahya", "43", 1},
                { "Malatya", "44", 1},
                { "Manisa", "45", 1},
                { "Kahramanmaraş", "46", 1},
                { "Mardin", "47", 1},
                { "Muğla", "48", 1},
                { "Muş", "49", 1},
                { "Nevşehir", "50", 1},
                { "Niğde", "51", 1},
                { "Ordu", "52", 1},
                { "Rize", "53", 1},
                { "Sakarya", "54", 1},
                { "Samsun", "55", 1},
                { "Siirt", "56", 1},
                { "Sinop", "57", 1},
                { "Sivas", "58", 1},
                { "Tekirdağ", "59", 1},
                { "Tokat", "60", 1},
                { "Trabzon", "61", 1},
                { "Tunceli", "62", 1},
                { "Şanlıurfa", "63", 1},
                { "Uşak", "64", 1},
                { "Van", "65", 1},
                { "Yozgat", "66", 1},
                { "Zonguldak", "67", 1},
                { "Aksaray", "68", 1},
                { "Bayburt", "69", 1},
                { "Karaman", "70", 1},
                { "Kırıkkale", "71", 1},
                { "Batman", "72", 1},
                { "Şırnak", "73", 1},
                { "Bartın", "74", 1},
                { "Ardahan", "75", 1},
                { "Iğdır", "76", 1},
                { "Yalova", "77", 1},
                { "Karabük", "78", 1},
                { "Kilis", "79", 1},
                { "Osmaniye", "80", 1},
                { "Düzce", "81", 1}
            };


            migrationBuilder.InsertData(table: "Cities",
                                        columns: citiesColumns,
                                        columnTypes: citiesColumnTypes,
                                        values: citiesValues);
        }
    }
}
