using BloodCheck.Models;

using Microsoft.EntityFrameworkCore;

namespace BloodCheck.Data;

public class RequestRepositoryEF : IRequestRepository
{
    private readonly BloodCheckContext _context;

    public RequestRepositoryEF(BloodCheckContext context)
    {
        _context = context;
    } 

    public async Task<Request?> GetAsync(int id)
    {
        return await _context.Requests.FindAsync(id);
    }

    public async Task<IEnumerable<Request>> GetAllAsync()
    {
        return await _context.Requests.ToListAsync();
    }
}
