﻿// <auto-generated />
using System;
using Assignment_1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment_1.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.2");

            modelBuilder.Entity("Assignment_1.Models.Article", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ContributorUsername")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ArticleId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            ArticleId = 1,
                            Body = "Charli xcx turned Crypto.com Arena into a rave at the 2025 GRAMMYs, where she delivered a wild live performance of 'Von dutch' and 'Guess' from her GRAMMY-winning album  brat. \n\n Charlie walked into the 67th Annual GRAMMY Awards as one of the night's most-nominated artists, earning eight nominations in total. She ended the night with three wins, including Best Dance Pop Recording (“Von dutch”), Best Dance/Electronic Album (BRAT)and Best Recording Package (BRAT).",
                            ContributorUsername = "c@c.c",
                            CreateDate = new DateTime(2025, 2, 25, 20, 50, 22, 633, DateTimeKind.Local).AddTicks(2734),
                            EndDate = new DateTime(2025, 3, 4, 20, 50, 22, 633, DateTimeKind.Local).AddTicks(2734),
                            StartDate = new DateTime(2025, 2, 25, 20, 50, 22, 633, DateTimeKind.Local).AddTicks(2734),
                            Title = "Charli XCX Brings 'Brat' To The 2025 GRAMMYs"
                        });
                });

            modelBuilder.Entity("Assignment_1.Models.CustomRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "bcab97de-ad0b-47bc-8fdd-04e90b5c1f66",
                            CreatedDate = new DateTime(2025, 2, 25, 20, 50, 22, 509, DateTimeKind.Local).AddTicks(813),
                            Description = "Admin role",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "c462939e-b10b-4252-9556-1783c3980155",
                            CreatedDate = new DateTime(2025, 2, 25, 20, 50, 22, 510, DateTimeKind.Local).AddTicks(5338),
                            Description = "Contributor role",
                            Name = "Contributor",
                            NormalizedName = "CONTRIBUTOR"
                        });
                });

            modelBuilder.Entity("Assignment_1.Models.CustomUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1c0a1bd7-1e51-4d37-838b-36f1c4f0fab1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "12f58260-8149-42f9-894e-e6eed429976e",
                            Email = "a@a.a",
                            EmailConfirmed = true,
                            FirstName = "Adam",
                            IsApproved = true,
                            LastName = "Anderson",
                            LockoutEnabled = false,
                            NormalizedEmail = "A@A.A",
                            NormalizedUserName = "A@A.A",
                            Password = "P@$$w0rd",
                            PasswordHash = "AQAAAAIAAYagAAAAENhvFARAhMFJlxqpEt7RRnpGfqasTjvwhjlOSr2jBXIBMfW7B7Mcg/KeOnmVR9MfYQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8072dc32-f21c-4c54-9135-95a64e0c5525",
                            TwoFactorEnabled = false,
                            UserName = "a@a.a"
                        },
                        new
                        {
                            Id = "bff07d44-135b-4915-9806-28b0c4d089ce",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "74d41e72-ddb3-44b8-8e7c-7d0f0dda258b",
                            Email = "c@c.c",
                            EmailConfirmed = true,
                            FirstName = "Cindy",
                            IsApproved = true,
                            LastName = "Cain",
                            LockoutEnabled = false,
                            NormalizedEmail = "C@C.C",
                            NormalizedUserName = "C@C.C",
                            Password = "P@$$w0rd",
                            PasswordHash = "AQAAAAIAAYagAAAAEPAEhqwx0HgWx+ZwSuYyFYbDhA38YtwOslUJjw9hdMMedIgKhz5cPNcneoAtbs0Otg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ea9419d3-746a-4ce8-90fe-1e3fd93de3e0",
                            TwoFactorEnabled = false,
                            UserName = "c@c.c"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1c0a1bd7-1e51-4d37-838b-36f1c4f0fab1",
                            RoleId = "bcab97de-ad0b-47bc-8fdd-04e90b5c1f66"
                        },
                        new
                        {
                            UserId = "bff07d44-135b-4915-9806-28b0c4d089ce",
                            RoleId = "c462939e-b10b-4252-9556-1783c3980155"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Assignment_1.Models.CustomRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Assignment_1.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Assignment_1.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Assignment_1.Models.CustomRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment_1.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Assignment_1.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
