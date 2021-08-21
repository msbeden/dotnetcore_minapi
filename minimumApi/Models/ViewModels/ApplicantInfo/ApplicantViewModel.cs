using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.ApplicantInfo
{
    public class ApplicantViewModel : IViewModel
    {
        public int ApplicantId { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicantTCKN { get; set; }
        public string ApplicantEmail { get; set; }
        public string ApplicantPhone { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string DoorNumber { get; set; }
        public string AddressDefinition { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthCity { get; set; }
        public string BirthTown { get; set; }
        public int Gender { get; set; }
        public int MaritalStatus { get; set; }
        public int MilitaryStatus { get; set; }
        public DateTime EndDateDelay { get; set; }
        public int HeightCm { get; set; }
        public int WeightKg { get; set; }
        public int IsDisabled { get; set; }
        public int IsSmoker { get; set; }
        public int CanTravel { get; set; }
        public int WorkShifts { get; set; }
        public int HasReferences { get; set; }
        public int CriminalRecord { get; set; }
        public int CanDrive { get; set; }
        public int DriverLicenceType { get; set; }
        public string ObstacleDiseases { get; set; }
        public string Photo { get; set; }
    }
}
