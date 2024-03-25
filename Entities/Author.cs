using System;



namespace BlogApi.Entities
{
public class Author
{
     public int Id { get; set; }
    public string Name { get; set; } = string.Empty; // Initialized with an empty string
    public string Email { get; set; } = string.Empty; // Initialized with an empty string
    public ICollection<Post> Posts { get; set; } = new List<Post>(); // Initialized with an empty list
}
}