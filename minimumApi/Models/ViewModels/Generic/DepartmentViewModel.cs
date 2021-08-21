using minimumApi.Models.Abstractions;

namespace minimumApi.Models.ViewModels
{
    public class DepartmentViewModel : IViewModel 
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDegree { get; set; }
    }
}
