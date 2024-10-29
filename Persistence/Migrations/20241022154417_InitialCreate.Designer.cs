﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Solucao.Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(EFCoreContext))]
    [Migration("20241022154417_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Solucao.Models.ReportModel", b =>
                {
                    b.Property<int>("ReportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Profit")
                        .HasColumnType("TEXT");

                    b.Property<int>("TotalReserve")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TotalRoom")
                        .HasColumnType("INTEGER");

                    b.HasKey("ReportID");

                    b.ToTable("ReportModel");
                });

            modelBuilder.Entity("Solucao.Models.ReserveModel", b =>
                {
                    b.Property<int>("ReserveID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCheckIn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCheckOut")
                        .HasColumnType("TEXT");

                    b.HasKey("ReserveID");

                    b.ToTable("ReserveModel");
                });

            modelBuilder.Entity("Solucao.Models.RoomModel", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Availability")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Desc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("RoomID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Solucao.Models.UserModel", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserCPF")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserRG")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
