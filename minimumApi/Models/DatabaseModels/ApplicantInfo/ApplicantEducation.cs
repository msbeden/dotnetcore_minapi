﻿using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.DatabaseModels.ApplicantInfo
{
    public class ApplicantEducation : ApplicantBaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApplicantEId { get; set; }
        [ForeignKey("Applicants")]
        public override int ApplicantId { get; set; }
        public Applicant Applicant { get; set; }
        public string EducationLevel { get; set; }
        public string VocationHighSchool { get; set; }
        public string VocationHighSchoolCountry { get; set; }
        public string VocationHighSchoolName { get; set; }
        public int VocationHighSchoolYearGrad { get; set; }
        public float VocationHighSchoolPoint { get; set; }
        public string VocationCollege { get; set; }
        public string VocationCollegeCountry { get; set; }
        public string VocationCollegeName { get; set; }
        public int VocationCollegeYearGrad { get; set; }
        public float VocationCollegePoint { get; set; }
        public string University { get; set; }
        public string UniversityCountry { get; set; }
        public string UniversityName { get; set; }
        public int UniversityYearGrad { get; set; }
        public float UniversityPoint { get; set; }
        public string Postgraduate { get; set; }
        public string PostgraduateCountry { get; set; }
        public string PostgraduateName { get; set; }
        public int PostgraduateYearGrad { get; set; }
        public float PostgraduatePoint { get; set; }
    }
}
