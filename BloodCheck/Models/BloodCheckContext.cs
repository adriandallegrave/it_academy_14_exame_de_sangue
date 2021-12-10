using Microsoft.EntityFrameworkCore;
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
    
    // Table names.
    
    public DbSet<Patient> Patients {get; set;} = null!;
    public DbSet<Doctor> Doctors {get; set;} = null!;
    public DbSet<Exam> Exams {get; set;} = null!;
    public DbSet<Request> Requests {get; set;} = null!;
    public DbSet<RequestExam> RequestExams {get; set;} = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Database scheme.
        
        // Table: Exam.
        modelBuilder.Entity<Exam>()
            .ToTable("Exams")
            .HasKey(t => t.examId)
            .HasName("examId");
        modelBuilder.Entity<Exam>()
            .Property(t => t.price)
            .HasColumnName("price")
            .HasColumnType("numeric(5,2)");
        modelBuilder.Entity<Exam>()
            .Property(t => t.description)
            .HasColumnName("description")
            .HasColumnType("varchar(255)")
            .IsRequired();
        modelBuilder.Entity<Exam>()
            .Property(t => t.deliveryDays)
            .HasColumnName("deliveryDays")
            .HasColumnType("numeric(2)");

        // Table: Patients.
        modelBuilder.Entity<Patient>()
            .ToTable("Patients")
            .HasKey(t => t.patientId)
            .HasName("patientId");
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
            .HasIndex(t => t.cpf)
            .IsUnique();
        modelBuilder.Entity<Patient>()
            .Property(t => t.phone)
            .HasColumnName("phone")
            .HasColumnType("varchar(11)")
            .IsRequired();
        
        // Table: Doctors.
        modelBuilder.Entity<Doctor>()
            .ToTable("Doctors")
            .HasKey(t => t.doctorId)
            .HasName("doctorId");    
        modelBuilder.Entity<Doctor>()
            .Property(t => t.crm)
            .HasColumnName("crm")
            .HasColumnType("char(6)")
            .IsRequired();
        modelBuilder.Entity<Doctor>()
            .HasIndex(t => t.crm)
            .IsUnique();
        modelBuilder.Entity<Doctor>()
            .Property(t => t.name)
            .HasColumnName("name")
            .HasColumnType("varchar(50)")
            .IsRequired();
        
        // Table: Requests.
        modelBuilder.Entity<Request>()
            .ToTable("Requests")
            .HasKey(t => t.requestId)
            .HasName("requestId");
        modelBuilder.Entity<Request>()
            .Property(t => t.patientId)
            .HasColumnName("patientId");
        modelBuilder.Entity<Request>()
            .Property(t => t.doctorId)
            .HasColumnName("doctorId");
        modelBuilder.Entity<Request>()
            .Property(t => t.requestDate)
            .HasColumnName("requestDate")
            .HasColumnType("date");

        // N to N RequestExam.
        modelBuilder.Entity<Request>()
            .HasMany(e => e.Exams)
            .WithMany(e => e.Requests)
            .UsingEntity<RequestExam>();

        // Inserts in doctors (15 doctors).
        modelBuilder.Entity<Doctor>().HasData(
            new Doctor { doctorId = 1, crm = "143523", name = "Julia" },
            new Doctor { doctorId = 2, crm = "444444", name = "Alice" },
            new Doctor { doctorId = 3, crm = "309345", name = "Arthur" },
            new Doctor { doctorId = 4, crm = "940481", name = "Yasmin" },
            new Doctor { doctorId = 5, crm = "482345", name = "Jorge" },
            new Doctor { doctorId = 6, crm = "935612", name = "Ronaldo" },
            new Doctor { doctorId = 7, crm = "277077", name = "Cleide" },
            new Doctor { doctorId = 8, crm = "761161", name = "Clarissa" },
            new Doctor { doctorId = 9, crm = "292392", name = "Joao" },
            new Doctor { doctorId = 10, crm = "545454", name = "Vitor" },
            new Doctor { doctorId = 11, crm = "723456", name = "Gustavo" },
            new Doctor { doctorId = 12, crm = "111111", name = "Elise" },
            new Doctor { doctorId = 13, crm = "334345", name = "Paulo" },
            new Doctor { doctorId = 14, crm = "934594", name = "Godofreda" },
            new Doctor { doctorId = 15, crm = "869233", name = "Elias" }
        );
        
         // Inserts in patients (15 pacients).
         modelBuilder.Entity<Patient>().HasData(
             new Patient { patientId = 1, name = "Walmir", cpf = "74341671920", phone = "5195483921" },
             new Patient { patientId = 2, name = "Rudinei", cpf = "12345678911", phone = "5118432950" },
             new Patient { patientId = 3, name = "Amanda", cpf = "32215177721", phone = "5114345940" },
             new Patient { patientId = 4, name = "Lucio", cpf = "47397069483", phone = "5111111111" },
             new Patient { patientId = 5, name = "Otavio", cpf = "11122233344", phone = "51968667432" },
             new Patient { patientId = 6, name = "Luiza", cpf = "10594837474", phone = "51934663543" },
             new Patient { patientId = 7, name = "Bruno", cpf = "47121131518", phone = "5130303030" },
             new Patient { patientId = 8, name = "Junior", cpf = "58493067251", phone = "5100000001" },
             new Patient { patientId = 9, name = "Pedro", cpf = "69705847362", phone = "5123456780" },
             new Patient { patientId = 10, name = "Lucas", cpf = "11000111010", phone = "51999347589" },
             new Patient { patientId = 11, name = "Carol", cpf = "31415926535", phone = "51999323214" },
             new Patient { patientId = 12, name = "William", cpf = "27182818284", phone = "51923142134" },
             new Patient { patientId = 13, name = "Beatriz", cpf = "12347658761", phone = "51940028922" },
             new Patient { patientId = 14, name = "Maria", cpf = "9638527410", phone = "51985209630" },
             new Patient { patientId = 15, name = "Antoniela", cpf = "32165498736", phone = "51978945612" }
         );

        // Insert in exams (30 exams).
        modelBuilder.Entity<Exam>().HasData(
            new Exam { examId = 1, price = 5.77M, description = "TTA - TEMPO DE TROMBOPLASTINA ATIVADA", deliveryDays = 2 },
            new Exam { examId = 2, price = 1.85M, description = "DAU - DOSAGEM DE ACIDO URICO", deliveryDays = 3 },
            new Exam { examId = 3, price = 3.68M, description = "DAG - DOSAGEM DE ALFA-1-GLICOPROTEINA ACIDA", deliveryDays = 3 },
            new Exam { examId = 4, price = 2.25M, description = "DAL - DOSAGEM DE AMILASE", deliveryDays = 7 },
            new Exam { examId = 5, price = 2.01M, description = "DBF - DOSAGEM DE BILIRRUBINA TOTAL E FRACOES", deliveryDays = 5 },
            new Exam { examId = 6, price = 1.85M, description = "DCA - DOSAGEM DE CALCIO", deliveryDays = 12 },
            new Exam { examId = 7, price = 3.68M, description = "DAA - DOSAGEM DE ALFA-1-GLICOPROTEINA ACIDA", deliveryDays = 2 },
            new Exam { examId = 8, price = 1.85M, description = "DDS - DOSAGEM DE SODIO", deliveryDays = 1 },
            new Exam { examId = 9, price = 12.54M, description = "DIT - DETERMINACAO DE INDICE DE TIROXINA LIVRE", deliveryDays = 6 },
            new Exam { examId = 10, price = 9.00M , description = "DSI - DETERMINACAO DE TEMPO DE SANGRAMENTO DE IVY", deliveryDays = 8 },
            new Exam { examId = 11, price = 16.97M, description = "PAA - PESQUISA DE ANTICORPOS IGG ANTITOXOPLASMA", deliveryDays = 3 },
            new Exam { examId = 12, price = 1.53M, description = "DDH - DOSAGEM DE HEMOGLOBINA", deliveryDays = 4 },
            new Exam { examId = 13, price = 2.83M, description = "DFR - DETERMINACAO DE FATOR REUMATOIDE", deliveryDays = 6 },
            new Exam { examId = 14, price = 3.93M, description = "DPR - DOSAGEM DE PROTEINA C REATIVA", deliveryDays = 1 },
            new Exam { examId = 15, price = 10.00M, description = "TFS - TESTE FTA-ABS IGG P/ DIAGNOSTICO DA SIFIL", deliveryDays = 5 },
            new Exam { examId = 16, price = 18.55M, description = "PAI - PESQUISA DE ANTICORPOS IGM ANTITOXOPLASM", deliveryDays = 13 },
            new Exam { examId = 17, price = 18.55M, description = "DUR - DOSAGEM DE UREIA", deliveryDays = 5 },
            new Exam { examId = 18, price = 10.15M, description = "DDP - DOSAGEM DE PROLACTINA", deliveryDays = 3 },
            new Exam { examId = 19, price = 10.00M, description = "TDF - TESTE FTA-ABS IGG P/ DIAGNOSTICO DA SIFILIS", deliveryDays = 10 },
            new Exam { examId = 20, price = 10.43M, description = "DDT - DOSAGEM DE TESTOSTERONA", deliveryDays = 12 },
            new Exam { examId = 21, price = 4.98M, description = "ABG - ANTIBIOGRAMA", deliveryDays = 8  },
            new Exam { examId = 22, price = 2.73M, description = "CDT - CONTAGEM DE RETICULOCITOS", deliveryDays = 4 },
            new Exam { examId = 23, price = 1.37M, description = "PRH - PESQUISA DE FATOR RH (I", deliveryDays = 3 },
            new Exam { examId = 24, price = 15.59M, description = "DFR - DOSAGEM DE FERRITINA", deliveryDays = 5 },
            new Exam { examId = 25, price = 1.85M, description = "DFF - DOSAGEM DE FOSFORO", deliveryDays = 7 },
            new Exam { examId = 26, price = 65.00M, description = "RHV - DETECCAO DE RNA DO HIV-1", deliveryDays = 9 },
            new Exam { examId = 27, price = 18.55M, description = "HPC - PESQUISA DE ANTICORPOS CONTRA O VIRUS DA HEPATITE C (ANTI-HCV)", deliveryDays = 3 },
            new Exam { examId = 28, price = 8.71M, description = "DT3 - DOSAGEM DE TRIIODOTIRONINA (T3)", deliveryDays = 2 },
            new Exam { examId = 29, price = 8.76M, description = "DT4 - DOSAGEM DE TIROXINA (T4)", deliveryDays = 11 },
            new Exam { examId = 30, price = 10.15M, description = "DES - DOSAGEM DE ESTRADIOL", deliveryDays = 6 }
        );
    }
}
