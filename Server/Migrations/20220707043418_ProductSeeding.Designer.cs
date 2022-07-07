﻿// <auto-generated />
using EcommerceWebAsmb.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcommerceWebAsmb.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220707043418_ProductSeeding")]
    partial class ProductSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EcommerceWebAsmb.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descriptions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descriptions = "This is a good Product",
                            ImageUrl = "https://en.wikipedia.org/wiki/Tree#/media/File:Daintree_Rainforest_4.jpg",
                            Price = 550.25m,
                            Title = "Jwt Authentication Here Refresh Token"
                        },
                        new
                        {
                            Id = 2,
                            Descriptions = "This is a good Product",
                            ImageUrl = "https://en.wikipedia.org/wiki/Tree#/media/File:Daintree_Rainforest_4.jpg",
                            Price = 400.25m,
                            Title = "Entity Framework"
                        },
                        new
                        {
                            Id = 3,
                            Descriptions = "This is a good Product",
                            ImageUrl = "https://en.wikipedia.org/wiki/Tree#/media/File:Daintree_Rainforest_4.jpg",
                            Price = 400.25m,
                            Title = "JavaScriptHello"
                        },
                        new
                        {
                            Id = 4,
                            Descriptions = "This is a good Product",
                            ImageUrl = "https://en.wikipedia.org/wiki/Tree#/media/File:Daintree_Rainforest_4.jpg",
                            Price = 400.25m,
                            Title = "TypeScript"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}