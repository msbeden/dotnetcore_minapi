using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.ApplicantInfo
{
    public class ApplicantCertificateViewModel : IApplicantViewModel
    {
        public int ApplicantCEId { get; set; }
        public int ApplicantId { get; set; }
        public int QueNumber { get; set; }
        public string Certificate { get; set; }
        public string CourseName { get; set; }
        public int CertificateYear { get; set; }
        public string Description { get; set; }
    }
}
