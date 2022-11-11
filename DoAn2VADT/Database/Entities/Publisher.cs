using DoAn2VADT.Database.Entities.Base;

namespace DoAn2VADT.Database.Entities
{
    public class Publisher : BaseEntity
    {
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Mail { get; set; }
    }
}
