using Microsoft.EntityFrameworkCore;

namespace Travelia.Model
{
    public class DbContext
    {
        public DbContext(DbContextOptions<TripDB_Context> options)
        {
        }
    }
}