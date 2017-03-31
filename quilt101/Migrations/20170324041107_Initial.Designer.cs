using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using quilt101.Models;

namespace quilt101.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20170324041107_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("quilt101.Model.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.Property<string>("Desription");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("quilt101.Model.Quilt", b =>
                {
                    b.Property<int>("QuiltId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("LongDescription");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("ShortDescription");

                    b.Property<string>("ThumbNailUrl");

                    b.HasKey("QuiltId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Quilts");
                });

            modelBuilder.Entity("quilt101.Model.Quilt", b =>
                {
                    b.HasOne("quilt101.Model.Category", "Category")
                        .WithMany("Quilts")
                        .HasForeignKey("CategoryId");
                });
        }
    }
}
