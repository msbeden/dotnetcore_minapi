using AutoMapper;
using minimumApi.Configuration.Authorization;
using minimumApi.Models;
using minimumApi.Models.DatabaseModels;
using minimumApi.Models.ViewModels;
using minimumApi.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace minimumApi.Controllers
{
    [ApiExplorerSettings(GroupName = "GenericControllers")]
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : Controller
    {
        private readonly IGenericDefinitionsBaseService<CountryViewModel, Country> _countryService;
        private IMapper _mapper;
        public CountryController(IGenericDefinitionsBaseService<CountryViewModel, Country> countryService, IMapper mapper)
        {
            this._countryService = countryService;
            this._mapper = mapper;
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpGet("GetCountry/{rowCount}")]
        public ServiceResponse<CountryViewModel> GetCountries(int rowCount)
        {
            return this._countryService.List(rowCount);
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpGet("GetCountriesAll")]
        public ServiceResponse<CountryViewModel> GetCountriesAll()
        {
            int itemCount = this._countryService.GetCount()?.Entity ?? 0;
            return this._countryService.List(itemCount);
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpGet("GetCountryById/{id}")]
        public ServiceResponse<CountryViewModel> Get(int id)
        {
            return this._countryService.GetById(id);
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpPost("AddCountry")]
        public ServiceResponse<long> AddCountry(CountryViewModel countryVm)
        {
            return this._countryService.Insert(countryVm);
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpPut("UpdateCountry")]
        public ServiceResponse<long> UpdateTown(CountryViewModel countryVm)
        {
            return this._countryService.Update(countryVm);
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpDelete("DeleteCountry")]
        public ServiceResponse<bool> DeleteTown(int countryId)
        {
            return this._countryService.Delete(countryId);
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpGet("GetCountryByName/{name}")]
        public ServiceResponse<CountryViewModel> GetCountryByName(string name)
        {
            return this._countryService.GetByName(name);
        }
    }
}
