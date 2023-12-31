﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StajProjesi.Areas.Data;

#nullable disable

namespace StajProjesi.Migrations.ClassesDb
{
    [DbContext(typeof(ClassesDbContext))]
    [Migration("20230813125550_AddFirstTermToDb")]
    partial class AddFirstTermToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StajProjesi.Models.FirstTerm", b =>
                {
                    b.Property<string>("Classname")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Bütünleme")
                        .HasColumnType("int");

                    b.Property<int>("FinalNt")
                        .HasColumnType("int");

                    b.Property<int>("Vize")
                        .HasColumnType("int");

                    b.HasKey("Classname");

                    b.ToTable("FirstT");

                    b.HasData(
                        new
                        {
                            Classname = "Bilgisayar Mimarisi I",
                            Bütünleme = 67,
                            FinalNt = 32,
                            Vize = 60
                        },
                        new
                        {
                            Classname = "Dosya Organizasyonu",
                            Bütünleme = 60,
                            FinalNt = 33,
                            Vize = 56
                        },
                        new
                        {
                            Classname = "Görsel Programlama",
                            Bütünleme = 0,
                            FinalNt = 100,
                            Vize = 90
                        },
                        new
                        {
                            Classname = "Mesleki İngilizce III",
                            Bütünleme = 0,
                            FinalNt = 80,
                            Vize = 94
                        },
                        new
                        {
                            Classname = "Veri Tabanı Yönetim Sistemleri I",
                            Bütünleme = 0,
                            FinalNt = 80,
                            Vize = 65
                        },
                        new
                        {
                            Classname = "İşletim Sistemleri I",
                            Bütünleme = 0,
                            FinalNt = 65,
                            Vize = 91
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
