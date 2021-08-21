using AutoMapper;
using minimumApi.Models;
using minimumApi.Models.DatabaseModels;
using minimumApi.Models.ViewModels;
using minimumApi.Repositories.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace minimumApi.Services
{
    public class TownService : GenericDefinitionsBaseService<TownViewModel, Town>, ITownService
    {
        public TownService(IRepository<Town> repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public ServiceResponse<TownViewModel> GetTownsByCityId(int cityId)
        {
            var response = new ServiceResponse<TownViewModel>(null);
            var query = this._repository.Table.Where(x => x.CityId == cityId);
            response.Count = query.Count();

            var entities = query.ToList();
            IEnumerable<TownViewModel> viewModels = this._mapper.Map<IEnumerable<TownViewModel>>(entities);
            response.List = viewModels.ToList();
            response.IsSuccessful = true;

            return response;
        }
    }
}
