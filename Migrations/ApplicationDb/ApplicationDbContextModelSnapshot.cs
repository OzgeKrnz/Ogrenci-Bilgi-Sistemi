﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StajProjesi.Areas.Data;

#nullable disable

namespace StajProjesi.Migrations.ApplicationDb
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StajProjesi.Models.AcademicCalendar", b =>
                {
                    b.Property<string>("Calendar")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Calendar");

                    b.ToTable("AcademicCalendarInfo");
                });

            modelBuilder.Entity("StajProjesi.Models.Classes", b =>
                {
                    b.Property<string>("Classname")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Mark")
                        .HasColumnType("int");

                    b.HasKey("Classname");

                    b.ToTable("ClassesInfo");

                    b.HasData(
                        new
                        {
                            Classname = "Bilgisayar Mimarisi 1",
                            Mark = 90
                        },
                        new
                        {
                            Classname = "Dosya Organizasyonu",
                            Mark = 90
                        },
                        new
                        {
                            Classname = "Görsel Programlama",
                            Mark = 90
                        },
                        new
                        {
                            Classname = "Mesleki İngilizce III",
                            Mark = 90
                        },
                        new
                        {
                            Classname = "Veri Tabanı 1",
                            Mark = 90
                        },
                        new
                        {
                            Classname = "İşletim Sistemleri 1",
                            Mark = 90
                        },
                        new
                        {
                            Classname = "Bilgisayar Ağları",
                            Mark = 90
                        },
                        new
                        {
                            Classname = "Sistem Analizi ve Tasarımı",
                            Mark = 90
                        },
                        new
                        {
                            Classname = "Web Tabanlı Programlama",
                            Mark = 90
                        },
                        new
                        {
                            Classname = "Mesleki İngilizce IV",
                            Mark = 90
                        });
                });

            modelBuilder.Entity("StajProjesi.Models.StudentInfo", b =>
                {
                    b.Property<string>("StId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Bolum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Gno")
                        .HasColumnType("float");

                    b.Property<string>("StEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StId");

                    b.ToTable("StudentInfos");

                    b.HasData(
                        new
                        {
                            StId = "100200300",
                            Bolum = "Bilgisayar Mühendisliği",
                            Gno = 3.0099999999999998,
                            StEmail = "ozge@ogr.edu.tr",
                            StName = "Özge Kurnaz"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
