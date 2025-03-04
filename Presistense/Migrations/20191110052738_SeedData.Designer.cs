﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Presistense;

namespace Presistense.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191110052738_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Domain.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Values");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Value 100"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Value 102"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Value 103"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Value 104"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Value 105"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Value 106"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Value 107"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Value 108"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Value 109"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Value 110"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
