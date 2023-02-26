public class LocalContext : DbContext
{
    public LocalContext(DbContextOptions<LocalContext> options) : base(options)
    {
    }

    public DbSet<Local> Locais { get; set; }
}
