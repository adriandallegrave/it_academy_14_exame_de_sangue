using Microsoft.AspNetCore.Mvc;
using BloodCheck.Models;
using BloodCheck.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BloodCheck.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BloodCheckController : ControllerBase
{

    private readonly ILogger<BloodCheckController> _logger;
    private readonly BloodCheckContext _context;

    public BloodCheckController(ILogger<BloodCheckController> logger, BloodCheckContext context)
    {
        _logger = logger;
        _context = context;
    }

    // GET api/BloodCheck/doctor
    [HttpGet("doctor")]
    public async Task<IEnumerable<DoctorDTO>> getDoctor()
    {
        return await _context.Doctors
            .Select(d => new DoctorDTO(d.doctorId, d.crm!, d.name!)).ToListAsync();
    }
    // Get Doctor By Id
    [HttpGet("doctor/{doctorId}")]
    public async Task<ActionResult<DoctorDTO>> getDoctorId(int doctorId)
    {
        var doctor = await _context.Doctors.FindAsync(doctorId);
        if (doctor == null)
        {
            return NotFound();
        }
        return new DoctorDTO(doctor!.doctorId, doctor.crm!, doctor.name!);
    }
}
