using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.Entities.Concrete;

namespace YSKProje.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();

            builder.Property(i => i.AuthorName).HasMaxLength(100).IsRequired();
            builder.Property(i => i.AuthorEmail).HasMaxLength(100).IsRequired();
            builder.Property(i => i.Description).HasColumnType("ntext").IsRequired();

            builder.HasMany(i => i.SubComment).WithOne(i => i.ParentComment).HasForeignKey(i => i.ParentCommentId);


        }
    }
}
