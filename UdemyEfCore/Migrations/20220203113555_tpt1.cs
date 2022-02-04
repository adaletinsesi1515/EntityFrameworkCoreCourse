using Microsoft.EntityFrameworkCore.Migrations;

namespace UdemyEfCore.Migrations
{
    public partial class tpt1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DailyWage",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "HourlyWage",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Empyoyees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empyoyees",
                table: "Empyoyees",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "FulltimeEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    HourlyWage = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FulltimeEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FulltimeEmployees_Empyoyees_Id",
                        column: x => x.Id,
                        principalTable: "Empyoyees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParttimeEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    DailyWage = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParttimeEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParttimeEmployees_Empyoyees_Id",
                        column: x => x.Id,
                        principalTable: "Empyoyees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FulltimeEmployees");

            migrationBuilder.DropTable(
                name: "ParttimeEmployees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empyoyees",
                table: "Empyoyees");

            migrationBuilder.RenameTable(
                name: "Empyoyees",
                newName: "Employees");

            migrationBuilder.AddColumn<decimal>(
                name: "DailyWage",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "HourlyWage",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");
        }
    }
}
