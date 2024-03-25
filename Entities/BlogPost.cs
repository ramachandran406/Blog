using System;



namespace BlogApi.Entities
{

public class BlogPost
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public DateTime? DateCreated { get; set; }
    // Other nullable properties as needed
}
}