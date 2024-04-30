using Microsoft.EntityFrameworkCore;
using Domain;

namespace Infrastructure;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
    { }

    public DbSet<User> Users { get; set; }

}
