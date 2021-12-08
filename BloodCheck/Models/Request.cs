namespace BloodCheck.Models;

public class Request
{
    public int requestId { get; set; }
    public int patientId { get; set; }
    public Patient? Patient { get; set; }
    public int doctorId { get; set; }
    public Doctor? Doctor { get; set; }
    public DateTime requestDate { get; set; }

    public List<RequestExam> RequestExams { get; set; } = null!;
    public ICollection<Exam> Exams { get; set; } = null!;
}
