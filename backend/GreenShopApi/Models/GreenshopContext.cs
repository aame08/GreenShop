using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace GreenShopApi.Models;

public partial class GreenshopContext : DbContext
{
    public GreenshopContext()
    {
    }

    public GreenshopContext(DbContextOptions<GreenshopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = Environment.GetEnvironmentVariable("DefaultConnection")
                                ?? "server=localhost;username=root;password=ame0372;database=greenshop";
            optionsBuilder
                .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
                .UseLazyLoadingProxies();
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PRIMARY");

            entity.ToTable("users");

            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.EmailUser)
                .HasMaxLength(100)
                .HasColumnName("email_user");
            entity.Property(e => e.PasswordUser)
                .HasMaxLength(30)
                .HasColumnName("password_user");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
