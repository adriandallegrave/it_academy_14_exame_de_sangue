using System.ComponentModel.DataAnnotations;
using BloodCheck.Models;

namespace BloodCheck.DTOs;

public class PostPatientDTO
{
    [Required]
    [MaxLength(50)]
    public string? Name {get; set;}

    [Required]
    [MaxLength(11)]
    public string? Cpf {get; set;}

    [Required]
    [MaxLength(11)]
    public string? Phone {get; set;}

    public PostPatientDTO(string name, string cpf, string phone)
    {
        this.Name = name;
        this.Cpf = cpf;
        this.Phone = phone;
    }
}
