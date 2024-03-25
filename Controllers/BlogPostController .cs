using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApi.Data;
using BlogApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace BlogApi.Controllers
{

// Controllers/BlogPostsController.cs
[Route("api/blogposts")]
[ApiController]
public class BlogPostsController : ControllerBase
{
    private readonly DataContext _context;

    public BlogPostsController(DataContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<BlogPost>> CreateBlogPost(BlogPost blogPost)
    {
        _context.BlogPost.Add(blogPost);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetBlogPost), new { id = blogPost.Id }, blogPost);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<BlogPost>> GetBlogPost(int id)
    {
        var blogPost = await _context.BlogPost.FindAsync(id);

        if (blogPost == null)
        {
            return NotFound();
        }

        return blogPost;
    }

    // Controllers/BlogPostsController.cs
[HttpPut("{id}")]
public async Task<IActionResult> UpdateBlogPost(int id, BlogPost blogPost)
{
    if (id != blogPost.Id)
    {
        return BadRequest();
    }

    _context.Entry(blogPost).State = EntityState.Modified;

    try
    {
        await _context.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (!BlogPostExists(id))
        {
            return NotFound();
        }
        else
        {
            throw;
        }
    }

    return NoContent();
}

[HttpDelete("{id}")]
public async Task<IActionResult> DeleteBlogPost(int id)
{
    var blogPost = await _context.BlogPost.FindAsync(id);
    if (blogPost == null)
    {
        return NotFound();
    }

    _context.BlogPost.Remove(blogPost);
    await _context.SaveChangesAsync();

    return NoContent();
}

private bool BlogPostExists(int id)
{
    return _context.BlogPost.Any(e => e.Id == id);
}

}

}