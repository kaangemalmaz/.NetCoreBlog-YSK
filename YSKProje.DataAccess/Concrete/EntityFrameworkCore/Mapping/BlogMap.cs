using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.Entities.Concrete;

namespace YSKProje.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class BlogMap : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();

            builder.Property(i => i.Title).HasMaxLength(100).IsRequired();
            builder.Property(i => i.ShortDescription).HasMaxLength(100).IsRequired();
            builder.Property(i => i.Description).HasColumnType("ntext");
            builder.Property(i => i.ImagePath).HasMaxLength(300);

            builder.HasMany(i => i.Comments).WithOne(i => i.Blog).HasForeignKey(i => i.BlogId);

            builder.HasMany(i => i.CategoryBlogs).WithOne(i => i.Blog).HasForeignKey(i => i.BlogId);
        }
    }
}
