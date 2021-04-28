﻿// <auto-generated />
using System;
using IsaacsHotell.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IsaacsHotell.Migrations
{
    [DbContext(typeof(HotellDbContext))]
    [Migration("20210428124731_produkt")]
    partial class produkt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IsaacsHotell.Models.Anställd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Efternamn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Förnamn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Anställda");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Efternamn = "Anka",
                            Förnamn = "Anders"
                        },
                        new
                        {
                            Id = 2,
                            Efternamn = "Bengtsson",
                            Förnamn = "Bertil"
                        },
                        new
                        {
                            Id = 3,
                            Efternamn = "Cello",
                            Förnamn = "Ceasar"
                        });
                });

            modelBuilder.Entity("IsaacsHotell.Models.Bokning", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GästId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Incheckning")
                        .HasColumnType("datetime2");

                    b.Property<int>("RumId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Utcheckning")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GästId");

                    b.HasIndex("RumId");

                    b.ToTable("Bokningar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GästId = 1,
                            Incheckning = new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RumId = 1,
                            Utcheckning = new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            GästId = 1,
                            Incheckning = new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RumId = 2,
                            Utcheckning = new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            GästId = 1,
                            Incheckning = new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RumId = 3,
                            Utcheckning = new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            GästId = 1,
                            Incheckning = new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RumId = 4,
                            Utcheckning = new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            GästId = 1,
                            Incheckning = new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RumId = 5,
                            Utcheckning = new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            GästId = 1,
                            Incheckning = new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RumId = 6,
                            Utcheckning = new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            GästId = 1,
                            Incheckning = new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RumId = 7,
                            Utcheckning = new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            GästId = 1,
                            Incheckning = new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RumId = 8,
                            Utcheckning = new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            GästId = 1,
                            Incheckning = new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RumId = 9,
                            Utcheckning = new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            GästId = 1,
                            Incheckning = new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RumId = 10,
                            Utcheckning = new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("IsaacsHotell.Models.Gäst", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BokningId")
                        .HasColumnType("int");

                    b.Property<string>("Efternamn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Förnamn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique()
                        .HasFilter("[OrderId] IS NOT NULL");

                    b.ToTable("Gäster");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BokningId = 1,
                            Efternamn = "Aronsson",
                            Förnamn = "Alf",
                            OrderId = 1
                        });
                });

            modelBuilder.Entity("IsaacsHotell.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GästId")
                        .HasColumnType("int");

                    b.Property<double>("Pris")
                        .HasColumnType("float");

                    b.Property<string>("Produkt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ordrar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GästId = 1,
                            Pris = 990.0,
                            Produkt = "Hotellnätter"
                        });
                });

            modelBuilder.Entity("IsaacsHotell.Models.Rum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Antalsovplatser")
                        .HasColumnType("int");

                    b.Property<int?>("BokningId")
                        .HasColumnType("int");

                    b.Property<string>("Namn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrisPerNatt")
                        .HasColumnType("float");

                    b.Property<bool>("Smutsigt")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Rum");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Antalsovplatser = 1,
                            Namn = "Jan",
                            PrisPerNatt = 399.0,
                            Smutsigt = false
                        },
                        new
                        {
                            Id = 2,
                            Antalsovplatser = 1,
                            Namn = "Feb",
                            PrisPerNatt = 399.0,
                            Smutsigt = false
                        },
                        new
                        {
                            Id = 3,
                            Antalsovplatser = 1,
                            Namn = "Mar",
                            PrisPerNatt = 399.0,
                            Smutsigt = false
                        },
                        new
                        {
                            Id = 4,
                            Antalsovplatser = 1,
                            Namn = "Apr",
                            PrisPerNatt = 399.0,
                            Smutsigt = false
                        },
                        new
                        {
                            Id = 5,
                            Antalsovplatser = 1,
                            Namn = "Maj",
                            PrisPerNatt = 399.0,
                            Smutsigt = false
                        },
                        new
                        {
                            Id = 6,
                            Antalsovplatser = 2,
                            Namn = "Jun",
                            PrisPerNatt = 499.0,
                            Smutsigt = false
                        },
                        new
                        {
                            Id = 7,
                            Antalsovplatser = 2,
                            Namn = "Jul",
                            PrisPerNatt = 499.0,
                            Smutsigt = false
                        },
                        new
                        {
                            Id = 8,
                            Antalsovplatser = 2,
                            Namn = "Aug",
                            PrisPerNatt = 499.0,
                            Smutsigt = false
                        },
                        new
                        {
                            Id = 9,
                            Antalsovplatser = 2,
                            Namn = "Sep",
                            PrisPerNatt = 499.0,
                            Smutsigt = false
                        },
                        new
                        {
                            Id = 10,
                            Antalsovplatser = 2,
                            Namn = "Okt",
                            PrisPerNatt = 499.0,
                            Smutsigt = false
                        });
                });

            modelBuilder.Entity("IsaacsHotell.Models.Bokning", b =>
                {
                    b.HasOne("IsaacsHotell.Models.Gäst", "Gäst")
                        .WithMany("Bokningar")
                        .HasForeignKey("GästId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IsaacsHotell.Models.Rum", "Rum")
                        .WithMany("Bokningar")
                        .HasForeignKey("RumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gäst");

                    b.Navigation("Rum");
                });

            modelBuilder.Entity("IsaacsHotell.Models.Gäst", b =>
                {
                    b.HasOne("IsaacsHotell.Models.Order", "Order")
                        .WithOne("Gäst")
                        .HasForeignKey("IsaacsHotell.Models.Gäst", "OrderId");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("IsaacsHotell.Models.Gäst", b =>
                {
                    b.Navigation("Bokningar");
                });

            modelBuilder.Entity("IsaacsHotell.Models.Order", b =>
                {
                    b.Navigation("Gäst");
                });

            modelBuilder.Entity("IsaacsHotell.Models.Rum", b =>
                {
                    b.Navigation("Bokningar");
                });
#pragma warning restore 612, 618
        }
    }
}
