using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CetaitQuoiLeContexte.Core.Data
{
    public class DataDbContext : DbContext
    {
        #region Constructors
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {
        }
        #endregion

        #region Internal methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //http://stackoverflow.com/questions/39088486/explicitly-map-interface-member-in-entity-framework-7
            modelBuilder.Entity<Core.Data.Context>()
            .HasOne(h => (Core.Data.Person) h.Author)
            .WithOne();

            modelBuilder.Entity<Core.Data.Context>().ToTable(typeof(Core.Data.Context).Name);
            modelBuilder.Entity<Core.Data.Person>().ToTable(typeof(Core.Data.Person).Name);
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