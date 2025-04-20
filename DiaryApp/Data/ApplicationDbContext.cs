using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry {
                    Id = 1,
                    Title = "First Entry",
                    Content = "This is my first diary entry.",
                    Created = new DateTime(2025, 4, 20, 12, 0, 0)
                },

                new DiaryEntry
                {
                    Id = 2,
                    Title = "Second Entry",
                    Content = "This is my second diary entry.",
                    Created = new DateTime(2025, 4, 21, 9, 30, 0)
                }
                );
        }
    }
}
