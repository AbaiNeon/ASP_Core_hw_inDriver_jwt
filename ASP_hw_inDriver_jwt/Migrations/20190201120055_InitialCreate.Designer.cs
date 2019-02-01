﻿// <auto-generated />
using System;
using ASP_hw_inDriver_jwt.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASP_hw_inDriver_jwt.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190201120055_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASP_hw_inDriver_jwt.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<bool>("ExecutionStatus");

                    b.Property<DateTime>("OrderReceiptTime");

                    b.Property<string>("PointA");

                    b.Property<string>("PointB");

                    b.Property<int>("Price");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Orders");

                    b.HasData(
                        new { Id = 1, ClientId = 1, ExecutionStatus = false, OrderReceiptTime = new DateTime(2019, 2, 1, 18, 0, 54, 833, DateTimeKind.Local), PointA = "Брусиловского 5", PointB = "КА ШАГ", Price = 700 }
                    );
                });

            modelBuilder.Entity("ASP_hw_inDriver_jwt.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1, Login = "Abai", Name = "Абай", Password = "123", PhoneNumber = "911" }
                    );
                });

            modelBuilder.Entity("ASP_hw_inDriver_jwt.Models.Order", b =>
                {
                    b.HasOne("ASP_hw_inDriver_jwt.Models.User", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
