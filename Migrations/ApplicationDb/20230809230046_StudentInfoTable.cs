using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StajProjesi.Migrations.ApplicationDb
{
    /// <inheritdoc />
    public partial class StudentInfoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentInfos",
                columns: table => new
                {
                    StId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bolum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gno = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentInfos", x => x.StId);
                });

            migrationBuilder.InsertData(
                table: "StudentInfos",
                columns: new[] { "StId", "Bolum", "Gno", "StEmail", "StName" },
                values: new object[] { "100200300", "Bilgisayar Mühendisliği", 3.0099999999999998, "ozge@ogr.edu.tr", "Özge Kurnaz" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentInfos");
        }
    }
}
