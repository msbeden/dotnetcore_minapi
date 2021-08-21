using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.Generic
{
    public class ObstacleDiseaseViewModel : IViewModel
    {
        public int ObstacleDiseaseId { get; set; }
        public string ObstacleDiseaseName { get; set; }
    }
}
