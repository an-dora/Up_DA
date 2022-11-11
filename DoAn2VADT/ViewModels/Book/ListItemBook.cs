namespace DoAn2VADT.ViewModels.Book
{
    public class ListItemBook
    {
        public int Id { get; set; }
        public String? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public decimal? Price { get; set; }
        public decimal? Discount { get; set; }

        public string? DistributorName { get; set; }
        public string? PublisherName { get; set; }
        public string? AuthorName { get; set; }
        public string? TitleName { get; set; }
        public string? CategoryName { get; set; }
    }
}
