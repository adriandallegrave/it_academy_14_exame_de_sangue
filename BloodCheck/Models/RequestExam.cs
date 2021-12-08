namespace BloodCheck.Models;

public class RequestExam
{
    public Request Request { get; set; }
    public int requestId { get; set; }

    public Exam Exam { get; set; }
    public int examId { get; set; }
}