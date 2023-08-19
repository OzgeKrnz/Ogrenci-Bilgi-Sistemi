using Microsoft.EntityFrameworkCore;
using StajProjesi.Models;

namespace StajProjesi.Areas.Data;


public class Classes1DbContext : DbContext
{
    public Classes1DbContext(DbContextOptions<Classes1DbContext> options) : base(options)
    {
        
    }

    public DbSet<SecondTerm> Secondt { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<SecondTerm>().HasData(
            new SecondTerm { Classname = "Bilgisayar Ağları", Vize = 90,FinalNt = 40},
            new SecondTerm { Classname = "Sistem Analizi ve Tasarımı", Vize = 60,FinalNt = 83},
            new SecondTerm { Classname = "Web Tabanlı Programlama", Vize = 52,FinalNt = 80},
            new SecondTerm { Classname = "Mesleki İngilizce IV", Vize = 73,FinalNt = 77},
            new SecondTerm { Classname = "Veri Tabanı Yönetim Sistemleri II", Vize = 43,FinalNt = 37,Bütünleme=72}

         


        );
    }

    
}