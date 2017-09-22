namespace GenericRepository.Data
{
    using Microsoft.EntityFrameworkCore;

    public class CodingBlastDbContext : DbContext
    {
        public CodingBlastDbContext(DbContextOptions<CodingBlastDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}