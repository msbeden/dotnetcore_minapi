using AutoMapper;
using minimumApi.Configuration.GenericDefinitionsConfiguration;
using minimumApi.Extensions;
using minimumApi.Models;
using minimumApi.Models.Abstractions;
using minimumApi.Repositories.Abstractions;
using minimumApi.Services.Abstractions;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace minimumApi.Services
{
    public class GenericDefinitionsBaseService<TViewModel, TDatabaseModel>
        : BaseService<TViewModel, TDatabaseModel>, IGenericDefinitionsBaseService<TViewModel, TDatabaseModel>
        where TViewModel : IViewModel
        where TDatabaseModel : BaseEntity
    {
        public GenericDefinitionsBaseService(IRepository<TDatabaseModel> repository, IMapper mapper) : base(repository, mapper)
        {

        }

        public ServiceResponse<TViewModel> GetByName(string name)
        {
            var response = new ServiceResponse<TViewModel>(null);
            PropertyInfo property = typeof(TDatabaseModel).GetProperties()
                                                          .Where(prop => prop.GetCustomAttribute<NameAttribute>(true) != null)
                                                          .FirstOrDefault();
            var query = from data in this._repository.Table select data;
            IEnumerable<TDatabaseModel> models = query.Where(field: property, value: name);
            TDatabaseModel model = models.FirstOrDefault();
            response.Entity = this._mapper.Map<TViewModel>(model);
            response.List = this._mapper.Map<IList<TViewModel>>(models);
            if (response.List != null)
            {
                response.Count = response.List.Count;
            }
            response.IsSuccessful = true;
            return response;
        }

    }
}
