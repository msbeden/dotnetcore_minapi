using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.Generic
{
    public class BachelorDegreeViewModel : IViewModel
    {
        public int BachelorDegreeId { get; set; }
        public string BachelorDegreeName { get; set; }
        public string BachelorDegreeGrade { get; set; }
    }
}
