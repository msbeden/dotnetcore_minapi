using AutoMapper;
using minimumApi.Configuration.Authorization;
using minimumApi.Models;
using minimumApi.Models.DatabaseModels.ApplicantInfo;
using minimumApi.Models.ViewModels.ApplicantInfo;
using minimumApi.Repositories.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Controllers.ApplicantInfo
{
    [ApiExplorerSettings(GroupName = "ApplicantInfo")]
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantsController : Controller
    {
        private readonly IBaseService<ApplicantViewModel, Applicant> _applicantService;
        private IMapper _mapper;

        public ApplicantsController(IBaseService<ApplicantViewModel, Applicant> applicantService, IMapper mapper)
        {
            this._applicantService = applicantService;
            this._mapper = mapper;
        }


        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpGet("GetApplicants")]
        public ServiceResponse<ApplicantViewModel> GetApplicants()
        {
            int rowCount = this._applicantService.GetCount()?.Entity ?? 0;
            return this._applicantService.List(rowCount);
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpGet("GetApplicantById/{id}")]
        public ServiceResponse<ApplicantViewModel> Get(int id)
        {
            return this._applicantService.GetById(id);
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpPost("AddApplicant")]
        public ServiceResponse<long> AddApplicant(ApplicantViewModel applicantVm)
        {
            return _applicantService.Insert(applicantVm);
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpPut("UpdateApplicant")]
        public ServiceResponse<long> UpdateApplicant(ApplicantViewModel applicantVm)
        {
            return _applicantService.Update(applicantVm);
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpDelete("DeleteApplicant")]
        public ServiceResponse<bool> DeleteApplicant(int applicantId)
        {
            return _applicantService.Delete(applicantId);
        }
    }
}
