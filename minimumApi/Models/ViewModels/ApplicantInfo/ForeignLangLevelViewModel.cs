using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.Generic
{
    public class ForeignLangLevelViewModel : IViewModel
    {
        public int ForeignLangLevelId { get; set; }
        public string ForeignLangLevelDescription { get; set; }
    }
}
