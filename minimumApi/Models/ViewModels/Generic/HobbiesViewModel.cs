using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.Generic
{
    public class HobbiesViewModel : IViewModel
    {
        public int HobbyId { get; set; }
        public string HobbyFactorName { get; set; }
    }
}
