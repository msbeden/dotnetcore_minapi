using minimumApi.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

namespace minimumApi.Migrations.DataManipulations.Auth
{
    [DbContext(typeof(minimumApiDbContext))]
    [Migration("2015-InsertAuthGroups_Data")]
    public class InsertAuthGroups : Migration
    {
        protected override void Up([NotNull] MigrationBuilder migrationBuilder)
        {
            string[] authGroupsColumns = new[] { "AuthGroupId", "AuthGroupName","Priority" };
            string[] authGroupsColumnTypes = new[] { "int", "varchar(100)", "int" };
            object[,] authGroupsValues = new object[,]
            {
                { 1, "Administrators", 0 },
                { 2, "Users", 1 },
                { 3, "Employers", 2 },
                { 4, "Applicants", 3 }
            };

            migrationBuilder.InsertData(table: "AuthGroups",
                                        columns: authGroupsColumns,
                                        columnTypes: authGroupsColumnTypes,
                                        values: authGroupsValues);
        }
    }
}
