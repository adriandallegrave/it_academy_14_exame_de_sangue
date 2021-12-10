using BloodCheck.Models;

using Microsoft.EntityFrameworkCore;

namespace BloodCheck.Data;

public class PatientRepositoryEF : IPatientRepository
{
    private readonly BloodCheckContext _context;

    public PatientRepositoryEF(BloodCheckContext context)
    {
        _context = context;
    } 

    public async Task<Patient?> GetAsync(int id)
    {
        return await _context.Patients.FindAsync(id);
    }

    public async Task<IEnumerable<Patient>> GetAllAsync()
    {
        return await _context.Patients.ToListAsync();
    }
}
