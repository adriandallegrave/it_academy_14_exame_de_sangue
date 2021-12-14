using BloodCheck.Models;

using Microsoft.EntityFrameworkCore;

namespace BloodCheck.Data;

public class ExamRepositoryEF : IExamRepository
{
    private readonly BloodCheckContext _context;

    public ExamRepositoryEF(BloodCheckContext context)
    {
        _context = context;
    } 

    public async Task<Exam?> GetAsync(int id)
    {
        return await _context.Exams.FindAsync(id);
    }

    public async Task<IEnumerable<Exam>> GetAllAsync()
    {
        return await _context.Exams.ToListAsync();
    }
}
