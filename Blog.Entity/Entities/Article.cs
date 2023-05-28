using Blog.Core.Entities;

namespace Blog.Entity.Entities;

public class Article : EntityBase, IEntityBase
{
    public string Title { get; set; }
    public string Content { get; set; }
    public int ViewCount { get; set; }

    public Guide CategoryId { get; set; }
    public Category Category { get; set; }

    public Guide ImageId { get; set; }
    public Image Image { get; set; }
}