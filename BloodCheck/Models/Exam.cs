namespace BloodCheck.Models;

public class Exam
{
    public int ExamId { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public int DeliveryDays { get; set; }

    // List and interface to generate foreign key (Exam many to many Request).
    public ICollection<Request> Requests { get; set; } = null!;
    public List<RequestExam> RequestExams { get; set; } = null!;
}
