using EasyForm.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyForm.Infrastructure.Database;

public class DataContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public override void Dispose()
    {
        base.Dispose();
    }
}