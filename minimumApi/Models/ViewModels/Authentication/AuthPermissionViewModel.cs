using minimumApi.Models.Abstractions;

namespace minimumApi.Models.ViewModels
{
    public class AuthPermissionViewModel : IViewModel
    {
        public int AuthPermissionId { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public bool IsEnabled { get; set; }
    }
}
