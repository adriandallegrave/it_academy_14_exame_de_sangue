namespace BloodCheck.Models;

public class Doctor
{
    public int doctorId {get; set;}
    public string? crm {get; set;}
    public string? name {get; set;}
    
    // List to generate foreign key (Doctor 1 to many Requests).
    public List<Request> Requests { get; set; } = null!;
}
