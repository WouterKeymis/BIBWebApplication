﻿// <auto-generated />
using System;
using BIBData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BIBData.Migrations
{
    [DbContext(typeof(BIBDbContext))]
    partial class BIBDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BIBData.Models.Lener", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Familienaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GeboorteDatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Telefoonnr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Voornaam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Leners");
                });

            modelBuilder.Entity("BIBData.Models.OperatingSysteem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Operatingsystemen");
                });

            modelBuilder.Entity("BIBData.Models.Reservering", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("GereserveerdOp")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LenerId")
                        .HasColumnType("int");

                    b.Property<int?>("UitleenobjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LenerId");

                    b.HasIndex("UitleenobjectId");

                    b.ToTable("Reserveringen");
                });

            modelBuilder.Entity("BIBData.Models.Uitleenobject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Jaar")
                        .HasColumnType("int");

                    b.Property<decimal>("Kostprijs")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Uitleenobjecten");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Uitleenobject");
                });

            modelBuilder.Entity("BIBData.Models.Uitlening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LenerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Tot")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UitleenobjectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Van")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LenerId");

                    b.HasIndex("UitleenobjectId");

                    b.ToTable("Uitleningen");
                });

            modelBuilder.Entity("BIBData.Models.Boek", b =>
                {
                    b.HasBaseType("BIBData.Models.Uitleenobject");

                    b.Property<int>("Aantalpaginas")
                        .HasColumnType("int");

                    b.Property<string>("Auteur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Boek");
                });

            modelBuilder.Entity("BIBData.Models.Device", b =>
                {
                    b.HasBaseType("BIBData.Models.Uitleenobject");

                    b.Property<int?>("OperatingsysteemId")
                        .HasColumnType("int");

                    b.Property<float>("Schermgrootte")
                        .HasColumnType("real");

                    b.HasIndex("OperatingsysteemId");

                    b.HasDiscriminator().HasValue("Device");
                });

            modelBuilder.Entity("BIBData.Models.Reservering", b =>
                {
                    b.HasOne("BIBData.Models.Lener", "Lener")
                        .WithMany()
                        .HasForeignKey("LenerId");

                    b.HasOne("BIBData.Models.Uitleenobject", "Uitleenobject")
                        .WithMany()
                        .HasForeignKey("UitleenobjectId");
                });

            modelBuilder.Entity("BIBData.Models.Uitlening", b =>
                {
                    b.HasOne("BIBData.Models.Lener", "Lener")
                        .WithMany("Uitleningen")
                        .HasForeignKey("LenerId");

                    b.HasOne("BIBData.Models.Uitleenobject", "Uitleenobject")
                        .WithMany()
                        .HasForeignKey("UitleenobjectId");
                });

            modelBuilder.Entity("BIBData.Models.Device", b =>
                {
                    b.HasOne("BIBData.Models.OperatingSysteem", "Operatingsysteem")
                        .WithMany()
                        .HasForeignKey("OperatingsysteemId");
                });
#pragma warning restore 612, 618
        }
    }
}
