using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StajProjesi.Models;

namespace StajProjesi.Areas.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    // create table for student info
    public DbSet<StudentInfo> StudentInfos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<StudentInfo>().HasData(
            new StudentInfo
            {
                StId = "100200300",
                StName = "Özge Kurnaz",
                     Bolum = "Bilgisayar Mühendisliği",
                     Gno = 3.01,
                     StEmail = "ozge@ogr.edu.tr"
                 }
             );
     
         }
}

    