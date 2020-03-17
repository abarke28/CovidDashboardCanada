﻿// <auto-generated />
using System;
using CovidDashboardCanada.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CovidDashboardCanada.Migrations
{
    [DbContext(typeof(CovidContext))]
    [Migration("20200317224618_AddedXAndY")]
    partial class AddedXAndY
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CovidDashboardCanada.Model.DailyCaseRecord", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AB")
                        .HasColumnType("int");

                    b.Property<int>("BC")
                        .HasColumnType("int");

                    b.Property<string>("CaseType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DateString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longtitude")
                        .HasColumnType("float");

                    b.Property<int>("MB")
                        .HasColumnType("int");

                    b.Property<int>("MT")
                        .HasColumnType("int");

                    b.Property<int>("NB")
                        .HasColumnType("int");

                    b.Property<int>("NF")
                        .HasColumnType("int");

                    b.Property<int>("NS")
                        .HasColumnType("int");

                    b.Property<int>("NV")
                        .HasColumnType("int");

                    b.Property<int>("NWT")
                        .HasColumnType("int");

                    b.Property<int>("ON")
                        .HasColumnType("int");

                    b.Property<int>("PEI")
                        .HasColumnType("int");

                    b.Property<int>("QC")
                        .HasColumnType("int");

                    b.Property<int>("SK")
                        .HasColumnType("int");

                    b.Property<int>("WS")
                        .HasColumnType("int");

                    b.Property<int>("YK")
                        .HasColumnType("int");

                    b.Property<int>("xPosition")
                        .HasColumnType("int");

                    b.Property<int>("yPosition")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Recordset");
                });
#pragma warning restore 612, 618
        }
    }
}
