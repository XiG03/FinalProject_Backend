using Microsoft.EntityFrameworkCore;


namespace FinalProject.Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // ===== TABLES =====
        

        // ===== MODEL CONFIG =====
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Student
           
        }
    }
}