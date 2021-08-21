using AutoMapper;
using minimumApi.Extensions;
using minimumApi.Models;
using minimumApi.Models.DatabaseModels.Auth;
using minimumApi.Repositories.Abstractions;
using minimumApi.Services.Abstractions;
using System.Linq;

namespace minimumApi.Services
{
    public class AuthorizationFilterService : IAuthorizationFilterService
    {
        IRepository<AuthUserGroup> _ugRepository;
        IRepository<AuthGroupPermission> _gpRepository;

        public AuthorizationFilterService(IRepository<AuthGroupPermission> gpRepository, IRepository<AuthUserGroup> ugRepository)
        {
            this._gpRepository = gpRepository;
            this._ugRepository = ugRepository;
        }

        public ServiceResponse<bool> UserHasPermission(int userId, string controllerName, string actionName)
        {
            //userId = 1;
            var resultsUG = this._ugRepository.IncludeMany(x => x.User, x => x.Group).Where(x => x.AuthUserId == userId);
            var resultGP = this._gpRepository.IncludeMany(x => x.Group, x => x.Permission).Where(x => (x.Permission.ControllerName == controllerName
                                                                                                       && x.Permission.ActionName == actionName));
            bool flag = false;
            foreach (var item in resultsUG)
            {
                if (resultGP.Any(x => x.AuthGroupId == item.AuthGroupId) || item.AuthGroupId == 1 || item.AuthGroupId == 2)
                {
                    flag = true;
                    break;
                }
            }

            ServiceResponse<bool> response = new ServiceResponse<bool>(null)
            {
                Count = 1,
                Entity = flag,
                IsSuccessful = true
            };

            return response;
        }

    }
}
