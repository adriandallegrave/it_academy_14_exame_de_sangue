namespace BloodCheck.Models;

public class Request
{
    public int requestId { get; set; }

    // Create foreign key Patient (Request many to 1 Patient).
    public int patientId { get; set; }
    public Patient? Patient { get; set; }
    
    // Create foreign key Doctor (Request many to 1 Doctor).
    public int doctorId { get; set; }
    public Doctor? Doctor { get; set; }
    
    public DateTime requestDate { get; set; }

    // List and interface to generate foreign key (Request many to many Exam).
    public List<RequestExam> RequestExams { get; set; } = null!;
    public ICollection<Exam> Exams { get; set; } = null!;
}
