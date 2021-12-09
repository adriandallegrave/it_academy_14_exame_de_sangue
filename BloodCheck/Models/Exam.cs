namespace BloodCheck.Models;

public class Exam
{
    public int examId { get; set; }
    public decimal price { get; set; }
    public string? description { get; set; }
    public int deliveryDays { get; set; }

    // List and interface to generate foreign key (Exam many to many Request).
    public ICollection<Request> Requests { get; set; } = null!;
    public List<RequestExam> RequestExams { get; set; } = null!;
}
