namespace Sogeti.WSDocker2019.ComposeService.Context
{
    using Microsoft.EntityFrameworkCore;
    using Sogeti.WSDocker2019.ComposeService.Models;

    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Catalog> Catalogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catalog>().ToTable("Catalog");

        }

    }
}
