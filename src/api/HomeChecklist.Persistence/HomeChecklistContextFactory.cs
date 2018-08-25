using HomeChecklist.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace HomeChecklist.Persistence
{
    public class HomeChecklistContextFactory : IDesignTimeDbContextFactory<HomeChecklistDbContext>
    {
        public HomeChecklistDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                //TODO This is stupid. There has to be a better way.
                .SetBasePath(Directory.GetCurrentDirectory() + "/../HomeChecklist")
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<HomeChecklistDbContext>();
            var connectionString = configuration.GetConnectionString("Default");
            optionsBuilder.UseSqlServer(connectionString);

            return new HomeChecklistDbContext(optionsBuilder.Options);
        }
        
    }
}