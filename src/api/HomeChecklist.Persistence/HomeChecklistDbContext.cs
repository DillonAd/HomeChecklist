using HomeChecklist.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HomeChecklist.Persistence
{
    public partial class HomeChecklistDbContext : DbContext
    {
        public virtual DbSet<Home> Homes { get; set; }
        public virtual DbSet<Resident> Residents { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }

        public HomeChecklistDbContext(DbContextOptions<HomeChecklistDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
		{
            builder.Entity<Home>();
            builder.Entity<Resident>();
            builder.Entity<Room>();
            builder.Entity<Task>();
		}
    }
}