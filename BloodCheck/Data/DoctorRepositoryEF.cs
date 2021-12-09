using BloodCheck.Models;
using BloodCheck.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BloodCheck.Data;

public class DoctorRepositoryEF : IDoctorRepository //ignorar os 200 avisos de erro
{
    private readonly BloodCheckContext _context;

    public DoctorRepositoryEF(BloodCheckContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<DoctorDTO>> GetAllAsync() //lembrete pra mim mesma
    {
        return await _context.Doctors
            .Select(d => new DoctorDTO(d.DoctorId, d.Crm!, d.Name!)).ToListAsync();
    }

    public async Task<Doctor?> GetAsync(int id)
    {
        return await _context.Doctors.FindAsync(id);
    }
}