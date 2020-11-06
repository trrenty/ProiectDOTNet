﻿// <auto-generated />
using System;
using Lab6DOTNET.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab6DOTNET.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("Lab6DOTNET.Model.ToDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<bool>("IsDone")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ToDos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2020, 11, 6, 13, 2, 26, 318, DateTimeKind.Local).AddTicks(3106),
                            Description = "Termina Lab DOTNET",
                            IsDone = true
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2020, 11, 6, 13, 2, 26, 320, DateTimeKind.Local).AddTicks(8889),
                            Description = "Continua Tema SI",
                            IsDone = false
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2020, 11, 6, 13, 2, 26, 320, DateTimeKind.Local).AddTicks(8933),
                            Description = "Tema ML",
                            IsDone = false
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2020, 11, 6, 13, 2, 26, 320, DateTimeKind.Local).AddTicks(8939),
                            Description = "Tema AI",
                            IsDone = false
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2020, 11, 6, 13, 2, 26, 320, DateTimeKind.Local).AddTicks(8942),
                            Description = "IMR",
                            IsDone = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
