using CXEngine;
using Microsoft.EntityFrameworkCore;

namespace ShortLinks_Final.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> User { get; }
        public DbSet<Feedback> Feedback { get; }
        public DbSet<Templates> Templates { get; }
        public DbSet<WorkItem> WorkItems { get; }
    }
}
