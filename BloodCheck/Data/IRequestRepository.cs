using BloodCheck.Models;
using BloodCheck.DTOs;

namespace BloodCheck.Data;

public interface IRequestRepository 
{
    Task<IEnumerable<Request>?> GetAsync(string cpf);
    Task<Request> AddAsync(Request request);
}
