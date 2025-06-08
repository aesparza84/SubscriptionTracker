using System.Data.Entity;
using Models;

namespace SubscriptionTracker.DBFiles
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=DefaultConnection") { }
        public DbSet<Subscription> Subscriptions { get; set; }
    }
}
