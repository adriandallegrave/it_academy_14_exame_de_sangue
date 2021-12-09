namespace BloodCheck.Models;

public class RequestExam
{
    // Class to generate composite Primary key.
    
    // Create foreign key Exam (RequestExam many to 1 Exam).
    public int examId { get; set; }
    public Exam Exam { get; set; } = null!;

    // Create foreign key Request (RequestExam many to 1 Request).
    public int requestId { get; set; }
    public Request Request { get; set; } = null!;
}
