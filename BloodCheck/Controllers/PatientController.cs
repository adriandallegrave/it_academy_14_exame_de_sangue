using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
//using Microsoft.AspNetCore.Cors;
using BloodCheck.Data;
using BloodCheck.DTOs;
using BloodCheck.Models;
using Microsoft.AspNetCore.Cors;

namespace BloodCheck.Controllers;

[ApiController]
[Route("api/[controller]")]
[EnableCors("AllowAll")]
public class PatientController : ControllerBase
{
    private readonly ILogger<PatientController> _logger;
    private readonly IPatientRepository _patientRepository;

    public PatientController(ILogger<PatientController> logger, IPatientRepository patientRepository)
    {
        _logger = logger;
        _patientRepository =  patientRepository;
    }

    // GET api/patient/{cpf}
    [HttpGet("{cpf:long:length(11)}")]
    public async Task<ActionResult<PatientDTO>> GetByCpfAsync([FromRoute] long cpf)
    {
        var cpfToString = cpf.ToString();
        var patient = await _patientRepository.GetAsync(cpfToString);
        if (patient is null)
        {
            return NotFound();
        }
        return Ok(PatientDTO.FromPatient(patient));
    }

    // GET api/patient
    [HttpGet]
    public async Task<IEnumerable<PatientDTO>> GetAllAsync()
    {
        var patientAux = await _patientRepository.GetAllAsync();
        return patientAux.Select(PatientDTO.FromPatient);
    }

    [HttpPost]
    public async Task<ActionResult> PostAsync([FromBody] PostPatientDTO postPatientDTO)
    {
        var patient = _patientRepository.GetAsync(postPatientDTO.Cpf);
        if (patient is not null)
        {
            return BadRequest();
        }
        _patientRepository.AddAsync(postPatientDTO);
        return Ok();
    }
}
