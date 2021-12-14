namespace BloodCheck.Models;

public class Patient
{
    public int PatientId {get; set;}
    public string? Name {get; set;}
    public string? Cpf {get; set;}
    public string? Phone {get; set;}

    // List to generate foreign key (Patient 1 to many Requests).
    public List<Request> Requests { get; set; } = null!;
}
