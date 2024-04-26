
using Microsoft.EntityFrameworkCore;

namespace signalrserver.Models.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }

        public DbSet<TransactionDetail> TransactionDetails { get; set; }

        public DbSet<POS> POS { get; set; }
    }
}
