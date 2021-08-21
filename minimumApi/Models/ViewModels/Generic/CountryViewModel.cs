using minimumApi.Models.Abstractions;

namespace minimumApi.Models.ViewModels
{
    public class CountryViewModel : IViewModel
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }
}
