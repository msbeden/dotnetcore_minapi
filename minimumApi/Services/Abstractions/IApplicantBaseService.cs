using minimumApi.Models;
using minimumApi.Models.Abstractions;
using minimumApi.Repositories.Services.Abstractions;
using System;
using System.Linq.Expressions;


namespace minimumApi.Services.Abstractions
{
    public interface IApplicantBaseService<TViewModel, TDatabaseModel>
        : IBaseService<TViewModel, TDatabaseModel>
        where TViewModel : IApplicantViewModel 
        where TDatabaseModel: ApplicantBaseEntity
    {
        ServiceResponse<TViewModel> GetByApplicantId(int ApplicantId);
        ServiceResponse<TViewModel> GetByApplicantId(int ApplicantId, params Expression<Func<TDatabaseModel, object>>[] includes);
    }
}
