using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.ApplicantInfo
{
    public class ApplicantReferenceViewModel : IApplicantViewModel
    {
        public int ApplicantREFId { get; set; }
        public int ApplicantId { get; set; }
        public string ReferenceName { get; set; }
        public string ReferenceEmail { get; set; }
        public string ReferenceTelephone { get; set; }
        public string ReferenceCompany { get; set; }
        public string ReferencePosition { get; set; }
        public string ReferenceType { get; set; }
    }
}
