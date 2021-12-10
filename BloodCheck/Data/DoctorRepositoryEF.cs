using BloodCheck.Models;
using BloodCheck.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BloodCheck.Data;

public class DoctorRepositoryEF : IDoctorRepository 
{
    private readonly BloodCheckContext _context;

    public DoctorRepositoryEF(BloodCheckContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Doctor>> GetAllAsync()
    {
        return await _context.Doctors.ToListAsync();
    }

    public async Task<Doctor?> GetAsync(int id)
    {
        return await _context.Doctors.FindAsync(id);
    }
}
