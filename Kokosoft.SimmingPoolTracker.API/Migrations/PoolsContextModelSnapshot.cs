﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Kokosoft.SimmingPoolTracker.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Kokosoft.SimmingPoolTracker.API.Migrations
{
    [DbContext(typeof(PoolsContext))]
    partial class PoolsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Kokosoft.SimmingPoolTracker.API.Model.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Kokosoft.SimmingPoolTracker.API.Model.Pool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressId");

                    b.Property<string>("Name");

                    b.Property<string>("ShortName");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("SwimmingPools");
                });

            modelBuilder.Entity("Kokosoft.SimmingPoolTracker.API.Model.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Day");

                    b.Property<string>("EndTime")
                        .HasMaxLength(5);

                    b.Property<int?>("PoolId");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<List<string>>("Tracks");

                    b.HasKey("Id");

                    b.HasAlternateKey("Day", "StartTime");

                    b.HasIndex("PoolId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("Kokosoft.SimmingPoolTracker.API.Model.Pool", b =>
                {
                    b.HasOne("Kokosoft.SimmingPoolTracker.API.Model.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });

            modelBuilder.Entity("Kokosoft.SimmingPoolTracker.API.Model.Schedule", b =>
                {
                    b.HasOne("Kokosoft.SimmingPoolTracker.API.Model.Pool", "Pool")
                        .WithMany()
                        .HasForeignKey("PoolId");
                });
#pragma warning restore 612, 618
        }
    }
}
