using minimumApi.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

namespace minimumApi.Migrations.DataManipulations.Auth
{
    [DbContext(typeof(minimumApiDbContext))]
    [Migration("2016-InsertAuthUser_Data")]
    public class InsertAuthUsers : Migration
    {
        protected override void Up([NotNull] MigrationBuilder migrationBuilder)
        {
            string[] authUsersColumns = new[] { "AuthUserId", "Username", "FirstName", "LastName", "Password", "PasswordHash", "EMail", "Gsm" };
            string[] authUsersColumnTypes = new[] { "int", "varchar(100)", "varchar(100)", "varchar(100)", "varchar(100)", "varchar(100)", "varchar(100)", "varchar(20)" };
            object[,] authUsersValues = new object[,]
            {
                { 1, "admin", "Administrator","Administrator", "123456", "*", "admin@e-yaz.com.tr", "00000000000" }
            };

            migrationBuilder.InsertData(table: "AuthUsers",
                                        columns: authUsersColumns,
                                        columnTypes: authUsersColumnTypes,
                                        values: authUsersValues);
        }
    }
}
