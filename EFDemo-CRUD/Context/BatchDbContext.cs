using EFDemo_CRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo_CRUD.Context
{
    internal class BatchDbContext : DbContext
    {
        public BatchDbContext()
        {

        }

         
        public BatchDbContext(DbContextOptions<BatchDbContext> options) : base(options) { }
        public DbSet<Batch> Batches { get; set; }
        
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"data source=ANAMIKA\SQLSERVER;initial catalog=EmpDb;integrated security=true;TrustServerCertificate=True");
        }

        // Fluent Api
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grade>().HasKey(
                x => x.GradeCode);

            modelBuilder.Entity<Grade>()
              .Property(x => x.GradeCode)
              .HasColumnName("Grade")
              .IsRequired();
               

            modelBuilder.Entity<Grade>()
                .Property(x => x.GradeName)
                .HasColumnName("Name")
                .IsRequired()
                .HasDefaultValue("G1");

            


        }



    }
}
