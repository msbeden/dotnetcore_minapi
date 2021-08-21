using AutoMapper;
using minimumApi.Models.DatabaseModels.ApplicantInfo;
using minimumApi.Models.ViewModels.ApplicantInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Configuration.MapperProfiles.ApplicantInfo
{
    public class ApplicantEducationMapper : Profile
    {
        public ApplicantEducationMapper()
        {
            CreateMap<ApplicantEducationViewModel, ApplicantEducation>();
            CreateMap<ApplicantEducation, ApplicantEducationViewModel>();

        }        
    }
}
