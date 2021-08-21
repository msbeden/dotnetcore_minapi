using System;

namespace minimumApi.Configuration.ApplicantConfiguration
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ApplicantIdAttribute : Attribute
    {
        public ApplicantIdAttribute()
        {

        }
    }
}
