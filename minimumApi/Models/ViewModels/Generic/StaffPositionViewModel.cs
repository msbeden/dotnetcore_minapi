using minimumApi.Models.Abstractions;

namespace minimumApi.Models.ViewModels.Generic
{
    public class StaffPositionViewModel : IViewModel
    {
        public int StaffPositionId { get; set; }
        public string StaffPositionName { get; set; }
    }
}
