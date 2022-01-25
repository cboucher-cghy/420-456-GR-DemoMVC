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
    [Migration("20220125155251_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoMVC.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Argent")
                        .HasColumnType("real");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("DemoMVC.Models.Marque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Marques");
                });

            modelBuilder.Entity("DemoMVC.Models.Modele", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MarqueId")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MarqueId");

                    b.ToTable("Modeles");
                });

            modelBuilder.Entity("DemoMVC.Models.Voiture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MarqueId")
                        .HasColumnType("int");

                    b.Property<int?>("ModeleId")
                        .HasColumnType("int");

                    b.Property<double>("Prix")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("MarqueId");

                    b.HasIndex("ModeleId");

                    b.ToTable("Voitures");
                });

            modelBuilder.Entity("DemoMVC.Models.Modele", b =>
                {
                    b.HasOne("DemoMVC.Models.Marque", "Marque")
                        .WithMany("Modeles")
                        .HasForeignKey("MarqueId");

                    b.Navigation("Marque");
                });

            modelBuilder.Entity("DemoMVC.Models.Voiture", b =>
                {
                    b.HasOne("DemoMVC.Models.Marque", "Marque")
                        .WithMany()
                        .HasForeignKey("MarqueId");

                    b.HasOne("DemoMVC.Models.Modele", "Modele")
                        .WithMany()
                        .HasForeignKey("ModeleId");

                    b.Navigation("Marque");

                    b.Navigation("Modele");
                });

            modelBuilder.Entity("DemoMVC.Models.Marque", b =>
                {
                    b.Navigation("Modeles");
                });
#pragma warning restore 612, 618
        }
    }
}
