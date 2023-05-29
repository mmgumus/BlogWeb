using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings;

public class ImageMap : IEntityTypeConfiguration<Image>
{
    public void Configure(EntityTypeBuilder<Image> builder)
    {
        builder.HasData(
            new Image()
            {
                Id = Guid.Parse("C0D4BBE1-4F93-4F50-8641-E5C59342D9A1"),
                FileName = "Test Image",
                FileType = "jpg",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Image()
            {
                Id = Guid.Parse("278E8DF1-9DC0-47D1-80F4-F3C5A3622CC8"),
                FileName = "Test Image2",
                FileType = "jpg",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            }
        );
    }
}