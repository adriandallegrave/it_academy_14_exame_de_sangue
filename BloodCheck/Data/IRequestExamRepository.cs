using BloodCheck.Models;

namespace BloodCheck.Data;

public interface IRequestExamRepository 
{
    Task<RequestExam> AddAsync(RequestExam requestExam);
}