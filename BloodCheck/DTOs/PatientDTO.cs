using System.ComponentModel.DataAnnotations;
using BloodCheck.Models;
namespace BloodCheck.DTOs;

public class PatientDTO
{
    //[Required]
    public int patientId {get; set;}

    [Required]
    [MaxLength(50)]
    public string? name {get; set;}

    [Required]
    [MaxLength(11)]
    public string? cpf {get; set;}

    [Required]
    [MaxLength(11)]
    public string? phone {get; set;}

    public List<Request> Requests { get; set; } = null!;

    public PatientDTO(int patientId, string name, string cpf, string phone)
    {
        this.patientId = patientId;
        this.name=name;
        this.cpf=cpf;
        this.phone=phone;
    }

    public static PatientDTO FromPatient(Patient patient)
    {
        return new PatientDTO(patient.patientId, patient.name!, patient.cpf!, patient.phone!);
    }
}