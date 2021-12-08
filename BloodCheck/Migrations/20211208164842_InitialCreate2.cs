using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodCheck.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    idDoctor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    crm = table.Column<string>(type: "char(6)", nullable: true),
                    name = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id Doctors", x => x.idDoctor);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    idExam = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<decimal>(type: "numeric(5,2)", nullable: false),
                    description = table.Column<string>(type: "varchar(255)", nullable: true),
                    deliveryDays = table.Column<decimal>(type: "numeric(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("idExam", x => x.idExam);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    idPatient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", nullable: true),
                    cpf = table.Column<string>(type: "varchar(11)", nullable: true),
                    phone = table.Column<string>(type: "varchar(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id Patients", x => x.idPatient);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    idRequest = table.Column<int>(type: "int", nullable: false),
                    idPatient = table.Column<decimal>(type: "numeric(4)", nullable: false),
                    idDoctor = table.Column<decimal>(type: "numeric(4)", nullable: false),
                    requestDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id Requests", x => new { x.idRequest, x.idPatient, x.idDoctor });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Requests");
        }
    }
}
