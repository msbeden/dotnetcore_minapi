using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.Generic
{
    public class PostgraduateViewModel : IViewModel
    {
        public int PostgraduateId { get; set; }
        public string PostgraduateName { get; set; }
    }
}
