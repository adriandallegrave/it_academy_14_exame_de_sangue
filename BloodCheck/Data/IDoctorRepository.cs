using BloodCheck.Models;

namespace BloodCheck.Data;

public interface IDoctorRepository
{
    Task<Doctor?> GetAsync(int id);
    Task<Doctor?> GetAsync(string crm);
    Task<IEnumerable<Doctor>> GetAllAsync();
}
