using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.Generic
{
    public class AssociateDegreeViewModel : IViewModel
    {
        public int AssociateDegreeId { get; set; }
        public string AssociateDegreeName { get; set; }
        public string AssociateDegreeGrade { get; set; }
    }
}
