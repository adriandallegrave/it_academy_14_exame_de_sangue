using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
//using Microsoft.AspNetCore.Cors;
using BloodCheck.Data;
using BloodCheck.DTOs;
using BloodCheck.Models;

namespace BloodCheck.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RequestController : ControllerBase
{
    private readonly ILogger<RequestController> _logger;
    private readonly IRequestRepository _requestRepository;

    public RequestController(ILogger<RequestController> logger, IRequestRepository requestRepository)
    {
        _logger = logger;
        _requestRepository =  requestRepository;
    }

    // GET /bloodcheck/{id}
    [HttpGet("{id:int}")] 
    public async Task<ActionResult<RequestDTO>> GetById(int id)
    {
        var request = await _requestRepository.GetAsync(id);
        if (request is null)
        {
            return NotFound($"Requisicao #{id} nao encontrada");
        }
        return RequestDTO.FromRequest(request);
    }

    [HttpGet]
    public async Task<IEnumerable<RequestDTO>> GetAllAsync()
    {
        var requestAux = await _requestRepository.GetAllAsync();
        return requestAux.Select(RequestDTO.FromRequest);
    }
}
