using BloodCheck.Models;
using BloodCheck.DTOs;

namespace BloodCheck.Data;

public interface IDoctorRepository
{
    public Task<Doctor?> GetAsync(int id);
    public Task<IEnumerable<DoctorDTO>> GetAllAsync();
}