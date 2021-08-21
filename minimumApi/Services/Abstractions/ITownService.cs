using minimumApi.Models;
using minimumApi.Models.DatabaseModels;
using minimumApi.Models.ViewModels;
using minimumApi.Services.Abstractions;

namespace minimumApi.Services
{
    public interface ITownService : IGenericDefinitionsBaseService<TownViewModel, Town>
    {
        ServiceResponse<TownViewModel> GetTownsByCityId(int cityId);
    }
}
