﻿// <auto-generated />
using System;
using DemoMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220327202641_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoMVC.Models.Marque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Acronyme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Marques");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nom = "Audi"
                        },
                        new
                        {
                            Id = 2,
                            Nom = "BMW"
                        },
                        new
                        {
                            Id = 3,
                            Nom = "Lexus"
                        },
                        new
                        {
                            Id = 4,
                            Nom = "Mazda"
                        },
                        new
                        {
                            Id = 5,
                            Nom = "Honda"
                        },
                        new
                        {
                            Id = 6,
                            Nom = "Hyundai"
                        },
                        new
                        {
                            Id = 7,
                            Nom = "Kia"
                        },
                        new
                        {
                            Id = 8,
                            Nom = "Chevrolet"
                        },
                        new
                        {
                            Id = 9,
                            Nom = "Ferrari"
                        });
                });

            modelBuilder.Entity("DemoMVC.Models.Modele", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Annee")
                        .HasColumnType("int");

                    b.Property<int>("MarqueId")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PDSF")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MarqueId");

                    b.ToTable("Modeles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Annee = 2006,
                            MarqueId = 1,
                            Nom = "A3",
                            PDSF = 79000.009999999995
                        },
                        new
                        {
                            Id = 2,
                            Annee = 2032,
                            MarqueId = 1,
                            Nom = "A4",
                            PDSF = 99999.990000000005
                        },
                        new
                        {
                            Id = 3,
                            Annee = 2022,
                            MarqueId = 2,
                            Nom = "X5",
                            PDSF = 81000.0
                        },
                        new
                        {
                            Id = 4,
                            Annee = 2020,
                            MarqueId = 2,
                            Nom = "X5 M",
                            PDSF = 81500.0
                        },
                        new
                        {
                            Id = 5,
                            Annee = 2019,
                            MarqueId = 2,
                            Nom = "M6",
                            PDSF = 111500.50999999999
                        },
                        new
                        {
                            Id = 6,
                            Annee = 2020,
                            MarqueId = 2,
                            Nom = "i8",
                            PDSF = 121500.50999999999
                        },
                        new
                        {
                            Id = 7,
                            Annee = 2021,
                            MarqueId = 2,
                            Nom = "i8",
                            PDSF = 111500.50999999999
                        },
                        new
                        {
                            Id = 8,
                            Annee = 2020,
                            MarqueId = 3,
                            Nom = "RX",
                            PDSF = 42500.0
                        },
                        new
                        {
                            Id = 9,
                            Annee = 2020,
                            MarqueId = 3,
                            Nom = "CT",
                            PDSF = 53000.0
                        },
                        new
                        {
                            Id = 10,
                            Annee = 2021,
                            MarqueId = 3,
                            Nom = "CT",
                            PDSF = 62500.0
                        });
                });

            modelBuilder.Entity("DemoMVC.Models.Personne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<double>("Argent")
                        .HasColumnType("float");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Proprietaires");
                });

            modelBuilder.Entity("DemoMVC.Models.ProprietaireVoiture", b =>
                {
                    b.Property<int>("ProprietaireId")
                        .HasColumnType("int");

                    b.Property<int>("VoitureId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAcquisition")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int?>("PrixPaye")
                        .HasColumnType("int");

                    b.HasKey("ProprietaireId", "VoitureId");

                    b.HasIndex("VoitureId");

                    b.ToTable("ProprietairesVoitures");
                });

            modelBuilder.Entity("DemoMVC.Models.Modele", b =>
                {
                    b.HasOne("DemoMVC.Models.Marque", "Marque")
                        .WithMany("Modeles")
                        .HasForeignKey("MarqueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marque");
                });

            modelBuilder.Entity("DemoMVC.Models.ProprietaireVoiture", b =>
                {
                    b.HasOne("DemoMVC.Models.Personne", "Proprietaire")
                        .WithMany("ProprietairesVoitures")
                        .HasForeignKey("ProprietaireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DemoMVC.Models.Modele", "Voiture")
                        .WithMany("ProprietairesVoitures")
                        .HasForeignKey("VoitureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proprietaire");

                    b.Navigation("Voiture");
                });

            modelBuilder.Entity("DemoMVC.Models.Marque", b =>
                {
                    b.Navigation("Modeles");
                });

            modelBuilder.Entity("DemoMVC.Models.Modele", b =>
                {
                    b.Navigation("ProprietairesVoitures");
                });

            modelBuilder.Entity("DemoMVC.Models.Personne", b =>
                {
                    b.Navigation("ProprietairesVoitures");
                });
#pragma warning restore 612, 618
        }
    }
}