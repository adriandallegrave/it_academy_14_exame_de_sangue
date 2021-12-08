namespace BloodCheck.Models;

public class Exam
{
    public int examId {get; set;}
    public decimal price {get; set;}
    public string? description {get; set;}
    public int deliveryDays {get; set;}

    public ICollection<Request> Requests {get; set;} = null!;
    public  List<RequestExam> RequestExams {get; set;} = null!;
}
