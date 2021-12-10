using BloodCheck.Models;

namespace BloodCheck.Data;

public interface IRequestRepository 
{
    Task<Request?> GetAsync(int id);

    Task<IEnumerable<Request>> GetAllAsync();
}
