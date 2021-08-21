using minimumApi.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Migrations.TableStructure.ApplicantInfo
{
    [DbContext(typeof(minimumApiDbContext))]
    [Migration("1061-CreateApplicants_Table")]
    public class CreateApplicants : Migration
    {
        protected override void Up([NotNull] MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(name: "Applicants",
                                         schema: "dbo",
                                         columns: table => new
                                         {
                                             ApplicantId = table.Column<int>(nullable: false)
                                                    .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),

                                             ApplicantName = table.Column<string>(nullable: false, type: "varchar(255)"),
                                             ApplicantTCKN = table.Column<string>(nullable: true, type: "varchar(11)"),
                                             ApplicantEmail = table.Column<string>(nullable: true, type: "varchar(50)"),
                                             ApplicantPhone = table.Column<string>(nullable: true, type: "varchar(15)"),
                                             City = table.Column<string>(nullable: true, type: "varchar(25)"),
                                             Town = table.Column<string>(nullable: true, type: "varchar(25)"),
                                             District = table.Column<string>(nullable: true, type: "varchar(25)"),
                                             Street = table.Column<string>(nullable: true, type: "varchar(25)"),
                                             DoorNumber = table.Column<string>(nullable: true, type: "varchar(10)"),
                                             AddressDefinition = table.Column<string>(nullable: true, type: "varchar(100)"),
                                             BirthDate = table.Column<DateTime>(nullable: false, type: "datetime"),
                                             BirthCity = table.Column<string>(nullable: true, type: "varchar(25)"),
                                             BirthTown = table.Column<string>(nullable: true, type: "varchar(25)"),

                                             Gender = table.Column<int>(nullable: false, defaultValueSql: "0"),
                                             MaritalStatus = table.Column<int>(nullable: false, defaultValueSql: "0"),
                                             MilitaryStatus = table.Column<int>(nullable: false, defaultValueSql: "0"),
                                             EndDateDelay = table.Column<DateTime>(nullable: false, type: "datetime", defaultValueSql:"'1901-01-01'"),

                                             HeightCm = table.Column<int>(nullable: false, defaultValueSql: "0"),
                                             WeightKg = table.Column<int>(nullable: false, defaultValueSql: "0"),
                                             IsDisabled = table.Column<int>(nullable: false, defaultValueSql: "0"),
                                             IsSmoker = table.Column<int>(nullable: false, defaultValueSql: "0"),
                                             CanTravel = table.Column<int>(nullable: false, defaultValueSql: "0"),
                                             WorkShifts = table.Column<int>(nullable: false, defaultValueSql: "0"),
                                             HasReferences = table.Column<int>(nullable: false, defaultValueSql: "0"),
                                             CriminalRecord = table.Column<int>(nullable: false, defaultValueSql: "0"),
                                             CanDrive = table.Column<int>(nullable: false, defaultValueSql: "0"),
                                             DriverLicenceType = table.Column<int>(nullable: false, defaultValueSql: "0"),
                                             ObstacleDiseases = table.Column<string>(nullable: true, type: "varchar(255)"),
                                             Photo = table.Column<string>(nullable: true, type: "varchar(max)"),


                                         }, constraints: table =>
                                         {
                                             table.PrimaryKey("PK_ApplicantId", x => x.ApplicantId);

                                         });
        }
    }
}
