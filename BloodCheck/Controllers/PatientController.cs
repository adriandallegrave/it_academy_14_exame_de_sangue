using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
//using Microsoft.AspNetCore.Cors;
using BloodCheck.Data;
using BloodCheck.DTOs;
using BloodCheck.Models;

namespace BloodCheck.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PatientController : ControllerBase
{
    private readonly ILogger<PatientController> _logger;
    private readonly IPatientRepository _patientRepository;

    public PatientController(ILogger<PatientController> logger, IPatientRepository patientRepository)
    {
        _logger = logger;
        _patientRepository =  patientRepository;
    }

    // GET /bloodcheck/{id}
    [HttpGet("{id:int}")] 
    public async Task<ActionResult<PatientDTO>> GetById(int id)
    {
        var patient = await _patientRepository.GetAsync(id);
        if (patient is null)
        {
            return NotFound($"Paciente #{id} nao encontrado");
        }
        return PatientDTO.FromPatient(patient);
    }

    [HttpGet]
    public async Task<IEnumerable<PatientDTO>> GetAllAsync()
    {
        var patientAux = await _patientRepository.GetAllAsync();
        return patientAux.Select(PatientDTO.FromPatient);
    }

    /*
    [HttpGet("doctor")]
    public async Task<IEnumerable<DoctorDTO>> getDoctor()
    {
        return await _context.Doctors
            .Select(d => new DoctorDTO(d.doctorId, d.crm!, d.name!)).ToListAsync();
    }
    */
}
