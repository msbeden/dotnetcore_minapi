using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.Generic
{
    public class ComputerKnowledgeViewModel : IViewModel
    {
        public int ComputerKnowledgeId { get; set; }
        public string ComputerKnowledgeName { get; set; }
    }
}
