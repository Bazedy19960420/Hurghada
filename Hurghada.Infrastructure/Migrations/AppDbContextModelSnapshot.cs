﻿// <auto-generated />
using Hurghada.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hurghada.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hurghada.Domain.Entities.Property.Amenity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Amenities", "Property");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Air conditioning"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Balcony"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Cable TV"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Cleaning after exit"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Cofee pot"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Computer"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Cot"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Fan"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Kitchen Appliances"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Swimming bool"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Wifi"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Landline"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Parking"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Pets allowed"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Garden"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Gym"
                        },
                        new
                        {
                            Id = 20,
                            Name = "BeachAcess"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Security"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Elevator"
                        });
                });

            modelBuilder.Entity("Hurghada.Domain.Entities.Property.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<int>("BedRooms")
                        .HasColumnType("int");

                    b.Property<int>("DailyPayment")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DownPayment")
                        .HasColumnType("int");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFurnished")
                        .HasColumnType("bit");

                    b.Property<int>("MonthlyPayment")
                        .HasColumnType("int");

                    b.Property<int>("PathRooms")
                        .HasColumnType("int");

                    b.Property<int>("PropertyTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PropertyTypeId");

                    b.ToTable("Properties", "Property");
                });

            modelBuilder.Entity("Hurghada.Domain.Entities.Property.PropertyAmenity", b =>
                {
                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<int>("AmenityId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("PropertyId", "AmenityId");

                    b.HasIndex("AmenityId");

                    b.ToTable("PropertyAmenities");
                });

            modelBuilder.Entity("Hurghada.Domain.Entities.Property.PropertyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PropertyTypes", "Property");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Apartment"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Villa"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Chalet"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Studio"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Duplex"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Penthouse"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Townhouse"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Twin House"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Cabin"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Building"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Farm House"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Chalet"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Hotel"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Resort"
                        },
                        new
                        {
                            Id = 15,
                            Name = "House"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Flat"
                        });
                });

            modelBuilder.Entity("Hurghada.Domain.Entities.Property.Property", b =>
                {
                    b.HasOne("Hurghada.Domain.Entities.Property.PropertyType", "PropertyType")
                        .WithMany("Properties")
                        .HasForeignKey("PropertyTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("PropertyType");
                });

            modelBuilder.Entity("Hurghada.Domain.Entities.Property.PropertyAmenity", b =>
                {
                    b.HasOne("Hurghada.Domain.Entities.Property.Amenity", "Amenity")
                        .WithMany("PropertyAmenities")
                        .HasForeignKey("AmenityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Hurghada.Domain.Entities.Property.Property", "Property")
                        .WithMany("PropertyAmenities")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Amenity");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("Hurghada.Domain.Entities.Property.Amenity", b =>
                {
                    b.Navigation("PropertyAmenities");
                });

            modelBuilder.Entity("Hurghada.Domain.Entities.Property.Property", b =>
                {
                    b.Navigation("PropertyAmenities");
                });

            modelBuilder.Entity("Hurghada.Domain.Entities.Property.PropertyType", b =>
                {
                    b.Navigation("Properties");
                });
#pragma warning restore 612, 618
        }
    }
}
