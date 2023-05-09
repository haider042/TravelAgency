using Microsoft.EntityFrameworkCore;

namespace Travelia.Model
{
    public class TripDB_Context : DbContext
    {


        public TripDB_Context(DbContextOptions<TripDB_Context> options) : base(options)
        {
            
        }

        public DbSet<Trip> customer { get; set; }
        
    }
}
