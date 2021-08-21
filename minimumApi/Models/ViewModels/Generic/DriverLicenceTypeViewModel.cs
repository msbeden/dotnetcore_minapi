using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.Generic
{
    public class DriverLicenceTypeViewModel : IViewModel
    {
        public int DriverLicenceTypeId { get; set; }
        public string DriverLicenceTypeName { get; set; }
    }
}
