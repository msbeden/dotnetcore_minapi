using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.ApplicantInfo
{
    public class ApplicantFunctionViewModel : IApplicantViewModel
    {
        public int ApplicantFUId { get; set; }
        public int ApplicantId { get; set; }
        public int Q1 { get; set; }
        public int Q2 { get; set; }
        public int Q3 { get; set; }
        public int Q4 { get; set; }
        public int Q5 { get; set; }
        public int Q6 { get; set; }
        public string FinancialRisk { get; set; }
        public bool FinancialRiskNewJob { get; set; }
        public string LegalRisk { get; set; }
        public bool LegalRiskNewJob { get; set; }
        public string MedicalRisk { get; set; }
        public bool MedicalRiskNewJob { get; set; }
        public string LifeRisk { get; set; }
        public bool LifeRiskNewJob { get; set; }
        public float SalaryMax { get; set; }
        public float SalaryMin { get; set; }
        public bool PerformancePayment { get; set; }
        public bool SocialBonusPayment { get; set; }
        public bool SocialChildBenefit { get; set; }
        public bool SocialHeatingAid { get; set; }
        public bool SocialEducationalAid { get; set; }
        public bool SocialIndividualPension { get; set; }
        public bool SocialLifeInsurance { get; set; }
        public bool SocialUnavailable { get; set; }
        public bool SocialOther { get; set; }
        public string SocialOtherDescription { get; set; }
    }
}
