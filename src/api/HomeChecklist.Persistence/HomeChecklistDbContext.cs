using HomeChecklist.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System.Collections.Generic;

namespace HomeChecklist.Persistence
{
    public class HomeChecklistDbContext : DbContext
    {
        private static ILoggerFactory loggerFactory = 
            new LoggerFactory(new [] { new ConsoleLoggerProvider((_, __) => true, true) });

        public virtual DbSet<Home> Homes { get; set; }
        public virtual DbSet<Resident> Residents { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }

        public HomeChecklistDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("")
                .UseLoggerFactory(loggerFactory);
                
            base.OnConfiguring(optionsBuilder);
        }
    }
}