using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SLHDotNetCore.GraphqlExample.Database;
using SLHDotNetCore.GraphqlExample.Features.Blog;
using SLHDotNetCore.GraphqlExample.Features.Fruit;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
});
builder.Services.AddGraphQLServer()
    .AddQueryType<BlogQuery>()
    .AddQueryType<FruitQuery>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGraphQL("/");

app.Run();
