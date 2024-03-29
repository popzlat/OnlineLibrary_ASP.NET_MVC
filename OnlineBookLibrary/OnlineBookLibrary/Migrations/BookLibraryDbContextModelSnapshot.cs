﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineBookLibrary.Models;

namespace OnlineBookLibrary.Migrations
{
    [DbContext(typeof(BookLibraryDbContext))]
    partial class BookLibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineBookLibrary.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Orson Scott"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Truman Capote"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Graeme Simsion"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ernest Hemingway"
                        },
                        new
                        {
                            Id = 5,
                            Name = "George R. R. Martin"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Gillian Flynn"
                        });
                });

            modelBuilder.Entity("OnlineBookLibrary.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId");

                    b.Property<string>("Description");

                    b.Property<int>("Genre");

                    b.Property<string>("Isbn");

                    b.Property<string>("Name");

                    b.Property<int>("Pages");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Description = "Ender's Game is a 1985 military science fiction novel by American author Orson Scott Card. Set at an unspecified date in Earth's future, the novel presents an imperiled humankind after two conflicts with the Formics, an insectoid alien species they dub the buggers.",
                            Genre = 1,
                            Isbn = "0-312-93208-1",
                            Name = "Ender's Game",
                            Pages = 324,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Description = "In Cold Blood is a non-fiction novel by American author Truman Capote, first published in 1966; it details the 1959 murders of four members of the Herbert Clutter family in the small farming community of Holcomb, Kansas.",
                            Genre = 4,
                            Isbn = "0-679-74558-0",
                            Name = "In Cold Blood",
                            Pages = 343,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            Description = "Don Tillman is an Australian genetics professor who has spent his days organizing his life with the expectation that it will reduce inefficiency, improve himself as a person, and make him an all around happier person.",
                            Genre = 2,
                            Isbn = "9781922079770",
                            Name = "The Rosie Project",
                            Pages = 304,
                            Quantity = 8
                        });
                });

            modelBuilder.Entity("OnlineBookLibrary.Models.Loan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookId");

                    b.Property<int>("LoanBookId");

                    b.Property<DateTime>("LoanDate");

                    b.Property<int?>("StatusId");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("OnlineBookLibrary.Models.LoanStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Active");

                    b.Property<string>("Finished");

                    b.HasKey("Id");

                    b.ToTable("LoanStatuses");
                });

            modelBuilder.Entity("OnlineBookLibrary.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Role");
                });

            modelBuilder.Entity("OnlineBookLibrary.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<int?>("RoleId");

                    b.Property<int>("RollId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OnlineBookLibrary.Models.UserRoll", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRolls");
                });

            modelBuilder.Entity("OnlineBookLibrary.Models.Book", b =>
                {
                    b.HasOne("OnlineBookLibrary.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineBookLibrary.Models.Loan", b =>
                {
                    b.HasOne("OnlineBookLibrary.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId");

                    b.HasOne("OnlineBookLibrary.Models.LoanStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.HasOne("OnlineBookLibrary.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("OnlineBookLibrary.Models.Role", b =>
                {
                    b.HasOne("OnlineBookLibrary.Models.User", "User")
                        .WithOne("Role")
                        .HasForeignKey("OnlineBookLibrary.Models.Role", "UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OnlineBookLibrary.Models.User", b =>
                {
                    b.HasOne("OnlineBookLibrary.Models.Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("OnlineBookLibrary.Models.UserRoll", b =>
                {
                    b.HasOne("OnlineBookLibrary.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OnlineBookLibrary.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
