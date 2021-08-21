using minimumApi.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

namespace minimumApi.Migrations
{
    [DbContext(typeof(minimumApiDbContext))]
    [Migration("1001-CreateCountries_Table")]
    public class CreateCountries : Migration
    {
        protected override void Up([NotNull] MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(name: "Countries", schema: "dbo", columns: table => new
            {
                CountryId = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                CountryName = table.Column<string>(nullable: false, type: "varchar(100)")
            }, constraints: table =>
            {
                table.PrimaryKey("PK_CountryId", x => x.CountryId);
            });
        }
    }
}
