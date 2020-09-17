
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace bPetClinicSolution.Data.EF
{
    public class BPetDbContextFactory : IDesignTimeDbContextFactory<BPetDbContext>
    {
        public BPetDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            //conection string
            var connectionString = configuration.GetConnectionString("bPetSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<BPetDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new BPetDbContext(optionsBuilder.Options);
        }
    }
}
