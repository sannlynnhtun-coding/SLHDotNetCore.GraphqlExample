using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using SLHDotNetCore.GraphqlExample.Features.Blog;
using SLHDotNetCore.GraphqlExample.Features.Fruit;
using System.IO;

namespace SLHDotNetCore.GraphqlExample.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<BlogModel> Blogs { get; set; }
    public DbSet<FruitModel> Fruits { get; set; }
}
