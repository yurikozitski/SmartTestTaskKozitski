﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartTestTaskKozitski.DAL.Data;

#nullable disable

namespace SmartTestTaskKozitski.DAL.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20250121200355_Initial2")]
    partial class Initial2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SmartTestTaskKozitski.DAL.Entities.Contract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProcessEquipmentTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductionFacilityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProcessEquipmentTypeId");

                    b.HasIndex("ProductionFacilityId");

                    b.ToTable("Contracts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
                            ProcessEquipmentTypeId = new Guid("d1e59328-7e39-4fe7-9b54-768cebbeb324"),
                            ProductionFacilityId = new Guid("b0fc118d-527d-41b1-9b1c-3a74bdc8dd2a"),
                            Quantity = 10
                        },
                        new
                        {
                            Id = new Guid("2a3b4c5d-6e7f-8a9b-0c1d-2e3f4a5b6c7d"),
                            ProcessEquipmentTypeId = new Guid("4cd6e57c-d7ae-42ef-9d6e-74a49dbd4223"),
                            ProductionFacilityId = new Guid("241a2aa6-0bf4-442a-9058-9db7c2355f96"),
                            Quantity = 20
                        },
                        new
                        {
                            Id = new Guid("3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d"),
                            ProcessEquipmentTypeId = new Guid("7e02cfa1-5ec5-4507-8c68-d471cbf6e9c5"),
                            ProductionFacilityId = new Guid("3c663d1b-f9f9-47d6-a9ed-e3ab2a9b2895"),
                            Quantity = 30
                        },
                        new
                        {
                            Id = new Guid("4a5b6c7d-8e9f-0a1b-2c3d-4e5f6a7b8c9d"),
                            ProcessEquipmentTypeId = new Guid("f9215bfc-58cc-494e-a0db-8c42c7c88f64"),
                            ProductionFacilityId = new Guid("2342040a-9c7a-4537-9bfc-6b1895cd711f"),
                            Quantity = 40
                        },
                        new
                        {
                            Id = new Guid("5a6b7c8d-9e0f-1a2b-3c4d-5e6f7a8b9c0d"),
                            ProcessEquipmentTypeId = new Guid("7a4de707-61a4-4d7f-94e5-4e1dd6f442d4"),
                            ProductionFacilityId = new Guid("e3c1a636-05cf-4b7f-8f16-7d4bd7416e67"),
                            Quantity = 50
                        });
                });

            modelBuilder.Entity("SmartTestTaskKozitski.DAL.Entities.ProcessEquipmentType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("ProcessEquipmentTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d1e59328-7e39-4fe7-9b54-768cebbeb324")
                        },
                        new
                        {
                            Id = new Guid("4cd6e57c-d7ae-42ef-9d6e-74a49dbd4223")
                        },
                        new
                        {
                            Id = new Guid("7e02cfa1-5ec5-4507-8c68-d471cbf6e9c5")
                        },
                        new
                        {
                            Id = new Guid("f9215bfc-58cc-494e-a0db-8c42c7c88f64")
                        },
                        new
                        {
                            Id = new Guid("7a4de707-61a4-4d7f-94e5-4e1dd6f442d4")
                        });
                });

            modelBuilder.Entity("SmartTestTaskKozitski.DAL.Entities.ProductionFacility", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("ProductionFacilities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b0fc118d-527d-41b1-9b1c-3a74bdc8dd2a")
                        },
                        new
                        {
                            Id = new Guid("241a2aa6-0bf4-442a-9058-9db7c2355f96")
                        },
                        new
                        {
                            Id = new Guid("3c663d1b-f9f9-47d6-a9ed-e3ab2a9b2895")
                        },
                        new
                        {
                            Id = new Guid("2342040a-9c7a-4537-9bfc-6b1895cd711f")
                        },
                        new
                        {
                            Id = new Guid("e3c1a636-05cf-4b7f-8f16-7d4bd7416e67")
                        });
                });

            modelBuilder.Entity("SmartTestTaskKozitski.DAL.Entities.Contract", b =>
                {
                    b.HasOne("SmartTestTaskKozitski.DAL.Entities.ProcessEquipmentType", "ProcessEquipmentType")
                        .WithMany()
                        .HasForeignKey("ProcessEquipmentTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SmartTestTaskKozitski.DAL.Entities.ProductionFacility", "ProductionFacility")
                        .WithMany()
                        .HasForeignKey("ProductionFacilityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ProcessEquipmentType");

                    b.Navigation("ProductionFacility");
                });

            modelBuilder.Entity("SmartTestTaskKozitski.DAL.Entities.ProcessEquipmentType", b =>
                {
                    b.OwnsOne("SmartTestTaskKozitski.DAL.Entities.Specifications", "Specifications", b1 =>
                        {
                            b1.Property<Guid>("ProcessEquipmentTypeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Area")
                                .HasColumnType("int")
                                .HasColumnName("Area");

                            b1.Property<long>("Code")
                                .HasColumnType("bigint")
                                .HasColumnName("Code");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Name");

                            b1.HasKey("ProcessEquipmentTypeId");

                            b1.HasIndex("Code")
                                .IsUnique();

                            b1.ToTable("ProcessEquipmentTypes");

                            b1.WithOwner()
                                .HasForeignKey("ProcessEquipmentTypeId");

                            b1.HasData(
                                new
                                {
                                    ProcessEquipmentTypeId = new Guid("d1e59328-7e39-4fe7-9b54-768cebbeb324"),
                                    Area = 50,
                                    Code = 1001L,
                                    Name = "TypeA"
                                },
                                new
                                {
                                    ProcessEquipmentTypeId = new Guid("4cd6e57c-d7ae-42ef-9d6e-74a49dbd4223"),
                                    Area = 75,
                                    Code = 1002L,
                                    Name = "TypeB"
                                },
                                new
                                {
                                    ProcessEquipmentTypeId = new Guid("7e02cfa1-5ec5-4507-8c68-d471cbf6e9c5"),
                                    Area = 100,
                                    Code = 1003L,
                                    Name = "TypeC"
                                },
                                new
                                {
                                    ProcessEquipmentTypeId = new Guid("f9215bfc-58cc-494e-a0db-8c42c7c88f64"),
                                    Area = 125,
                                    Code = 1004L,
                                    Name = "TypeD"
                                },
                                new
                                {
                                    ProcessEquipmentTypeId = new Guid("7a4de707-61a4-4d7f-94e5-4e1dd6f442d4"),
                                    Area = 150,
                                    Code = 1005L,
                                    Name = "TypeE"
                                });
                        });

                    b.Navigation("Specifications")
                        .IsRequired();
                });

            modelBuilder.Entity("SmartTestTaskKozitski.DAL.Entities.ProductionFacility", b =>
                {
                    b.OwnsOne("SmartTestTaskKozitski.DAL.Entities.Specifications", "Specifications", b1 =>
                        {
                            b1.Property<Guid>("ProductionFacilityId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Area")
                                .HasColumnType("int")
                                .HasColumnName("Area");

                            b1.Property<long>("Code")
                                .HasColumnType("bigint")
                                .HasColumnName("Code");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Name");

                            b1.HasKey("ProductionFacilityId");

                            b1.HasIndex("Code")
                                .IsUnique();

                            b1.ToTable("ProductionFacilities");

                            b1.WithOwner()
                                .HasForeignKey("ProductionFacilityId");

                            b1.HasData(
                                new
                                {
                                    ProductionFacilityId = new Guid("b0fc118d-527d-41b1-9b1c-3a74bdc8dd2a"),
                                    Area = 200,
                                    Code = 2001L,
                                    Name = "FacilityA"
                                },
                                new
                                {
                                    ProductionFacilityId = new Guid("241a2aa6-0bf4-442a-9058-9db7c2355f96"),
                                    Area = 300,
                                    Code = 2002L,
                                    Name = "FacilityB"
                                },
                                new
                                {
                                    ProductionFacilityId = new Guid("3c663d1b-f9f9-47d6-a9ed-e3ab2a9b2895"),
                                    Area = 400,
                                    Code = 2003L,
                                    Name = "FacilityC"
                                },
                                new
                                {
                                    ProductionFacilityId = new Guid("2342040a-9c7a-4537-9bfc-6b1895cd711f"),
                                    Area = 500,
                                    Code = 2004L,
                                    Name = "FacilityD"
                                },
                                new
                                {
                                    ProductionFacilityId = new Guid("e3c1a636-05cf-4b7f-8f16-7d4bd7416e67"),
                                    Area = 600,
                                    Code = 2005L,
                                    Name = "FacilityE"
                                });
                        });

                    b.Navigation("Specifications")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
