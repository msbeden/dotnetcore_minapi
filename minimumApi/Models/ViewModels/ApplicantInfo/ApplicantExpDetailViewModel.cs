using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.ApplicantInfo
{
    public class ApplicantExpDetailViewModel : IApplicantViewModel
    {
        public int ApplicantEXDId { get; set; }
        public int ApplicantId { get; set; }
        public int QueNumber { get; set; }
        public string CompanyName { get; set; }
        public string Sector { get; set; }
        public string Position { get; set; }
        public string Class { get; set; }
        public int PeriodYear { get; set; }

        public string TaskDescription { get; set; }
        public string Tasks { get; set; }
    }
}
