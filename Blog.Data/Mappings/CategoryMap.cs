using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings;

public class CategoryMap : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasData(
            new Category()
            {
                Id = Guid.Parse("43111C27-BD52-4EBF-A2A1-4045FC8BC6CF"),
                Name = "Test Category",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            },
            new Category
            {
                Id = Guid.Parse("DD5C4ADC-4079-4E20-8DF3-7C7985708BAD"),
                Name = "Visual Studio 2020",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            }
        );
    }
}