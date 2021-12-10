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
    [HttpGet("{id:int}")]
    public async Task<ActionResult<DoctorDTO>> GetByIdAsync(int id)
    {
        var doctor = await _doctorRepository.GetAsync(id);
        if (doctor is null)
        {
            return NotFound();
        }
        return DoctorDTO.FromDoctor(doctor);
    }
}
