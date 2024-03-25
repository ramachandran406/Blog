using System;
using BlogApi.Entities;

namespace BlogApi.Entities
{

public class BlogComment
{
    public int Id { get; set; }
    public string? Content { get; set; }
    public DateTime? DateCreated { get; set; }
    // Other nullable properties as needed

    // Foreign key
    public int? PostId { get; set; }
    public BlogPost? BlogPost { get; set; }
}
}
