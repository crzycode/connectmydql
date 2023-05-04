using connectmydql.Model;
using Microsoft.EntityFrameworkCore;

namespace connectmydql.Context
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }
        public DbSet<Books> books { get; set; }
    }
}
