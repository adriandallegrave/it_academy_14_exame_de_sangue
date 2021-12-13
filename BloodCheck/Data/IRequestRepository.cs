using BloodCheck.Models;
using BloodCheck.DTOs;

namespace BloodCheck.Data;

public interface IRequestRepository 
{
    Task<Request?> GetAsync(int id);
    Task<Request> AddAsync(Request request);
    Task<Request?> UpdateAsync(int requestId, RequestDTO requestDTO);
}
