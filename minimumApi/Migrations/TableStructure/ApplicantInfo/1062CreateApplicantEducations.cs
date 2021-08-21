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
    [Migration("1062-CreateApplicantEducations_Table")]
    public class ApplicantEducations : Migration
    {
        protected override void Up([NotNull] MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(name: "ApplicantEducations",
                                         schema: "dbo",
                                         columns: table => new
                                         {
                                             ApplicantEId = table.Column<int>(nullable: false)
                                                    .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),

                                             ApplicantId = table.Column<int>(nullable: false),
                                             EducationLevel = table.Column<string>(nullable: false, type: "varchar(100)"),
                                             VocationHighSchool = table.Column<string>(nullable: true, type: "varchar(255)"),
                                             VocationHighSchoolCountry = table.Column<string>(nullable: true, type: "varchar(100)"),
                                             VocationHighSchoolName = table.Column<string>(nullable: true, type: "varchar(100)"),

                                             VocationHighSchoolYearGrad = table.Column<int>(nullable: false, defaultValueSql: "0"),
                                             VocationHighSchoolPoint = table.Column<float>(nullable: false, defaultValueSql: "0"),

                                             VocationCollege = table.Column<string>(nullable: true, type: "varchar(255)"),

                                             VocationCollegeCountry = table.Column<string>(nullable: true, type: "varchar(100)"),
                                             VocationCollegeName = table.Column<string>(nullable: true, type: "varchar(100)"),

                                             VocationCollegeYearGrad = table.Column<int>(nullable: false, defaultValueSql: "0"),
                                             VocationCollegePoint = table.Column<float>(nullable: false, defaultValueSql: "0"),

                                             University = table.Column<string>(nullable: true, type: "varchar(255)"),
                                             UniversityCountry = table.Column<string>(nullable: true, type: "varchar(100)"),
                                             UniversityName = table.Column<string>(nullable: true, type: "varchar(100)"),

                                             UniversityYearGrad = table.Column<int>(nullable: false, defaultValueSql: "0"),
                                             UniversityPoint = table.Column<float>(nullable: false, defaultValueSql: "0"),

                                             Postgraduate = table.Column<string>(nullable: true, type: "varchar(255)"),
                                             PostgraduateCountry = table.Column<string>(nullable: true, type: "varchar(100)"),
                                             PostgraduateName = table.Column<string>(nullable: true, type: "varchar(100)"),

                                             PostgraduateYearGrad = table.Column<int>(nullable: false, defaultValueSql: "0"),
                                             PostgraduatePoint = table.Column<float>(nullable: false, defaultValueSql: "0"),



                                         }, constraints: table =>
                                         {
                                             table.PrimaryKey("PK_ApplicantEducationId", x => x.ApplicantEId);
                                             table.ForeignKey("FK_ApplicantEducation_ApplicantId", x => x.ApplicantId ,principalTable:"Applicants", principalColumn:"ApplicantId");
                                         });
        }
    }
}
