using HomeChecklist.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Collections.Generic;
using System.Configuration;

namespace HomeChecklist.Persistence
{
    public class HomeChecklistContextFactory : IDesignTimeDbContextFactory<HomeChecklistDbContext>
    {
        public HomeChecklistDbContext CreateDbContext(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            var optionsBuilder = new DbContextOptionsBuilder<BloggingContext>();
            //optionsBuilder("Data Source=blog.db");

            return new HomeChecklistDbContext(optionsBuilder.Options);
        }
    }
}