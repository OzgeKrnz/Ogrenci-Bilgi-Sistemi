using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StajProjesi.Migrations.Classes1Db
{
    /// <inheritdoc />
    public partial class AddSecondTermClassesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Secondt",
                columns: table => new
                {
                    Classname = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Vize = table.Column<int>(type: "int", nullable: false),
                    FinalNt = table.Column<int>(type: "int", nullable: false),
                    Bütünleme = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secondt", x => x.Classname);
                });

            migrationBuilder.InsertData(
                table: "Secondt",
                columns: new[] { "Classname", "Bütünleme", "FinalNt", "Vize" },
                values: new object[,]
                {
                    { "Bilgisayar Ağları", 0, 40, 90 },
                    { "Mesleki İngilizce IV", 0, 77, 73 },
                    { "Sistem Analizi ve Tasarımı", 0, 83, 60 },
                    { "Veri Tabanı Yönetim Sistemleri II", 72, 37, 43 },
                    { "Web Tabanlı Programlama", 0, 80, 52 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Secondt");
        }
    }
}
