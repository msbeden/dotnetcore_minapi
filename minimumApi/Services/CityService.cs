using AutoMapper;
using minimumApi.Models;
using minimumApi.Models.DatabaseModels;
using minimumApi.Models.ViewModels;
using minimumApi.Repositories.Abstractions;
using minimumApi.Services.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace minimumApi.Services
{
    public class CityService : GenericDefinitionsBaseService<CityViewModel, City>, ICityService
    {
        public CityService(IRepository<City> repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public ServiceResponse<CityViewModel> GetCitiesByCountryId(int countryId)
        {
            var response = new ServiceResponse<CityViewModel>(null);
            var query = this._repository.Table.Where(x => x.CountryId == countryId);
            response.Count = query.Count();

            var entities = query.ToList();
            IEnumerable<CityViewModel> viewModels = this._mapper.Map<IEnumerable<CityViewModel>>(entities);
            response.List = viewModels.ToList();
            response.IsSuccessful = true;

            return response;
        }
    }
}
