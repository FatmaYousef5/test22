using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ITIContext : DbContext
    {
        public ITIContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<StoreModel> stores { get; set; }
    }
}
