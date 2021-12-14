namespace BloodCheck.Models;

public class Doctor
{
    public int DoctorId {get; set;}
    public string? Crm {get; set;}
    public string? Name {get; set;}
    
    // List to generate foreign key (Doctor 1 to many Requests).
    public List<Request> Requests { get; set; } = null!;
}
