using BloodCheck.Models;
using Microsoft.EntityFrameworkCore;
using BloodCheck.DTOs;

namespace BloodCheck.Data;

public class RequestRepositoryEF : IRequestRepository
{
    private readonly BloodCheckContext _context;

    public RequestRepositoryEF(BloodCheckContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Request>?> GetAsync(string cpf)
    {
        var requests = await _context.Requests.ToListAsync();
        var patient = await _context.Patients
            .SingleOrDefaultAsync(d => d.Cpf == cpf);
        if (patient is null)
        {
            return null;
        }
        Console.WriteLine($"\n\n\n\n\n{patient.PatientId}, {patient.Name}, {patient.Cpf}\n\n\n\n");

        var requestsById = _context.Requests.FromSqlInterpolated($"select * from requests where requests.PatientId = {patient.PatientId}").ToListAsync();
        
        return null;
    }
    
    public async Task<Request> AddAsync(Request request)
    {
        var newRequest = await _context.Requests.AddAsync(request);
        await _context.SaveChangesAsync();
        return request;
    }
}
