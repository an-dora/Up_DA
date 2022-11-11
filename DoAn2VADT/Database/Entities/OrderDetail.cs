using DoAn2VADT.Database.Entities.Base;

namespace DoAn2VADT.Database.Entities
{
    public class OrderDetail : BaseEntity
    {
        public decimal? Price { get; set; }
        public decimal? Discount { get; set; }
        public int? Amount { get; set; }
        public int? OrderId { get; set; }
        public int? BookId { get; set; }
        public Order? Order { get; set; }
        public Book? Book { get; set; }

    }
}
