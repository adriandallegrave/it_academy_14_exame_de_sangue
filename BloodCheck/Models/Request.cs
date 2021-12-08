namespace BloodCheck.Models;

public class Request
{
    public int requestId {get; set;}
    public int patientId {get; set;}
    public int doctorId {get; set;}
    public DateTime requestDate {get; set;}

    public List<Doctor> Doctors { get; set; } = null!;
    public List<Patient> Patients { get; set; } = null!;
    public List<RequestExam> RequestExams { get; set; } = null!;
    public ICollection<Exam> Exams { get; set; } = null!;
}
