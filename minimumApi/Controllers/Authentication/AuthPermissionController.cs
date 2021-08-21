using AutoMapper;
using minimumApi.Configuration.Authorization;
using minimumApi.Models;
using minimumApi.Models.DatabaseModels.Auth;
using minimumApi.Models.ViewModels;
using minimumApi.Repositories.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace minimumApi.Controllers
{
    [ApiExplorerSettings(GroupName = "Authentication")]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthPermissionController : Controller
    {
        private readonly IBaseService<AuthPermissionViewModel, AuthPermission> _authPermissionService;

        public AuthPermissionController(IBaseService<AuthPermissionViewModel, AuthPermission> authPermissionService)
        {
            this._authPermissionService = authPermissionService;
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpGet("GetAuthPermission/{rowCount}")]
        public ServiceResponse<AuthPermissionViewModel> GetAuthGroups(int rowCount)
        {
            var response = this._authPermissionService.List(rowCount);
            return response;
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpGet("GetAuthPermissionById/{id}")]
        public ServiceResponse<AuthPermissionViewModel> Get(int id)
        {
            var response = this._authPermissionService.GetById(id);
            return response;
        }
    }
}
