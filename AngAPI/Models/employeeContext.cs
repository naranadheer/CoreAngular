using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AngAPI.Models
{
    public partial class employeeContext : DbContext
    {
        public employeeContext()
        {
        }

        public employeeContext(DbContextOptions<employeeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Emp> Emp { get; set; }
        public virtual DbSet<TblEmployeeinfo> TblEmployeeinfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=employee;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emp>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEmployeeinfo>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.ToTable("tbl_employeeinfo");

                entity.Property(e => e.Comment).HasMaxLength(50);

                entity.Property(e => e.LeaveDate).HasColumnType("datetime");

                entity.Property(e => e.LeaveReason).HasMaxLength(50);

                entity.Property(e => e.Project).HasMaxLength(50);

                entity.Property(e => e.Sno).HasMaxLength(10);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Worktype).HasMaxLength(50);
            });
        }
    }
}
