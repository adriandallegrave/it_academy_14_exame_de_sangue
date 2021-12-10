using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BloodCheck.Models;
using BloodCheck.DTOs;
using BloodCheck.Data;

namespace BloodCheck.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DoctorController : ControllerBase
{
    private ILogger<DoctorController> _logger;

    private readonly IDoctorRepository _doctorRepository;
    
    public DoctorController(ILogger<DoctorController> logger, IDoctorRepository doctorRepository)
    {
        _logger = logger;
        _doctorRepository = doctorRepository;
    }

    // GET /doctor
    [HttpGet]
    public async Task<IEnumerable<DoctorDTO>> GetAllAsync()
    {
        var doctorAux = await _doctorRepository.GetAllAsync();
        return doctorAux.Select(DoctorDTO.FromDoctor);
    }
    
    // GET /doctor/1
    [HttpGet("{crm}")]
    public async Task<ActionResult<DoctorDTO>> GetByIdAsync(string crm)
    {
        var doctorDTO = await _doctorRepository.GetAsync(crm);
        Console.WriteLine(doctorDTO);
        if (doctorDTO is null)
        {
            return NotFound();
        }
        return doctorDTO;
    }
}
