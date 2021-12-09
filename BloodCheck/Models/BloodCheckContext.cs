using Microsoft.EntityFrameworkCore;

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
    
    public DbSet<Patient> Patients { get; set; } = null!;
    public DbSet<Doctor> Doctors { get; set; } = null!;
    public DbSet<Exam> Exams { get; set; } = null!;
    public DbSet<Request> Requests { get; set; } = null!;
    public DbSet<RequestExam> RequestExams { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Database scheme.
        
        // Table: Exam.
        modelBuilder.Entity<Exam>()
            .ToTable("Exams")
            .HasKey(t => t.ExamId)
            .HasName("ExamId");
        modelBuilder.Entity<Exam>()
            .Property(t => t.Price)
            .HasColumnName("price")
            .HasColumnType("numeric(5,2)");
        modelBuilder.Entity<Exam>()
            .Property(t => t.Description)
            .HasColumnName("description")
            .HasColumnType("varchar(255)");
        modelBuilder.Entity<Exam>()
            .Property(t => t.DeliveryDays)
            .HasColumnName("deliveryDays")
            .HasColumnType("numeric(2)");

        // Table: Patients.
        modelBuilder.Entity<Patient>()
            .ToTable("Patients")
            .HasKey(t => t.PatientId)
            .HasName("patientId");
        modelBuilder.Entity<Patient>()
            .Property(t => t.Name)
            .HasColumnName("name")
            .HasColumnType("varchar(50)")
            .IsRequired();
        modelBuilder.Entity<Patient>()
            .Property(t => t.Cpf)
            .HasColumnName("cpf")
            .HasColumnType("char(11)")
            .IsRequired();
        modelBuilder.Entity<Patient>()
            .HasIndex(t => t.Cpf)
            .IsUnique();
        modelBuilder.Entity<Patient>()
            .Property(t => t.Phone)
            .HasColumnName("phone")
            .HasColumnType("varchar(11)")
            .IsRequired();
        
        // Table: Doctors.
        modelBuilder.Entity<Doctor>()
            .ToTable("Doctors")
            .HasKey(t => t.DoctorId)
            .HasName("doctorId");    
        modelBuilder.Entity<Doctor>()
            .Property(t => t.Crm)
            .HasColumnName("crm")
            .HasColumnType("char(6)")
            .IsRequired();
        modelBuilder.Entity<Doctor>()
            .HasIndex(t => t.Crm)
            .IsUnique();
        modelBuilder.Entity<Doctor>()
            .Property(t => t.Name)
            .HasColumnName("name")
            .HasColumnType("varchar(50)")
            .IsRequired();
        
        // Table: Requests.
        modelBuilder.Entity<Request>()
            .ToTable("Requests")
            .HasKey(t => t.RequestId)
            .HasName("requestId");
        modelBuilder.Entity<Request>()
            .Property(t => t.PatientId)
            .HasColumnName("patientId");
        modelBuilder.Entity<Request>()
            .Property(t => t.DoctorId)
            .HasColumnName("doctorId");
        modelBuilder.Entity<Request>()
            .Property(t => t.RequestDate)
            .HasColumnName("requestDate")
            .HasColumnType("date");

        // N to N RequestExam.
        modelBuilder.Entity<Request>()
            .HasMany(e => e.Exams)
            .WithMany(e => e.Requests)
            .UsingEntity<RequestExam>();

        // Inserts in doctors (15 doctors).
        modelBuilder.Entity<Doctor>().HasData(
            new Doctor { DoctorId = 1, Crm = "143523", Name = "Julia" },
            new Doctor { DoctorId = 2, Crm = "444444", Name = "Alice" },
            new Doctor { DoctorId = 3, Crm = "309345", Name = "Arthur" },
            new Doctor { DoctorId = 4, Crm = "940481", Name = "Yasmin" },
            new Doctor { DoctorId = 5, Crm = "482345", Name = "Jorge" },
            new Doctor { DoctorId = 6, Crm = "935612", Name = "Ronaldo" },
            new Doctor { DoctorId = 7, Crm = "277077", Name = "Cleide" },
            new Doctor { DoctorId = 8, Crm = "761161", Name = "Clarissa" },
            new Doctor { DoctorId = 9, Crm = "292392", Name = "Joao" },
            new Doctor { DoctorId = 10, Crm = "545454", Name = "Vitor" },
            new Doctor { DoctorId = 11, Crm = "723456", Name = "Gustavo" },
            new Doctor { DoctorId = 12, Crm = "111111", Name = "Elise" },
            new Doctor { DoctorId = 13, Crm = "334345", Name = "Paulo" },
            new Doctor { DoctorId = 14, Crm = "934594", Name = "Godofreda" },
            new Doctor { DoctorId = 15, Crm = "869233", Name = "Elias" }
        );
        
         // Inserts in patients (15 pacients).
         modelBuilder.Entity<Patient>().HasData(
             new Patient { PatientId = 1, Name = "Walmir", Cpf = "74341671920", Phone = "5195483921" },
             new Patient { PatientId = 2, Name = "Rudinei", Cpf = "12345678911", Phone = "5118432950" },
             new Patient { PatientId = 3, Name = "Amanda", Cpf = "32215177721", Phone = "5114345940" },
             new Patient { PatientId = 4, Name = "Lucio", Cpf = "47397069483", Phone = "5111111111" },
             new Patient { PatientId = 5, Name = "Otavio", Cpf = "11122233344", Phone = "51968667432" },
             new Patient { PatientId = 6, Name = "Luiza", Cpf = "10594837474", Phone = "51934663543" },
             new Patient { PatientId = 7, Name = "Bruno", Cpf = "47121131518", Phone = "5130303030" },
             new Patient { PatientId = 8, Name = "Junior", Cpf = "58493067251", Phone = "5100000001" },
             new Patient { PatientId = 9, Name = "Pedro", Cpf = "69705847362", Phone = "5123456780" },
             new Patient { PatientId = 10, Name = "Lucas", Cpf = "11000111010", Phone = "51999347589" },
             new Patient { PatientId = 11, Name = "Carol", Cpf = "31415926535", Phone = "51999323214" },
             new Patient { PatientId = 12, Name = "William", Cpf = "27182818284", Phone = "51923142134" },
             new Patient { PatientId = 13, Name = "Beatriz", Cpf = "12347658761", Phone = "51940028922" },
             new Patient { PatientId = 14, Name = "Maria", Cpf = "9638527410", Phone = "51985209630" },
             new Patient { PatientId = 15, Name = "Antoniela", Cpf = "32165498736", Phone = "51978945612" }
         );

        // Insert in exams (30 exams).
        modelBuilder.Entity<Exam>().HasData(
            new Exam { ExamId = 1, Price = 5.77M, Description = "TTA - TEMPO DE TROMBOPLASTINA ATIVADA", DeliveryDays = 2 },
            new Exam { ExamId = 2, Price = 1.85M, Description = "DAU - DOSAGEM DE ACIDO URICO", DeliveryDays = 3 },
            new Exam { ExamId = 3, Price = 3.68M, Description = "DAG - DOSAGEM DE ALFA-1-GLICOPROTEINA ACIDA", DeliveryDays = 3 },
            new Exam { ExamId = 4, Price = 2.25M, Description = "DAL - DOSAGEM DE AMILASE", DeliveryDays = 7 },
            new Exam { ExamId = 5, Price = 2.01M, Description = "DBF - DOSAGEM DE BILIRRUBINA TOTAL E FRACOES", DeliveryDays = 5 },
            new Exam { ExamId = 6, Price = 1.85M, Description = "DCA - DOSAGEM DE CALCIO", DeliveryDays = 12 },
            new Exam { ExamId = 7, Price = 3.68M, Description = "DAA - DOSAGEM DE ALFA-1-GLICOPROTEINA ACIDA", DeliveryDays = 2 },
            new Exam { ExamId = 8, Price = 1.85M, Description = "DDS - DOSAGEM DE SODIO", DeliveryDays = 1 },
            new Exam { ExamId = 9, Price = 12.54M, Description = "DIT - DETERMINACAO DE INDICE DE TIROXINA LIVRE", DeliveryDays = 6 },
            new Exam { ExamId = 10, Price = 9.00M , Description = "DSI - DETERMINACAO DE TEMPO DE SANGRAMENTO DE IVY", DeliveryDays = 8 },
            new Exam { ExamId = 11, Price = 16.97M, Description = "PAA - PESQUISA DE ANTICORPOS IGG ANTITOXOPLASMA", DeliveryDays = 3 },
            new Exam { ExamId = 12, Price = 1.53M, Description = "DDH - DOSAGEM DE HEMOGLOBINA", DeliveryDays = 4 },
            new Exam { ExamId = 13, Price = 2.83M, Description = "DFR - DETERMINACAO DE FATOR REUMATOIDE", DeliveryDays = 6 },
            new Exam { ExamId = 14, Price = 3.93M, Description = "DPR - DOSAGEM DE PROTEINA C REATIVA", DeliveryDays = 1 },
            new Exam { ExamId = 15, Price = 10.00M, Description = "TFS - TESTE FTA-ABS IGG P/ DIAGNOSTICO DA SIFIL", DeliveryDays = 5 },
            new Exam { ExamId = 16, Price = 18.55M, Description = "PAI - PESQUISA DE ANTICORPOS IGM ANTITOXOPLASM", DeliveryDays = 13 },
            new Exam { ExamId = 17, Price = 18.55M, Description = "DUR - DOSAGEM DE UREIA", DeliveryDays = 5 },
            new Exam { ExamId = 18, Price = 10.15M, Description = "DDP - DOSAGEM DE PROLACTINA", DeliveryDays = 3 },
            new Exam { ExamId = 19, Price = 10.00M, Description = "TDF - TESTE FTA-ABS IGG P/ DIAGNOSTICO DA SIFILIS", DeliveryDays = 10 },
            new Exam { ExamId = 20, Price = 10.43M, Description = "DDT - DOSAGEM DE TESTOSTERONA", DeliveryDays = 12 },
            new Exam { ExamId = 21, Price = 4.98M, Description = "ABG - ANTIBIOGRAMA", DeliveryDays = 8  },
            new Exam { ExamId = 22, Price = 2.73M, Description = "CDT - CONTAGEM DE RETICULOCITOS", DeliveryDays = 4 },
            new Exam { ExamId = 23, Price = 1.37M, Description = "PRH - PESQUISA DE FATOR RH (I", DeliveryDays = 3 },
            new Exam { ExamId = 24, Price = 15.59M, Description = "DFR - DOSAGEM DE FERRITINA", DeliveryDays = 5 },
            new Exam { ExamId = 25, Price = 1.85M, Description = "DFF - DOSAGEM DE FOSFORO", DeliveryDays = 7 },
            new Exam { ExamId = 26, Price = 65.00M, Description = "RHV - DETECCAO DE RNA DO HIV-1", DeliveryDays = 9 },
            new Exam { ExamId = 27, Price = 18.55M, Description = "HPC - PESQUISA DE ANTICORPOS CONTRA O VIRUS DA HEPATITE C (ANTI-HCV)", DeliveryDays = 3 },
            new Exam { ExamId = 28, Price = 8.71M, Description = "DT3 - DOSAGEM DE TRIIODOTIRONINA (T3)", DeliveryDays = 2 },
            new Exam { ExamId = 29, Price = 8.76M, Description = "DT4 - DOSAGEM DE TIROXINA (T4)", DeliveryDays = 11 },
            new Exam { ExamId = 30, Price = 10.15M, Description = "DES - DOSAGEM DE ESTRADIOL", DeliveryDays = 6 }
        );
    }
}
