using minimumApi.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

namespace minimumApi.Migrations
{
    [DbContext(typeof(minimumApiDbContext))]
    [Migration("1003-CreateTowns_Table")]
    public class CreateTowns : Migration
    {
        protected override void Up([NotNull] MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(name: "Towns",
                                         schema: "dbo",
                                         columns: table => new
                                         {
                                             TownId = table.Column<int>(nullable: false)
                                                    .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                                             TownName = table.Column<string>(nullable: false, type: "varchar(100)"),
                                             CityId = table.Column<int>(nullable: false)
                                         }, constraints: table =>
                                         {
                                             table.PrimaryKey("PK_TownId", x => x.TownId);
                                             table.ForeignKey("FK_CityId", x => x.CityId, principalTable: "Cities", principalColumn: "CityId");
                                         });
        }
    }
}
