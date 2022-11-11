using DoAn2VADT.Database.Entities.Base;

namespace DoAn2VADT.Database.Entities
{
    public class Author:BaseEntity
    {
        public string? HomeTown { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
    }
}
