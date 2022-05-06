using Amazon.Models.Tables;
using Microsoft.EntityFrameworkCore;

namespace Amazon.Models.DataContext
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options)    
        {

        }
        public DbSet<A_Users> users { get; set; }
    }
}
