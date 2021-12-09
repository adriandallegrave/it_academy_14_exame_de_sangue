using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BloodCheck.Models;
using BloodCheck.DTOs;
using BloodCheck.Data;

namespace BloodCheck.Controllers;

[ApiController]
[Route("[controller]")]
public class DoctorController : ControllerBase
{
    private BloodCheckContext _context;
    private ILogger<DoctorController> _logger;

    private readonly IDoctorRepository _doctorRepository;
    
    public DoctorController(BloodCheckContext context, ILogger<DoctorController> logger,
    IDoctorRepository doctorRepository)
    {
        _context = context;
        _logger = logger;
        _doctorRepository = doctorRepository;
    }

    // GET /doctor
    [HttpGet]
    public async Task<IEnumerable<DoctorDTO>> GetAllAsync()
    {
        return await _doctorRepository.GetAllAsync();
    }
    
    // GET /doctor/1
    [HttpGet("{doctorId}")]
    public async Task<ActionResult<DoctorDTO>> GetByIdAsync(int doctorId)
    {
        var doctor = await _doctorRepository.GetAsync(doctorId);
        if (doctor == null)
        {
            return NotFound();
        }
        return DoctorDTO.FromDoctor(doctor);
    }
}