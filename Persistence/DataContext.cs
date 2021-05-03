using System;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Value> Values { get; set; }

        // This will reflect the Database Table name i.e. Activities
        public DbSet<Activity> Activities { get; set; }
    }
}
