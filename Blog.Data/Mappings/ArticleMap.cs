using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings;

public class ArticleMap : IEntityTypeConfiguration<Article> 
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.HasData(
            new Article
        {
            Id = Guid.NewGuid(),
            Title = "Test Article",
            Content = "Test Content", 
            ViewCount = 15,
            ImageId = Guid.Parse("C0D4BBE1-4F93-4F50-8641-E5C59342D9A1"),
            CategoryId = Guid.Parse("43111C27-BD52-4EBF-A2A1-4045FC8BC6CF"),
            CreatedBy = "Admin Test",
            CreatedDate = DateTime.Now,
            IsDeleted = false,
            UserId = Guid.Parse("34F4249A-E193-4224-B881-43FB15C8DCFB"),

            },

            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Test Article2",
                Content = "Test Content2",
                ViewCount = 17,
                CategoryId = Guid.Parse("DD5C4ADC-4079-4E20-8DF3-7C7985708BAD"),
                ImageId = Guid.Parse("278E8DF1-9DC0-47D1-80F4-F3C5A3622CC8"),
                CreatedBy = "Admin Test2",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("906CF7B6-99AD-49D4-80DD-70B75E6B1DD6"),
            }
            );

       
        
    }
}