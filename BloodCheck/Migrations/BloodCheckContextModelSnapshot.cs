﻿// <auto-generated />
using System;
using BloodCheck.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BloodCheck.Migrations
{
    [DbContext(typeof(BloodCheckContext))]
    partial class BloodCheckContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BloodCheck.Models.Doctor", b =>
                {
                    b.Property<int>("idDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idDoctor"), 1L, 1);

                    b.Property<string>("crm")
                        .HasColumnType("char(6)")
                        .HasColumnName("crm");

                    b.Property<string>("name")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("idDoctor")
                        .HasName("id Doctors");

                    b.ToTable("Doctors", (string)null);
                });

            modelBuilder.Entity("BloodCheck.Models.Exam", b =>
                {
                    b.Property<int>("idExam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idExam"), 1L, 1);

                    b.Property<decimal>("deliveryDays")
                        .HasColumnType("numeric(2)")
                        .HasColumnName("deliveryDays");

                    b.Property<string>("description")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("description");

                    b.Property<decimal>("price")
                        .HasColumnType("numeric(5,2)")
                        .HasColumnName("price");

                    b.HasKey("idExam")
                        .HasName("idExam");

                    b.ToTable("Exams", (string)null);
                });

            modelBuilder.Entity("BloodCheck.Models.Patient", b =>
                {
                    b.Property<int>("idPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idPatient"), 1L, 1);

                    b.Property<string>("cpf")
                        .HasColumnType("varchar(11)")
                        .HasColumnName("cpf");

                    b.Property<string>("name")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("phone")
                        .HasColumnType("varchar(11)")
                        .HasColumnName("phone");

                    b.HasKey("idPatient")
                        .HasName("id Patients");

                    b.ToTable("Patients", (string)null);
                });

            modelBuilder.Entity("BloodCheck.Models.Request", b =>
                {
                    b.Property<int>("idRequest")
                        .HasColumnType("int");

                    b.Property<decimal>("idPatient")
                        .HasColumnType("numeric(4)")
                        .HasColumnName("idPatient");

                    b.Property<decimal>("idDoctor")
                        .HasColumnType("numeric(4)")
                        .HasColumnName("idDoctor");

                    b.Property<DateTime>("requestDate")
                        .HasColumnType("date")
                        .HasColumnName("requestDate");

                    b.HasKey("idRequest", "idPatient", "idDoctor")
                        .HasName("id Requests");

                    b.ToTable("Requests", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
