using Microsoft.EntityFrameworkCore;

namespace SignalRCurdApp.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { 
        
        }
        public virtual DbSet<Products> Products { get; set; }
    }
}
