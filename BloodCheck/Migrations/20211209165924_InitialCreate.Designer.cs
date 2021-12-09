﻿// <auto-generated />
using System;
using BloodCheck.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BloodCheck.Migrations
{
    [DbContext(typeof(BloodCheckContext))]
    [Migration("20211209165924_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BloodCheck.Models.Doctor", b =>
                {
                    b.Property<int>("doctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("doctorId"), 1L, 1);

                    b.Property<string>("crm")
                        .IsRequired()
                        .HasColumnType("char(6)")
                        .HasColumnName("crm");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("doctorId")
                        .HasName("doctorId");

                    b.HasIndex("crm")
                        .IsUnique();

                    b.ToTable("Doctors", (string)null);

                    b.HasData(
                        new
                        {
                            doctorId = 1,
                            crm = "143523",
                            name = "Julia"
                        },
                        new
                        {
                            doctorId = 2,
                            crm = "444444",
                            name = "Alice"
                        },
                        new
                        {
                            doctorId = 3,
                            crm = "309345",
                            name = "Arthur"
                        },
                        new
                        {
                            doctorId = 4,
                            crm = "940481",
                            name = "Yasmin"
                        },
                        new
                        {
                            doctorId = 5,
                            crm = "482345",
                            name = "Jorge"
                        },
                        new
                        {
                            doctorId = 6,
                            crm = "935612",
                            name = "Ronaldo"
                        },
                        new
                        {
                            doctorId = 7,
                            crm = "277077",
                            name = "Cleide"
                        },
                        new
                        {
                            doctorId = 8,
                            crm = "761161",
                            name = "Clarissa"
                        },
                        new
                        {
                            doctorId = 9,
                            crm = "292392",
                            name = "Joao"
                        },
                        new
                        {
                            doctorId = 10,
                            crm = "545454",
                            name = "Vitor"
                        },
                        new
                        {
                            doctorId = 11,
                            crm = "723456",
                            name = "Gustavo"
                        },
                        new
                        {
                            doctorId = 12,
                            crm = "111111",
                            name = "Elise"
                        },
                        new
                        {
                            doctorId = 13,
                            crm = "334345",
                            name = "Paulo"
                        },
                        new
                        {
                            doctorId = 14,
                            crm = "934594",
                            name = "Godofreda"
                        },
                        new
                        {
                            doctorId = 15,
                            crm = "869233",
                            name = "Elias"
                        });
                });

            modelBuilder.Entity("BloodCheck.Models.Exam", b =>
                {
                    b.Property<int>("examId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("examId"), 1L, 1);

                    b.Property<decimal>("deliveryDays")
                        .HasColumnType("numeric(2)")
                        .HasColumnName("deliveryDays");

                    b.Property<string>("description")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("description");

                    b.Property<decimal>("price")
                        .HasColumnType("numeric(5,2)")
                        .HasColumnName("price");

                    b.HasKey("examId")
                        .HasName("ExamId");

                    b.ToTable("Exams", (string)null);

                    b.HasData(
                        new
                        {
                            examId = 1,
                            deliveryDays = 2m,
                            description = "TTA - TEMPO DE TROMBOPLASTINA ATIVADA",
                            price = 5.77m
                        },
                        new
                        {
                            examId = 2,
                            deliveryDays = 3m,
                            description = "DAU - DOSAGEM DE ACIDO URICO",
                            price = 1.85m
                        },
                        new
                        {
                            examId = 3,
                            deliveryDays = 3m,
                            description = "DAG - DOSAGEM DE ALFA-1-GLICOPROTEINA ACIDA",
                            price = 3.68m
                        },
                        new
                        {
                            examId = 4,
                            deliveryDays = 7m,
                            description = "DAL - DOSAGEM DE AMILASE",
                            price = 2.25m
                        },
                        new
                        {
                            examId = 5,
                            deliveryDays = 5m,
                            description = "DBF - DOSAGEM DE BILIRRUBINA TOTAL E FRACOES",
                            price = 2.01m
                        },
                        new
                        {
                            examId = 6,
                            deliveryDays = 12m,
                            description = "DCA - DOSAGEM DE CALCIO",
                            price = 1.85m
                        },
                        new
                        {
                            examId = 7,
                            deliveryDays = 2m,
                            description = "DAA - DOSAGEM DE ALFA-1-GLICOPROTEINA ACIDA",
                            price = 3.68m
                        },
                        new
                        {
                            examId = 8,
                            deliveryDays = 1m,
                            description = "DDS - DOSAGEM DE SODIO",
                            price = 1.85m
                        },
                        new
                        {
                            examId = 9,
                            deliveryDays = 6m,
                            description = "DIT - DETERMINACAO DE INDICE DE TIROXINA LIVRE",
                            price = 12.54m
                        },
                        new
                        {
                            examId = 10,
                            deliveryDays = 8m,
                            description = "DSI - DETERMINACAO DE TEMPO DE SANGRAMENTO DE IVY",
                            price = 9.00m
                        },
                        new
                        {
                            examId = 11,
                            deliveryDays = 3m,
                            description = "PAA - PESQUISA DE ANTICORPOS IGG ANTITOXOPLASMA",
                            price = 16.97m
                        },
                        new
                        {
                            examId = 12,
                            deliveryDays = 4m,
                            description = "DDH - DOSAGEM DE HEMOGLOBINA",
                            price = 1.53m
                        },
                        new
                        {
                            examId = 13,
                            deliveryDays = 6m,
                            description = "DFR - DETERMINACAO DE FATOR REUMATOIDE",
                            price = 2.83m
                        },
                        new
                        {
                            examId = 14,
                            deliveryDays = 1m,
                            description = "DPR - DOSAGEM DE PROTEINA C REATIVA",
                            price = 3.93m
                        },
                        new
                        {
                            examId = 15,
                            deliveryDays = 5m,
                            description = "TFS - TESTE FTA-ABS IGG P/ DIAGNOSTICO DA SIFIL",
                            price = 10.00m
                        },
                        new
                        {
                            examId = 16,
                            deliveryDays = 13m,
                            description = "PAI - PESQUISA DE ANTICORPOS IGM ANTITOXOPLASM",
                            price = 18.55m
                        },
                        new
                        {
                            examId = 17,
                            deliveryDays = 5m,
                            description = "DUR - DOSAGEM DE UREIA",
                            price = 18.55m
                        },
                        new
                        {
                            examId = 18,
                            deliveryDays = 3m,
                            description = "DDP - DOSAGEM DE PROLACTINA",
                            price = 10.15m
                        },
                        new
                        {
                            examId = 19,
                            deliveryDays = 10m,
                            description = "TDF - TESTE FTA-ABS IGG P/ DIAGNOSTICO DA SIFILIS",
                            price = 10.00m
                        },
                        new
                        {
                            examId = 20,
                            deliveryDays = 12m,
                            description = "DDT - DOSAGEM DE TESTOSTERONA",
                            price = 10.43m
                        },
                        new
                        {
                            examId = 21,
                            deliveryDays = 8m,
                            description = "ABG - ANTIBIOGRAMA",
                            price = 4.98m
                        },
                        new
                        {
                            examId = 22,
                            deliveryDays = 4m,
                            description = "CDT - CONTAGEM DE RETICULOCITOS",
                            price = 2.73m
                        },
                        new
                        {
                            examId = 23,
                            deliveryDays = 3m,
                            description = "PRH - PESQUISA DE FATOR RH (I",
                            price = 1.37m
                        },
                        new
                        {
                            examId = 24,
                            deliveryDays = 5m,
                            description = "DFR - DOSAGEM DE FERRITINA",
                            price = 15.59m
                        },
                        new
                        {
                            examId = 25,
                            deliveryDays = 7m,
                            description = "DFF - DOSAGEM DE FOSFORO",
                            price = 1.85m
                        },
                        new
                        {
                            examId = 26,
                            deliveryDays = 9m,
                            description = "RHV - DETECCAO DE RNA DO HIV-1",
                            price = 65.00m
                        },
                        new
                        {
                            examId = 27,
                            deliveryDays = 3m,
                            description = "HPC - PESQUISA DE ANTICORPOS CONTRA O VIRUS DA HEPATITE C (ANTI-HCV)",
                            price = 18.55m
                        },
                        new
                        {
                            examId = 28,
                            deliveryDays = 2m,
                            description = "DT3 - DOSAGEM DE TRIIODOTIRONINA (T3)",
                            price = 8.71m
                        },
                        new
                        {
                            examId = 29,
                            deliveryDays = 11m,
                            description = "DT4 - DOSAGEM DE TIROXINA (T4)",
                            price = 8.76m
                        },
                        new
                        {
                            examId = 30,
                            deliveryDays = 6m,
                            description = "DES - DOSAGEM DE ESTRADIOL",
                            price = 10.15m
                        });
                });

            modelBuilder.Entity("BloodCheck.Models.Patient", b =>
                {
                    b.Property<int>("patientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("patientId"), 1L, 1);

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("char(11)")
                        .HasColumnName("cpf");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("phone");

                    b.HasKey("patientId")
                        .HasName("patientId");

                    b.HasIndex("cpf")
                        .IsUnique();

                    b.ToTable("Patients", (string)null);

                    b.HasData(
                        new
                        {
                            patientId = 1,
                            cpf = "74341671920",
                            name = "Walmir",
                            phone = "5195483921"
                        },
                        new
                        {
                            patientId = 2,
                            cpf = "12345678911",
                            name = "Rudinei",
                            phone = "5118432950"
                        },
                        new
                        {
                            patientId = 3,
                            cpf = "32215177721",
                            name = "Amanda",
                            phone = "5114345940"
                        },
                        new
                        {
                            patientId = 4,
                            cpf = "47397069483",
                            name = "Lucio",
                            phone = "5111111111"
                        },
                        new
                        {
                            patientId = 5,
                            cpf = "11122233344",
                            name = "Otavio",
                            phone = "51968667432"
                        },
                        new
                        {
                            patientId = 6,
                            cpf = "10594837474",
                            name = "Luiza",
                            phone = "51934663543"
                        },
                        new
                        {
                            patientId = 7,
                            cpf = "47121131518",
                            name = "Bruno",
                            phone = "5130303030"
                        },
                        new
                        {
                            patientId = 8,
                            cpf = "58493067251",
                            name = "Junior",
                            phone = "5100000001"
                        },
                        new
                        {
                            patientId = 9,
                            cpf = "69705847362",
                            name = "Pedro",
                            phone = "5123456780"
                        },
                        new
                        {
                            patientId = 10,
                            cpf = "11000111010",
                            name = "Lucas",
                            phone = "51999347589"
                        },
                        new
                        {
                            patientId = 11,
                            cpf = "31415926535",
                            name = "Carol",
                            phone = "51999323214"
                        },
                        new
                        {
                            patientId = 12,
                            cpf = "27182818284",
                            name = "William",
                            phone = "51923142134"
                        },
                        new
                        {
                            patientId = 13,
                            cpf = "12347658761",
                            name = "Beatriz",
                            phone = "51940028922"
                        },
                        new
                        {
                            patientId = 14,
                            cpf = "9638527410",
                            name = "Maria",
                            phone = "51985209630"
                        },
                        new
                        {
                            patientId = 15,
                            cpf = "32165498736",
                            name = "Antoniela",
                            phone = "51978945612"
                        });
                });

            modelBuilder.Entity("BloodCheck.Models.Request", b =>
                {
                    b.Property<int>("requestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("requestId"), 1L, 1);

                    b.Property<int>("doctorId")
                        .HasColumnType("int")
                        .HasColumnName("doctorId");

                    b.Property<int>("patientId")
                        .HasColumnType("int")
                        .HasColumnName("patientId");

                    b.Property<DateTime>("requestDate")
                        .HasColumnType("date")
                        .HasColumnName("requestDate");

                    b.HasKey("requestId")
                        .HasName("requestId");

                    b.HasIndex("doctorId");

                    b.HasIndex("patientId");

                    b.ToTable("Requests", (string)null);
                });

            modelBuilder.Entity("BloodCheck.Models.RequestExam", b =>
                {
                    b.Property<int>("examId")
                        .HasColumnType("int");

                    b.Property<int>("requestId")
                        .HasColumnType("int");

                    b.HasKey("examId", "requestId");

                    b.HasIndex("requestId");

                    b.ToTable("RequestExams");
                });

            modelBuilder.Entity("BloodCheck.Models.Request", b =>
                {
                    b.HasOne("BloodCheck.Models.Doctor", "Doctor")
                        .WithMany("Requests")
                        .HasForeignKey("doctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BloodCheck.Models.Patient", "Patient")
                        .WithMany("Requests")
                        .HasForeignKey("patientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("BloodCheck.Models.RequestExam", b =>
                {
                    b.HasOne("BloodCheck.Models.Exam", "Exam")
                        .WithMany("RequestExams")
                        .HasForeignKey("examId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BloodCheck.Models.Request", "Request")
                        .WithMany("RequestExams")
                        .HasForeignKey("requestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Request");
                });

            modelBuilder.Entity("BloodCheck.Models.Doctor", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("BloodCheck.Models.Exam", b =>
                {
                    b.Navigation("RequestExams");
                });

            modelBuilder.Entity("BloodCheck.Models.Patient", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("BloodCheck.Models.Request", b =>
                {
                    b.Navigation("RequestExams");
                });
#pragma warning restore 612, 618
        }
    }
}
