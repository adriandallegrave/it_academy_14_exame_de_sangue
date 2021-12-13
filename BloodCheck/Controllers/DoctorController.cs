using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BloodCheck.Models;
using BloodCheck.DTOs;
using BloodCheck.Data;
using Microsoft.AspNetCore.Cors;

namespace BloodCheck.Controllers;

[ApiController]
[Route("api/[controller]")]
[EnableCors("AllowAll")]
public class DoctorController : ControllerBase
{
    private ILogger<DoctorController> _logger;

    private readonly IDoctorRepository _doctorRepository;
    
    public DoctorController(ILogger<DoctorController> logger, IDoctorRepository doctorRepository)
    {
        _logger = logger;
        _doctorRepository = doctorRepository;
    }

    // GET api/doctor/{crm}
    [HttpGet("{crm:int:length(6)}")]
    public async Task<ActionResult<DoctorDTO>> GetByCrmAsync([FromRoute] int crm)
    {
        var crmToString = crm.ToString();
        var doctor = await _doctorRepository.GetAsync(crmToString);
        if (doctor is null)
        {
            return NotFound();
        }
        return Ok(DoctorDTO.FromDoctor(doctor));
    }
    
    // GET api/doctor
    [HttpGet]
    public async Task<IEnumerable<DoctorDTO>> GetAllAsync()
    {
        var doctorAux = await _doctorRepository.GetAllAsync();
        return doctorAux.Select(DoctorDTO.FromDoctor);
    }
}