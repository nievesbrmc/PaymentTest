using Microsoft.EntityFrameworkCore;
using Entity;
namespace DbContextLaye
{
    public class DbContextData: DbContext
    {
        public DbContextData(DbContextOptions<DbContextData> options) : base(options)
        {

        }       

        public DbSet<PaymentsLog> PaymentsLogs { get; set; }
        public DbSet<PaymentStatus> PaymentStatus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PaymentsLog>().HasKey(x => x.PaymentId);
            modelBuilder.Entity<PaymentStatus>().HasKey(x => x.PaymentStatusId);
        }
    }
}