using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CetaitQuoiLeContexte.Core.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DataDbContext>
    {
        #region Public methods
        public DataDbContext CreateDbContext(string[] args)
        {
            ConfigurationBuilder configBuilder = new ConfigurationBuilder();

            configBuilder.SetBasePath(Directory.GetCurrentDirectory());

            string path = Directory.GetCurrentDirectory();
            path = Path.Combine(path, "design-config.json");

            configBuilder.AddJsonFile(path);

            IConfigurationRoot root = configBuilder.Build();

            var builder = new DbContextOptionsBuilder<DataDbContext>();
            var config = root.GetConnectionString("DefaultConnection");

            builder.UseSqlServer(config);

            return new DataDbContext(builder.Options, null);
        }
        #endregion
    }
}
