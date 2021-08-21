using minimumApi.Models.Abstractions;

namespace minimumApi.Models.ViewModels
{
    public class AuthGroupViewModel : IViewModel
    {
        public int AuthGroupId { get; set; }
        public string AuthGroupName { get; set; }
        public bool IsEnabled { get; set; }
    }
}
