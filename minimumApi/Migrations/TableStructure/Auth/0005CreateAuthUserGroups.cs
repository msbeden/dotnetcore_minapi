using minimumApi.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

namespace minimumApi.Migrations.TableStructure.Auth
{
    [DbContext(typeof(minimumApiDbContext))]
    [Migration("0005-CreateAuthUserGroups_Table")]
    public class CreateAuthUserGroups : Migration
    {
        protected override void Up([NotNull] MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(name: "AuthUserGroups", schema: "dbo", columns: table => new
            {
                AuthUserGroupId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                AuthUserId = table.Column<int>(nullable: false),
                AuthGroupId = table.Column<int>(nullable: false)
            }, constraints: table =>
            {
                table.PrimaryKey("PK_AuthUserGroupId", x => x.AuthUserGroupId);
                table.ForeignKey("FK_AuthUserId", x => x.AuthUserId, principalTable: "AuthUsers", principalColumn: "AuthUserId");
                table.ForeignKey("FK_AuthGroupId", x => x.AuthGroupId, principalTable: "AuthGroups", principalColumn: "AuthGroupId");
            });
        }
    }
}
