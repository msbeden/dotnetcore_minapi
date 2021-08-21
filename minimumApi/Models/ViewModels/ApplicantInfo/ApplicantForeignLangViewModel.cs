using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.ApplicantInfo
{
    public class ApplicantForeignLangViewModel : IApplicantViewModel
    {
        public int ApplicantFLId { get; set; }
        public int ApplicantId { get; set; }
        public int QueNumber { get; set; }
        public string Language { get; set; }
        public string LanguageLevel { get; set; }
    }
}
