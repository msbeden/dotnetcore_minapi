using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.Generic
{
    public class LanguageViewModel : IViewModel
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public string LanguageDescription { get; set; }
    }
}
