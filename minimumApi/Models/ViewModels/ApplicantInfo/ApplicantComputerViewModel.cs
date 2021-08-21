using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.ApplicantInfo
{
    public class ApplicantComputerViewModel : IApplicantViewModel
    {
        public int ApplicantCId { get; set; }
        public int ApplicantId { get; set; }
        public int QueNumber { get; set; }
        public string Subject { get; set; }
        public string SubjectLevel { get; set; }
    }
}
