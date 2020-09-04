//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;

//namespace Supermarket.API.Models
//{
//    public partial class SupermarketDBContext : DbContext
//    {
//        public SupermarketDBContext()
//        {
//        }

//        public SupermarketDBContext(DbContextOptions<SupermarketDBContext> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<Category> Category { get; set; }
//        public virtual DbSet<Product> Product { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=SupermarketDB;Trusted_Connection=True;");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Category>(entity =>
//            {
//                entity.Property(e => e.CategoryName)
//                    .IsRequired()
//                    .HasMaxLength(500)
//                    .IsUnicode(false);
//            });

//            modelBuilder.Entity<Product>(entity =>
//            {
//                entity.Property(e => e.ProductName)
//                    .IsRequired()
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.HasOne(d => d.Category)
//                    .WithMany(p => p.Product)
//                    .HasForeignKey(d => d.CategoryId)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FK__Product__Categor__267ABA7A");
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}
