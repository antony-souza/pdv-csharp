using Microsoft.EntityFrameworkCore;
using pdvback.modules.pdv.entity;
using pdvback.modules.store.entity;

namespace pdvback;

public class ApplicationDbContext : DbContext
{
    private IConfiguration _configuration;
    
    public DbSet<Store> Store { get; set; }
    public DbSet<Pdv> Pdv { get; set; }

    public ApplicationDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var typeDatabase = _configuration["TypeDatabase"];
        var connectionString = _configuration.GetConnectionString(typeDatabase);

        if (typeDatabase == "SqlServer")
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}