namespace BloodCheck.Models;

public class Request
{
    public int RequestId { get; set; }

    // Create foreign key Patient (Request many to 1 Patient).
    public int PatientId { get; set; }
    public Patient? Patient { get; set; }
    
    // Create foreign key Doctor (Request many to 1 Doctor).
    public int DoctorId { get; set; }
    public Doctor? Doctor { get; set; }
    
    public DateTime RequestDate { get; set; }

    // List and interface to generate foreign key (Request many to many Exam).
    public List<RequestExam> RequestExams { get; set; } = null!;
    public ICollection<Exam> Exams { get; set; } = null!;
}
