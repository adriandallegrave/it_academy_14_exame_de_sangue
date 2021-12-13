using BloodCheck.Models;

namespace BloodCheck.Data;

public class RequestExamRepositoryEF : IRequestExamRepository
{
    private readonly BloodCheckContext _context;

    public RequestExamRepositoryEF(BloodCheckContext context)
    {
        _context = context;
    }

    public async Task<RequestExam> AddAsync(RequestExam requestExam)
    {
        await _context.RequestExams.AddAsync(requestExam);
        await _context.SaveChangesAsync();
        return requestExam;
    }
}