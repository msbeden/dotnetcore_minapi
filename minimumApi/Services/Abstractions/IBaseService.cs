using minimumApi.Models;
using minimumApi.Models.Abstractions;
using System.Collections.Generic;

namespace minimumApi.Repositories.Services.Abstractions
{
    public interface IBaseService<TViewModel, TDatabaseModel>
        where TViewModel : IViewModel
        where TDatabaseModel : BaseEntity
    {
        ServiceResponse<long> Insert<TInsertViewModel>(TInsertViewModel model) where TInsertViewModel : IViewModel;
        ServiceResponse<long> Insert<TInsertViewModel>(IEnumerable<TInsertViewModel> entities) where TInsertViewModel : IViewModel;
        ServiceResponse<long> Update<TInsertViewModel>(TInsertViewModel model) where TInsertViewModel : IViewModel;
        ServiceResponse<long> Update<TInsertViewModel>(IEnumerable<TInsertViewModel> entities) where TInsertViewModel : IViewModel;
        ServiceResponse<bool> Delete(int id);
        ServiceResponse<long> Delete(IEnumerable<int> idList);
        ServiceResponse<int> GetCount();
        ServiceResponse<TViewModel> List(int rowCount);
        ServiceResponse<TViewModel> GetById(int id);
    }
}
