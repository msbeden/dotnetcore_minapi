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
    public class AuthUserController : Controller
    {
        private readonly IBaseService<AuthUserViewModel, AuthUser> _authUserService;
        private IMapper _mapper;

        public AuthUserController(IBaseService<AuthUserViewModel, AuthUser> authUserService, IMapper mapper)
        {
            this._authUserService = authUserService;
            this._mapper = mapper;
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpGet("GetAuthUser/{rowCount}")]
        public ServiceResponse<AuthUserViewModel> GetAuthGroups(int rowCount)
        {
            var response = this._authUserService.List(rowCount);
            return response;
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpGet("GetAuthUserById/{id}")]
        public ServiceResponse<AuthUserViewModel> Get(int id)
        {
            var response = this._authUserService.GetById(id);
            return response;
        }
    }
}
