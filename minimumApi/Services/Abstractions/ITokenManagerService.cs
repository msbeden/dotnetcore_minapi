using minimumApi.Models;
using minimumApi.Models.DatabaseModels.Auth;
using minimumApi.Models.ViewModels.Login;
using System.Collections.Generic;

namespace minimumApi.Services.Abstractions
{
    public interface ITokenManagerService
    {
        public string GenerateToken(AuthUser user, IEnumerable<AuthGroup> userGroups);
        public ServiceResponse<ValidateTokenResponseViewModel> ValidateToken(string jwtToken);
    }
}