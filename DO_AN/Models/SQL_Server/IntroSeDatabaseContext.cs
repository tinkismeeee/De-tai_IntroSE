using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DO_AN.Models.SQL_Server;

public partial class IntroSeDatabaseContext : DbContext
{
    public IntroSeDatabaseContext()
    {
    }

    public IntroSeDatabaseContext(DbContextOptions<IntroSeDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CartInfo> CartInfos { get; set; }

    public virtual DbSet<UserInfo> UserInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Initial Catalog=introSE_database;User ID=;Password=;TrustServerCertificate=True;Trusted_Connection=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CartInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cart_info");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Hovaten)
                .HasMaxLength(100)
                .HasColumnName("hovaten");
            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("id");
            entity.Property(e => e.Nam)
                .HasMaxLength(100)
                .HasColumnName("nam");
            entity.Property(e => e.Ngay)
                .HasMaxLength(100)
                .HasColumnName("ngay");
            entity.Property(e => e.Sodienthoai)
                .HasMaxLength(100)
                .HasColumnName("sodienthoai");
            entity.Property(e => e.Soluong)
                .HasMaxLength(100)
                .HasColumnName("soluong");
            entity.Property(e => e.Sotien)
                .HasMaxLength(100)
                .HasColumnName("sotien");
            entity.Property(e => e.Tenhang)
                .HasMaxLength(100)
                .HasColumnName("tenhang");
            entity.Property(e => e.Thang)
                .HasMaxLength(100)
                .HasColumnName("thang");
        });

        modelBuilder.Entity<UserInfo>(entity =>
        {
            entity.HasKey(e => e.Username);

            entity.ToTable("user_info");

            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasColumnName("username");
            entity.Property(e => e.Day)
                .HasMaxLength(100)
                .HasColumnName("day");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Gender)
                .HasMaxLength(100)
                .HasColumnName("gender");
            entity.Property(e => e.Magioithieu1)
                .HasMaxLength(100)
                .HasColumnName("magioithieu1");
            entity.Property(e => e.Month)
                .HasMaxLength(100)
                .HasColumnName("month");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .HasColumnName("phone");
            entity.Property(e => e.Year)
                .HasMaxLength(100)
                .HasColumnName("year");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
