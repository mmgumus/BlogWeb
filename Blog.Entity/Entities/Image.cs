namespace Blog.Entity.Entities;

public class Image
{
    public string FileName { get; set; }
    public string FileType { get; set; }
    public ICollection<Article> Articles { get; set; }
}