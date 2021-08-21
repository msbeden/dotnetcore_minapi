using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.ApplicantInfo
{
    public class ApplicantExperienceViewModel : IApplicantViewModel
    {
        public int ApplicantEXId { get; set; }
        public int ApplicantId { get; set; }
        public string Position1 { get; set; }
        public string Position1Factor { get; set; }
        public string Position2 { get; set; }
        public string Position2Factor { get; set; }
        public string Position3 { get; set; }
        public string Position3Factor { get; set; }
        public string Position4 { get; set; }
        public string Position4Factor { get; set; }
        public string Position5 { get; set; }
        public string Position5Factor { get; set; }
        public int ExperienceYear { get; set; }
        public int ExperienceYearFactor { get; set; }
    }
}
