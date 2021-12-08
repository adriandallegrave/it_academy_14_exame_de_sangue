using System.ComponentModel.DataAnnotations;
namespace BloodCheck.Models;

public class Patient
{
    
    public int patientId {get; set;}
    public string? name {get; set;}
    public string? cpf {get; set;}
    public string? phone {get; set;}

    //public Request Request { get; set; }
}
