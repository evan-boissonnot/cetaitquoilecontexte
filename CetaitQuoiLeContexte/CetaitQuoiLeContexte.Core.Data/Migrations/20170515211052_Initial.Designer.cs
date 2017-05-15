using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CetaitQuoiLeContexte.Core.Data;

namespace CetaitQuoiLeContexte.Core.Data.Migrations
{
    [DbContext(typeof(DataDbContext))]
    [Migration("20170515211052_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CetaitQuoiLeContexte.Core.Data.Context", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Message")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Context");
                });

            modelBuilder.Entity("CetaitQuoiLeContexte.Core.Data.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("CetaitQuoiLeContexte.Core.Data.Context", b =>
                {
                    b.HasOne("CetaitQuoiLeContexte.Core.Data.Person", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
