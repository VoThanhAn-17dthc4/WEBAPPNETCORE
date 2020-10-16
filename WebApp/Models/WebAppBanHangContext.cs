using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApp.Models
{
    public partial class WebAppBanHangContext : DbContext
    {
        public WebAppBanHangContext()
        {
        }

        public WebAppBanHangContext(DbContextOptions<WebAppBanHangContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<CthoaDon> CthoaDon { get; set; }
        public virtual DbSet<CtphieuNhap> CtphieuNhap { get; set; }
        public virtual DbSet<CtsanPham> CtsanPham { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<LoaiSp> LoaiSp { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCap { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhap { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<Size> Size { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=ADMIN\\SQLEXPRESS;Database=WebAppBanHang;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<CthoaDon>(entity =>
            {
                entity.ToTable("CTHoaDon");

                entity.Property(e => e.IdHd).HasColumnName("Id_HD");

                entity.Property(e => e.IdLoaisp).HasColumnName("Id_Loaisp");

                entity.Property(e => e.IdSize).HasColumnName("Id_Size");

                entity.Property(e => e.IdSp).HasColumnName("Id_SP");
            });

            modelBuilder.Entity<CtphieuNhap>(entity =>
            {
                entity.ToTable("CTPhieuNhap");

                entity.Property(e => e.IdPn).HasColumnName("Id_PN");

                entity.Property(e => e.IdSize).HasColumnName("Id_Size");

                entity.Property(e => e.IdSp).HasColumnName("Id_SP");
            });

            modelBuilder.Entity<CtsanPham>(entity =>
            {
                entity.ToTable("CTSanPham");

                entity.Property(e => e.IdSize).HasColumnName("Id_Size");

                entity.Property(e => e.IdSp).HasColumnName("Id_SP");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.Property(e => e.IdKh).HasColumnName("Id_KH");

                entity.Property(e => e.NgayTao).HasColumnType("datetime");
            });

            modelBuilder.Entity<LoaiSp>(entity =>
            {
                entity.ToTable("LoaiSP");

                entity.Property(e => e.Ten).HasMaxLength(50);
            });

            modelBuilder.Entity<NhaCungCap>(entity =>
            {
                entity.Property(e => e.NgayTao).HasColumnType("datetime");

                entity.Property(e => e.Ten).HasMaxLength(50);
            });

            modelBuilder.Entity<PhieuNhap>(entity =>
            {
                entity.Property(e => e.IdNcc).HasColumnName("Id_NCC");

                entity.Property(e => e.IdTk).HasColumnName("Id_TK");

                entity.Property(e => e.NgayTao).HasColumnType("datetime");

                entity.Property(e => e.TieuDe).HasMaxLength(50);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.Property(e => e.NgayTao).HasColumnType("datetime");

                entity.Property(e => e.NoiDung).HasMaxLength(50);

                entity.Property(e => e.Ten).HasMaxLength(50);
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.Property(e => e.IdSp).HasColumnName("Id_SP");

                entity.Property(e => e.SizeNumber).HasColumnName("Size_Number");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.Property(e => e.HoVaTen).HasMaxLength(50);

                entity.Property(e => e.MatKhau).HasMaxLength(50);

                entity.Property(e => e.NgayTao).HasColumnType("datetime");

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(50);

                entity.Property(e => e.TenTaiKhoan).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
