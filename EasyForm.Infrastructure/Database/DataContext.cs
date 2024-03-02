using EasyForm.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyForm.Infrastructure.Database;

public class DataContext : DbContext, IDisposable
{
    public DbSet<User> Users { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public override void Dispose()
    {
        base.Dispose();
    }
}