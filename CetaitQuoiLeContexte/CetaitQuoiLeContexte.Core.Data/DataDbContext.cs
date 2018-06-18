using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace CetaitQuoiLeContexte.Core.Data
{

    /// <summary>
    /// Pour migration, manquait des références, à ajouter dans le csproj : https://github.com/aspnet/EntityFramework/issues/7869
    /// </summary>
    public class DataDbContext : DbContext
    {
        #region Fields
        private ILoggerFactory _loggerFactory = null;
        #endregion

        #region Constructors
        public DataDbContext(DbContextOptions<DataDbContext> options, ILoggerFactory loggerFactory) : base(options)
        {
            this._loggerFactory = loggerFactory;
        }
        #endregion

        #region Internal methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //http://stackoverflow.com/questions/39088486/explicitly-map-interface-member-in-entity-framework-7
            modelBuilder.Entity<Core.Data.Context>()
                        .HasOne(h => (Core.Data.Person) h.Author)
                        .WithMany();

            modelBuilder.Entity<Core.Data.Context>().ToTable(typeof(Core.Data.Context).Name);
            modelBuilder.Entity<Core.Data.Person>().ToTable(typeof(Core.Data.Person).Name);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(this._loggerFactory);
        }
        #endregion

        #region Properties
        /// <summary>
        /// Accès aux contextes
        /// </summary>
        public DbSet<Context> Contexts { get; set; }

        /// <summary>
        /// Accès aux personnes
        /// </summary>
        public DbSet<Person> Persons { get; set; }
        #endregion
    }
}