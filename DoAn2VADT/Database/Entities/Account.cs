using DoAn2VADT.Database.Entities.Base;

namespace DoAn2VADT.Database.Entities
{
    public class Account : BaseEntity
    {
        public string? Address { get; set; }
        public string? Email { get; set; }
        public int? Role { get; set; }
    }
}
