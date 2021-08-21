using minimumApi.Models.Abstractions;

namespace minimumApi.Models.ViewModels
{
    public class CityViewModel : IViewModel
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string PlateCode { get; set; }
        public int CountryId { get; set; }
    }
}
