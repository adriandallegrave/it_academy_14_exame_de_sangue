namespace BloodCheck.Models;

public class Patient
{
    
    public int patientId {get; set;}
    public string? name {get; set;}
    public string? cpf {get; set;}
    public string? phone {get; set;}

    // (Patient) 1:N (Request)
    public List<Request> Requests { get; set; } = null!;

    //public Request Request { get; set; }
}
