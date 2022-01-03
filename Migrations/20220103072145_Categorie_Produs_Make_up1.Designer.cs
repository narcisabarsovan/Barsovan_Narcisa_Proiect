﻿// <auto-generated />
using System;
using Barsovan_Narcisa_Proiect.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Barsovan_Narcisa_Proiect.Migrations
{
    [DbContext(typeof(Barsovan_Narcisa_ProiectContext))]
    [Migration("20220103072145_Categorie_Produs_Make_up1")]
    partial class Categorie_Produs_Make_up1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Barsovan_Narcisa_Proiect.Models.Categorie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nume_Catergorie")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categorie");
                });

            modelBuilder.Entity("Barsovan_Narcisa_Proiect.Models.Categorie_Produs_Make_up", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategorieID")
                        .HasColumnType("int");

                    b.Property<int>("Produs_Make_upID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategorieID");

                    b.HasIndex("Produs_Make_upID");

                    b.ToTable("Categorie_Produs_Make_up");
                });

            modelBuilder.Entity("Barsovan_Narcisa_Proiect.Models.Furnizor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nume_Furnizor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Furnizor");
                });

            modelBuilder.Entity("Barsovan_Narcisa_Proiect.Models.Produs_Make_up", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data_lansarii")
                        .HasColumnType("datetime2");

                    b.Property<int>("FurnizorID")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("Produs")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("FurnizorID");

                    b.ToTable("Produs_Make_up");
                });

            modelBuilder.Entity("Barsovan_Narcisa_Proiect.Models.Categorie_Produs_Make_up", b =>
                {
                    b.HasOne("Barsovan_Narcisa_Proiect.Models.Categorie", "Categorie")
                        .WithMany("Categorii_Produs_Make_up")
                        .HasForeignKey("CategorieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Barsovan_Narcisa_Proiect.Models.Produs_Make_up", "Produs_Make_Up")
                        .WithMany("Categorii_Produs_Make_up")
                        .HasForeignKey("Produs_Make_upID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorie");

                    b.Navigation("Produs_Make_Up");
                });

            modelBuilder.Entity("Barsovan_Narcisa_Proiect.Models.Produs_Make_up", b =>
                {
                    b.HasOne("Barsovan_Narcisa_Proiect.Models.Furnizor", "Furnizor")
                        .WithMany("Produse_Make_up")
                        .HasForeignKey("FurnizorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Furnizor");
                });

            modelBuilder.Entity("Barsovan_Narcisa_Proiect.Models.Categorie", b =>
                {
                    b.Navigation("Categorii_Produs_Make_up");
                });

            modelBuilder.Entity("Barsovan_Narcisa_Proiect.Models.Furnizor", b =>
                {
                    b.Navigation("Produse_Make_up");
                });

            modelBuilder.Entity("Barsovan_Narcisa_Proiect.Models.Produs_Make_up", b =>
                {
                    b.Navigation("Categorii_Produs_Make_up");
                });
#pragma warning restore 612, 618
        }
    }
}
