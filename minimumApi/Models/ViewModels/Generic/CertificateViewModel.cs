using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Models.ViewModels.Generic
{
    public class CertificateViewModel : IViewModel
    {
        public int CertificateId { get; set; }
        public string CertificateName { get; set; }
        public string CertificateDescription { get; set; }
    }
}
