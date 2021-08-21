using AutoMapper;
using minimumApi.Configuration.Authorization;
using minimumApi.Models;
using minimumApi.Models.ViewModels;
using minimumApi.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace minimumApi.Controllers
{
    [ApiExplorerSettings(GroupName = "GenericControllers")]
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : Controller
    {
        private readonly ICityService _cityService;
        private IMapper _mapper;

        public CityController(ICityService cityService, IMapper mapper)
        {
            this._cityService = cityService;
            this._mapper = mapper;
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpGet("GetCity/{rowCount}")]
        public ServiceResponse<CityViewModel> GetCities(int rowCount)
        {
            return this._cityService.List(rowCount);
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpGet("GetCityById/{id}")]
        public ServiceResponse<CityViewModel> Get(int id)
        {
            return this._cityService.GetById(id);
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpGet("GetCityByCountryId/{id}")]
        public ServiceResponse<CityViewModel> GetCitiesByCountryId(int id)
        {
            return this._cityService.GetCitiesByCountryId(id);
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpGet("GetCityByCityName/{name}")]
        public ServiceResponse<CityViewModel> GetCityByName(string name)
        {
            return this._cityService.GetByName(name); 
        }


        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpPost("AddCity")]
        public ServiceResponse<long> AddCity(CityViewModel cityVm)
        {
            return this._cityService.Insert(cityVm);
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpPut("UpdateCity")]
        public ServiceResponse<long> UpdateCity(CityViewModel cityVm)
        {
            return this._cityService.Update(cityVm);
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpDelete("DeleteCity")]
        public ServiceResponse<bool> DeleteCity(int cityId)
        {
            return this._cityService.Delete(cityId);
        }
    }
}
