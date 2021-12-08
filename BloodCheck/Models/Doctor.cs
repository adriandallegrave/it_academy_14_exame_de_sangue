namespace BloodCheck.Models;

public class Doctor
{
    public int doctorId {get; set;}
    public string? crm {get; set;}
    public string? name {get; set;}

    public List<Request> Requests { get; set; } = null!;
    //public Request Request { get; set; }
}
