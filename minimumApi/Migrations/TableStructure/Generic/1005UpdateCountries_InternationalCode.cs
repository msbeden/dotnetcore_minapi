using minimumApi.Models;
using minimumApi.Models.DatabaseModels;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

namespace minimumApi.Migrations.TableStructure
{
    [DbContext(typeof(minimumApiDbContext))]
    [Migration("1005-UpdateCountries_InternationalCode")]
    public class UpdateCountries_InternationalCode : Migration
    {
        protected override void Up([NotNull] MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Country>(name: "InternationalCode",
                                                table: "Countries",
                                                type: "varchar(3)",
                                                maxLength: 3,
                                                schema: "dbo",
                                                nullable: true);
        }
    }
}
