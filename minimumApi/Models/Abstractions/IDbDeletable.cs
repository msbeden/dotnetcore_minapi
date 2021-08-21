namespace minimumApi.Models.Abstractions
{
    public interface IDbDeletable
    {
        public bool IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
    }
}