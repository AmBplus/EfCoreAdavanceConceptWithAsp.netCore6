using System.Reflection;
using Ef.Domain.Product;
using Ef.Domain.ProductCategory;
using EF.EFcore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace EF.EFcore;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> ProductCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Assembly assembly = typeof(MapProduct).Assembly;
        modelBuilder.ApplyConfigurationsFromAssembly(assembly);
        base.OnModelCreating(modelBuilder);
    }
}