using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.ApplicantInfo
{
    public class ApplicantAbilityViewModel : IApplicantViewModel
    {
        public int ApplicantAbilityId { get; set; }
        public int ApplicantId { get; set; }
        public int NumericalAbility { get; set; }
        public int NumericalPoint { get; set; }
        public int AnalyticalAbility { get; set; }
        public int AnalyticalPoint { get; set; }
        public int LearnAbility { get; set; }
        public int LearnPoint { get; set; }

        public int ApplyingAbility { get; set; }
        public int ApplyingAbilityPoint { get; set; }
        public int CareAbility { get; set; }
        public int CarePoint { get; set; }

        public int InnovationAbility { get; set; }
        public int InnovationPoint { get; set; }
        public int ComminicationAbility { get; set; }
        public int ComminicationPoint { get; set; }
        public int SolutionAbility { get; set; }
        public int SolutionPoint { get; set; }




        public int PlanningAbility { get; set; }
        public int PlanningPoint { get; set; }
        public int CoordinationAbility { get; set; }
        public int CoordinationPoint { get; set; }
        public int ObeyingAbility { get; set; }
        public int ObeyingPoint { get; set; }
        public int DesignAbility { get; set; }
        public int DesignPoint { get; set; }
        public int RepresentationAbility { get; set; }
        public int RepresentationPoint { get; set; }
        public string ExpertsOpinion { get; set; }
    }
}
