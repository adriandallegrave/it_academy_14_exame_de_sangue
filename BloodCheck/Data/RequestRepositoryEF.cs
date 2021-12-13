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

    public async Task<Request?> GetAsync(int id)
    {
        return await _context.Requests.FindAsync(id);
    }
    
    public async Task<Request> AddAsync(Request request)
    {
        var newRequest = await _context.Requests.AddAsync(request);
        await _context.SaveChangesAsync();
        return request;
    }

    public async Task<Request?> UpdateAsync(int requestId, RequestDTO requestDTO)
    {
        var request = await _context.Requests.FindAsync(requestId);
        if (request == null){
            return null;
        }

        request.DoctorId = requestDTO.DoctorId;
        request.PatientId = requestDTO.PatientId;
        request.RequestDate = requestDTO.RequestDate;
        await _context.SaveChangesAsync();

        return request;
    }
}
