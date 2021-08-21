using AutoMapper;
using minimumApi.Configuration.Authorization;
using minimumApi.Models;
using minimumApi.Models.DatabaseModels.ApplicantInfo;
using minimumApi.Models.ViewModels.ApplicantInfo;
using minimumApi.Repositories.Services.Abstractions;
using minimumApi.Services.Abstractions;
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
    public class ApplicantEducationsController : Controller
    {
        private readonly IApplicantBaseService<ApplicantEducationViewModel, ApplicantEducation> _applicanteducationService;
        private IMapper _mapper;

        public ApplicantEducationsController(IApplicantBaseService<ApplicantEducationViewModel, ApplicantEducation> applicanteducationService, IMapper mapper)
        {
            this._applicanteducationService = applicanteducationService;
            this._mapper = mapper;
        }


        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpGet("GetApplicantEducations")]
        public ServiceResponse<ApplicantEducationViewModel> GetApplicantEducations()
        {
            int rowCount = this._applicanteducationService.GetCount()?.Entity ?? 0;
            return this._applicanteducationService.List(rowCount);
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpGet("GetApplicantEducationById/{id}")]
        public ServiceResponse<ApplicantEducationViewModel> Get(int id)
        {
            return this._applicanteducationService.GetById(id);
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpGet("GetApplicantEducationsByApplicantId/{applicantId}")]
        public ServiceResponse<ApplicantEducationViewModel> GetByApplicantId(int applicantId)
        {
            return this._applicanteducationService.GetByApplicantId(applicantId);
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpPost("AddApplicantEducation")]
        public ServiceResponse<long> AddApplicantEducation(ApplicantEducationViewModel applicanteducationVm)
        {
            return _applicanteducationService.Insert(applicanteducationVm);
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpPut("UpdateApplicantEducation")]
        public ServiceResponse<long> UpdateApplicantEducation(ApplicantEducationViewModel applicanteducationVm)
        {
            return _applicanteducationService.Update(applicanteducationVm);
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        [HttpDelete("DeleteApplicantEducation")]
        public ServiceResponse<bool> DeleteApplicantEducation(int applicantEducationId)
        {
            return _applicanteducationService.Delete(applicantEducationId);
        }
    }
}
