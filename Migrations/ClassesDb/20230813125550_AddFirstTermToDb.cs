using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StajProjesi.Migrations.ClassesDb
{
    /// <inheritdoc />
    public partial class AddFirstTermToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FirstT",
                columns: table => new
                {
                    Classname = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Vize = table.Column<int>(type: "int", nullable: false),
                    FinalNt = table.Column<int>(type: "int", nullable: false),
                    Bütünleme = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstT", x => x.Classname);
                });

            migrationBuilder.InsertData(
                table: "FirstT",
                columns: new[] { "Classname", "Bütünleme", "FinalNt", "Vize" },
                values: new object[,]
                {
                    { "Bilgisayar Mimarisi I", 67, 32, 60 },
                    { "Dosya Organizasyonu", 60, 33, 56 },
                    { "Görsel Programlama", 0, 100, 90 },
                    { "İşletim Sistemleri I", 0, 65, 91 },
                    { "Mesleki İngilizce III", 0, 80, 94 },
                    { "Veri Tabanı Yönetim Sistemleri I", 0, 80, 65 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FirstT");
        }
    }
}
