using AutoMapper;
using minimumApi.Configuration.ApplicantConfiguration;
using minimumApi.Extensions;
using minimumApi.Repositories.Abstractions;
using minimumApi.Services.Abstractions;
using minimumApi.Models;
using minimumApi.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace minimumApi.Services
{
    public class ApplicantBaseService<TViewModel, TDatabaseModel>
        :BaseService<TViewModel, TDatabaseModel> , IApplicantBaseService<TViewModel, TDatabaseModel>
        where TViewModel : IApplicantViewModel 
        where TDatabaseModel : ApplicantBaseEntity 
    {
        public ApplicantBaseService(IRepository<TDatabaseModel> repository, IMapper mapper) : base(repository, mapper)
        {

        }

        public ServiceResponse<TViewModel> GetByApplicantId(int ApplicantId)
        {
            var response = new ServiceResponse<TViewModel>(null);
            PropertyInfo property = typeof(TDatabaseModel).GetProperties().Where(prop => prop.GetCustomAttribute<ApplicantIdAttribute>(true) != null).FirstOrDefault();
            var query = from data in this._repository.Table select data;
            IEnumerable<TDatabaseModel> models = query.Where(field: property, value: ApplicantId);
            TDatabaseModel model = models.FirstOrDefault();
            response.Entity = this._mapper.Map<TViewModel>(model);
            response.List = this._mapper.Map<IList<TViewModel>>(models);
            if (response.List !=null)
            {
                response.Count = response.List.Count;
            }
            response.IsSuccessful = true;
            return response; 
        }

        public ServiceResponse<TViewModel> GetByApplicantId(int ApplicantId, params Expression<Func<TDatabaseModel, object>>[] includes)
        {
            var response = new ServiceResponse<TViewModel>(null);

            PropertyInfo property = typeof(TDatabaseModel).GetProperties().Where(prop => prop.GetCustomAttribute<ApplicantIdAttribute>(true) != null).FirstOrDefault();
            var query = from data in this._repository.Table select data;
            IEnumerable<TDatabaseModel> models = query.Where(field: property, value: ApplicantId).IncludeMultiple(includes);
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
