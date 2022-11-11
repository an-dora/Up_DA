﻿using DoAn2VADT.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoAn2VADT.Database.Entities
{
    public class PublisherConfig : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(250);
            builder.Property(x => x.Address).HasMaxLength(250);
            builder.Property(x => x.PhoneNumber).HasMaxLength(15);

        }
    }
}
