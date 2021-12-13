using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BloodCheck.Data;
using BloodCheck.DTOs;
using BloodCheck.Models;
using Microsoft.AspNetCore.Cors;

namespace BloodCheck.Controllers;

[ApiController]
[Route("api/[controller]")]
[EnableCors("AllowAll")]
public class RequestController : ControllerBase
{
    private readonly ILogger<RequestController> _logger;
    private readonly IRequestExamRepository _requestExamRepository;
    private readonly IRequestRepository _requestRepository;
    private readonly IPatientRepository _patientRepository;
    private readonly IDoctorRepository _doctorRepository;
    private readonly IExamRepository _examRepository;

    public RequestController(ILogger<RequestController> logger, IRequestRepository requestRepository,
        IPatientRepository patientRepository, IDoctorRepository doctorRepository, IExamRepository examRepository,
        IRequestExamRepository requestExamRepository)
    {
        _logger = logger;
        _requestExamRepository = requestExamRepository;
        _requestRepository =  requestRepository;
        _patientRepository = patientRepository;
        _doctorRepository = doctorRepository;
        _examRepository = examRepository;
    }

    // GET /api/request/{id}
    [HttpGet("{id:int}")] 
    public async Task<ActionResult<RequestDTO>> GetByIdAsync(int id)
    {
        var request = await _requestRepository.GetAsync(id);
        if (request is null)
        {
            return NotFound();
        }
        return Ok(RequestDTO.FromRequest(request));
    }
    
    // POST /api/request/
    [HttpPost]
    public async Task<ActionResult<RequestDTO>> PostAsync([FromBody] RequestDTO requestDTO)
    {
        var patient = await _patientRepository.GetAsync(requestDTO.PatientId);
        if (patient is null)
        {
            return BadRequest($"Paciente não encontrado! (id = {requestDTO.PatientId})");
        }
        var doctor = await _doctorRepository.GetAsync(requestDTO.DoctorId);
        if (doctor is null)
        {
            return BadRequest($"Doutor não encontrado! (id = {requestDTO.DoctorId})");
        }
        if(requestDTO.RequestDate > DateTime.Now)
        {
            return BadRequest($"Data inválida! ({requestDTO.RequestDate})");
        }

        foreach(int examId in requestDTO.ExamsIDs)
        {
            var exam = await _examRepository.GetAsync(examId);
            if (exam is null)
            {
                return BadRequest($"Exame não encontrado! (id = {examId})");
            }
        }
        
        var request = new Request()
        {
            DoctorId = requestDTO.DoctorId,
            Doctor = doctor,
            PatientId = requestDTO.PatientId,
            Patient = patient,
            RequestDate = requestDTO.RequestDate,
        };
        var newRequest = await _requestRepository.AddAsync(request);
        requestDTO.RequestId = newRequest.RequestId;

        foreach(int examId in requestDTO.ExamsIDs)
        {
            var exam = await _examRepository.GetAsync(examId);
            var requestExam = new RequestExam
            {
                Exam = exam!,
                ExamId = examId,
                Request = newRequest,
                RequestId = newRequest.RequestId
            };
            var newRequestExam = await _requestExamRepository.AddAsync(requestExam);
        }  
        return requestDTO;
    }

    [HttpPut("{id:int}")]       
    public async Task<ActionResult> UpdateRequest(int id, RequestDTO requestDTO)
    {
        _logger.LogInformation($"Data from request:\n{requestDTO}");
        _logger.LogInformation($"Doctor id:\n{requestDTO.DoctorId}");
        _logger.LogInformation($"Patient id:\n{requestDTO.PatientId}");
        _logger.LogInformation($"Exams ids:\n{requestDTO.ExamsIDs}");
        _logger.LogInformation($"Request date:\n{requestDTO.RequestDate}");
        _logger.LogInformation($"Request id:\n{requestDTO.RequestId}");

        var request = await _requestRepository.UpdateAsync(id, requestDTO);
        if(request == null){
            return NotFound();
        }

        var updatedDTO = RequestDTO.FromRequest(request);
        _logger.LogInformation($"Data from request:\n{updatedDTO}");
        _logger.LogInformation($"Doctor id:\n{updatedDTO.DoctorId}");
        _logger.LogInformation($"Patient id:\n{updatedDTO.PatientId}");
        _logger.LogInformation($"Exams ids:\n{updatedDTO.ExamsIDs}");
        _logger.LogInformation($"Request date:\n{updatedDTO.RequestDate}");
        _logger.LogInformation($"Request id:\n{updatedDTO.RequestId}");

        return Ok(updatedDTO);
    }
}


/*
[HttpPut("{id:long}")] //PUT api/TodoItems/1
    public async Task<ActionResult> UpdateTodoItem(long id, TodoItemDTO todoDTO)
    {
        _logger.LogInformation($"UpdateTodoItem:{todoDTO}");
        var todoItem = await _context.TodoItems.FindAsync(id);
        if (todoItem == null)
        {
            return NotFound();
        }
        if (id != todoDTO.Id)
        {
            return BadRequest();
        }
        todoItem.Name = todoDTO.Name;
        todoItem.IsComplete = todoDTO.IsComplete;
        await _context.SaveChangesAsync();
        return NoContent();
    }

*/

/*
       [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(string id, Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return BadRequest();
            }

            _context.Entry(customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
*/