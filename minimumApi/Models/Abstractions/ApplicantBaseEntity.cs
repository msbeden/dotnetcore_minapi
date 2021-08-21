using minimumApi.Configuration.ApplicantConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.Abstractions
{
    public abstract class ApplicantBaseEntity : BaseEntity
    {
        [ApplicantId]
        public abstract int ApplicantId { get; set; }
    }
}
