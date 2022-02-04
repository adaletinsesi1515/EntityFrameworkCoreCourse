﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UdemyEfCore.Data.Contexts;

namespace UdemyEfCore.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UdemyEfCore.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("UdemyEfCore.Data.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empyoyees");
                });

            modelBuilder.Entity("UdemyEfCore.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 3)
                        .HasColumnType("decimal(18,3)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("UdemyEfCore.Data.Entities.ProductCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("productCategories");
                });

            modelBuilder.Entity("UdemyEfCore.Data.Entities.ProductDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("productDetails");
                });

            modelBuilder.Entity("UdemyEfCore.Data.Entities.SaleHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("SaleHistories");
                });

            modelBuilder.Entity("UdemyEfCore.Data.Entities.FulltimeEmployee", b =>
                {
                    b.HasBaseType("UdemyEfCore.Data.Entities.Employee");

                    b.Property<decimal>("HourlyWage")
                        .HasColumnType("decimal(18,2)");

                    b.ToTable("FulltimeEmployees");
                });

            modelBuilder.Entity("UdemyEfCore.Data.Entities.ParttimeEmployee", b =>
                {
                    b.HasBaseType("UdemyEfCore.Data.Entities.Employee");

                    b.Property<decimal>("DailyWage")
                        .HasColumnType("decimal(18,2)");

                    b.ToTable("ParttimeEmployees");
                });

            modelBuilder.Entity("UdemyEfCore.Data.Entities.ProductCategory", b =>
                {
                    b.HasOne("UdemyEfCore.Data.Entities.Category", "Category")
                        .WithMany("productCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UdemyEfCore.Data.Entities.Product", "Product")
                        .WithMany("productCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("UdemyEfCore.Data.Entities.ProductDetail", b =>
                {
                    b.HasOne("UdemyEfCore.Data.Entities.Product", "Product")
                        .WithOne("ProductDetail")
                        .HasForeignKey("UdemyEfCore.Data.Entities.ProductDetail", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("UdemyEfCore.Data.Entities.SaleHistory", b =>
                {
                    b.HasOne("UdemyEfCore.Data.Entities.Product", "product")
                        .WithMany("saleHistory")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("UdemyEfCore.Data.Entities.FulltimeEmployee", b =>
                {
                    b.HasOne("UdemyEfCore.Data.Entities.Employee", null)
                        .WithOne()
                        .HasForeignKey("UdemyEfCore.Data.Entities.FulltimeEmployee", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UdemyEfCore.Data.Entities.ParttimeEmployee", b =>
                {
                    b.HasOne("UdemyEfCore.Data.Entities.Employee", null)
                        .WithOne()
                        .HasForeignKey("UdemyEfCore.Data.Entities.ParttimeEmployee", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UdemyEfCore.Data.Entities.Category", b =>
                {
                    b.Navigation("productCategories");
                });

            modelBuilder.Entity("UdemyEfCore.Data.Entities.Product", b =>
                {
                    b.Navigation("productCategories");

                    b.Navigation("ProductDetail");

                    b.Navigation("saleHistory");
                });
#pragma warning restore 612, 618
        }
    }
}
