using minimumApi.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

namespace minimumApi.Migrations.DataManipulations.Auth
{
    [DbContext(typeof(minimumApiDbContext))]
    [Migration("2017-InsertAuthUserGroups_Data")]
    public class InsertAuthUserGroups : Migration
    {
        protected override void Up([NotNull] MigrationBuilder migrationBuilder)
        {
            string[] authUserGroupsColumns = new[] { "AuthUserGroupId", "AuthUserId", "AuthGroupId" };
            string[] authUserGroupsColumnTypes = new[] { "bigint", "int", "int" };
            object[,] authUserGroupsValues = new object[,]
            {
                { 1, 1, 1 }
            };

            migrationBuilder.InsertData(table: "AuthUserGroups",
                                        columns: authUserGroupsColumns,
                                        columnTypes: authUserGroupsColumnTypes,
                                        values: authUserGroupsValues);
        }
    }
}