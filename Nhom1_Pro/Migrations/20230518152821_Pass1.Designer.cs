﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nhom1_Pro.Models;

#nullable disable

namespace Nhom1_Pro.Migrations
{
    [DbContext(typeof(DBContextModel))]
    [Migration("20230518152821_Pass1")]
    partial class Pass1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Nhom1_Pro.Models.Bill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid?>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdVoucher")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("NgayNhan")
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("NgayShip")
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("NgayThanhToan")
                        .HasColumnType("DateTime");

                    b.Property<string>("Sdt")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<decimal?>("SoTienGiam")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TenNguoiNhan")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<decimal?>("TienShip")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdUser");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.BillDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("DonGia")
                        .HasColumnType("decimal");

                    b.Property<Guid?>("IdBill")
                        .HasColumnType("UNIQUEIDENTIFIER");

                    b.Property<Guid?>("IdProductDetail")
                        .HasColumnType("UNIQUEIDENTIFIER");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdBill");

                    b.HasIndex("IdProductDetail");

                    b.ToTable("BillDetails");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.Cart", b =>
                {
                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.CartDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DetailProductID")
                        .HasColumnType("UNIQUEIDENTIFIER");

                    b.Property<decimal>("Dongia")
                        .HasColumnType("decimal");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.Property<Guid>("UserID")
                        .HasColumnType("UNIQUEIDENTIFIER");

                    b.HasKey("Id");

                    b.HasIndex("DetailProductID");

                    b.HasIndex("UserID");

                    b.ToTable("CartDetails");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.Color", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Color", (string)null);
                });

            modelBuilder.Entity("Nhom1_Pro.Models.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("DuongDan")
                        .HasColumnType("varbinary(max)");

                    b.Property<Guid?>("IdProductDetail")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenAnh")
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdProductDetail");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.Material", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Material", (string)null);
                });

            modelBuilder.Entity("Nhom1_Pro.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.ProductDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BaoHanh")
                        .HasColumnType("nvarchar(250)");

                    b.Property<decimal?>("GiaBan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("GiaNhap")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("IdColor")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdMaterial")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdProduct")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSize")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdTypeProduct")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("SoLuongTon")
                        .HasColumnType("int");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdColor");

                    b.HasIndex("IdMaterial");

                    b.HasIndex("IdProduct");

                    b.HasIndex("IdSize");

                    b.HasIndex("IdTypeProduct");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.Sale", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoaiHinhKm")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Ma")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MoTa")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<decimal?>("MucGiam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,0)")
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime?>("NgayBatDau")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayKetThuc")
                        .HasColumnType("datetime");

                    b.Property<string>("Ten")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.ToTable("Sale", (string)null);
                });

            modelBuilder.Entity("Nhom1_Pro.Models.SaleDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<Guid?>("IdChiTietSp")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdChiTietSP");

                    b.Property<Guid?>("IdSale")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdSale");

                    b.Property<string>("MoTa")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.HasIndex("IdChiTietSp");

                    b.HasIndex("IdSale");

                    b.ToTable("DetailSale", (string)null);
                });

            modelBuilder.Entity("Nhom1_Pro.Models.Size", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Cm")
                        .HasColumnType("decimal");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Size1")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Size", (string)null);
                });

            modelBuilder.Entity("Nhom1_Pro.Models.TypeProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TypeProducts");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<Guid>("IdRole")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TaiKhoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdRole");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.Voucher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DieuKien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoaiHinhKm")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Ma")
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("MucUuDai")
                        .HasColumnType("decimal");

                    b.Property<DateTime?>("NgayBatDau")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayKetThuc")
                        .HasColumnType("datetime");

                    b.Property<string>("PhamVi")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("SoLanSuDung")
                        .HasColumnType("int");

                    b.Property<int?>("SoLuongTon")
                        .HasColumnType("int");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vouchers");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.Bill", b =>
                {
                    b.HasOne("Nhom1_Pro.Models.User", "User")
                        .WithMany("Bills")
                        .HasForeignKey("IdUser");

                    b.HasOne("Nhom1_Pro.Models.Voucher", "Voucher")
                        .WithMany("Bills")
                        .HasForeignKey("IdUser");

                    b.Navigation("User");

                    b.Navigation("Voucher");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.BillDetail", b =>
                {
                    b.HasOne("Nhom1_Pro.Models.Bill", "Bill")
                        .WithMany("BillDetails")
                        .HasForeignKey("IdBill");

                    b.HasOne("Nhom1_Pro.Models.ProductDetail", "ProductDetail")
                        .WithMany("BillDetail")
                        .HasForeignKey("IdProductDetail");

                    b.Navigation("Bill");

                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.Cart", b =>
                {
                    b.HasOne("Nhom1_Pro.Models.User", "User")
                        .WithOne("Carts")
                        .HasForeignKey("Nhom1_Pro.Models.Cart", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.CartDetail", b =>
                {
                    b.HasOne("Nhom1_Pro.Models.ProductDetail", "ProductDetail")
                        .WithMany("CartDetail")
                        .HasForeignKey("DetailProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nhom1_Pro.Models.Cart", "Cart")
                        .WithMany("cartdetail")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.Image", b =>
                {
                    b.HasOne("Nhom1_Pro.Models.ProductDetail", "ProductDetail")
                        .WithMany("Image")
                        .HasForeignKey("IdProductDetail");

                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.ProductDetail", b =>
                {
                    b.HasOne("Nhom1_Pro.Models.Color", "Color")
                        .WithMany("ProductDetail")
                        .HasForeignKey("IdColor");

                    b.HasOne("Nhom1_Pro.Models.Material", "Material")
                        .WithMany("ProductDetail")
                        .HasForeignKey("IdMaterial");

                    b.HasOne("Nhom1_Pro.Models.Product", "Product")
                        .WithMany("ProductDetail")
                        .HasForeignKey("IdProduct");

                    b.HasOne("Nhom1_Pro.Models.Size", "Size")
                        .WithMany("ProductDetail")
                        .HasForeignKey("IdSize");

                    b.HasOne("Nhom1_Pro.Models.TypeProduct", "TypeProduct")
                        .WithMany("ProductDetails")
                        .HasForeignKey("IdTypeProduct");

                    b.Navigation("Color");

                    b.Navigation("Material");

                    b.Navigation("Product");

                    b.Navigation("Size");

                    b.Navigation("TypeProduct");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.SaleDetail", b =>
                {
                    b.HasOne("Nhom1_Pro.Models.ProductDetail", "ProductDetail")
                        .WithMany("DetailSale")
                        .HasForeignKey("IdChiTietSp");

                    b.HasOne("Nhom1_Pro.Models.Sale", "Sale")
                        .WithMany("DetailSales")
                        .HasForeignKey("IdSale");

                    b.Navigation("ProductDetail");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.User", b =>
                {
                    b.HasOne("Nhom1_Pro.Models.Role", "Roles")
                        .WithMany("Users")
                        .HasForeignKey("IdRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.Bill", b =>
                {
                    b.Navigation("BillDetails");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.Cart", b =>
                {
                    b.Navigation("cartdetail");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.Color", b =>
                {
                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.Material", b =>
                {
                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.Product", b =>
                {
                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.ProductDetail", b =>
                {
                    b.Navigation("BillDetail");

                    b.Navigation("CartDetail");

                    b.Navigation("DetailSale");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.Sale", b =>
                {
                    b.Navigation("DetailSales");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.Size", b =>
                {
                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.TypeProduct", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("Nhom1_Pro.Models.User", b =>
                {
                    b.Navigation("Bills");

                    b.Navigation("Carts")
                        .IsRequired();
                });

            modelBuilder.Entity("Nhom1_Pro.Models.Voucher", b =>
                {
                    b.Navigation("Bills");
                });
#pragma warning restore 612, 618
        }
    }
}
