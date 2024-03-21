﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WildAnimalsAPI.Persistence;

#nullable disable

namespace WildAnimalsAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240321015512_edit-many-to-many-AnimalContinent3")]
    partial class editmanytomanyAnimalContinent3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MarvelPersonalProject.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WildAnimalsAPI.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AverageHeightMax")
                        .HasColumnType("int");

                    b.Property<int>("AverageHeightMin")
                        .HasColumnType("int");

                    b.Property<int>("AverageLifespanMax")
                        .HasColumnType("int");

                    b.Property<int>("AverageLifespanMin")
                        .HasColumnType("int");

                    b.Property<int>("AverageSpeedMax")
                        .HasColumnType("int");

                    b.Property<int>("AverageSpeedMin")
                        .HasColumnType("int");

                    b.Property<int>("AverageWeightMax")
                        .HasColumnType("int");

                    b.Property<int>("AverageWeightMin")
                        .HasColumnType("int");

                    b.Property<string>("CommonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstimatedPopulationSize")
                        .HasColumnType("int");

                    b.Property<string>("ScientificName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("WildAnimalsAPI.Models.AnimalContinent", b =>
                {
                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<int>("ContinentId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("AnimalId", "ContinentId");

                    b.HasIndex("ContinentId");

                    b.ToTable("AnimalContinents");
                });

            modelBuilder.Entity("WildAnimalsAPI.Models.Continent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Population")
                        .HasColumnType("int");

                    b.Property<int>("SurfaceKm2")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Continents");
                });

            modelBuilder.Entity("WildAnimalsAPI.Models.AnimalContinent", b =>
                {
                    b.HasOne("WildAnimalsAPI.Models.Animal", "Animal")
                        .WithMany("Continents")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WildAnimalsAPI.Models.Continent", "Continent")
                        .WithMany("Animals")
                        .HasForeignKey("ContinentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("Continent");
                });

            modelBuilder.Entity("WildAnimalsAPI.Models.Animal", b =>
                {
                    b.Navigation("Continents");
                });

            modelBuilder.Entity("WildAnimalsAPI.Models.Continent", b =>
                {
                    b.Navigation("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}
