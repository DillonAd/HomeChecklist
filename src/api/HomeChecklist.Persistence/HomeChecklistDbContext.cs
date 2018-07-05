using HomeChecklist.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HomeChecklist.Persistence
{
    public class HomeChecklistDbContext : DbContext
    {
        public virtual DbSet<Home> Homes { get; set; }
        public virtual DbSet<Resident> Residents { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }

        public HomeChecklistDbContext(DbContextOptions<HomeChecklistDbContext> options)
            : base(options) { }
    }
}