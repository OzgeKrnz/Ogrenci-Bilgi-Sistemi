
using Microsoft.EntityFrameworkCore;
using StajProjesi.Models;

namespace StajProjesi.Areas.Data;


public class ClassesDbContext : DbContext
{
    public ClassesDbContext(DbContextOptions<ClassesDbContext> options) : base(options)
    {
        
    }
    public DbSet<FirstTerm> FirstT { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FirstTerm>().HasData(
                new FirstTerm { Classname = "Bilgisayar Mimarisi I", Vize = 60,FinalNt = 32,Bütünleme=67},
                new FirstTerm { Classname = "Dosya Organizasyonu", Vize = 56,FinalNt = 33,Bütünleme = 60},
                new FirstTerm { Classname = "Görsel Programlama", Vize = 90,FinalNt = 100},
                new FirstTerm { Classname = "Mesleki İngilizce III",Vize = 94,FinalNt = 80},
                new FirstTerm { Classname = "Veri Tabanı Yönetim Sistemleri I", Vize = 65,FinalNt = 80},
                new FirstTerm { Classname = "İşletim Sistemleri I",Vize = 91,FinalNt = 65}
            );
        }
    }

