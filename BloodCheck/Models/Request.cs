namespace BloodCheck.Models;

public class Request
{
    public int idRequest {get; set;} 
    public int idPatient {get; set;}
    public int idDoctor {get; set;}
    public DateTime requestDate {get; set;}
}
