﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SellerData.Migrations
{
    [DbContext(typeof(SellerDbContext))]
    [Migration("20181018132546_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Models.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime>("Time");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("Data.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count");

                    b.Property<double>("Value");

                    b.HasKey("Id");

                    b.ToTable("SellerRating");
                });

            modelBuilder.Entity("Data.SellerModels.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<double>("Price");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Data.SellerModels.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<bool>("Approved");

                    b.Property<string>("Description");

                    b.Property<bool>("Gender");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("PostalCode")
                        .IsRequired();

                    b.Property<int?>("SellerRatingId");

                    b.Property<double>("SuccessProcent");

                    b.HasKey("Id");

                    b.HasIndex("SellerRatingId");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("Data.SellerModels.SellerItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<int>("FullItemId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("OrdersId");

                    b.Property<int?>("SellerId");

                    b.HasKey("Id");

                    b.HasIndex("OrdersId");

                    b.HasIndex("SellerId");

                    b.ToTable("SellerItems");
                });

            modelBuilder.Entity("Data.SellerModels.Shipping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("ExpectedTime");

                    b.Property<int>("Method");

                    b.Property<bool>("Notifications");

                    b.Property<int>("OrderInfoId");

                    b.HasKey("Id");

                    b.HasIndex("OrderInfoId");

                    b.ToTable("Shippings");
                });

            modelBuilder.Entity("Data.SellerModels.Seller", b =>
                {
                    b.HasOne("Data.Models.Rating", "SellerRating")
                        .WithMany()
                        .HasForeignKey("SellerRatingId");
                });

            modelBuilder.Entity("Data.SellerModels.SellerItem", b =>
                {
                    b.HasOne("Data.SellerModels.Orders")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrdersId");

                    b.HasOne("Data.SellerModels.Seller")
                        .WithMany("SellerItems")
                        .HasForeignKey("SellerId");
                });

            modelBuilder.Entity("Data.SellerModels.Shipping", b =>
                {
                    b.HasOne("Data.SellerModels.Orders", "OrderInfo")
                        .WithMany()
                        .HasForeignKey("OrderInfoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
