﻿// <auto-generated />
using Geekymon2.CarsApi.Cars.DAL.DataAccess.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Geekymon2.CarsApi.Cars.DAL.Migrations
{
    [DbContext(typeof(CarContext))]
    partial class CarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Geekymon2.CarsApi.Cars.DAL.DataAccess.Entities.Car", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("BodyType")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Doors")
                        .HasColumnType("int");

                    b.Property<string>("EngineID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Odometer")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Seats")
                        .HasColumnType("int");

                    b.Property<string>("TransmissionID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EngineID");

                    b.HasIndex("TransmissionID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Geekymon2.CarsApi.Cars.DAL.DataAccess.Entities.Engine", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CylinderConfig")
                        .HasColumnType("int");

                    b.Property<int>("DriveType")
                        .HasColumnType("int");

                    b.Property<int>("EngineSizeCC")
                        .HasColumnType("int");

                    b.Property<double>("FuelEconomy")
                        .HasColumnType("float");

                    b.Property<int>("FuelType")
                        .HasColumnType("int");

                    b.Property<int>("NoOfCylinders")
                        .HasColumnType("int");

                    b.Property<int>("PowerKW")
                        .HasColumnType("int");

                    b.Property<double>("PowerToWeight")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Engine");
                });

            modelBuilder.Entity("Geekymon2.CarsApi.Cars.DAL.DataAccess.Entities.Feature", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CarID")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CarID");

                    b.ToTable("Feature");
                });

            modelBuilder.Entity("Geekymon2.CarsApi.Cars.DAL.DataAccess.Entities.Transmission", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Detail")
                        .HasColumnType("int");

                    b.Property<int>("Gears")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Transmission");
                });

            modelBuilder.Entity("Geekymon2.CarsApi.Cars.DAL.DataAccess.Entities.Car", b =>
                {
                    b.HasOne("Geekymon2.CarsApi.Cars.DAL.DataAccess.Entities.Engine", "Engine")
                        .WithMany()
                        .HasForeignKey("EngineID");

                    b.HasOne("Geekymon2.CarsApi.Cars.DAL.DataAccess.Entities.Transmission", "Transmission")
                        .WithMany()
                        .HasForeignKey("TransmissionID");

                    b.Navigation("Engine");

                    b.Navigation("Transmission");
                });

            modelBuilder.Entity("Geekymon2.CarsApi.Cars.DAL.DataAccess.Entities.Feature", b =>
                {
                    b.HasOne("Geekymon2.CarsApi.Cars.DAL.DataAccess.Entities.Car", null)
                        .WithMany("FeatureList")
                        .HasForeignKey("CarID");
                });

            modelBuilder.Entity("Geekymon2.CarsApi.Cars.DAL.DataAccess.Entities.Car", b =>
                {
                    b.Navigation("FeatureList");
                });
#pragma warning restore 612, 618
        }
    }
}
