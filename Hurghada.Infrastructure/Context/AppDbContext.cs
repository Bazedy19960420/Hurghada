﻿using Hurghada.Domain.Entities.Property;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Hurghada.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        #region Constructors
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        #endregion
        #region DbSets
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }

        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<PropertyAmenity> PropertyAmenities { get; set; }
        #endregion
        #region Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        #endregion


    }
}
