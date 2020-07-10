﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using urunKovaniApi;

namespace urunKovaniApi.Migrations
{
    [DbContext(typeof(UrunKovaniContext))]
    [Migration("20200710090931_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("urunKovaniApi.Models.AdminUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnName("address");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatedById")
                        .HasColumnName("created_by");

                    b.Property<bool>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<string>("Email")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .HasColumnName("phone");

                    b.Property<string>("SureName")
                        .HasColumnName("surename");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.ToTable("AdminUser");
                });

            modelBuilder.Entity("urunKovaniApi.Models.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BasketTotal")
                        .HasColumnName("basket_total");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatedById")
                        .HasColumnName("created_by");

                    b.Property<bool>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<int>("EmployeeId")
                        .HasColumnName("employee_id");

                    b.Property<int>("OrderId")
                        .HasColumnName("order_id");

                    b.Property<string>("PieceKg")
                        .HasColumnName("piece_kg");

                    b.Property<int>("PrdocutId")
                        .HasColumnName("product_id");

                    b.Property<string>("ProductName")
                        .HasColumnName("product_name");

                    b.Property<int>("ProductPrice")
                        .HasColumnName("product_price");

                    b.Property<int>("ShopId")
                        .HasColumnName("shop_id");

                    b.Property<string>("ShopName")
                        .HasColumnName("shop_name");

                    b.Property<string>("Unit")
                        .HasColumnName("unit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.ToTable("Basket");
                });

            modelBuilder.Entity("urunKovaniApi.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnName("category_name");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatedById")
                        .HasColumnName("created_by");

                    b.Property<bool>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<int>("ShopId");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.Property<int?>("shopId");

                    b.HasKey("Id");

                    b.HasIndex("shopId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("urunKovaniApi.Models.Complaints", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatedById")
                        .HasColumnName("created_by");

                    b.Property<bool>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<int>("EmployeeId")
                        .HasColumnName("employee_id");

                    b.Property<string>("Message")
                        .HasColumnName("message");

                    b.Property<int>("ShopId")
                        .HasColumnName("shop_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.ToTable("Complaints");
                });

            modelBuilder.Entity("urunKovaniApi.Models.EmployeeUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnName("address");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatedById")
                        .HasColumnName("created_by");

                    b.Property<bool>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<string>("Email")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .HasColumnName("phone");

                    b.Property<string>("SureName")
                        .HasColumnName("surename");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.ToTable("EmployeeUserteriUser");
                });

            modelBuilder.Entity("urunKovaniApi.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatedById")
                        .HasColumnName("created_by");

                    b.Property<bool>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<int>("EmployeeId")
                        .HasColumnName("employee_id");

                    b.Property<int>("OrderTotal")
                        .HasColumnName("order_total");

                    b.Property<string>("PaymentType")
                        .HasColumnName("payment_type");

                    b.Property<int>("ProductId")
                        .HasColumnName("product_id");

                    b.Property<int>("ShopId")
                        .HasColumnName("shop_id");

                    b.Property<string>("ShopName")
                        .HasColumnName("shop_name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("urunKovaniApi.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatedById")
                        .HasColumnName("created_by");

                    b.Property<bool>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<string>("Kg")
                        .HasColumnName("kg");

                    b.Property<double>("Price")
                        .HasColumnName("price");

                    b.Property<string>("ShopName")
                        .HasColumnName("shop_name");

                    b.Property<string>("Unit")
                        .HasColumnName("birim");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("urunKovaniApi.Models.ShopCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnName("category_name");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatedById")
                        .HasColumnName("created_by");

                    b.Property<bool>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.ToTable("ShopCategory");
                });

            modelBuilder.Entity("urunKovaniApi.Models.Shops", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatedById")
                        .HasColumnName("created_by");

                    b.Property<bool>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<string>("DeliveryTime")
                        .HasColumnName("delivery_time");

                    b.Property<double>("MinOrderPrice")
                        .HasColumnName("min_order_price");

                    b.Property<string>("ShopAddress")
                        .HasColumnName("shop_address");

                    b.Property<int?>("ShopCategoryId");

                    b.Property<string>("ShopName")
                        .HasColumnName("shop_name");

                    b.Property<string>("ShopPhone")
                        .HasColumnName("shop_phone");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.Property<string>("WorkHours")
                        .HasColumnName("work_hours");

                    b.HasKey("Id");

                    b.HasIndex("ShopCategoryId");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("urunKovaniApi.Models.Categories", b =>
                {
                    b.HasOne("urunKovaniApi.Models.Shops", "Shop")
                        .WithMany("Categorie")
                        .HasForeignKey("shopId");
                });

            modelBuilder.Entity("urunKovaniApi.Models.Products", b =>
                {
                    b.HasOne("urunKovaniApi.Models.Categories", "Category")
                        .WithMany("Product")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("urunKovaniApi.Models.Shops", b =>
                {
                    b.HasOne("urunKovaniApi.Models.ShopCategory", "ShopCategory")
                        .WithMany("Shops")
                        .HasForeignKey("ShopCategoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
