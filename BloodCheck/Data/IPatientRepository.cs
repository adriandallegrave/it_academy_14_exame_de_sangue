using BloodCheck.Models;
using BloodCheck.DTOs;

namespace BloodCheck.Data;

public interface IPatientRepository 
{
    Task<Patient?> GetAsync(int id);
    Task<Patient?> GetAsync(string cpf);
    Task<IEnumerable<Patient>> GetAllAsync();
    Task<Patient> AddAsync(Patient patient);
}
