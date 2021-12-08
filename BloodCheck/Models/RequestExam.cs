namespace BloodCheck.Models;

public class RequestExam
{
    public Request Request { get; set; } = null!;
    public int requestId { get; set; }

    public Exam Exam { get; set; } = null!;
    public int examId { get; set; }
}