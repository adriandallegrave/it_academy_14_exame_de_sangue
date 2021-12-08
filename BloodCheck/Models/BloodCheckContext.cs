using Microsoft.EntityFrameworkCore;
///////////////////////////////////////////
using System.ComponentModel.DataAnnotations;

namespace BloodCheck.Models;

public class BloodCheckContext : DbContext
{
    public BloodCheckContext(DbContextOptions<BloodCheckContext> options) : base(options)
    {
    }
    public BloodCheckContext()
    {
    }
    
    /*
        Table names
    */
    public DbSet<Patient> Patients {get; set;} = null!;
    public DbSet<Doctor> Doctors {get; set;} = null!;
    public DbSet<Exam> Exams {get; set;} = null!;
    public DbSet<Request> Requests {get; set;} = null!;
    public DbSet<RequestExam> RequestExams {get; set;} = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Exam>()
            .ToTable("Exams")
            .HasKey(t => t.examId)
            .HasName("Id Exam");
        modelBuilder.Entity<Exam>()
            .Property(t => t.price)
            .HasColumnName("price")
            .HasColumnType("numeric(5,2)");
        modelBuilder.Entity<Exam>()
            .Property(t => t.description)
            .HasColumnName("description")
            .HasColumnType("varchar(255)");
        modelBuilder.Entity<Exam>()
            .Property(t => t.deliveryDays)
            .HasColumnName("deliveryDays")
            .HasColumnType("numeric(2)");

        modelBuilder.Entity<Patient>()
            .ToTable("Patients")
            .HasKey(t => t.patientId)
            .HasName("id Patients");
        modelBuilder.Entity<Patient>()
            .Property(t => t.name)
            .HasColumnName("name")
            .HasColumnType("varchar(50)")
            .IsRequired();
        modelBuilder.Entity<Patient>()
            .Property(t => t.cpf)
            .HasColumnName("cpf")
            .HasColumnType("char(11)")
            .IsRequired();
        modelBuilder.Entity<Patient>()
            .Property(t => t.phone)
            .HasColumnName("phone")
            .HasColumnType("varchar(11)")
            .IsRequired();

        modelBuilder.Entity<Doctor>()
            .ToTable("Doctors")
            .HasKey(t => t.doctorId)
            .HasName("id Doctors");
        modelBuilder.Entity<Doctor>()
            .Property(t => t.crm)
            .HasColumnName("crm")
            .HasColumnType("char(6)")
            .IsRequired();
        modelBuilder.Entity<Doctor>()
            .Property(t => t.name)
            .HasColumnName("name")
            .HasColumnType("varchar(50)")
            .IsRequired();
        
        modelBuilder.Entity<Request>()
            .ToTable("Requests")
            .HasKey(t => t.requestId)
            .HasName("id Requests");
        modelBuilder.Entity<Request>()
            .Property(t => t.patientId)
            .HasColumnName("patientId")
            .HasColumnType("numeric(4)");
        modelBuilder.Entity<Request>()
            .Property(t => t.doctorId)
            .HasColumnName("doctorId")
            .HasColumnType("numeric(4)");
        modelBuilder.Entity<Request>()
            .Property(t => t.requestDate)
            .HasColumnName("requestDate")
            .HasColumnType("date");
                  
    
        // n to n RequestExam
        modelBuilder.Entity<Request>()
            .HasMany(e => e.Exams)
            .WithMany(e => e.Requests)
            .UsingEntity<RequestExam>();
    }
}
