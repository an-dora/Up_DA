using DoAn2VADT.Database.Entities.Base;

namespace DoAn2VADT.Database.Entities
{
    public class Book : BaseEntity
    {
        public string? Description { get; set; }
        public string? Image { get; set; }
        public decimal? Price { get; set; }
        public decimal? Discount { get; set; }
        public int? Amont { get; set; }
        public int? DistributorId { get; set; }
        public int? PublisherId { get; set; }
        public int? AuthorId { get; set; }
        public int? TitleId { get; set; }
        public int? CategoryId { get; set; }

        public  Category? Category { get; set; }
        public Title? Title { get; set; }
        public Distributor? Distributor { get; set; }
        public Publisher? Publisher { get; set; }
        public Author? Author { get; set; }
    }
}
