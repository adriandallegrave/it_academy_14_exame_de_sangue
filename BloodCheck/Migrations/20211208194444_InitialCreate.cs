using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodCheck.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    doctorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    crm = table.Column<string>(type: "char(6)", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id Doctors", x => x.doctorId);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    examId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<decimal>(type: "numeric(5,2)", nullable: false),
                    description = table.Column<string>(type: "varchar(255)", nullable: true),
                    deliveryDays = table.Column<decimal>(type: "numeric(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Id Exam", x => x.examId);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    patientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", nullable: false),
                    cpf = table.Column<string>(type: "char(11)", nullable: false),
                    phone = table.Column<string>(type: "varchar(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id Patients", x => x.patientId);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    requestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientId = table.Column<decimal>(type: "numeric(4)", nullable: false),
                    doctorId = table.Column<decimal>(type: "numeric(4)", nullable: false),
                    requestDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id Requests", x => x.requestId);
                    table.ForeignKey(
                        name: "FK_Requests_Doctors_doctorId",
                        column: x => x.doctorId,
                        principalTable: "Doctors",
                        principalColumn: "doctorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_Patients_patientId",
                        column: x => x.patientId,
                        principalTable: "Patients",
                        principalColumn: "patientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestExams",
                columns: table => new
                {
                    requestId = table.Column<int>(type: "int", nullable: false),
                    examId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestExams", x => new { x.examId, x.requestId });
                    table.ForeignKey(
                        name: "FK_RequestExams_Exams_examId",
                        column: x => x.examId,
                        principalTable: "Exams",
                        principalColumn: "examId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestExams_Requests_requestId",
                        column: x => x.requestId,
                        principalTable: "Requests",
                        principalColumn: "requestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RequestExams_requestId",
                table: "RequestExams",
                column: "requestId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_doctorId",
                table: "Requests",
                column: "doctorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Requests_patientId",
                table: "Requests",
                column: "patientId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequestExams");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
