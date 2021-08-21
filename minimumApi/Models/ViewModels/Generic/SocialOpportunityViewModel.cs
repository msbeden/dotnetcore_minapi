using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.Generic
{
    public class SocialOpportunityViewModel : IViewModel
    {
        public int SocialOpportunityId { get; set; }
        public string SocialOpportunityName { get; set; }
    }
}
