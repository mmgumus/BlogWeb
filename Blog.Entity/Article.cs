namespace Blog.Entity;

public class Article
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public String Content { get; set; }
    public int ViewCount { get; set; }

    public Guide CategoryId { get; set; }
    public Category Category { get; set; }

    public Guide ImageId { get; set; }
    public Image Image { get; set; }
}