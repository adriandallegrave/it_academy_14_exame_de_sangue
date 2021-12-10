using BloodCheck.Models;
using BloodCheck.DTOs;

namespace BloodCheck.Data;

public interface IDoctorRepository
{
    public Task<DoctorDTO?> GetAsync(string crm);
    public Task<IEnumerable<Doctor>> GetAllAsync();
}
