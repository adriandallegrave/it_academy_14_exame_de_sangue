using System.ComponentModel.DataAnnotations;
using BloodCheck.Models;

namespace BloodCheck.DTOs;

public class PatientDTO
{
    //[Required]
    public int PatientId {get; set;}

    [Required]
    [MaxLength(50)]
    public string? Name {get; set;}

    [Required]
    [MaxLength(11)]
    public string? Cpf {get; set;}

    [Required]
    [MaxLength(11)]
    public string? Phone {get; set;}

    //public List<Request> Requests { get; set; } = null!;

    public PatientDTO(int patientId, string name, string cpf, string phone)
    {
        this.PatientId = patientId;
        this.Name=name;
        this.Cpf=cpf;
        this.Phone=phone;
    }

    public static PatientDTO FromPatient(Patient patient)
    {
        return new PatientDTO(patient.PatientId, patient.Name!, patient.Cpf!, patient.Phone!);
    }
}