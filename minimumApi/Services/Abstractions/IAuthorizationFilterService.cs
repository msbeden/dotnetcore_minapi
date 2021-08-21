using minimumApi.Models;

namespace minimumApi.Services.Abstractions
{
    public interface IAuthorizationFilterService
    {
        ServiceResponse<bool> UserHasPermission(int userId, string controllerName, string actionName);
    }
}
