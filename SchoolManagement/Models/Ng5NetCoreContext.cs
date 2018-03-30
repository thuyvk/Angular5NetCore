using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SchoolManagement.Models
{
    public partial class Ng5NetCoreContext : DbContext
    {
        public virtual DbSet<ArticleFavorites> ArticleFavorites { get; set; }
        public virtual DbSet<ArticleRating> ArticleRating { get; set; }
        public virtual DbSet<Articles> Articles { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"server=.\SQLEXPRESS02;user=thuyvk;password=123;database=Ng5NetCore");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArticleFavorites>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<ArticleRating>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Articles>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.TimePost).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CateName).HasMaxLength(50);
            });
        }
    }
}
