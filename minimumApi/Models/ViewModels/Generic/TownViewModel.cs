using minimumApi.Models.Abstractions;

namespace minimumApi.Models.ViewModels
{
    public class TownViewModel : IViewModel
    {
        public int TownId { get; set; }
        public string TownName { get; set; }
        public int CityId { get; set; }
    }
}
