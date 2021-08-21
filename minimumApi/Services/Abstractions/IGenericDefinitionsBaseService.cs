using minimumApi.Models;
using minimumApi.Models.Abstractions;
using minimumApi.Repositories.Services.Abstractions;

namespace minimumApi.Services.Abstractions
{
    public interface IGenericDefinitionsBaseService<TViewModel, TDatabaseModel> : IBaseService<TViewModel, TDatabaseModel>
        where TViewModel : IViewModel
        where TDatabaseModel : BaseEntity
    {
        ServiceResponse<TViewModel> GetByName(string name);
    }
}
