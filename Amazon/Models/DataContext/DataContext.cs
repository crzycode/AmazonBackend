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
        public DbSet<A_Products> Products { get; set; }
        public DbSet<A_Pincode> pincodes { get; set; }

        public DbSet<A_Review> reviews { get; set; }
        public DbSet<A_Comment> comments { get; set; }
    }
}
