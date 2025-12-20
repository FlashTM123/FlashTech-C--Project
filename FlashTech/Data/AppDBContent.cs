using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FlashTech.Models;

namespace FlashTech.Data
{
    public class AppDBContent : DbContext
    {

        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
            
        }   
        public DbSet<Users> users { get; set; }

        public DbSet<Customers> customers { get; set; }
        public DbSet<Brands> brands { get; set;}

        public DbSet<Products> products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brands>(entity =>{
               entity.ToTable("Brands");
               entity.HasKey(b => b.Id);
               entity.Property(b => b.Id).HasColumnName("Id");
               entity.Property(b => b.name).HasColumnName("name");   
            });

            modelBuilder.Entity<Products>(entity =>{
               entity.ToTable("Products");
               entity.HasKey(p => p.id);
               entity.Property(p => p.id).HasColumnName("id");
               entity.Property(p => p.name).HasColumnName("name");
               entity.Property(p => p.brandId).HasColumnName("brandId");
               entity.Property(p => p.color).HasColumnName("color");
               entity.Property(p => p.CPU).HasColumnName("CPU");
               entity.Property(p => p.RAM).HasColumnName("RAM");
               entity.Property(p => p.storage).HasColumnName("storage");
               entity.Property(p => p.GPU).HasColumnName("GPU");
               entity.Property(p => p.price).HasColumnName("price");
               entity.Property(p => p.discount).HasColumnName("discount");
               entity.Property(p => p.promotionalPrice).HasColumnName("promotionalPrice");
               entity.Property(p => p.quantity).HasColumnName("quantity");
               entity.Property(p => p.status).HasColumnName("status");
               entity.Property(p => p.image).HasColumnName("image");
            });
        }
    }

    
}