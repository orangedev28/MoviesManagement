using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PhanMemQuanLyPhim.Data
{
    public partial class MovieDbContext : DbContext
    {
        public MovieDbContext()
            : base("name=MovieDbContext3")
        {
        }

        public virtual DbSet<DaoDien> DaoDiens { get; set; }
        public virtual DbSet<DienVien> DienViens { get; set; }
        public virtual DbSet<NhaSanXuat> NhaSanXuats { get; set; }
        public virtual DbSet<NuocSanXuat> NuocSanXuats { get; set; }
        public virtual DbSet<Phim> Phims { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DaoDien>()
                .HasMany(e => e.Phims)
                .WithRequired(e => e.DaoDien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DienVien>()
                .HasMany(e => e.Phims)
                .WithRequired(e => e.DienVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaSanXuat>()
                .HasMany(e => e.Phims)
                .WithRequired(e => e.NhaSanXuat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NuocSanXuat>()
                .HasMany(e => e.Phims)
                .WithRequired(e => e.NuocSanXuat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TheLoai>()
                .HasMany(e => e.Phims)
                .WithRequired(e => e.TheLoai)
                .WillCascadeOnDelete(false);
        }
    }
}
