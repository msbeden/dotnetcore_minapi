using minimumApi.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

namespace minimumApi.Migrations.TableStructure.Auth
{
    [DbContext(typeof(minimumApiDbContext))]
    [Migration("0002-CreateAuthUsers_Table")]
    public class CreateAuthUsers : Migration
    {
        protected override void Up([NotNull] MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(name: "AuthUsers", schema: "dbo", columns: table => new
            {
                AuthUserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                Username = table.Column<string>(nullable: false, type: "varchar(100)"),
                FirstName = table.Column<string>(nullable: false, type: "varchar(100)"),
                MiddleName = table.Column<string>(nullable: true, type: "varchar(100)"),
                LastName = table.Column<string>(nullable: false, type: "varchar(100)"),
                Password = table.Column<string>(nullable: false, type: "varchar(100)"),
                PasswordHash = table.Column<string>(nullable: false, type: "varchar(256)"),
                EMail = table.Column<string>(nullable: true, type: "varchar(100)"),
                Gsm = table.Column<string>(nullable: false, type: "varchar(20)"),
                IsEnabled = table.Column<bool>(nullable: false, type: "bit", defaultValueSql: "1"),
                IsDeleted = table.Column<bool>(nullable: false, type: "bit", defaultValueSql: "0")
            }, constraints: table =>
            {
                table.PrimaryKey("PK_AuthUserId", x => x.AuthUserId);
            });
        }
    }
}
