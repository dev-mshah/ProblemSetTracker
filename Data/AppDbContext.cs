using Microsoft.EntityFrameworkCore;
using LeetCode.Models;

namespace LeetCode.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<LeetCodeQuestion> LeetCodeQuestions { get; set; }
    }
}
