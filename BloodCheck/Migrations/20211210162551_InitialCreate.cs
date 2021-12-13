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
                    table.PrimaryKey("doctorId", x => x.doctorId);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    examId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<decimal>(type: "numeric(5,2)", nullable: false),
                    description = table.Column<string>(type: "varchar(255)", nullable: false),
                    deliveryDays = table.Column<decimal>(type: "numeric(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("examId", x => x.examId);
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
                    table.PrimaryKey("patientId", x => x.patientId);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    requestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientId = table.Column<int>(type: "int", nullable: false),
                    doctorId = table.Column<int>(type: "int", nullable: false),
                    requestDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("requestId", x => x.requestId);
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
                    examId = table.Column<int>(type: "int", nullable: false),
                    requestId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "doctorId", "crm", "name" },
                values: new object[,]
                {
                    { 1, "143523", "Julia" },
                    { 2, "444444", "Alice" },
                    { 3, "309345", "Arthur" },
                    { 4, "940481", "Yasmin" },
                    { 5, "482345", "Jorge" },
                    { 6, "935612", "Ronaldo" },
                    { 7, "277077", "Cleide" },
                    { 8, "761161", "Clarissa" },
                    { 9, "292392", "Joao" },
                    { 10, "545454", "Vitor" },
                    { 11, "723456", "Gustavo" },
                    { 12, "111111", "Elise" },
                    { 13, "334345", "Paulo" },
                    { 14, "934594", "Godofreda" },
                    { 15, "869233", "Elias" }
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "examId", "deliveryDays", "description", "price" },
                values: new object[,]
                {
                    { 1, 2m, "TTA - TEMPO DE TROMBOPLASTINA ATIVADA", 5.77m },
                    { 2, 3m, "DAU - DOSAGEM DE ACIDO URICO", 1.85m },
                    { 3, 3m, "DAG - DOSAGEM DE ALFA-1-GLICOPROTEINA ACIDA", 3.68m },
                    { 4, 7m, "DAL - DOSAGEM DE AMILASE", 2.25m },
                    { 5, 5m, "DBF - DOSAGEM DE BILIRRUBINA TOTAL E FRACOES", 2.01m },
                    { 6, 12m, "DCA - DOSAGEM DE CALCIO", 1.85m },
                    { 7, 2m, "DAA - DOSAGEM DE ALFA-1-GLICOPROTEINA ACIDA", 3.68m },
                    { 8, 1m, "DDS - DOSAGEM DE SODIO", 1.85m },
                    { 9, 6m, "DIT - DETERMINACAO DE INDICE DE TIROXINA LIVRE", 12.54m },
                    { 10, 8m, "DSI - DETERMINACAO DE TEMPO DE SANGRAMENTO DE IVY", 9.00m },
                    { 11, 3m, "PAA - PESQUISA DE ANTICORPOS IGG ANTITOXOPLASMA", 16.97m },
                    { 12, 4m, "DDH - DOSAGEM DE HEMOGLOBINA", 1.53m },
                    { 13, 6m, "DFR - DETERMINACAO DE FATOR REUMATOIDE", 2.83m },
                    { 14, 1m, "DPR - DOSAGEM DE PROTEINA C REATIVA", 3.93m },
                    { 15, 5m, "TFS - TESTE FTA-ABS IGG P/ DIAGNOSTICO DA SIFIL", 10.00m },
                    { 16, 13m, "PAI - PESQUISA DE ANTICORPOS IGM ANTITOXOPLASM", 18.55m },
                    { 17, 5m, "DUR - DOSAGEM DE UREIA", 18.55m },
                    { 18, 3m, "DDP - DOSAGEM DE PROLACTINA", 10.15m },
                    { 19, 10m, "TDF - TESTE FTA-ABS IGG P/ DIAGNOSTICO DA SIFILIS", 10.00m },
                    { 20, 12m, "DDT - DOSAGEM DE TESTOSTERONA", 10.43m },
                    { 21, 8m, "ABG - ANTIBIOGRAMA", 4.98m },
                    { 22, 4m, "CDT - CONTAGEM DE RETICULOCITOS", 2.73m },
                    { 23, 3m, "PRH - PESQUISA DE FATOR RH (I", 1.37m },
                    { 24, 5m, "DFR - DOSAGEM DE FERRITINA", 15.59m },
                    { 25, 7m, "DFF - DOSAGEM DE FOSFORO", 1.85m },
                    { 26, 9m, "RHV - DETECCAO DE RNA DO HIV-1", 65.00m },
                    { 27, 3m, "HPC - PESQUISA DE ANTICORPOS CONTRA O VIRUS DA HEPATITE C (ANTI-HCV)", 18.55m }
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "examId", "deliveryDays", "description", "price" },
                values: new object[,]
                {
                    { 28, 2m, "DT3 - DOSAGEM DE TRIIODOTIRONINA (T3)", 8.71m },
                    { 29, 11m, "DT4 - DOSAGEM DE TIROXINA (T4)", 8.76m },
                    { 30, 6m, "DES - DOSAGEM DE ESTRADIOL", 10.15m }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "patientId", "cpf", "name", "phone" },
                values: new object[,]
                {
                    { 1, "74341671920", "Walmir", "5195483921" },
                    { 2, "12345678911", "Rudinei", "5118432950" },
                    { 3, "32215177721", "Amanda", "5114345940" },
                    { 4, "47397069483", "Lucio", "5111111111" },
                    { 5, "11122233344", "Otavio", "51968667432" },
                    { 6, "10594837474", "Luiza", "51934663543" },
                    { 7, "47121131518", "Bruno", "5130303030" },
                    { 8, "58493067251", "Junior", "5100000001" },
                    { 9, "69705847362", "Pedro", "5123456780" },
                    { 10, "11000111010", "Lucas", "51999347589" },
                    { 11, "31415926535", "Carol", "51999323214" },
                    { 12, "27182818284", "William", "51923142134" },
                    { 13, "12347658761", "Beatriz", "51940028922" },
                    { 14, "9638527410", "Maria", "51985209630" },
                    { 15, "32165498736", "Antoniela", "51978945612" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_crm",
                table: "Doctors",
                column: "crm",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_cpf",
                table: "Patients",
                column: "cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RequestExams_requestId",
                table: "RequestExams",
                column: "requestId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_doctorId",
                table: "Requests",
                column: "doctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_patientId",
                table: "Requests",
                column: "patientId");
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
