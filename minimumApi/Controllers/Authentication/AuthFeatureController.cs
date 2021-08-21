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
    public class AuthFeatureController : Controller
    {
        private readonly IBaseService<AuthFeatureViewModel, AuthFeature> _authFeatureService;
        private IMapper _mapper;

        public AuthFeatureController(IBaseService<AuthFeatureViewModel, AuthFeature> authFeatureService, IMapper mapper)
        {
            this._authFeatureService = authFeatureService;
            this._mapper = mapper;
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpGet("GetAuthFeature/{rowCount}")]
        public ServiceResponse<AuthFeatureViewModel> GetAuthGroups(int rowCount)
        {
            var response = this._authFeatureService.List(rowCount);
            return response;
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpGet("GetAuthFeatureById/{id}")]
        public ServiceResponse<AuthFeatureViewModel> Get(int id)
        {
            var response = this._authFeatureService.GetById(id);
            return response;
        }
    }
}
