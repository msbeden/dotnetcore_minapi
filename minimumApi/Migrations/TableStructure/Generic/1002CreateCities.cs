using minimumApi.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

namespace minimumApi.Migrations
{
    [DbContext(typeof(minimumApiDbContext))]
    [Migration("1002-CreateCities_Table")]
    public class CreateCities : Migration
    {
        protected override void Up([NotNull] MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(name: "Cities",
                                         schema: "dbo",
                                         columns: table => new
                                         {
                                             CityId = table.Column<int>(nullable: false)
                                                    .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                                             CityName = table.Column<string>(nullable: false, type: "varchar(100)"),
                                             PlateCode = table.Column<string>(nullable: false, type: "varchar(2)"),
                                             CountryId = table.Column<int>(nullable: false)
                                         }, constraints: table =>
                                         {
                                             table.PrimaryKey("PK_CityId", x => x.CityId);
                                             table.ForeignKey("FK_CountryId", x => x.CountryId, principalTable: "Countries", principalColumn: "CountryId");
                                         });
        }
    }
}
