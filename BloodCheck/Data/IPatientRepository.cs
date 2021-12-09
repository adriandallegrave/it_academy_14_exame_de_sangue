using BloodCheck.Models;

namespace BloodCheck.Data;

public interface IPatientRepository 
{
    Task<Patient?> GetAsync(int id);
}