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
    [Migration("20210422102905_listabokning")]
    partial class listabokning
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

                    b.Property<string>("Roll")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Anställda");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Efternamn = "Anka",
                            Förnamn = "Anders",
                            Roll = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Efternamn = "Bengtsson",
                            Förnamn = "Bertil",
                            Roll = "Receptionist"
                        },
                        new
                        {
                            Id = 3,
                            Efternamn = "Cello",
                            Förnamn = "Ceasar",
                            Roll = "Städare"
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

                    b.HasKey("Id");

                    b.ToTable("Ordrar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GästId = 1,
                            Pris = 990.0
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

                    b.Property<int>("BokningId")
                        .HasColumnType("int");

                    b.Property<string>("Namn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Smutsigt")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Rum");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Antalsovplatser = 2,
                            BokningId = 1,
                            Namn = "Jan",
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
