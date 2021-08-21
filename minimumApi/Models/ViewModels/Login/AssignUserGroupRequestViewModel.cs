using minimumApi.Models.Abstractions;

namespace minimumApi.Models.ViewModels.Login
{
    public class AssignUserGroupRequestViewModel : IViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int GroupId { get; set; }
    }
}
