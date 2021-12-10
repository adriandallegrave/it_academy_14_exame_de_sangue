namespace BloodCheck.Models;

public class Patient
{
    public int patientId {get; set;}
    public string? name {get; set;}
    public string? cpf {get; set;}
    public string? phone {get; set;}

    // List to generate foreign key (Patient 1 to many Requests).
    public List<Request> Requests { get; set; } = null!;
}
