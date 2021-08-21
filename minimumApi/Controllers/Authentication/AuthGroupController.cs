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
    public class AuthGroupController : Controller
    {
        private readonly IBaseService<AuthGroupViewModel, AuthGroup> _authGroupService;
        private IMapper _mapper;

        public AuthGroupController(IBaseService<AuthGroupViewModel, AuthGroup> authGroupService, IMapper mapper)
        {
            this._authGroupService = authGroupService;
            this._mapper = mapper;
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpGet("GetAuthGroup/{rowCount}")]
        public ServiceResponse<AuthGroupViewModel> GetAuthGroups(int rowCount)
        {
            var response = this._authGroupService.List(rowCount);
            return response;
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpGet("GetAuthGroupById/{id}")]
        public ServiceResponse<AuthGroupViewModel> Get(int id)
        {
            var response = this._authGroupService.GetById(id);
            return response;
        }
    }
}
