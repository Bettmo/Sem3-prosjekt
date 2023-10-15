using Microsoft.EntityFrameworkCore;

namespace Nøsted.data
{
    public class ApplicationDbContext : DbContext
    {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Skjema> Skjemaer { get; set; }
    }
}
