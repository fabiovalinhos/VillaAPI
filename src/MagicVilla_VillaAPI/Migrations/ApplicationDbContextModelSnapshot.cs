﻿// <auto-generated />
using System;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Details")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Occupancy")
                        .HasColumnType("integer");

                    b.Property<double>("Rate")
                        .HasColumnType("double precision");

                    b.Property<int>("Sqft")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedDate = new DateTime(2024, 1, 2, 13, 50, 40, 293, DateTimeKind.Utc).AddTicks(3000),
                            Details = "Esta área é description",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/7d/Microsoft_.NET_logo.svg",
                            Name = "Royal Villa",
                            Occupancy = 5,
                            Rate = 200.0,
                            Sqft = 500,
                            UpdateDate = new DateTime(2024, 1, 2, 13, 50, 40, 293, DateTimeKind.Utc).AddTicks(3000)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2024, 1, 2, 13, 50, 40, 293, DateTimeKind.Utc).AddTicks(3000),
                            Details = "Diamond detalhes",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/7d/Microsoft_.NET_logo.svg",
                            Name = "Diamond Villa",
                            Occupancy = 3,
                            Rate = 500.0,
                            Sqft = 450,
                            UpdateDate = new DateTime(2024, 1, 2, 13, 50, 40, 293, DateTimeKind.Utc).AddTicks(3000)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2024, 1, 2, 13, 50, 40, 293, DateTimeKind.Utc).AddTicks(3010),
                            Details = "Ruby detalhes",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/7d/Microsoft_.NET_logo.svg",
                            Name = "Ruby Villa",
                            Occupancy = 6,
                            Rate = 100.0,
                            Sqft = 700,
                            UpdateDate = new DateTime(2024, 1, 2, 13, 50, 40, 293, DateTimeKind.Utc).AddTicks(3010)
                        });
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.VillaNumber", b =>
                {
                    b.Property<int>("VillaNo")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("SpecialDetails")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("VillaID")
                        .HasColumnType("integer");

                    b.HasKey("VillaNo");

                    b.HasIndex("VillaID");

                    b.ToTable("VillaNumbers");
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.VillaNumber", b =>
                {
                    b.HasOne("MagicVilla_VillaAPI.Models.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });
#pragma warning restore 612, 618
        }
    }
}
