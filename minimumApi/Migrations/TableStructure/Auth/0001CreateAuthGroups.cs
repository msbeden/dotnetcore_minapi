using minimumApi.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

namespace minimumApi.Migrations.TableStructure.Auth
{
    [DbContext(typeof(minimumApiDbContext))]
    [Migration("0001-CreateAuthGroups_Table")]
    public class CreateAuthGroups : Migration
    {
        protected override void Up([NotNull] MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(name: "AuthGroups", schema: "dbo", columns: table => new
            {
                AuthGroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                AuthGroupName = table.Column<string>(nullable: false, type: "varchar(100)"),
                IsEnabled = table.Column<bool>(nullable: false, type: "bit", defaultValueSql: "1"),
                IsDeleted = table.Column<bool>(nullable: false, type: "bit", defaultValueSql: "0"),
                Priority =  table.Column<int>(nullable:false, type: "int", defaultValueSql: "3")
            }, constraints: table =>
            {
                table.PrimaryKey("PK_AuthGroupId", x => x.AuthGroupId);
            });
        }
    }
}
