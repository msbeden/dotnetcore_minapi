using minimumApi.Models;
using minimumApi.Models.DatabaseModels;
using minimumApi.Models.ViewModels;
using minimumApi.Repositories.Services.Abstractions;

namespace minimumApi.Services.Abstractions
{
    public interface ICityService : IGenericDefinitionsBaseService<CityViewModel, City>
    {
        ServiceResponse<CityViewModel> GetCitiesByCountryId(int countryId);
    }
}
