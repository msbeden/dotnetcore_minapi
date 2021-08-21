using minimumApi.Models;
using minimumApi.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;

namespace minimumApi.Configuration.Authorization
{
    public class AuthorizationFilter : IActionFilter
    {
        private readonly IAuthorizationFilterService _permissionFilterService;
        private readonly ITokenManagerService _tokenManagerService;
        public AuthorizationFilter(IAuthorizationFilterService permissionFilterService, ITokenManagerService tokenManagerService)
        {
            this._permissionFilterService = permissionFilterService;
            this._tokenManagerService = tokenManagerService;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            return;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            string jwtToken = context.HttpContext.Request.Headers["Authorization"].FirstOrDefault();
            ObjectResult failedResult = new ObjectResult(context.ModelState) { Value = "Not Authorized", StatusCode = StatusCodes.Status401Unauthorized };
            try
            {
                string actionName = ((ControllerActionDescriptor)context.ActionDescriptor).ActionName;
                string controllerName = ((ControllerActionDescriptor)context.ActionDescriptor).ControllerName;

                var tokenResponse = this._tokenManagerService.ValidateToken(jwtToken);

                TimeSpan? tokenExpiryDiff = (tokenResponse.Entity?.ExpiredDate - DateTime.UtcNow);
                if (!tokenExpiryDiff.HasValue)
                {
                    context.Result = failedResult;
                    return;
                }

                bool isExpired = tokenExpiryDiff.Value.TotalSeconds < 1;
                if (!tokenResponse.IsSuccessful || isExpired)
                {
                    context.Result = failedResult;
                    return;
                }

                ServiceResponse<bool> response = this._permissionFilterService.UserHasPermission(tokenResponse.Entity.UserId, controllerName, actionName);
                if (!response.Entity)
                {
                    context.Result = failedResult;
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
