using minimumApi.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

namespace minimumApi.Migrations.TableStructure.Auth
{
    [DbContext(typeof(minimumApiDbContext))]
    [Migration("0004-CreateAuthPermissions_Table")]
    public class CreateAuthPermissions : Migration
    {
        protected override void Up([NotNull] MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(name: "AuthPermissions", schema: "dbo", columns: table => new
            {
                AuthPermissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                ControllerName = table.Column<string>(nullable: false, type: "varchar(100)"),
                ActionName = table.Column<string>(nullable: false, type: "varchar(100)"),
                IsEnabled = table.Column<bool>(nullable: false, type: "bit", defaultValueSql: "1"),
                IsDeleted = table.Column<bool>(nullable: false, type: "bit", defaultValueSql: "0")
            }, constraints: table =>
            {
                table.PrimaryKey("PK_AuthPermissionId", x => x.AuthPermissionId);
            });
        }
    }
}
