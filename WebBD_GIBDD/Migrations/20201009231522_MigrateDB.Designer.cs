﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebBD_GIBDD.Data;

namespace WebBD_GIBDD.Migrations
{
    [DbContext(typeof(WebBD_GIBDDContext))]
    [Migration("20201009231522_MigrateDB")]
    partial class MigrateDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BD_GIBDD.Models.Auto", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("COLOR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("CarsStolenID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfRegistration")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateSheetNumber")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTechInspection")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EngineNumber")
                        .HasColumnType("int");

                    b.Property<string>("NumberCarBody")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegNum")
                        .HasColumnType("int");

                    b.Property<string>("TechInspection")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CarsStolenID");

                    b.ToTable("Auto");
                });

            modelBuilder.Entity("BD_GIBDD.Models.BrandAuto", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("AutoID")
                        .HasColumnType("bigint");

                    b.Property<string>("CompanyManufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryManufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndProduction")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specifications")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartProduction")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("AutoID");

                    b.ToTable("BrandAuto");
                });

            modelBuilder.Entity("BD_GIBDD.Models.CarsStolen", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Circumstances")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAppeal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateFind")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateStolen")
                        .HasColumnType("datetime2");

                    b.Property<bool>("MarkFind")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("CarsStolen");
                });

            modelBuilder.Entity("BD_GIBDD.Models.Driver", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("AutoID")
                        .HasColumnType("bigint");

                    b.Property<long?>("CarsStolenID")
                        .HasColumnType("bigint");

                    b.Property<string>("CategoryCertificate")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<DateTime>("DateIssueCertificate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DriversLicenseNum")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDateCertificate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportData")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AutoID");

                    b.HasIndex("CarsStolenID");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("BD_GIBDD.Models.Position", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Duties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamePosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requirements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<long?>("StaffID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("StaffID");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("BD_GIBDD.Models.Rank", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Duties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameRank")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requirements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<long?>("StaffID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("StaffID");

                    b.ToTable("Rank");
                });

            modelBuilder.Entity("BD_GIBDD.Models.Staff", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Age")
                        .HasColumnType("smallint");

                    b.Property<long?>("AutoID")
                        .HasColumnType("bigint");

                    b.Property<long?>("CarsStolenID")
                        .HasColumnType("bigint");

                    b.Property<long?>("DriverID")
                        .HasColumnType("bigint");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AutoID");

                    b.HasIndex("CarsStolenID");

                    b.HasIndex("DriverID");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("BD_GIBDD.Models.Auto", b =>
                {
                    b.HasOne("BD_GIBDD.Models.CarsStolen", null)
                        .WithMany("AutoID")
                        .HasForeignKey("CarsStolenID");
                });

            modelBuilder.Entity("BD_GIBDD.Models.BrandAuto", b =>
                {
                    b.HasOne("BD_GIBDD.Models.Auto", null)
                        .WithMany("BrandAutoID")
                        .HasForeignKey("AutoID");
                });

            modelBuilder.Entity("BD_GIBDD.Models.Driver", b =>
                {
                    b.HasOne("BD_GIBDD.Models.Auto", null)
                        .WithMany("DriverID")
                        .HasForeignKey("AutoID");

                    b.HasOne("BD_GIBDD.Models.CarsStolen", null)
                        .WithMany("DriverID")
                        .HasForeignKey("CarsStolenID");
                });

            modelBuilder.Entity("BD_GIBDD.Models.Position", b =>
                {
                    b.HasOne("BD_GIBDD.Models.Staff", null)
                        .WithMany("PositionID")
                        .HasForeignKey("StaffID");
                });

            modelBuilder.Entity("BD_GIBDD.Models.Rank", b =>
                {
                    b.HasOne("BD_GIBDD.Models.Staff", null)
                        .WithMany("RankID")
                        .HasForeignKey("StaffID");
                });

            modelBuilder.Entity("BD_GIBDD.Models.Staff", b =>
                {
                    b.HasOne("BD_GIBDD.Models.Auto", null)
                        .WithMany("StaffID")
                        .HasForeignKey("AutoID");

                    b.HasOne("BD_GIBDD.Models.CarsStolen", null)
                        .WithMany("StaffID")
                        .HasForeignKey("CarsStolenID");

                    b.HasOne("BD_GIBDD.Models.Driver", null)
                        .WithMany("StaffID")
                        .HasForeignKey("DriverID");
                });
#pragma warning restore 612, 618
        }
    }
}
