﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductData;

namespace ProductData.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20181018132620_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProductData.Models.ImageSource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ItemId");

                    b.Property<string>("Original")
                        .IsRequired();

                    b.Property<string>("Thumbnail");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("ProductData.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Approved");

                    b.Property<int?>("CartId");

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<double>("Discount");

                    b.Property<int>("InStock");

                    b.Property<int?>("ItemRatingId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<double>("Price");

                    b.Property<string>("Properties")
                        .IsRequired();

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ItemRatingId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ProductData.Models.Log", b =>
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

            modelBuilder.Entity("ProductData.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count");

                    b.Property<double>("Value");

                    b.HasKey("Id");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("ProductData.ProductModels.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("ProductData.ProductModels.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("ItemsCount");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("ProductData.ProductModels.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("ProductData.ProductModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int?>("CurrentCartId");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("PostalCode")
                        .IsRequired();

                    b.Property<int?>("UserCityId");

                    b.HasKey("Id");

                    b.HasIndex("CurrentCartId");

                    b.HasIndex("UserCityId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ProductData.Models.ImageSource", b =>
                {
                    b.HasOne("ProductData.Models.Item")
                        .WithMany("ItemImages")
                        .HasForeignKey("ItemId");
                });

            modelBuilder.Entity("ProductData.Models.Item", b =>
                {
                    b.HasOne("ProductData.ProductModels.Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId");

                    b.HasOne("ProductData.ProductModels.Category")
                        .WithMany("CategoryItems")
                        .HasForeignKey("CategoryId");

                    b.HasOne("ProductData.Models.Rating", "ItemRating")
                        .WithMany()
                        .HasForeignKey("ItemRatingId");
                });

            modelBuilder.Entity("ProductData.ProductModels.Category", b =>
                {
                    b.HasOne("ProductData.ProductModels.Category")
                        .WithMany("SubCategorys")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("ProductData.ProductModels.User", b =>
                {
                    b.HasOne("ProductData.ProductModels.Cart", "CurrentCart")
                        .WithMany()
                        .HasForeignKey("CurrentCartId");

                    b.HasOne("ProductData.ProductModels.City", "UserCity")
                        .WithMany()
                        .HasForeignKey("UserCityId");
                });
#pragma warning restore 612, 618
        }
    }
}
