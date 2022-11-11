using DoAn2VADT.Database.Entities.Base;

namespace DoAn2VADT.Database.Entities
{
    public class Distributor : BaseEntity
    {
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public int? Discount { get; set; }
    }
}
