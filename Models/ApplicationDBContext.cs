using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerDOTNET.Models
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions options):base(options) {

        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; } 
    }
}
