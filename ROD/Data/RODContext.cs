﻿using Microsoft.EntityFrameworkCore;
using ROD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ROD.Data
{
    public class RODContext : DbContext
    {
        public RODContext(DbContextOptions<RODContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<MerchantType> MerchantTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<ItemModifier> ItemModifiers { get; set; }
        public DbSet<ItemModifierType> ItemModifierTypes { get; set; }
        public DbSet<ItemStock> ItemStock { get; set; }
        public DbSet<LineItem> LineItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderStatusType> OrderStatusTypes { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<PriceType> PriceTypes { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<ItemImage> ItemImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>();
            modelBuilder.Entity<MerchantType>();
            modelBuilder.Entity<User>();
            modelBuilder.Entity<Merchant>();
            modelBuilder.Entity<ItemType>();
            modelBuilder.Entity<Item>();
            modelBuilder.Entity<ItemCategory>();
            modelBuilder.Entity<ItemModifier>();
            modelBuilder.Entity<ItemModifierType>();
            modelBuilder.Entity<ItemStock>();
            modelBuilder.Entity<LineItem>();
            modelBuilder.Entity<Order>();
            modelBuilder.Entity<OrderStatusType>();
            modelBuilder.Entity<Payment>();
            modelBuilder.Entity<PaymentType>();
            modelBuilder.Entity<PriceType>();
            modelBuilder.Entity<UnitType>();
            modelBuilder.Entity<ItemImage>();

            modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys())
                .ToList()
                .ForEach(r => r.DeleteBehavior = DeleteBehavior.Restrict);
        }
    }
}
