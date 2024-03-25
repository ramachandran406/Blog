using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApi.Data;
using BlogApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

namespace BlogApi.Data
{
public class DataContext : DbContext
{
    public DbSet<Post> Posts { get; set; }


     public DbSet<BlogPost> BlogPost { get; set; }
    public DbSet<BlogComment> BlogComments { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
}

}
