using DoAn2VADT.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoAn2VADT.Database.Entities
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(250);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.Amont).HasColumnType("SMALLINT");
            builder.Property(x => x.Price).HasColumnType("money");
            builder.HasOne(x => x.Publisher).WithMany().IsRequired(false).HasForeignKey(x => x.PublisherId);
            builder.HasOne(x => x.Distributor).WithMany().IsRequired(false).HasForeignKey(x => x.DistributorId);
            builder.HasOne(x => x.Author).WithMany().IsRequired(false).HasForeignKey(x => x.AuthorId);
            builder.HasOne(x => x.Category).WithMany().IsRequired(false).HasForeignKey(x => x.CategoryId);
            builder.HasOne(x => x.Title).WithMany().IsRequired(false).HasForeignKey(x => x.TitleId);
        }
    }
}
