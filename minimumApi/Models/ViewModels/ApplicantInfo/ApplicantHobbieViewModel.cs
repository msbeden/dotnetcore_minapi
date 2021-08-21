using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.ApplicantInfo
{
    public class ApplicantHobbieViewModel : IApplicantViewModel
    {
        public int ApplicantHOId { get; set; }
        public int ApplicantId { get; set; }
        public string HobbyName { get; set; }
        public string FactorHobby { get; set; }
        public bool HobbyTask { get; set; }

    }
}
