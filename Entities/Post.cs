namespace BlogApi.Entities
{

public class Post
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public DateTime DateCreated { get; set; }

    public int AuthorId { get; set; }
    public Author? Author { get; set; }
}
}