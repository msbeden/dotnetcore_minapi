using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.Generic
{
    public class VocationalHighSchoolDepartmentViewModel : IViewModel
    {
        public int VocationalHighSchoolDepartmentId { get; set; }
        public string VocationalHighSchoolDepartmentName { get; set; }
    }
}
