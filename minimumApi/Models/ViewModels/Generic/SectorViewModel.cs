using minimumApi.Models.Abstractions;

namespace minimumApi.Models.ViewModels
{
    public class SectorViewModel :IViewModel
    {
        public int SectorId { get; set; }
        public string SectorName { get; set; }
        public int SectorJobCode { get; set; }
        public string NaceCode { get; set; }
        public string SectorDescription { get; set; }
    }
}
