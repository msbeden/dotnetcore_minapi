using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.ApplicantInfo
{
    public class ApplicantNotesViewModel : IApplicantViewModel
    {
        public int ApplicantNotId { get; set; }
        public int ApplicantId { get; set; }
        public string Notes { get; set; }
        public DateTime  NoteDate { get; set; }
    }
}
