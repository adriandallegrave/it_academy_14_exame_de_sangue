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

    public async Task<DoctorDTO?> GetAsync(string crm)
    {
        var listOfDoctors = await _context.Doctors
            .Where(d => d.crm!.Equals(crm))
            .Select(d => new DoctorDTO(d.doctorId, d.crm!, d.name!))
            .ToListAsync();
        return (listOfDoctors!.Count == 0) ? null : listOfDoctors[0];
    }
}
