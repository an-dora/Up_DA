using DoAn2VADT.Database.Entities.Base;

namespace DoAn2VADT.Database.Entities
{
    public class Order : BaseEntity
    {
        public decimal? Total { get; set; }
    }
}
