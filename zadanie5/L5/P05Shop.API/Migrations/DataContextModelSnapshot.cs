﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P05Shop.API.Models;

#nullable disable

namespace P05Shop.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("P06Shop.Shared.Library.Book", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("author")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("genres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("pages")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            id = 1,
                            author = "Dagmar Hackett",
                            genres = "Criminal",
                            name = "et cumque",
                            pages = 423
                        },
                        new
                        {
                            id = 2,
                            author = "Orval Tillman",
                            genres = "Action,Horror,Action",
                            name = "error cupiditate",
                            pages = 1127
                        },
                        new
                        {
                            id = 3,
                            author = "Tyson Hudson",
                            genres = "History,Romance",
                            name = "placeat qui",
                            pages = 848
                        },
                        new
                        {
                            id = 4,
                            author = "Janessa Botsford",
                            genres = "Drama,Criminal,History",
                            name = "ab non",
                            pages = 323
                        },
                        new
                        {
                            id = 5,
                            author = "Lera Flatley",
                            genres = "Horror,Romance",
                            name = "et blanditiis",
                            pages = 206
                        },
                        new
                        {
                            id = 6,
                            author = "Earnestine Sauer",
                            genres = "Drama",
                            name = "quis beatae",
                            pages = 541
                        },
                        new
                        {
                            id = 7,
                            author = "Chad Grimes",
                            genres = "Horror,Romance",
                            name = "omnis veritatis",
                            pages = 221
                        },
                        new
                        {
                            id = 8,
                            author = "Tina Cassin",
                            genres = "History",
                            name = "est ut",
                            pages = 980
                        },
                        new
                        {
                            id = 9,
                            author = "Aidan Gleason",
                            genres = "History",
                            name = "ad officiis",
                            pages = 898
                        },
                        new
                        {
                            id = 10,
                            author = "Griffin Mayert",
                            genres = "Romance,Horror,Horror",
                            name = "minima aut",
                            pages = 1090
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
