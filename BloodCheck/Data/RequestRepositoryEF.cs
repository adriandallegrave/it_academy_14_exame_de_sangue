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

    public async Task<RequestDTO?> GetAsync(int id)
    {
        var requestExams = await _context.RequestExams
            .FromSqlInterpolated($"select * from RequestExams where RequestId = {id}")
            .ToListAsync();

        if (requestExams.Count == 0)
        {
            return null;
        }

        List<int> examsIds = new List<int>();
        // Console.WriteLine("\n\n\n\n\n\n");
        foreach (var requestExam in requestExams)
        {
            // Console.WriteLine($"RequestId = {item.RequestId}, ExamId = {item.ExamId}");
            examsIds.Add(requestExam.ExamId);
        }
        // Console.WriteLine("\n\n\n\n\n\n");
        
        var request = await _context.Requests.FindAsync(id);
        var requestDTO = RequestDTO.FromRequest(request);
        requestDTO.ExamsIDs = examsIds;
        return requestDTO;
    }
    
    public async Task<Request> AddAsync(Request request)
    {
        var newRequest = await _context.Requests.AddAsync(request);
        await _context.SaveChangesAsync();
        return request;
    }

    public async Task<Request?> UpdateAsync(int requestId, PutRequestDTO putRequestDTO)
    {
        var request = await _context.Requests.FindAsync(requestId);
        if (request == null)
        {
            return null;
        }

        var doctor = await _context.Doctors.SingleOrDefaultAsync(d => d.Crm == putRequestDTO.Crm);
        if (doctor == null)
        {
            return null;
        }

        request.DoctorId = doctor.DoctorId;    
        request.RequestDate = DateTime.Now;
        await _context.SaveChangesAsync();

        return request;
    }
}
