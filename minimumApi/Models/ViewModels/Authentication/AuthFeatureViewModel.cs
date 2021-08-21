using minimumApi.Models.Abstractions;

namespace minimumApi.Models.ViewModels
{
    public class AuthFeatureViewModel : IViewModel
    {
        public int AuthFeatureId { get; set; }
        public string AuthFeatureName { get; set; }
        public string AuthFeatureTableName { get; set; }
        public bool IsEnabled { get; set; }
    }
}
