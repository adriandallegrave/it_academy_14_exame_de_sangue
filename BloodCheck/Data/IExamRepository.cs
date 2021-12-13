using BloodCheck.Models;

namespace BloodCheck.Data;

public interface IExamRepository 
{
    Task<Exam?> GetAsync(int id);
    Task<IEnumerable<Exam>> GetAllAsync();
}
