using minimumApi.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

namespace minimumApi.Migrations.TableStructure.Auth
{
    [DbContext(typeof(minimumApiDbContext))]
    [Migration("0003-CreateAuthFeatures_Table")]
    public class CreateAuthFeatures : Migration
    {
        protected override void Up([NotNull] MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(name: "AuthFeatures", schema: "dbo", columns: table => new
            {
                AuthFeatureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                AuthFeatureName = table.Column<string>(nullable: false, type: "varchar(100)"),
                AuthFeatureTableName = table.Column<string>(nullable: false, type: "varchar(100)"),
                IsEnabled = table.Column<bool>(nullable: false, type: "bit", defaultValueSql: "1"),
                IsDeleted = table.Column<bool>(nullable: false, type: "bit", defaultValueSql: "0")
            }, constraints: table =>
            {
                table.PrimaryKey("PK_AuthFeatureId", x => x.AuthFeatureId);
            });
        }
    }
}
