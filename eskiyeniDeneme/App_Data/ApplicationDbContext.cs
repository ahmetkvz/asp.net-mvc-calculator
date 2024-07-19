using eskiyeniDeneme.Models;
using System.Data.Entity;

namespace eskiyeniDeneme.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<calc> Calculations{ get; set; }

        public ApplicationDbContext() : base("DefaultConnection") { }
    }

}